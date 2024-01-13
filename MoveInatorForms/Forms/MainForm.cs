using Microsoft.Extensions.DependencyInjection;
using MoveInatorForms.Forms.Views;
using MoveInatorForms.Services.Interfaces;
using System.Diagnostics;
using System.Reflection;

namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        private Point Point;

        private GerarCSVSimplesViewControl GerarCSVSimplesView;
        private GerarMDFeSimplesViewControl GerarMDFeSimplesView;
        private CadastrosViewControl CadastrosViewControl;

        private readonly IUpdateService updateService;

        public MainForm(IUpdateService updateService)
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
                        labelVersion.Text += $"{Environment.NewLine}(Latest version: {updateService.GetLastVersion()})";
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

        private void LoadView(Control control)
        {
            if (!panelView.Controls.Contains(control))
            {
                panelView.Controls.Clear();
                panelView.Controls.Add(control);

                control.Dock = DockStyle.Fill;
            }
        }

        private void SetPoint_MouseDownEvent(object sender, MouseEventArgs e)
        {
            Point = e.Location;
        }

        private void MoveForm_MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Point.X;
                Top += e.Y - Point.Y;
            }
        }

        private void Exit_ClickEvent(object sender, EventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Realmente deseja sair?", "Sair", MessageBoxButtons.YesNo);

            if (messageBoxResult == DialogResult.Yes)
                Close();
        }

        private void LoadCSVSimples_ClickEvent(object sender, EventArgs e)
        {
            if (GerarCSVSimplesView is default(GerarCSVSimplesViewControl))
            {
                GerarCSVSimplesView = Program.ServiceProvider.GetRequiredService<GerarCSVSimplesViewControl>();
            }
            else
            {
                GerarCSVSimplesView.Reload();
            }

            LoadView(GerarCSVSimplesView);
        }

        private void LoadMDFeSimples_ClickEvent(object sender, EventArgs e)
        {
            if (GerarMDFeSimplesView is default(GerarMDFeSimplesViewControl))
            {
                GerarMDFeSimplesView = Program.ServiceProvider.GetRequiredService<GerarMDFeSimplesViewControl>();
            }
            else
            {
                GerarMDFeSimplesView.Reload();
            }

            LoadView(GerarMDFeSimplesView);
        }

        private void LoadCadastros_ClickEvent(object sender, EventArgs e)
        {
            if (CadastrosViewControl is default(CadastrosViewControl))
                CadastrosViewControl = Program.ServiceProvider.GetRequiredService<CadastrosViewControl>();

            LoadView(CadastrosViewControl);
        }
    }
}
