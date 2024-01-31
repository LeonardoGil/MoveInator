using MoveInatorForms.Domains.Entities.Cadastros;
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

        public BindingSource MDFeCTesViewBindingSource { get; set; } = new BindingSource() { DataSource = new List<MDFeCTeViewModel>() };

        public BindingSource EmpresasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Empresas };

        public BindingSource MotoristasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Motoristas };

        public List<MDFeCTeViewModel> MDFeCTes => MDFeCTesViewBindingSource.OfType<MDFeCTeViewModel>().ToList();

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
                buttonGerarMDFe.Enabled = MDFeCTes.Any();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EnableButtons(false);
            }
        }

        private async Task LoadFormAsync()
        {
            textBoxNumeroMDFe.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            textBoxSerieMDFe.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            textBoxNumeroCTe.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            textBoxNumeroMDFe.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            maskedTextBoxDataEmissao.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;

            MDFeCTesViewBindingSource.ListChanged += ListMDFeCTesViewModel_ChangedEvent;

            dataGridView.DataSource = MDFeCTesViewBindingSource;

            Reload();

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
            textBoxDiretorio.Text = folderBrowserDialog.SelectedPath;
        }

        private async Task AddMDFeCTeViewModelGridAsync()
        {
            var model = BuildMDFeCTeViewModel();

            MDFeCTesViewBindingSource.Add(model);
        }

        private MDFeCTeViewModel BuildMDFeCTeViewModel()
        {
            return new MDFeCTeViewModel
            {
                NumeroMDFe = int.Parse(textBoxNumeroMDFe.Text),
                SerieMDFe = int.Parse(textBoxSerieMDFe.Text),

                NumeroCTe = int.Parse(textBoxNumeroCTe.Text),
                SerieCTe = int.Parse(textBoxSerieCTe.Text),

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

        private void ValidateMDFeCTeViewModel()
        {
            textBoxNumeroMDFe.ValidateNumber("Informe um Numero MDFe!");
            textBoxSerieMDFe.ValidateNumber("Informe uma Série MDFe!");

            textBoxNumeroCTe.ValidateNumber("Informe um Numero CTe!");
            textBoxSerieCTe.ValidateNumber("Informe uma Série CTe!");

            maskedTextBoxDataEmissao.ValidateOnlyDate("Informe uma Data Emissão valída!");

            // Lista de CTes
            var ctes = (List<MDFeCTeViewModel>)MDFeCTesViewBindingSource.DataSource;

            if (ctes.Any(x => x.NumeroCTe == int.Parse(textBoxNumeroCTe.Text) &&
                              x.SerieCTe == int.Parse(textBoxSerieCTe.Text))) throw new Exception("Já possuí um CTe com esse Numero e Serie");
        }

        private async void PrepareFieldForNextCTeAsync()
        {
            textBoxNumeroCTe.Text = (int.Parse(textBoxNumeroCTe.Text) + 1).ToString();
        }

        #region Events

        private async void AddMDfeView_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                ValidateMDFeCTeViewModel();

                var addTask = AddMDFeCTeViewModelGridAsync();

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
                buttonGerarMDFe.Enabled = MDFeCTes.Any();
            }
        }

        private void ListMDFeCTesViewModel_ChangedEvent(object sender, ListChangedEventArgs e)
        {
            var enabled = MDFeCTes.Any();

            buttonGerarMDFe.Enabled = enabled;
            buttonLimparMDFeCTes.Enabled = enabled;

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

                var filePath = MDFeService.GenerateAsync(textBoxDiretorio.Text, MDFeCTes).Result;

                MDFeCTesViewBindingSource.Clear();

                MessageBox.Show($"Documentos Gerados no diretório:{Environment.NewLine}{filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EnableButtons();
                buttonGerarMDFe.Enabled = MDFeCTes.Any();
            }
        }

        private void ClearMDFeCTesGrid_ClickEvent(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluír os MDFeCTes?", "Excluír MDFeCTes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                MDFeCTesViewBindingSource.Clear();
        }

        private void ClearFields_ClickEvent(object sender, EventArgs e)
        {
            var anyMDFeCTe = MDFeCTes.Any();

            textBoxNumeroCTe.Text = string.Empty;
            textBoxSerieCTe.Text = string.Empty;

            if (anyMDFeCTe)
                return;

            textBoxNumeroMDFe.Text = string.Empty;
            textBoxSerieMDFe.Text = string.Empty;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
        }

        private void View_ResizeEvent(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                var sizeX = control.Width - 600;
                var sizeY = control.Height - 600;

                panelActions.Location = new Point(240 + sizeX, 270 + sizeY);
            }
        }

        private void Folder_ClickEvent(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxDiretorio.Text = folderBrowserDialog.SelectedPath;
        }

        #endregion
    }
}
