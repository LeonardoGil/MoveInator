using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Utilities.Extensions;

namespace MoveInatorForms.Forms.Views.Cadastros
{
    public partial class CadastroMotoristaViewControl : CadastroBaseViewControl
    {
        private List<Motorista> Motoristas => BindingSource.OfType<Motorista>().ToList();

        public CadastroMotoristaViewControl()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            maskedTextBoxCpfMotorista.KeyPress += ControlEventsExtensions.OnlyNumber_KeyPressEvent;
            buttonAdicionar.Click += AddMotorista_ClickEvent;
            buttonRemover.Click += RemoveMotorista_ClickEvent;

            BindingSource.DataSource = Program.DatabaseJson.Motoristas;
            dataGridView.DataSource = BindingSource;

            dataGridView.FillSpecificCells(nameof(Motorista.Nome), nameof(Motorista.Cpf));
        }

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
            BindingSource.Add(motorista);
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
            buttonAdicionar.Enabled = enabled;
        }

        private void ClearFieldsMotorista()
        {
            maskedTextBoxCpfMotorista.Text = string.Empty;
            textBoxNomeMotorista.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        private void AddMotorista_ClickEvent(object sender, EventArgs e)
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

        private void RemoveMotorista_ClickEvent(object sender, EventArgs e)
        {
            var row = dataGridView.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault();

            if (row is null)
            {
                MessageBox.Show("Selecione um Motorista!");
                return;
            }

            BindingSource.RemoveAt(row.Index);
        }
    }
}
