using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Services;
using MoveInatorForms.Services.Interfaces;
using MoveInatorForms.Utilities.Extensions;
using MoveInatorForms.Utilities.Mocks;
using System.ComponentModel;
using System.Windows.Forms;

namespace MoveInatorForms.Forms.Views
{
    public partial class GerarMDFeSimplesViewControl : BaseViewControl
    {
        private readonly IMDFeService MDFeService;

        public BindingSource MDFeViewBindingSource { get; set; } = new BindingSource() { DataSource = new List<MDFeViewModel>() };

        public BindingSource EmpresasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Empresas };

        public BindingSource MotoristasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Motoristas };

        public List<MDFeViewModel> DocumentosMDFe => MDFeViewBindingSource.OfType<MDFeViewModel>().ToList();

        public List<Empresa> Empresas => EmpresasBindingSource.OfType<Empresa>().ToList();

        public List<Motorista> Motoristas => MotoristasBindingSource.OfType<Motorista>().ToList();

        public GerarMDFeSimplesViewControl(IMDFeService mDFeService)
        {
            InitializeComponent();

            LoadFormAsync();
            MDFeService = mDFeService;
        }

        public void Reload()
        {
            buttonGerarMDFe.Enabled = false;

            try
            {
                comboBoxEmissor.ReloadBindingSource<Empresa>(EmpresasBindingSource, nameof(Empresa.RazaoSocial), nameof(Empresa.Cnpj));
                comboBoxMotorista.ReloadBindingSource<Motorista>(MotoristasBindingSource, nameof(Motorista.Nome), nameof(Motorista.Cpf));

                if (!Empresas.Any())
                    throw new Exception("Cadastre um Emissor na aba Cadastros!");

                if (!Motoristas.Any())
                    throw new Exception("Cadastre um Motorista na aba Cadastros!");

                EnableButtons();
                buttonGerarMDFe.Enabled = DocumentosMDFe.Any();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EnableButtons(false);
            }
        }

        #region Private Methods

        private async Task LoadFormAsync()
        {
            textBoxNumeroMDFe.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            textBoxSerieMDFe.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            textBoxNumeroDocumento.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            textBoxNumeroMDFe.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            maskedTextBoxDataEmissao.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;

            MDFeViewBindingSource.ListChanged += ListMDFeViewModel_ChangedEvent;

            dataGridView.DataSource = MDFeViewBindingSource;

            Reload();

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
            textBoxDiretorio.Text = folderBrowserDialog.SelectedPath;
        }

        private async Task AddMDFeViewModelGridAsync()
        {
            var model = BuildMDFeViewModel();

            MDFeViewBindingSource.Add(model);
        }

        private MDFeViewModel BuildMDFeViewModel()
        {
            return new MDFeViewModel
            {
                Numero = int.Parse(textBoxNumeroMDFe.Text),
                Serie = int.Parse(textBoxSerieMDFe.Text),

                NumeroDocumento = int.Parse(textBoxNumeroDocumento.Text),
                SerieDocumento = int.Parse(textBoxSerieDocumento.Text),

                Emissor = (comboBoxEmissor.SelectedItem as Empresa).RazaoSocial,
                CnpjEmissor = (comboBoxEmissor.SelectedItem as Empresa).Cnpj,
                DataEmissao = DateTime.Parse(maskedTextBoxDataEmissao.Text),

                NomeMotorista = (comboBoxMotorista.SelectedItem as Motorista).Nome,
                CpfMotorista = (comboBoxMotorista.SelectedItem as Motorista).Cpf
            };
        }

        private void EnableFields(bool enabled = true)
        {
            textBoxNumeroMDFe.Enabled = enabled;
            textBoxSerieMDFe.Enabled = enabled;

            maskedTextBoxDataEmissao.Enabled = enabled;

            comboBoxMotorista.Enabled = enabled;
            comboBoxEmissor.Enabled = enabled;
        }

        private void EnableButtons(bool enabled = true)
        {
            buttonAdicionar.Enabled = enabled;
            buttonLimpar.Enabled = enabled;
        }

        private void ValidateMDFeViewModel()
        {
            textBoxNumeroMDFe.ValidateNumber("Informe um Numero MDFe!");
            textBoxSerieMDFe.ValidateNumber("Informe uma Série MDFe!");

            textBoxNumeroDocumento.ValidateNumber("Informe o Numero do documento!");
            textBoxSerieDocumento.ValidateNumber("Informe a Série do documento!");

            maskedTextBoxDataEmissao.ValidateOnlyDate("Informe uma Data Emissão valída!");

            // Lista de CTes
            var ctes = (List<MDFeViewModel>)MDFeViewBindingSource.DataSource;

            if (ctes.Any(x => x.NumeroDocumento == int.Parse(textBoxNumeroDocumento.Text) &&
                              x.SerieDocumento == int.Parse(textBoxSerieDocumento.Text))) throw new Exception("Já possuí um documento com esse Numero e Serie");
        }

        private async void PrepareFieldForNextCTeAsync()
        {
            textBoxNumeroDocumento.Text = (int.Parse(textBoxNumeroDocumento.Text) + 1).ToString();
        }

        #endregion

        #region Responsive Methods

        private void TableSizeChanged()
        {
            dataGridView.Location = new Point(0, tableLayoutPanel.Height);
            dataGridView.Height = Height - tableLayoutPanel.Height;
            dataGridView.Width = Width;
        }

        #endregion

        #region Events

        private async void AddMDfeView_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                ValidateMDFeViewModel();

                var addTask = AddMDFeViewModelGridAsync();

                PrepareFieldForNextCTeAsync();

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
                buttonGerarMDFe.Enabled = DocumentosMDFe.Any();
            }
        }

        private void ListMDFeViewModel_ChangedEvent(object sender, ListChangedEventArgs e)
        {
            var enabled = DocumentosMDFe.Any();

            buttonGerarMDFe.Enabled = enabled;
            buttonLimparMDFe.Enabled = enabled;

            EnableFields(!enabled);
        }

        private void GenerateMDFe_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(textBoxDiretorio.Text))
                    throw new Exception("Informe um Diretório válido");

                EnableButtons(false);

                buttonGerarMDFe.Enabled = false;

                var tipoDocumento = (TipoDocumentoEnum)checkedListBoxTipoDocumento.CheckedIndices.OfType<int>().First();

                var filePath = MDFeService.GenerateAsync(textBoxDiretorio.Text, DocumentosMDFe, tipoDocumento).Result;

                MDFeViewBindingSource.Clear();

                MessageBox.Show($"Documentos Gerados no diretório:{Environment.NewLine}{filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EnableButtons();
                buttonGerarMDFe.Enabled = DocumentosMDFe.Any();
            }
        }

        private void ClearMDFeGrid_ClickEvent(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluír os Documentos?", "Excluír Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                MDFeViewBindingSource.Clear();
        }

        private void ClearFields_ClickEvent(object sender, EventArgs e)
        {
            var anyMDFe = DocumentosMDFe.Any();

            textBoxNumeroDocumento.Text = string.Empty;
            textBoxSerieDocumento.Text = string.Empty;
            checkedListBoxTipoDocumento.ResetCheckedList();

            if (anyMDFe)
                return;

            textBoxNumeroMDFe.Text = string.Empty;
            textBoxSerieMDFe.Text = string.Empty;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
        }

        private void View_SizeChangedEvent(object sender, EventArgs e)
        {
            TableSizeChanged();
        }

        private void Folder_ClickEvent(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxDiretorio.Text = folderBrowserDialog.SelectedPath;
        }

        private void ResetCheckedListDocumento_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                checkedListBox.ResetCheckedList(e.Index);
            }
        }
        #endregion
    }
}
