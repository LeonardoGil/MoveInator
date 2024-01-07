using MoveInatorForms.Domains.Models;
using MoveInatorForms.Utilities.Extensions;
using MoveInatorForms.Utilities.Mocks;
using System.ComponentModel;

namespace MoveInatorForms.Forms.Views
{
    public partial class GerarMDFeSimplesViewControl : UserControl
    {
        public BindingSource MDFeCTesViewBindingSource { get; set; } = new BindingSource();

        public GerarMDFeSimplesViewControl()
        {
            InitializeComponent();

            LoadFormAsync();
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

        private async Task AddMDFeCTeViewModelGridAsync()
        {
            var model = BuildMDFeCTeViewModel();

            MDFeCTesViewBindingSource.Add(model);
        }

        private object BuildMDFeCTeViewModel()
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

        #region Events

        private async void AddMDfeView_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                ValidateMDFeCTeViewModel();

                var addTask = AddMDFeCTeViewModelGridAsync();

                //PrepareFieldForNextViagemAsync();

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

        #endregion
    }
}
