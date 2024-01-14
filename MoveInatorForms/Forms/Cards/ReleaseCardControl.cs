using GithubApiLib.Domains.Entities;
using System.Diagnostics;
using System.Reflection;

namespace MoveInatorForms.Forms.Cards
{
    public partial class ReleaseCardControl : UserControl
    {
        public ReleaseCardControl(Release release)
        {
            InitializeComponent();

            FormatRelease(release);
        }

        private void FormatRelease(Release release)
        {
            var versaoAtual = Assembly.GetExecutingAssembly()?.GetName()?.Version?.ToString() ?? string.Empty;

            var versao = release.Tag.Replace("Pre-Release@", string.Empty);

            var link = release.Anexados.FirstOrDefault()?.UrlDownload ?? string.Empty;

            var data = release.CriadoEm.ToString("d");

            var conteudo = release.Conteudo.Replace("### Feature", "🎁 Feature")
                                           .Replace("### Upgrade", "🛠 Upgrade")
                                           .Replace("### Bug", "💣 Bug")
                                           .Replace(">", "Obs: ");

            labelVersao.Text = versao;
            labelVersao.Location = new Point((Size.Width / 2) - (labelVersao.Size.Width / 2), labelVersao.Location.Y);

            if (versaoAtual == versao)
                labelVersao.ForeColor = Color.ForestGreen;

            labelData.Text = data;
            labelDescricao.Text = conteudo;
            linkLabel.Text = link;
        }

        private void DownloadVersion_LinkClickedEvent(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var message = $"Deseja fazer o download da versão {labelVersao.Text}?";
            var result = MessageBox.Show(message, "Download", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Process.Start("explorer.exe", linkLabel.Text);
        }
    }
}
