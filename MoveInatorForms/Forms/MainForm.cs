using MoveInatorForms.Extensions;
using MoveInatorForms.Mock;
using MoveInatorForms.Models;

namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        public BindingSource ViagensViewBindingSource { get; set; }

        public MainForm()
        {
            InitializeComponent();

            LoadFormAsync();
        }

        private async Task LoadFormAsync()
        {
            ViagensViewBindingSource = new BindingSource
            {
                DataSource = new List<ViagemViewModel>()
            };

            dataGridView.DataSource = ViagensViewBindingSource;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");

            textBoxNomeDestinatario.Text = Data.Nomes.GetRandom();
            textBoxNomeMotorista.Text = Data.Nomes.GetRandom();
        }
    }
}
