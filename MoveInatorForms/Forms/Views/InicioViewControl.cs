using MoveInatorForms.Services.Interfaces;
using System.Diagnostics;
using System.Reflection;

namespace MoveInatorForms.Forms.Views
{
    public partial class InicioViewControl : UserControl
    {
        private readonly IUpdateService updateService;

        public InicioViewControl(IUpdateService updateService)
        {
            this.updateService = updateService;

            InitializeComponent();

            Task.Run(SetVersion);
        }

        private void SetVersion()
        {
            try
            {
                var updated = updateService.Updated();

                Invoke(() =>
                {
                    labelVersion.Text += Assembly.GetExecutingAssembly()?.GetName()?.Version?.ToString() ?? "Not Found";
                    labelVersion.ForeColor = updated ? Color.ForestGreen : Color.Brown;

                    if (!updated)
                        labelVersion.Text += $" (Latest version: {updateService.GetLastVersion()})";
                });

                if (!updated)
                    DownloadLatestVersion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownloadLatestVersion()
        {
            var message = "A versão que você esta usando está desatualizada" + Environment.NewLine + "Deseja baixar a nova versão?";
            var result = MessageBox.Show(message, "Versão desatualizada!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Process.Start("explorer.exe", updateService.LastRelease.Anexados.First().UrlDownload);
        }

        private void OpenGitHub_LinkClickedEvent(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", linkLabel.Text);

        private void DownloadVersion_ClickEvent(object sender, EventArgs e)
        {
            if (!updateService.Updated())
                DownloadLatestVersion();
        }
    }
}
