using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Utilities.Extensions;
using System.ComponentModel;

namespace MoveInatorForms.Forms.Views
{
    public partial class CadastrosViewControl : UserControl
    {
        private readonly BindingSource EmpresasBindingSource = new() { DataSource = Program.DatabaseJson.Empresas };

        private readonly BindingSource MotoristasBindingSource = new() { DataSource = Program.DatabaseJson.Motoristas };

        private List<Empresa> Empresas => EmpresasBindingSource.OfType<Empresa>().ToList();

        private List<Motorista> Motoristas => MotoristasBindingSource.OfType<Motorista>().ToList();

        public CadastrosViewControl()
        {
            InitializeComponent();

            Load();
        }

        private async Task Load()
        {
            maskedTextBoxCnpjEmpresa.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            maskedTextBoxCpfMotorista.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;

            EmpresasBindingSource.ListChanged += BindindSourceChanged;
            MotoristasBindingSource.ListChanged += BindindSourceChanged;

            dataGridViewEmpresas.DataSource = EmpresasBindingSource;
            dataGridViewMotoristas.DataSource = MotoristasBindingSource;

            dataGridViewEmpresas.FillSpecificCells(nameof(Empresa.RazaoSocial), nameof(Empresa.Cnpj));
            dataGridViewMotoristas.FillSpecificCells(nameof(Motorista.Nome), nameof(Motorista.Cpf));
        }

        #region About Motoristas

        private Motorista BuildMotorista()
        {
            return new Motorista
            {
                Cpf = maskedTextBoxCpfMotorista.Text.OnlyNumber(),
                Nome = textBoxNomeMotorista.Text,
                Password = textBoxPassword.Text
            };
        }

        private void AddMotorista()
        {
            var motorista = BuildMotorista();

            MotoristasBindingSource.Add(motorista);
        }

        private void ValidateMotorista()
        {
            textBoxNomeMotorista.ValidateNotNullOrEmpty("Informe um Nome!");
            maskedTextBoxCpfMotorista.ValidateCPF("Informe um CPF para Motorista!");

            if (Motoristas.Any(x => x.Cpf == maskedTextBoxCpfMotorista.Text.OnlyNumber()))
                throw new Exception("Já possuí um Motorista com esse CPF!");
        }

        private void EnabledButtonsMotorista(bool enabled = true)
        {
            buttonAdicionarMotorista.Enabled = enabled;
        }

        private void ClearFieldsMotorista()
        {
            maskedTextBoxCpfMotorista.Text = string.Empty;
            textBoxNomeMotorista.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        #endregion

        #region About Empresas

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
            textBoxNomeRazaoSocial.ValidateNotNullOrEmpty("Informe uma Razão Social!");
            maskedTextBoxCnpjEmpresa.ValidateCNPJ("Informe um CNPJ para Empresa!");

            if (Empresas.Any(x => x.Cnpj == maskedTextBoxCnpjEmpresa.Text.OnlyNumber()))
                throw new Exception("Já possuí uma empresa com esse CNPJ!");
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

        #endregion

        #region Events

        private void BindindSourceChanged(object? sender, ListChangedEventArgs e)
        {
            buttonSalvar.Enabled = !Program.DatabaseJson.Atualizado;
        }

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

        private void RemoverEmpresa_ClickEvent(object sender, EventArgs e)
        {
            var row = dataGridViewEmpresas.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();

            if (row is null)
            {
                MessageBox.Show("Selecione uma empresa!");
                return;
            }

            EmpresasBindingSource.RemoveAt(row.Index);
        }

        private void AdicionarMotorista_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                EnabledButtonsMotorista(false);

                ValidateMotorista();

                AddMotorista();

                ClearFieldsMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EnabledButtonsMotorista();
            }
        }

        private void RemoverMotorista_ClickEvent(object sender, EventArgs e)
        {
            var row = dataGridViewMotoristas.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();

            if (row is null)
            {
                MessageBox.Show("Selecione um Motorista!");
                return;
            }

            MotoristasBindingSource.RemoveAt(row.Index);
            buttonSalvar.Enabled = true;
        }

        private void Salvar_ClickEvent(object sender, EventArgs e)
        {
            Program.DatabaseJson.Save();
            buttonSalvar.Enabled = !Program.DatabaseJson.Atualizado;
        }

        #endregion
    }
}
