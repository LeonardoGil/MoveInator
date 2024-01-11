using MoveInatorForms.Domains.Entities;
using MoveInatorForms.Utilities.Extensions;

namespace MoveInatorForms.Forms.Views
{
    public partial class CadastrosViewControl : UserControl
    {
        private readonly BindingSource EmpresasBindingSource = new BindingSource() { DataSource = new List<Empresa>() };

        private readonly BindingSource MotoristasBindingSource = new BindingSource() { DataSource = new List<Motorista>() };

        public CadastrosViewControl()
        {
            InitializeComponent();

            Load();
        }

        private async Task Load()
        {
            dataGridViewEmpresas.DataSource = EmpresasBindingSource;
            dataGridViewMotoristas.DataSource = MotoristasBindingSource;
        }


        private Empresa BuildEmpresa()
        {
            return new Empresa
            {
                RazaoSocial = textBoxNomeRazaoSocial.Text,
                Cnpj = maskedTextBoxCnpjEmpresa.Text.OnlyNumber(),

                ClientId = textBoxClientId.Text,
                ClientSecrect = textBoxClientSecret.Text
            };
        }

        private void AddEmpresa()
        {
            var empresa = BuildEmpresa();

            EmpresasBindingSource.Add(empresa);
        }

        private void ValidateEmpresa()
        {
            if (string.IsNullOrEmpty(textBoxNomeRazaoSocial.Text))
                throw new Exception("Informe uma Razão Social!");

            if (string.IsNullOrEmpty(maskedTextBoxCnpjEmpresa.Text.OnlyNumber()))
                throw new Exception("Informe um CNPJ para Empresa!");
        }

        private void EnabledButtonsEmpresa(bool enabled = true)
        {
            buttonAdicionarEmpresa.Enabled = enabled;
        }

        private void ClearFieldsEmpresa()
        {
            textBoxNomeRazaoSocial.Text = string.Empty;
            maskedTextBoxCnpjEmpresa.Text = string.Empty;
            textBoxClientId.Text = string.Empty;
            textBoxClientSecret.Text = string.Empty;
        }

        #region Events

        private void AdicionarEmpresa_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                EnabledButtonsEmpresa(false);

                ValidateEmpresa();

                AddEmpresa();

                ClearFieldsEmpresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EnabledButtonsEmpresa();
            }
        }

        #endregion
    }
}
