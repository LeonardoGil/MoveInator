using DocumentosBrasileiros;
using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Services.Interfaces;
using MoveInatorForms.Utilities.Extensions;
using MoveInatorForms.Utilities.Mocks;
using System.ComponentModel;
using System.Text;

namespace MoveInatorForms.Forms.Views
{
    public partial class GerarCSVSimplesViewControl : UserControl
    {
        private readonly ICSVService CSVService;

        public BindingSource ViagensViewBindingSource { get; set; } = new BindingSource() { DataSource = new List<ViagemViewModel>() };

        public BindingSource EmpresasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Empresas };

        public BindingSource MotoristasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Motoristas };

        public List<ViagemViewModel> Viagens => ViagensViewBindingSource.OfType<ViagemViewModel>().ToList();

        public List<Empresa> Empresas => EmpresasBindingSource.OfType<Empresa>().ToList();

        public List<Motorista> Motoristas => MotoristasBindingSource.OfType<Motorista>().ToList();

        public GerarCSVSimplesViewControl(ICSVService cSVService)
        {
            CSVService = cSVService;
            InitializeComponent();
            LoadFormAsync();
        }

        public void Reload()
        {
            buttonGerarCSV.Enabled = false;

            try
            {
                comboBoxEmissor.ReloadBindingSource<Empresa>(EmpresasBindingSource, nameof(Empresa.RazaoSocial), nameof(Empresa.Cnpj));
                comboBoxMotorista.ReloadBindingSource<Motorista>(MotoristasBindingSource, nameof(Motorista.Nome), nameof(Motorista.Cpf));

                if (!Empresas.Any())
                    throw new Exception("Cadastre um Emissor na aba Cadastros!");

                if (!Motoristas.Any())
                    throw new Exception("Cadastre um Motorista na aba Cadastros!");

                EnableButtons();
                buttonGerarCSV.Enabled = Viagens.Any();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EnableButtons(false);
            }
        }

        #region Private Methods

        private ViagemViewModel BuildViagemViewModel()
        {
            int? serieViagem = null;
            var tipoViagem = (TipoDocumentoViagemEnum)checkedListBoxTipoViagem.CheckedIndices.OfType<int>().First();

            if (tipoViagem == TipoDocumentoViagemEnum.MDFe)
            {
                serieViagem = int.Parse(textBoxSerieDocumento.Text);
            }

            return new ViagemViewModel
            {
                TipoViagem = tipoViagem,
                NumeroViagem = int.Parse(textBoxNumeroDocumento.Text),
                SerieViagem = serieViagem,

                TipoDocumento = (TipoDocumentoEnum)checkedListBoxTipoDocumento.CheckedIndices.OfType<int>().First(),
                NumeroDocumento = int.Parse(textBoxNumeroInicial.Text),
                SerieDocumento = int.Parse(textBoxSerieInicial.Text),
                Quantidade = (int)numericUpDownQuantidade.Value,

                DataEmissao = DateTime.Parse(maskedTextBoxDataEmissao.Text),
                CnpjEmissor = (comboBoxEmissor.SelectedItem as Empresa).Cnpj,

                NomeDestinatario = textBoxNomeDestinatario.Text,
                CpfCnpjDestinatario = maskedTextBoxCpfCnpjDestinatario.Text.OnlyNumber(),

                NomeMotorista = (comboBoxMotorista.SelectedItem as Motorista).Nome,
                CpfMotorista = (comboBoxMotorista.SelectedItem as Motorista).Cpf
            };
        }

        private async Task AddViagemViewModelGridAsync()
        {
            var model = BuildViagemViewModel();

            ViagensViewBindingSource.Add(model);
        }

        private bool ValidateViagemViewModel()
        {
            #region Viagem
            var checkedIndiceViagem = checkedListBoxTipoViagem.CheckedIndices.OfType<int?>().FirstOrDefault() ??
                throw new Exception("Selecione um Tipo Viagem!");

            textBoxNumeroDocumento.ValidateNotNullOrEmpty("Informe um Numero Documento!");

            if (checkedIndiceViagem == (int)TipoDocumentoViagemEnum.MDFe)
                textBoxSerieDocumento.ValidateNotNullOrEmpty("Informe uma Série Documento!");
            #endregion

            #region Documento
            if (!checkedListBoxTipoDocumento.CheckedIndices.OfType<int?>().Any())
                throw new Exception("Selecione um Tipo Documento!");

            textBoxNumeroInicial.ValidateNumber("Informe um Numero inicial!");
            textBoxSerieInicial.ValidateNumber("Informe uma Série inicial!");
            numericUpDownQuantidade.ValidateNumberGreaterThan("Informe uma quantidade valída!");
            #endregion

            #region Destinatario
            textBoxNomeDestinatario.ValidateNotNullOrEmpty("Informe o nome do Destinatário!");
            maskedTextBoxCpfCnpjDestinatario.ValidateCNPJ("Informe o Cpf/Cnpj do Destinatário!");
            #endregion

            maskedTextBoxDataEmissao.ValidateOnlyDate("Informe uma Data Emissão valída!");

            return true;
        }

        private async Task PrepareFieldForNextViagemAsync()
        {
            // Incrementa em 1 o numero Documento
            textBoxNumeroDocumento.Text = (int.Parse(textBoxNumeroDocumento.Text) + 1).ToString();

            // Incrementa a quantidade de Documentos na Numero Inicial
            textBoxNumeroInicial.Text = (int.Parse(textBoxNumeroInicial.Text) + numericUpDownQuantidade.Value).ToString();

            // Defini a quantidade de Documento em 1
            numericUpDownQuantidade.Value = 1;

            // Defini um Destinatário aleat[orio
            textBoxNomeDestinatario.Text = Data.Nomes.GetRandom();
        }

        private async Task LoadFormAsync()
        {
            ViagensViewBindingSource.ListChanged += ListViagemViewModel_ChangedEvent;

            dataGridView.DataSource = ViagensViewBindingSource;

            Reload();

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
            textBoxNomeDestinatario.Text = Data.Nomes.GetRandom();

            numericUpDownQuantidade.Value = 1;

            textBoxDiretorio.Text = @"C:/Temp";
        }

        private void EnableButtons(bool enabled = true)
        {
            buttonAdicionar.Enabled = enabled;
            buttonGerar.Enabled = enabled;
            buttonLimpar.Enabled = enabled;
        }

        #endregion

        #region Events

        private async void AddViagemViewModel_ClickEventAsync(object sender, EventArgs e)
        {
            try
            {
                ValidateViagemViewModel();

                var addTask = AddViagemViewModelGridAsync();

                PrepareFieldForNextViagemAsync();

                EnableButtons(false);

                await addTask;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EnableButtons();
                buttonGerarCSV.Enabled = Viagens.Any();
            }
        }

        private void ResetCheckedListDocumento_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                checkedListBox.ResetCheckedList(e.Index);
            }
        }

        private void ResetCheckedListViagem_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                checkedListBox.ResetCheckedList(e.Index);

                var mdfeChecked = false;

                if (e.Index == (int)TipoDocumentoViagemEnum.MDFe)
                {
                    mdfeChecked = e.NewValue == CheckState.Checked;
                }

                textBoxSerieDocumento.Enabled = mdfeChecked;
            }
        }

        private void ListViagemViewModel_ChangedEvent(object sender, ListChangedEventArgs e)
        {
            var enabled = ((List<ViagemViewModel>)ViagensViewBindingSource.DataSource).Any();

            buttonGerarCSV.Enabled = enabled;
            buttonLimparViagens.Enabled = enabled;
        }

        private void GenerateCSV_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(textBoxDiretorio.Text))
                    throw new Exception("Informe um Diretório válido");

                EnableButtons(false);

                buttonGerarCSV.Enabled = false;

                var viagens = (List<ViagemViewModel>)ViagensViewBindingSource.DataSource;

                var csv = CSVService.GenerateAsync(textBoxDiretorio.Text, viagens).Result;

                ViagensViewBindingSource.Clear();

                MessageBox.Show($"Documento Gerado no diretório:{Environment.NewLine}{csv}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EnableButtons();
            }
        }

        private void AutoComplete_ClickEvent(object sender, EventArgs e)
        {
            var random = new Random();
            var cnpj = new Cnpj();

            checkedListBoxTipoViagem.ResetCheckedList();
            checkedListBoxTipoDocumento.ResetCheckedList();

            var tipoViagem = random.Next(0, 2);

            checkedListBoxTipoViagem.SetItemChecked(tipoViagem, true);

            textBoxNumeroDocumento.Text = random.Next(1, 9999).ToString();
            textBoxSerieDocumento.Text = tipoViagem == (int)TipoDocumentoViagemEnum.MDFe ? random.Next(1, 500).ToString() :
                                                                                           string.Empty;

            checkedListBoxTipoDocumento.SetItemChecked(random.Next(0, 2), true);
            textBoxNumeroInicial.Text = random.Next(1, 9999).ToString();
            textBoxSerieInicial.Text = random.Next(1, 500).ToString();
            numericUpDownQuantidade.Value = random.Next(1, 50);

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
            textBoxNomeDestinatario.Text = Data.Nomes.GetRandom();
            maskedTextBoxCpfCnpjDestinatario.Text = cnpj.GerarFake();
        }

        private void ClearFields_ClickEvent(object sender, EventArgs e)
        {
            checkedListBoxTipoViagem.ResetCheckedList();
            checkedListBoxTipoDocumento.ResetCheckedList();

            textBoxNumeroDocumento.Text = string.Empty;
            textBoxSerieDocumento.Text = string.Empty;

            textBoxNumeroInicial.Text = string.Empty;
            textBoxSerieInicial.Text = string.Empty;
            numericUpDownQuantidade.Value = 1;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");

            textBoxNomeDestinatario.Text = string.Empty;
            maskedTextBoxCpfCnpjDestinatario.Text = string.Empty;
        }

        private void LimparViagensGrid_ClickEvent(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluír as Viagens?", "Excluír Viagens", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                ViagensViewBindingSource.Clear();
            }
        }

        #endregion
    }
}
