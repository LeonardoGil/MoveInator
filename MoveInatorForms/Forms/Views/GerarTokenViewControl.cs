using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Utilities.Extensions;

namespace MoveInatorForms.Forms.Views
{
    public partial class GerarTokenViewControl : UserControl
    {
        public BindingSource TokensViewBindingSource { get; set; } = new BindingSource() { DataSource = new List<TokenViewModel>() };

        public BindingSource EmpresasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Empresas };

        public BindingSource MotoristasBindingSource { get; set; } = new() { DataSource = Program.DatabaseJson.Motoristas };

        public List<TokenViewModel> Viagens => TokensViewBindingSource.OfType<TokenViewModel>().ToList();

        public List<Empresa> Empresas => EmpresasBindingSource.OfType<Empresa>().ToList();

        public List<Motorista> Motoristas => MotoristasBindingSource.OfType<Motorista>().ToList();

        public GerarTokenViewControl()
        {
            InitializeComponent();
        }

        private async void ResetListBoxAPI_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                checkedListBox.ResetCheckedList(e.Index);
                comboBoxEmpresa.Enabled = e.Index == 0 && e.NewValue == CheckState.Checked;
                comboBoxMotorista.Enabled = e.Index == 1 && e.NewValue == CheckState.Checked;
            }
        }
    }
}

