using DocumentosBrasileiros;
using Microsoft.Extensions.DependencyInjection;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Forms.Views;
using MoveInatorForms.Services.Interfaces;
using MoveInatorForms.Utilities.Extensions;
using MoveInatorForms.Utilities.Mocks;
using System.ComponentModel;
using System.Text;

namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        private Point Point;

        private GerarCSVSimplesViewControl GerarCSVSimplesView;

        public MainForm()
        {
            InitializeComponent();

            LoadView();
        }

        private async Task LoadView()
        {
            GerarCSVSimplesView = Program.ServiceProvider.GetRequiredService<GerarCSVSimplesViewControl>();
            GerarCSVSimplesView.Dock = DockStyle.Fill;

            panelView.Controls.Add(GerarCSVSimplesView);
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
    }
}
