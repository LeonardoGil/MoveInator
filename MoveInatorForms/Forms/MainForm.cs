using Microsoft.Extensions.DependencyInjection;
using MoveInatorForms.Forms.Views;

namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        private Point Point;

        private InicioViewControl InicioViewControl;
        private GerarCSVSimplesViewControl GerarCSVSimplesView;
        private GerarMDFeSimplesViewControl GerarMDFeSimplesView;
        private CadastrosViewControl CadastrosViewControl;
        private NovidadesViewControl NovidadesViewControl;

        public MainForm()
        {
            InitializeComponent();

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
            throw new NotImplementedException();
        }

        private void MainForm_FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            if (!Program.DatabaseJson.Atualizado && MessageBox.Show("Deseja salvar os dados antes de Sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Program.DatabaseJson.Save().Wait();

            if (MessageBox.Show("Realmente deseja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
