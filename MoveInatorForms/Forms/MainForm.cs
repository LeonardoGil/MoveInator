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
    }
}
