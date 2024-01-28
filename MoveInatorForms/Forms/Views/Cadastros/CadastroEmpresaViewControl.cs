using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Utilities.Extensions;
using System.Windows.Forms;

namespace MoveInatorForms.Forms.Views.Cadastros
{
    public partial class CadastroEmpresaViewControl : CadastroBaseViewControl
    {
        private List<Empresa> Empresas => BindingSource.OfType<Empresa>().ToList();

        public CadastroEmpresaViewControl()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            maskedTextBoxCnpjEmpresa.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            buttonAdicionar.Click += AddEmpresa_ClickEvent;
            buttonRemover.Click += RemoveEmpresa_ClickEvent;

            BindingSource.DataSource = Program.DatabaseJson.Empresas;
            dataGridView.DataSource = BindingSource;

            dataGridView.FillSpecificCells(nameof(Empresa.RazaoSocial), nameof(Empresa.Cnpj));
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

            BindingSource.Add(empresa);
        }

        private void ValidateEmpresa()
        {
            textBoxNomeRazaoSocial.ValidateNotNullOrEmpty("Informe uma Razão Social!");
            maskedTextBoxCnpjEmpresa.ValidateCNPJ("Informe um CNPJ para Empresa!");

            if (Empresas.Any(x => x.Cnpj == maskedTextBoxCnpjEmpresa.Text.OnlyNumber()))
                throw new Exception("Já possuí uma empresa com esse CNPJ!");
        }

        private void EnabledButtonsEmpresa(bool enabled = true)
        {
            buttonAdicionar.Enabled = enabled;
        }

        private void ClearFieldsEmpresa()
        {
            textBoxNomeRazaoSocial.Text = string.Empty;
            maskedTextBoxCnpjEmpresa.Text = string.Empty;
            textBoxClientId.Text = string.Empty;
            textBoxClientSecret.Text = string.Empty;
        }

        private void AddEmpresa_ClickEvent(object sender, EventArgs e)
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

        private void RemoveEmpresa_ClickEvent(object sender, EventArgs e)
        {
            var row = dataGridView.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();

            if (row is null)
            {
                MessageBox.Show("Selecione uma empresa!");
                return;
            }

            BindingSource.RemoveAt(row.Index);
        }
    }
}
