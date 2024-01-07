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

        public GerarMDFeSimplesViewControl(IMDFeService mDFeService)
        {
            InitializeComponent();

            LoadFormAsync();
            MDFeService = mDFeService;
        }

        private async Task LoadFormAsync()
        {
            MDFeCTesViewBindingSource.DataSource = new List<MDFeCTeViewModel>();
            MDFeCTesViewBindingSource.ListChanged += ListMDFeCTesViewModel_ChangedEvent;

            dataGridView.DataSource = MDFeCTesViewBindingSource;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");

            textBoxNomeMotorista.Text = Data.Nomes.GetRandom();

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

                CnpjEmissor = maskedTextBoxCnpjEmissor.Text.OnlyNumber(),
                DataEmissao = DateTime.Parse(maskedTextBoxDataEmissao.Text),

                NomeMotorista = textBoxNomeMotorista.Text,
                CpfMotorista = maskedTextBoxCpfMotorista.Text.OnlyNumber()
            };
        }

        private void EnableFields(bool enabled = true)
        {
            textBoxNumeroMDFe.Enabled = enabled;
            textBoxSerieMDFe.Enabled = enabled;

            maskedTextBoxDataEmissao.Enabled = enabled;
            maskedTextBoxCnpjEmissor.Enabled = enabled;

            textBoxNomeMotorista.Enabled = enabled;
            maskedTextBoxCpfMotorista.Enabled = enabled;
        }

        private void EnableButtons(bool enabled = true)
        {
            buttonAdicionar.Enabled = enabled;
            buttonLimpar.Enabled = enabled;
            buttonGerarMDFe.Enabled = ((List<MDFeCTeViewModel>)MDFeCTesViewBindingSource.DataSource).Any();
        }

        private void ValidateMDFeCTeViewModel()
        {
            if (string.IsNullOrEmpty(textBoxNumeroMDFe.Text))
                throw new Exception("Informe um Numero MDFe!");

            if (string.IsNullOrEmpty(textBoxSerieMDFe.Text))
                throw new Exception("Informe uma Série MDFe!");

            if (!int.TryParse(textBoxNumeroCTe.Text, out _))
                throw new Exception("Informe um Numero CTe!");

            if (!int.TryParse(textBoxSerieCTe.Text, out _))
                throw new Exception("Informe uma Série CTe!");

            // Emissor

            if (!DateTime.TryParse(maskedTextBoxDataEmissao.Text, out _))
                throw new Exception("Informe uma Data Emissão valída!");

            if (string.IsNullOrEmpty(maskedTextBoxCnpjEmissor.Text.OnlyNumber()))
                throw new Exception("Informe um CNPJ para o Emissor");

            // Motorista

            if (string.IsNullOrEmpty(textBoxNomeMotorista.Text))
                throw new Exception("Informe o nome do Motorista!");

            if (string.IsNullOrEmpty(maskedTextBoxCpfMotorista.Text.OnlyNumber()))
                throw new Exception("Informe o Cpf do Motorista!");
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
            }
        }

        private void ClearMDFeCTesGrid_ClickEvent(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluír os MDFeCTes?", "Excluír MDFeCTes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                MDFeCTesViewBindingSource.Clear();
        }

        #endregion
    }
}
