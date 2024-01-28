using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Utilities.Extensions;
using System.ComponentModel;

namespace MoveInatorForms.Forms.Views
{
    public partial class CadastroBaseViewControl : BaseViewControl
    {
        protected readonly BindingSource BindingSource = new();

        public CadastroBaseViewControl()
        {
            InitializeComponent();

            BindingSource.ListChanged += BindindSourceChanged;
        }


        #region Events

        private void BindindSourceChanged(object? sender, ListChangedEventArgs e)
        {
            buttonSalvar.Enabled = !Program.DatabaseJson.Atualizado;
        }

        private void Salvar_ClickEvent(object sender, EventArgs e)
        {
            Program.DatabaseJson.Save();
            buttonSalvar.Enabled = !Program.DatabaseJson.Atualizado;
        }

        #endregion
    }
}
