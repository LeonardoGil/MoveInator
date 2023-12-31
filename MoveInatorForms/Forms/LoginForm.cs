namespace MoveInatorForms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly string MaskConnectionString = @"Data Source={0};Initial Catalog={1};User ID={2};Password={3};MultipleActiveResultSets=true";

        public string ConnectionString { get; private set; }

        public bool OfflineMode { get; private set; }

        public bool Exit { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exit_ClickEvent(object sender, EventArgs e)
        {
            Exit = true;
            Close();
        }

        private void ConnectionStringValidate()
        {
            if (string.IsNullOrEmpty(textBoxServer.Text))
                throw new Exception("Informar Server!");

            if (string.IsNullOrEmpty(textBoxDatabase.Text))
                throw new Exception("Informar Database!");

            if (string.IsNullOrEmpty(textBoxUser.Text))
                throw new Exception("Informar User!");

            if (string.IsNullOrEmpty(textBoxPassword.Text))
                throw new Exception("Informar Password!");
        }

        private void Connect_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                ConnectionStringValidate();

                ConnectionString = string.Format(MaskConnectionString, textBoxServer.Text.Trim(),
                                                                       textBoxDatabase.Text.Trim(),
                                                                       textBoxUser.Text.Trim(),
                                                                       textBoxPassword.Text.Trim());

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Offline_ClickEvent(object sender, EventArgs e)
        {
            OfflineMode = true;
            Close();
        }
    }
}