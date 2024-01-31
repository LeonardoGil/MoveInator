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

        private void CadastroBaseViewControl_Resize(object sender, EventArgs e)
        {
            var buttonsY = 270;
            
            var buttonSaveX = 515;
            var buttonAddX = 411;
            var buttonRemoveX = 320;

            if (sender is Control control)
            {
                var sizeX = control.Width - 600;
                var sizeY = control.Height - 600;

                buttonSalvar.Location = new Point(buttonSaveX + sizeX, buttonsY + sizeY);
                buttonAdicionar.Location = new Point(buttonAddX + sizeX, buttonsY + sizeY);
                buttonRemover.Location = new Point(buttonRemoveX + sizeX, buttonsY + sizeY);
            }
        }

        #endregion
    }
}
