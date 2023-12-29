using MoveInatorForms.Enums;
using MoveInatorForms.Extensions;
using MoveInatorForms.Mock;
using MoveInatorForms.Models;

namespace MoveInatorForms.Forms
{
    public partial class MainForm : Form
    {
        public BindingSource ViagensViewBindingSource { get; set; }

        public MainForm()
        {
            InitializeComponent();

            LoadFormAsync();
        }

        private void ResetCheckedList(CheckedListBox checkedListBox, int index = -1)
        {
            foreach (int ind in checkedListBox.CheckedIndices)
            {
                if (ind != index)
                    checkedListBox.SetItemChecked(ind, false);
            }
        }

        private async Task LoadFormAsync()
        {
            ViagensViewBindingSource = new BindingSource
            {
                DataSource = new List<ViagemViewModel>()
            };

            dataGridView.DataSource = ViagensViewBindingSource;

            maskedTextBoxDataEmissao.Text = DateTime.Now.ToString("d");

            textBoxNomeDestinatario.Text = Data.Nomes.GetRandom();
            textBoxNomeMotorista.Text = Data.Nomes.GetRandom();
        }

        #region Events
        private void ResetCheckedListDocumento_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                ResetCheckedList(checkedListBox, e.Index);
            }
        }

        private void ResetCheckedListViagem_ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                ResetCheckedList(checkedListBox, e.Index);

                var mdfeIndex = (int)TipoDocumentoViagemEnum.MDFe;

                var mdfeChecked = false;

                if (e.Index == mdfeIndex)
                {
                    mdfeChecked = e.NewValue == CheckState.Checked;                 
                }

                textBoxNumeroDocumento.Enabled = mdfeChecked;
                textBoxSerieDocumento.Enabled = mdfeChecked;
            }
        }
        #endregion
    }
}
