using Microsoft.Extensions.DependencyInjection;
using MoveInatorForms.Forms.Views;

namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        private Point Point;

        private GerarCSVSimplesViewControl GerarCSVSimplesView;

        public MainForm()
        {
            InitializeComponent();
        }

        private async Task LoadView(Control control)
        {
            if (panelView.Controls.Contains(control))
                return;

            panelView.Controls.Clear();
            panelView.Controls.Add(control);

            control.Dock = DockStyle.Fill;
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
                GerarCSVSimplesView = Program.ServiceProvider.GetRequiredService<GerarCSVSimplesViewControl>();

            LoadView(GerarCSVSimplesView);
        }
    }
}
