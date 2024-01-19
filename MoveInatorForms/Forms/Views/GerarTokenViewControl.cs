using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Domains.Entities.Tokens;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Services.Interfaces;
using MoveInatorForms.Utilities.Extensions;
using MoveInatorForms.Utilities.Mocks;
using System.Security.Policy;

namespace MoveInatorForms.Forms.Views
{
    public partial class GerarTokenViewControl : UserControl
    {
        public BindingSource TokensViewBindingSource { get; set; } = new BindingSource() { DataSource = new List<TokenViewModel>() };

        public BindingSource EmpresasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Empresas };

        public BindingSource MotoristasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Motoristas };

        public List<TokenViewModel> Tokens => TokensViewBindingSource.OfType<TokenViewModel>().ToList();

        public List<Empresa> Empresas => EmpresasBindingSource.OfType<Empresa>().ToList();

        public List<Motorista> Motoristas => MotoristasBindingSource.OfType<Motorista>().ToList();

        private readonly IRequestTokenService RequestTokenService;

        public GerarTokenViewControl(IRequestTokenService requestTokenService)
        {
            InitializeComponent();
            RequestTokenService = requestTokenService;

            LoadFormAsync();
        }

        private async Task LoadFormAsync()
        {
            dataGridView.DataSource = TokensViewBindingSource;

            Reload();
        }

        private void RequestPortal(TokenViewModel tokenView)
        {
            var token = new TokenPortalRequest
            {
                ClientId = tokenView.Empresa.ClientId,
                ClientSecret = tokenView.Empresa.ClientSecrect
            };

            var responsePortal = RequestTokenService.RequestTokenPortal(token, tokenView.Url).Result;

            Invoke(() =>
            {
                tokenView.Token = $"Bearer {responsePortal.AccessToken}";
                tokenView.ExpiraEm.AddSeconds(responsePortal.ExpiresIn);

                Clipboard.SetText(tokenView.Token);
                MessageBox.Show("Token COPIADO!");
            });
        }

        public void Reload()
        {
            buttonRequest.Enabled = false;

            try
            {
                comboBoxEmpresa.ReloadBindingSource<Empresa>(EmpresasBindingSource, nameof(Empresa.RazaoSocial), nameof(Empresa.Cnpj));
                comboBoxMotorista.ReloadBindingSource<Motorista>(MotoristasBindingSource, nameof(Motorista.Nome), nameof(Motorista.Cpf));

                if (!Empresas.Any())
                    throw new Exception("Cadastre um Emissor na aba Cadastros!");

                if (!Motoristas.Any())
                    throw new Exception("Cadastre um Motorista na aba Cadastros!");

                buttonRequest.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonRequest.Enabled = false;
            }
        }

        private void ValidateTokenViewModel()
        {
            var api = checkedListBoxAPI.CheckedIndices.OfType<int?>().FirstOrDefault() ??
                throw new Exception("Selecione um Tipo Viagem!");

            textBoxUrl.ValidateNotNullOrEmpty("Informe uma Url!");

            if (!Uri.TryCreate(textBoxUrl.Text, new UriCreationOptions(), out var _))
                throw new Exception("Url inválida");

            switch ((TokenAPIEnum)api)
            {
                case TokenAPIEnum.Portal:
                    var empresa = (Empresa)EmpresasBindingSource.Current;

                    if (string.IsNullOrEmpty(empresa.ClientId) || string.IsNullOrEmpty(empresa.ClientSecrect))
                        throw new Exception("Cadastro Empresa incompleto!");
                    break;


                case TokenAPIEnum.Mobile:
                    var motorista = (Motorista)MotoristasBindingSource.Current;

                    if (string.IsNullOrEmpty(motorista.Password))
                        throw new Exception("Cadastro Motorista incompleto!");
                    break;
            }
        }

        private TokenViewModel BuildTokenViewModel()
        {
            var token = new TokenViewModel
            {
                API = (TokenAPIEnum)checkedListBoxAPI.CheckedIndices.OfType<int>().First(),
                Url = new Uri(textBoxUrl.Text),
                ExpiraEm = DateTime.Now
            };

            switch (token.API)
            {
                case TokenAPIEnum.Portal:
                    token.Empresa = (Empresa)EmpresasBindingSource.Current;
                    break;
                
                case TokenAPIEnum.Mobile:
                    token.Motorista = (Motorista)MotoristasBindingSource.Current;
                    break;
            }

            return token;
        }

        #region Events

        private async void ResetListBoxAPI_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                checkedListBox.ResetCheckedList(e.Index);
                comboBoxEmpresa.Enabled = e.Index == 0 && e.NewValue == CheckState.Checked;
                comboBoxMotorista.Enabled = e.Index == 1 && e.NewValue == CheckState.Checked;
            }
        }

        private async void Request_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                ValidateTokenViewModel();

                var token = BuildTokenViewModel();

                TokensViewBindingSource.Add(token);

                backgroundWorkerRequest.RunWorkerAsync(token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Request_DoWorkEvent(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (e.Argument is TokenViewModel tokenModel)
            {
                try
                {
                    switch (tokenModel.API)
                    {
                        case TokenAPIEnum.Portal:
                            RequestPortal(tokenModel);
                            break;

                        case TokenAPIEnum.Mobile:
                            throw new NotImplementedException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion
    }
}

