namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task LoadFieldAsync()
        {
            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");
        }
    }
}
