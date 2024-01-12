using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Services;
using MoveInatorForms.Services.Interfaces;
using MoveInatorForms.Utilities.Extensions;
using MoveInatorForms.Utilities.Mocks;
using System.ComponentModel;

namespace MoveInatorForms.Forms.Views
{
    public partial class GerarMDFeSimplesViewControl : UserControl
    {
        private readonly IMDFeService MDFeService;

        public BindingSource MDFeCTesViewBindingSource { get; set; } = new BindingSource();

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
                buttonGerarMDFe.Enabled = MDFeCTes.Any();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EnableButtons(false);
            }
        }

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

        private async Task LoadFormAsync()
        {
            MDFeCTesViewBindingSource.DataSource = new List<MDFeCTeViewModel>();
            MDFeCTesViewBindingSource.ListChanged += ListMDFeCTesViewModel_ChangedEvent;

            dataGridView.DataSource = MDFeCTesViewBindingSource;

            Reload();

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");

            textBoxDiretorio.Text = @"C:/Temp";
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
            if (string.IsNullOrEmpty(textBoxNumeroMDFe.Text))
                throw new Exception("Informe um Numero MDFe!");

            if (string.IsNullOrEmpty(textBoxSerieMDFe.Text))
                throw new Exception("Informe uma Série MDFe!");

            if (!int.TryParse(textBoxNumeroCTe.Text, out var numero))
                throw new Exception("Informe um Numero CTe!");

            if (!int.TryParse(textBoxSerieCTe.Text, out var serie))
                throw new Exception("Informe uma Série CTe!");

            // Emissor

            if (!DateTime.TryParse(maskedTextBoxDataEmissao.Text, out _))
                throw new Exception("Informe uma Data Emissão valída!");

            // Lista de CTes
            var ctes = (List<MDFeCTeViewModel>)MDFeCTesViewBindingSource.DataSource;

            if (ctes.Any(x => x.NumeroCTe == numero && x.SerieCTe == serie))
                throw new Exception("Já possuí um CTe com esse Numero e Serie");
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
            var enabled = ((List<MDFeCTeViewModel>)MDFeCTesViewBindingSource.DataSource).Any();

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

                var mdfeCTes = (List<MDFeCTeViewModel>)MDFeCTesViewBindingSource.DataSource;

                var filePath = MDFeService.GenerateAsync(textBoxDiretorio.Text, mdfeCTes).Result;

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
            var anyMDFeCTe = ((List<MDFeCTeViewModel>)MDFeCTesViewBindingSource.DataSource).Any();

            textBoxNumeroCTe.Text = string.Empty;
            textBoxSerieCTe.Text = string.Empty;

            if (anyMDFeCTe)
                return;

            textBoxNumeroMDFe.Text = string.Empty;
            textBoxSerieMDFe.Text = string.Empty;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
        }

        #endregion
    }
}
