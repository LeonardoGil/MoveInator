﻿using MoveInatorForms.Enums;
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

        private ViagemViewModel BuildViagemViewModel()
        {
            int? numeroViagem = null;
            int? serieViagem = null;

            var tipoViagem = (TipoDocumentoViagemEnum)checkedListBoxTipoViagem.SelectedIndex;

            if (tipoViagem == TipoDocumentoViagemEnum.MDFe)
            {
                numeroViagem = int.Parse(textBoxNumeroDocumento.Text);
                serieViagem = int.Parse(textBoxSerieDocumento.Text);
            }

            return new ViagemViewModel
            {
                TipoViagem = tipoViagem,
                NumeroViagem = numeroViagem,
                SerieViagem = serieViagem,

                TipoDocumento = (TipoDocumentoEnum)checkedListBoxTipoDocumento.SelectedIndex,
                NumeroDocumento = int.Parse(textBoxNumeroDocumento.Text),
                SerieDocumento = int.Parse(textBoxSerieDocumento.Text),
                Quantidade = (int)numericUpDownQuantidade.Value,

                DataEmissao = DateTime.Parse(maskedTextBoxDataEmissao.Text),
                CnpjEmissor = maskedTextBoxCnpjEmissor.Text,

                NomeDestinatario = textBoxNomeDestinatario.Text,
                CpfCnpjDestinatario = maskedTextBoxCpfCnpjDestinatario.Text,

                NomeMotorista = textBoxNomeMotorista.Text,
                CpfMotorista = maskedTextBoxCpfMotorista.Text
            };
        }

        private async Task AddViagemViewModelGrid()
        {
            var model = BuildViagemViewModel();

            ViagensViewBindingSource.Add(model);
        }

        private bool ValidateViagemViewModel()
        {
            // Viagem

            var tipoViagemValid = checkedListBoxTipoViagem.SelectedIndex >= 0;

            if (!tipoViagemValid)
                throw new Exception("Selecione um Tipo Viagem!");

            if ((TipoDocumentoViagemEnum)checkedListBoxTipoViagem.SelectedIndex == TipoDocumentoViagemEnum.MDFe)
            {
                if (string.IsNullOrEmpty(textBoxNumeroDocumento.Text))
                    throw new Exception("Informe um Numero Documento!");

                if (string.IsNullOrEmpty(textBoxSerieDocumento.Text))
                    throw new Exception("Informe uma Série Documento!");
            }

            // Documento

            var tipoDocumentoValid = checkedListBoxTipoDocumento.SelectedIndex >= 0;

            if (!tipoDocumentoValid)
                throw new Exception("Selecione um Tipo Documento!");

            if (!int.TryParse(textBoxNumeroInicial.Text, out _))
                throw new Exception("Informe um Numero inicial!");

            if (!int.TryParse(textBoxSerieInicial.Text, out _))
                throw new Exception("Informe uma Série inicial!");

            if (numericUpDownQuantidade.Value > 0)
                throw new Exception("Informe uma quantidade valída!");

            // Emissor

            if (!DateTime.TryParse(maskedTextBoxDataEmissao.Text, out _))
                throw new Exception("Informe uma Data Emissão valída!");

            if (string.IsNullOrEmpty(maskedTextBoxCnpjEmissor.Text))
                throw new Exception("Informe um CNPJ para o Emissor");

            // Destinatario

            if (string.IsNullOrEmpty(textBoxNomeDestinatario.Text))
                throw new Exception("Informe o nome do Destinatário!");

            if (string.IsNullOrEmpty(maskedTextBoxCpfCnpjDestinatario.Text))
                throw new Exception("Informe o Cpf/Cnpj do Destinatário!");

            // Motorista

            if (string.IsNullOrEmpty(textBoxNomeMotorista.Text))
                throw new Exception("Informe o nome do Motorista!");

            if (string.IsNullOrEmpty(maskedTextBoxCpfMotorista.Text))
                throw new Exception("Informe o Cpf do Motorista!");

            return true;
        }

        private void ResetCheckedList(CheckedListBox checkedListBox, int index = -1)
        {
            foreach (int ind in checkedListBox.CheckedIndices)
            {
                if (ind != index)
                    checkedListBox.SetItemChecked(ind, false);
            }
        }

        private void ClearFields()
        {
            throw new NotImplementedException();
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

            numericUpDownQuantidade.Value = 1;
        }

        private void EnableButtons(bool enabled = true)
        {
            buttonAdicionar.Enabled = enabled;
            buttonGerar.Enabled = enabled;
            buttonGerarCSV.Enabled = enabled;
            buttonLimpar.Enabled = enabled;
        }

        #region Events

        private async void Add_ClickEvent(object sender, EventArgs e)
        {
            try
            {
                ValidateViagemViewModel();

                var addTask = AddViagemViewModelGrid();

                EnableButtons(false);

                ClearFields();

                await addTask;

                if (addTask.Exception is not null)
                    throw addTask.Exception;

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
