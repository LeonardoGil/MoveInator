using MoveInatorForms.Services;

namespace MoveInatorForms.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void Exit_ClickEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conectar_ClickEvent(object sender, EventArgs e)
        {
            var connectionString = textBoxConnectionString.Text;

            if (string.IsNullOrEmpty(connectionString))
            {
                try
                {
                    ConnectService.ConnectionStringValidate(connectionString);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
