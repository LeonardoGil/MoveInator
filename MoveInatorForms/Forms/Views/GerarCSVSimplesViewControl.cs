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

        public BindingSource ViagensViewBindingSource { get; set; } = new BindingSource();

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

            var reloadMotorista = ReloadComboBoxMotorista();
            var reloadEmpresa = ReloadComboBoxEmpresa();

            Task.WaitAll(reloadEmpresa, reloadMotorista);

            try
            {
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

        private async Task ReloadComboBoxMotorista()
        {
            var motoristaOld = default(Motorista);

            if (comboBoxMotorista.SelectedItem is not null &&
                comboBoxMotorista.SelectedItem is Motorista motorista)
            {
                MotoristasBindingSource.ResetCurrentItem();
                motoristaOld = motorista;
            }

            comboBoxMotorista.DataSource = null;
            comboBoxMotorista.DataSource = MotoristasBindingSource;
            comboBoxMotorista.DisplayMember = "Nome";

            if (motoristaOld is not null)
            {
                comboBoxMotorista.SelectedItem = Motoristas.FirstOrDefault(x => x.Cpf == motoristaOld.Cpf);
            }
            else
            {
                comboBoxMotorista.SelectedItem = Motoristas.FirstOrDefault();
            }
        }

        private async Task ReloadComboBoxEmpresa()
        {
            var empresaOld = default(Empresa);

            if (comboBoxEmissor.SelectedItem is not null &&
                comboBoxEmissor.SelectedItem is Empresa empresa)
            {
                EmpresasBindingSource.ResetCurrentItem();
                empresaOld = empresa;
            }

            comboBoxEmissor.DataSource = null;
            comboBoxEmissor.DataSource = EmpresasBindingSource;
            comboBoxEmissor.DisplayMember = "RazaoSocial";

            if (empresaOld is not null)
            {
                comboBoxEmissor.SelectedItem = Empresas.FirstOrDefault(x => x.Cnpj == empresaOld.Cnpj);
            }
            else
            {
                comboBoxEmissor.SelectedItem = Empresas.FirstOrDefault();
            }
        }

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
            // Viagem

            var checkedIndiceViagem = checkedListBoxTipoViagem.CheckedIndices.OfType<int?>().FirstOrDefault();

            if (checkedIndiceViagem is null)
                throw new Exception("Selecione um Tipo Viagem!");

            if (string.IsNullOrEmpty(textBoxNumeroDocumento.Text))
                throw new Exception("Informe um Numero Documento!");

            if ((TipoDocumentoViagemEnum)checkedIndiceViagem == TipoDocumentoViagemEnum.MDFe)
            {
                if (string.IsNullOrEmpty(textBoxSerieDocumento.Text))
                    throw new Exception("Informe uma Série Documento!");
            }

            // Documento

            var checkedIndiceDocumento = checkedListBoxTipoDocumento.CheckedIndices.OfType<int?>().FirstOrDefault();

            if (checkedIndiceDocumento is null)
                throw new Exception("Selecione um Tipo Documento!");

            if (!int.TryParse(textBoxNumeroInicial.Text, out _))
                throw new Exception("Informe um Numero inicial!");

            if (!int.TryParse(textBoxSerieInicial.Text, out _))
                throw new Exception("Informe uma Série inicial!");

            if (numericUpDownQuantidade.Value <= 0)
                throw new Exception("Informe uma quantidade valída!");

            // Emissor

            if (!DateTime.TryParse(maskedTextBoxDataEmissao.Text, out _))
                throw new Exception("Informe uma Data Emissão valída!");

            // Destinatario

            if (string.IsNullOrEmpty(textBoxNomeDestinatario.Text))
                throw new Exception("Informe o nome do Destinatário!");

            if (string.IsNullOrEmpty(maskedTextBoxCpfCnpjDestinatario.Text.OnlyNumber()))
                throw new Exception("Informe o Cpf/Cnpj do Destinatário!");

            return true;
        }

        private void ResetCheckedList(CheckedListBox checkedListBox, int index = -1)
        {
            foreach (int ind in checkedListBox.CheckedIndices)
            {
                if (ind != index)
                    checkedListBox.SetItemChecked(ind, false);
            }
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
            ViagensViewBindingSource.DataSource = new List<ViagemViewModel>();
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
                ResetCheckedList(checkedListBox, e.Index);
            }
        }

        private void ResetCheckedListViagem_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                ResetCheckedList(checkedListBox, e.Index);

                var mdfeIndex = (int)TipoDocumentoViagemEnum.MDFe;

                var mdfeChecked = false;

                if (e.Index == mdfeIndex)
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
            var cpf = new Cpf();

            ResetCheckedList(checkedListBoxTipoViagem);
            ResetCheckedList(checkedListBoxTipoDocumento);

            var tipoViagem = random.Next(0, 2);

            checkedListBoxTipoViagem.SetItemChecked(tipoViagem, true);
            textBoxNumeroDocumento.Text = random.Next(1, 9999).ToString();

            if (tipoViagem == (int)TipoDocumentoViagemEnum.MDFe)
            {
                textBoxSerieDocumento.Text = random.Next(1, 500).ToString();
            }
            else
            {
                textBoxSerieDocumento.Text = string.Empty;
            }

            checkedListBoxTipoDocumento.SetItemChecked(random.Next(0, 2), true);
            textBoxNumeroInicial.Text = random.Next(1, 9999).ToString();
            textBoxSerieInicial.Text = random.Next(1, 500).ToString();
            numericUpDownQuantidade.Value = random.Next(1, 50);

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
            //maskedTextBoxCnpjEmissor.Text = cnpj.GerarFake();

            textBoxNomeDestinatario.Text = Data.Nomes.GetRandom();
            maskedTextBoxCpfCnpjDestinatario.Text = cnpj.GerarFake();

            //textBoxNomeMotorista.Text = Data.Nomes.GetRandom();
            //maskedTextBoxCpfMotorista.Text = cpf.GerarFake();
        }

        private void ClearFields_ClickEvent(object sender, EventArgs e)
        {
            ResetCheckedList(checkedListBoxTipoViagem);
            ResetCheckedList(checkedListBoxTipoDocumento);

            textBoxNumeroDocumento.Text = string.Empty;
            textBoxSerieDocumento.Text = string.Empty;

            textBoxNumeroInicial.Text = string.Empty;
            textBoxSerieInicial.Text = string.Empty;
            numericUpDownQuantidade.Value = 1;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
            //maskedTextBoxCnpjEmissor.Text = string.Empty;

            textBoxNomeDestinatario.Text = string.Empty;
            maskedTextBoxCpfCnpjDestinatario.Text = string.Empty;

            textBoxNumeroDocumento.Text = string.Empty;
            //maskedTextBoxCpfMotorista.Text = string.Empty;
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
