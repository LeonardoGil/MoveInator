using System.Diagnostics;

namespace MoveInatorForms.Forms.Views
{
    public partial class InicioViewControl : BaseViewControl
    {

        public InicioViewControl()
        {
            InitializeComponent();
        }

        private void OpenGitHub_LinkClickedEvent(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", linkLabel.Text);
    }
}
