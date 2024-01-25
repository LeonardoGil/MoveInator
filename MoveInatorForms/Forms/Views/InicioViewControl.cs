using MoveInatorForms.Services;
using MoveInatorForms.Services.Interfaces;
using System.Diagnostics;
using System.Reflection;

namespace MoveInatorForms.Forms.Views
{
    public partial class InicioViewControl : UserControl
    {

        public InicioViewControl()
        {
            InitializeComponent();
        }

        private void OpenGitHub_LinkClickedEvent(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", linkLabel.Text);
    }
}
