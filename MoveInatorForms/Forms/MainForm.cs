using Microsoft.Extensions.DependencyInjection;
using MoveInatorForms.Forms.Views;
using MoveInatorForms.Forms.Views.Cadastros;
using MoveInatorForms.Forms.Views.Manifestos;
using MoveInatorForms.Services.Interfaces;
using System.Diagnostics;
using System.Reflection;

namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        private Point Point;

        private InicioViewControl InicioViewControl;
        private GerarManifestoViewControl GerarCSVSimplesView;
        private GerarMDFeSimplesViewControl GerarMDFeSimplesView;
        private GerarTokenViewControl GerarTokenViewControl;
        private CadastroEmpresaViewControl CadastroEmpresaViewControl;
        private CadastroMotoristaViewControl CadastroMotoristaViewControl;
        private NovidadesViewControl NovidadesViewControl;

        private readonly IUpdateService updateService;

        public MainForm()
        {
        }

        public MainForm(IUpdateService _updateService)
        {
            updateService = _updateService;

            InitializeComponent();

            Task.Run(SetVersion);

            LoadInicio_ClickEvent(null, EventArgs.Empty);
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
                    {
                        labelVersion.Location = new Point(labelVersion.Location.X, labelVersion.Location.Y - 14);
                        labelVersion.Text += $"{Environment.NewLine}(Latest version: {updateService.GetLastVersion()})";
                    }
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

        #region Events

        private void DownloadVersion_ClickEvent(object sender, EventArgs e)
        {
            if (!updateService.Updated())
                DownloadLatestVersion();
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

        private void LoadCSVSimples_ClickEvent(object sender, EventArgs e)
        {
            if (GerarCSVSimplesView is default(GerarManifestoViewControl))
            {
                GerarCSVSimplesView = Program.ServiceProvider.GetRequiredService<GerarManifestoViewControl>();
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

        private void LoadCadastroEmpresa_ClickEvent(object sender, EventArgs e)
        {
            if (CadastroEmpresaViewControl is default(CadastroEmpresaViewControl))
                CadastroEmpresaViewControl = Program.ServiceProvider.GetRequiredService<CadastroEmpresaViewControl>();

            LoadView(CadastroEmpresaViewControl);
        }

        private void LoadCadastroMotorista_ClickEvent(object sender, EventArgs e)
        {
            if (CadastroMotoristaViewControl is default(CadastroMotoristaViewControl))
                CadastroMotoristaViewControl = Program.ServiceProvider.GetRequiredService<CadastroMotoristaViewControl>();

            LoadView(CadastroMotoristaViewControl);
        }

        private void LoadInicio_ClickEvent(object sender, EventArgs e)
        {
            if (InicioViewControl is default(InicioViewControl))
                InicioViewControl = Program.ServiceProvider.GetRequiredService<InicioViewControl>();

            LoadView(InicioViewControl);
        }

        private void LoadNovidades_ClickEvent(object sender, EventArgs e)
        {
            if (NovidadesViewControl is default(NovidadesViewControl))
                NovidadesViewControl = Program.ServiceProvider.GetRequiredService<NovidadesViewControl>();

            LoadView(NovidadesViewControl);
        }

        private void LoadTokens_ClickEvent(object sender, EventArgs e)
        {
            if (GerarTokenViewControl is default(GerarTokenViewControl))
                GerarTokenViewControl = Program.ServiceProvider.GetRequiredService<GerarTokenViewControl>();

            LoadView(GerarTokenViewControl);
        }

        private void MainForm_FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            if (!Program.DatabaseJson.Atualizado && MessageBox.Show("Deseja salvar os dados antes de Sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Program.DatabaseJson.Save().Wait();

            if (MessageBox.Show("Realmente deseja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        #endregion
    }
}
