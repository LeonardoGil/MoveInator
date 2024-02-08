﻿namespace MoveInatorForms.Forms.Views
{
    partial class GerarCSVSimplesViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarCSVSimplesViewControl));
            buttonAdicionar = new Button();
            buttonGerar = new Button();
            buttonLimpar = new Button();
            numericUpDownQuantidade = new NumericUpDown();
            textBoxSerieInicial = new TextBox();
            labelSerieInicial = new Label();
            textBoxNumeroInicial = new TextBox();
            labelNumeroInicial = new Label();
            labelQuantidadeDocumentos = new Label();
            checkedListBoxTipoDocumento = new CheckedListBox();
            labelTipoDocumento = new Label();
            textBoxSerieDocumento = new TextBox();
            labelSerieDocumento = new Label();
            textBoxNumeroDocumento = new TextBox();
            labelNumeroDocumento = new Label();
            checkedListBoxTipoViagem = new CheckedListBox();
            labelTipoViagem = new Label();
            comboBoxMotorista = new ComboBox();
            comboBoxEmissor = new ComboBox();
            maskedTextBoxCpfCnpjDestinatario = new MaskedTextBox();
            labelCpfCnpjDestinatario = new Label();
            textBoxNomeDestinatario = new TextBox();
            labelNomeDestinatario = new Label();
            labelNomeMotorista = new Label();
            labelEmissor = new Label();
            maskedTextBoxDataEmissao = new MaskedTextBox();
            labelDataEmissao = new Label();
            dataGridView = new DataGridView();
            buttonGerarCSV = new Button();
            textBoxDiretorio = new TextBox();
            labelDiretorio = new Label();
            labelTitulo = new Label();
            panelActions = new Panel();
            folderBrowserDialog = new FolderBrowserDialog();
            buttonFolder = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelActions.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.ForeColor = SystemColors.ControlLightLight;
            buttonAdicionar.Image = Properties.Resources.adicionar_16;
            buttonAdicionar.ImageAlign = ContentAlignment.TopLeft;
            buttonAdicionar.Location = new Point(155, 0);
            buttonAdicionar.Margin = new Padding(0);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(102, 27);
            buttonAdicionar.TabIndex = 29;
            buttonAdicionar.Text = " Adicionar";
            buttonAdicionar.TextAlign = ContentAlignment.BottomRight;
            buttonAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += AddViagemViewModel_ClickEventAsync;
            // 
            // buttonGerar
            // 
            buttonGerar.BackColor = Color.FromArgb(31, 31, 31);
            buttonGerar.FlatAppearance.BorderSize = 0;
            buttonGerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerar.FlatStyle = FlatStyle.Flat;
            buttonGerar.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerar.ForeColor = SystemColors.ControlLightLight;
            buttonGerar.Image = Properties.Resources.dados_16;
            buttonGerar.ImageAlign = ContentAlignment.TopLeft;
            buttonGerar.Location = new Point(85, 0);
            buttonGerar.Margin = new Padding(0);
            buttonGerar.Name = "buttonGerar";
            buttonGerar.Size = new Size(70, 27);
            buttonGerar.TabIndex = 30;
            buttonGerar.Text = " Auto";
            buttonGerar.TextAlign = ContentAlignment.BottomRight;
            buttonGerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGerar.UseVisualStyleBackColor = false;
            buttonGerar.Click += AutoComplete_ClickEvent;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.FromArgb(31, 31, 31);
            buttonLimpar.FlatAppearance.BorderSize = 0;
            buttonLimpar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpar.ForeColor = SystemColors.ControlLightLight;
            buttonLimpar.Image = Properties.Resources.vassoura_16;
            buttonLimpar.ImageAlign = ContentAlignment.TopLeft;
            buttonLimpar.Location = new Point(0, 0);
            buttonLimpar.Margin = new Padding(0);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(85, 27);
            buttonLimpar.TabIndex = 31;
            buttonLimpar.Text = " Limpar";
            buttonLimpar.TextAlign = ContentAlignment.BottomRight;
            buttonLimpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += ClearFields_ClickEvent;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownQuantidade.Location = new Point(239, 225);
            numericUpDownQuantidade.Margin = new Padding(5, 0, 0, 0);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownQuantidade.MaximumSize = new Size(120, 0);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(92, 25);
            numericUpDownQuantidade.TabIndex = 26;
            // 
            // textBoxSerieInicial
            // 
            textBoxSerieInicial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerieInicial.Location = new Point(125, 225);
            textBoxSerieInicial.Margin = new Padding(5, 0, 0, 0);
            textBoxSerieInicial.MaxLength = 3;
            textBoxSerieInicial.Name = "textBoxSerieInicial";
            textBoxSerieInicial.Size = new Size(109, 25);
            textBoxSerieInicial.TabIndex = 11;
            // 
            // labelSerieInicial
            // 
            labelSerieInicial.AutoSize = true;
            labelSerieInicial.ForeColor = SystemColors.ControlLightLight;
            labelSerieInicial.Location = new Point(125, 203);
            labelSerieInicial.Margin = new Padding(5, 5, 0, 5);
            labelSerieInicial.Name = "labelSerieInicial";
            labelSerieInicial.Size = new Size(37, 17);
            labelSerieInicial.TabIndex = 10;
            labelSerieInicial.Text = "Série";
            // 
            // textBoxNumeroInicial
            // 
            textBoxNumeroInicial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNumeroInicial.Location = new Point(125, 158);
            textBoxNumeroInicial.Margin = new Padding(5, 0, 0, 0);
            textBoxNumeroInicial.Name = "textBoxNumeroInicial";
            textBoxNumeroInicial.Size = new Size(109, 25);
            textBoxNumeroInicial.TabIndex = 9;
            // 
            // labelNumeroInicial
            // 
            labelNumeroInicial.AutoSize = true;
            labelNumeroInicial.ForeColor = SystemColors.ControlLightLight;
            labelNumeroInicial.Location = new Point(125, 136);
            labelNumeroInicial.Margin = new Padding(5, 5, 0, 5);
            labelNumeroInicial.Name = "labelNumeroInicial";
            labelNumeroInicial.Size = new Size(92, 17);
            labelNumeroInicial.TabIndex = 8;
            labelNumeroInicial.Text = "Numero Inicial";
            // 
            // labelQuantidadeDocumentos
            // 
            labelQuantidadeDocumentos.AutoSize = true;
            labelQuantidadeDocumentos.ForeColor = SystemColors.ControlLightLight;
            labelQuantidadeDocumentos.Location = new Point(239, 203);
            labelQuantidadeDocumentos.Margin = new Padding(5, 5, 0, 5);
            labelQuantidadeDocumentos.Name = "labelQuantidadeDocumentos";
            labelQuantidadeDocumentos.Size = new Size(76, 17);
            labelQuantidadeDocumentos.TabIndex = 12;
            labelQuantidadeDocumentos.Text = "Quantidade";
            // 
            // checkedListBoxTipoDocumento
            // 
            checkedListBoxTipoDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxTipoDocumento.BackColor = Color.FromArgb(31, 31, 31);
            checkedListBoxTipoDocumento.BorderStyle = BorderStyle.None;
            checkedListBoxTipoDocumento.CheckOnClick = true;
            checkedListBoxTipoDocumento.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoDocumento.FormattingEnabled = true;
            checkedListBoxTipoDocumento.Items.AddRange(new object[] { "CT-e", "NF-e" });
            checkedListBoxTipoDocumento.Location = new Point(120, 77);
            checkedListBoxTipoDocumento.Margin = new Padding(0);
            checkedListBoxTipoDocumento.Name = "checkedListBoxTipoDocumento";
            checkedListBoxTipoDocumento.Size = new Size(114, 40);
            checkedListBoxTipoDocumento.TabIndex = 7;
            checkedListBoxTipoDocumento.ItemCheck += ResetCheckedListDocumento_ItemCheckEvent;
            // 
            // labelTipoDocumento
            // 
            labelTipoDocumento.AutoSize = true;
            labelTipoDocumento.ForeColor = SystemColors.ControlLightLight;
            labelTipoDocumento.Location = new Point(125, 55);
            labelTipoDocumento.Margin = new Padding(5, 5, 0, 5);
            labelTipoDocumento.Name = "labelTipoDocumento";
            labelTipoDocumento.Size = new Size(105, 17);
            labelTipoDocumento.TabIndex = 6;
            labelTipoDocumento.Text = "Tipo Documento";
            // 
            // textBoxSerieDocumento
            // 
            textBoxSerieDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerieDocumento.Enabled = false;
            textBoxSerieDocumento.Location = new Point(20, 225);
            textBoxSerieDocumento.Margin = new Padding(20, 0, 0, 0);
            textBoxSerieDocumento.MaxLength = 3;
            textBoxSerieDocumento.Name = "textBoxSerieDocumento";
            textBoxSerieDocumento.Size = new Size(100, 25);
            textBoxSerieDocumento.TabIndex = 5;
            // 
            // labelSerieDocumento
            // 
            labelSerieDocumento.AutoSize = true;
            labelSerieDocumento.ForeColor = SystemColors.ControlLightLight;
            labelSerieDocumento.Location = new Point(20, 203);
            labelSerieDocumento.Margin = new Padding(20, 5, 0, 5);
            labelSerieDocumento.Name = "labelSerieDocumento";
            labelSerieDocumento.Size = new Size(67, 17);
            labelSerieDocumento.TabIndex = 4;
            labelSerieDocumento.Text = "Série Doc.";
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNumeroDocumento.Location = new Point(20, 158);
            textBoxNumeroDocumento.Margin = new Padding(20, 0, 0, 0);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(100, 25);
            textBoxNumeroDocumento.TabIndex = 3;
            // 
            // labelNumeroDocumento
            // 
            labelNumeroDocumento.AutoSize = true;
            labelNumeroDocumento.ForeColor = SystemColors.ControlLightLight;
            labelNumeroDocumento.Location = new Point(20, 136);
            labelNumeroDocumento.Margin = new Padding(20, 5, 0, 5);
            labelNumeroDocumento.Name = "labelNumeroDocumento";
            labelNumeroDocumento.Size = new Size(86, 17);
            labelNumeroDocumento.TabIndex = 2;
            labelNumeroDocumento.Text = "Numero Doc.";
            // 
            // checkedListBoxTipoViagem
            // 
            checkedListBoxTipoViagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxTipoViagem.BackColor = Color.FromArgb(31, 31, 31);
            checkedListBoxTipoViagem.BorderStyle = BorderStyle.None;
            checkedListBoxTipoViagem.CheckOnClick = true;
            checkedListBoxTipoViagem.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoViagem.FormattingEnabled = true;
            checkedListBoxTipoViagem.Items.AddRange(new object[] { "MDF-e", "Manifesto" });
            checkedListBoxTipoViagem.Location = new Point(20, 77);
            checkedListBoxTipoViagem.Margin = new Padding(20, 0, 0, 0);
            checkedListBoxTipoViagem.Name = "checkedListBoxTipoViagem";
            checkedListBoxTipoViagem.Size = new Size(100, 40);
            checkedListBoxTipoViagem.TabIndex = 1;
            checkedListBoxTipoViagem.ItemCheck += ResetCheckedListViagem_ItemCheckEvent;
            // 
            // labelTipoViagem
            // 
            labelTipoViagem.AutoSize = true;
            labelTipoViagem.ForeColor = SystemColors.ControlLightLight;
            labelTipoViagem.Location = new Point(20, 55);
            labelTipoViagem.Margin = new Padding(20, 5, 0, 5);
            labelTipoViagem.Name = "labelTipoViagem";
            labelTipoViagem.Size = new Size(82, 17);
            labelTipoViagem.TabIndex = 0;
            labelTipoViagem.Text = "Tipo Viagem";
            // 
            // comboBoxMotorista
            // 
            comboBoxMotorista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMotorista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotorista.FormattingEnabled = true;
            comboBoxMotorista.Location = new Point(336, 225);
            comboBoxMotorista.Margin = new Padding(5, 0, 0, 0);
            comboBoxMotorista.Name = "comboBoxMotorista";
            comboBoxMotorista.Size = new Size(107, 25);
            comboBoxMotorista.TabIndex = 33;
            // 
            // comboBoxEmissor
            // 
            comboBoxEmissor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEmissor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmissor.FormattingEnabled = true;
            comboBoxEmissor.Location = new Point(336, 158);
            comboBoxEmissor.Margin = new Padding(5, 0, 0, 0);
            comboBoxEmissor.Name = "comboBoxEmissor";
            comboBoxEmissor.Size = new Size(107, 25);
            comboBoxEmissor.TabIndex = 32;
            // 
            // maskedTextBoxCpfCnpjDestinatario
            // 
            maskedTextBoxCpfCnpjDestinatario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxCpfCnpjDestinatario.Location = new Point(448, 225);
            maskedTextBoxCpfCnpjDestinatario.Margin = new Padding(5, 0, 20, 0);
            maskedTextBoxCpfCnpjDestinatario.Mask = "00.000.000/0000-00";
            maskedTextBoxCpfCnpjDestinatario.Name = "maskedTextBoxCpfCnpjDestinatario";
            maskedTextBoxCpfCnpjDestinatario.Size = new Size(132, 25);
            maskedTextBoxCpfCnpjDestinatario.TabIndex = 21;
            maskedTextBoxCpfCnpjDestinatario.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfCnpjDestinatario
            // 
            labelCpfCnpjDestinatario.AutoSize = true;
            labelCpfCnpjDestinatario.ForeColor = SystemColors.ControlLightLight;
            labelCpfCnpjDestinatario.Location = new Point(448, 203);
            labelCpfCnpjDestinatario.Margin = new Padding(5, 5, 0, 5);
            labelCpfCnpjDestinatario.Name = "labelCpfCnpjDestinatario";
            labelCpfCnpjDestinatario.Size = new Size(111, 17);
            labelCpfCnpjDestinatario.TabIndex = 20;
            labelCpfCnpjDestinatario.Text = "CNPJ Destinatário";
            // 
            // textBoxNomeDestinatario
            // 
            textBoxNomeDestinatario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNomeDestinatario.Location = new Point(448, 158);
            textBoxNomeDestinatario.Margin = new Padding(5, 0, 20, 0);
            textBoxNomeDestinatario.Name = "textBoxNomeDestinatario";
            textBoxNomeDestinatario.Size = new Size(132, 25);
            textBoxNomeDestinatario.TabIndex = 19;
            // 
            // labelNomeDestinatario
            // 
            labelNomeDestinatario.AutoSize = true;
            labelNomeDestinatario.ForeColor = SystemColors.ControlLightLight;
            labelNomeDestinatario.Location = new Point(448, 136);
            labelNomeDestinatario.Margin = new Padding(5, 5, 0, 5);
            labelNomeDestinatario.Name = "labelNomeDestinatario";
            labelNomeDestinatario.Size = new Size(118, 17);
            labelNomeDestinatario.TabIndex = 18;
            labelNomeDestinatario.Text = "Nome Destinatário";
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.ForeColor = SystemColors.ControlLightLight;
            labelNomeMotorista.Location = new Point(336, 203);
            labelNomeMotorista.Margin = new Padding(5, 5, 0, 5);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(65, 17);
            labelNomeMotorista.TabIndex = 22;
            labelNomeMotorista.Text = "Motorista";
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(336, 136);
            labelEmissor.Margin = new Padding(5, 5, 0, 5);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(54, 17);
            labelEmissor.TabIndex = 16;
            labelEmissor.Text = "Emissor";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxDataEmissao.Location = new Point(239, 158);
            maskedTextBoxDataEmissao.Margin = new Padding(5, 0, 0, 0);
            maskedTextBoxDataEmissao.Mask = "00/00/0000";
            maskedTextBoxDataEmissao.MaximumSize = new Size(120, 25);
            maskedTextBoxDataEmissao.Name = "maskedTextBoxDataEmissao";
            maskedTextBoxDataEmissao.Size = new Size(92, 25);
            maskedTextBoxDataEmissao.TabIndex = 15;
            maskedTextBoxDataEmissao.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxDataEmissao.ValidatingType = typeof(DateTime);
            // 
            // labelDataEmissao
            // 
            labelDataEmissao.AutoSize = true;
            labelDataEmissao.ForeColor = SystemColors.ControlLightLight;
            labelDataEmissao.Location = new Point(239, 136);
            labelDataEmissao.Margin = new Padding(5, 5, 0, 5);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(87, 17);
            labelDataEmissao.TabIndex = 14;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 300);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle3.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(600, 300);
            dataGridView.TabIndex = 33;
            // 
            // buttonGerarCSV
            // 
            buttonGerarCSV.Enabled = false;
            buttonGerarCSV.FlatAppearance.BorderSize = 0;
            buttonGerarCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarCSV.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            buttonGerarCSV.FlatStyle = FlatStyle.Flat;
            buttonGerarCSV.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarCSV.ForeColor = SystemColors.ControlLightLight;
            buttonGerarCSV.Image = Properties.Resources.arquivo_csv_16;
            buttonGerarCSV.ImageAlign = ContentAlignment.TopLeft;
            buttonGerarCSV.Location = new Point(257, 0);
            buttonGerarCSV.Margin = new Padding(0);
            buttonGerarCSV.Name = "buttonGerarCSV";
            buttonGerarCSV.Size = new Size(80, 27);
            buttonGerarCSV.TabIndex = 42;
            buttonGerarCSV.Text = " Gerar";
            buttonGerarCSV.TextAlign = ContentAlignment.BottomCenter;
            buttonGerarCSV.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGerarCSV.UseVisualStyleBackColor = false;
            buttonGerarCSV.Click += GenerateCSV_ClickEvent;
            // 
            // textBoxDiretorio
            // 
            textBoxDiretorio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxDiretorio, 2);
            textBoxDiretorio.Location = new Point(331, 77);
            textBoxDiretorio.Margin = new Padding(0, 0, 20, 0);
            textBoxDiretorio.Name = "textBoxDiretorio";
            textBoxDiretorio.Size = new Size(249, 25);
            textBoxDiretorio.TabIndex = 44;
            // 
            // labelDiretorio
            // 
            labelDiretorio.AutoSize = true;
            labelDiretorio.ForeColor = SystemColors.ControlLightLight;
            labelDiretorio.Location = new Point(331, 55);
            labelDiretorio.Margin = new Padding(0, 5, 0, 5);
            labelDiretorio.Name = "labelDiretorio";
            labelDiretorio.Size = new Size(60, 17);
            labelDiretorio.TabIndex = 45;
            labelDiretorio.Text = "Diretório";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelTitulo, 2);
            labelTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(20, 10);
            labelTitulo.Margin = new Padding(20, 10, 0, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(129, 30);
            labelTitulo.TabIndex = 46;
            labelTitulo.Text = "CSV Simples";
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(panelActions, 5);
            panelActions.Controls.Add(buttonLimpar);
            panelActions.Controls.Add(buttonGerarCSV);
            panelActions.Controls.Add(buttonAdicionar);
            panelActions.Controls.Add(buttonGerar);
            panelActions.Location = new Point(264, 270);
            panelActions.Margin = new Padding(0, 3, 0, 3);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(336, 27);
            panelActions.TabIndex = 47;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.SelectedPath = "C:\\Temp";
            // 
            // buttonFolder
            // 
            buttonFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFolder.FlatAppearance.BorderSize = 0;
            buttonFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonFolder.FlatStyle = FlatStyle.Flat;
            buttonFolder.ForeColor = SystemColors.ControlLightLight;
            buttonFolder.Image = (Image)resources.GetObject("buttonFolder.Image");
            buttonFolder.Location = new Point(301, 77);
            buttonFolder.Margin = new Padding(0);
            buttonFolder.Name = "buttonFolder";
            buttonFolder.Size = new Size(30, 25);
            buttonFolder.TabIndex = 43;
            buttonFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFolder.UseVisualStyleBackColor = false;
            buttonFolder.Click += Folder_ClickEvent;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5027313F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6010933F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8571434F));
            tableLayoutPanel1.Controls.Add(labelTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxMotorista, 3, 6);
            tableLayoutPanel1.Controls.Add(maskedTextBoxCpfCnpjDestinatario, 4, 6);
            tableLayoutPanel1.Controls.Add(labelCpfCnpjDestinatario, 4, 5);
            tableLayoutPanel1.Controls.Add(panelActions, 0, 7);
            tableLayoutPanel1.Controls.Add(textBoxNomeDestinatario, 4, 4);
            tableLayoutPanel1.Controls.Add(comboBoxEmissor, 3, 4);
            tableLayoutPanel1.Controls.Add(labelNomeDestinatario, 4, 3);
            tableLayoutPanel1.Controls.Add(labelTipoViagem, 0, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownQuantidade, 2, 6);
            tableLayoutPanel1.Controls.Add(checkedListBoxTipoViagem, 0, 2);
            tableLayoutPanel1.Controls.Add(labelNomeMotorista, 3, 5);
            tableLayoutPanel1.Controls.Add(labelQuantidadeDocumentos, 2, 5);
            tableLayoutPanel1.Controls.Add(textBoxSerieInicial, 1, 6);
            tableLayoutPanel1.Controls.Add(labelNumeroDocumento, 0, 3);
            tableLayoutPanel1.Controls.Add(maskedTextBoxDataEmissao, 2, 4);
            tableLayoutPanel1.Controls.Add(labelSerieInicial, 1, 5);
            tableLayoutPanel1.Controls.Add(textBoxNumeroDocumento, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxNumeroInicial, 1, 4);
            tableLayoutPanel1.Controls.Add(labelNumeroInicial, 1, 3);
            tableLayoutPanel1.Controls.Add(labelSerieDocumento, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxSerieDocumento, 0, 6);
            tableLayoutPanel1.Controls.Add(labelTipoDocumento, 1, 1);
            tableLayoutPanel1.Controls.Add(checkedListBoxTipoDocumento, 1, 2);
            tableLayoutPanel1.Controls.Add(labelEmissor, 3, 3);
            tableLayoutPanel1.Controls.Add(textBoxDiretorio, 3, 2);
            tableLayoutPanel1.Controls.Add(labelDiretorio, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonFolder, 2, 2);
            tableLayoutPanel1.Controls.Add(labelDataEmissao, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(600, 300);
            tableLayoutPanel1.TabIndex = 48;
            // 
            // GerarCSVSimplesViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Name = "GerarCSVSimplesViewControl";
            Resize += View_ResizeEvent;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelActions.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAdicionar;
        private Button buttonGerar;
        private Button buttonLimpar;
        private NumericUpDown numericUpDownQuantidade;
        private MaskedTextBox maskedTextBoxCpfCnpjDestinatario;
        private Label labelCpfCnpjDestinatario;
        private TextBox textBoxNomeDestinatario;
        private Label labelNomeDestinatario;
        private TextBox textBoxSerieInicial;
        private Label labelSerieInicial;
        private TextBox textBoxNumeroInicial;
        private Label labelNumeroInicial;
        private Label labelNomeMotorista;
        private Label labelQuantidadeDocumentos;
        private CheckedListBox checkedListBoxTipoDocumento;
        private Label labelTipoDocumento;
        private MaskedTextBox maskedTextBoxDataEmissao;
        private Label labelDataEmissao;
        private TextBox textBoxSerieDocumento;
        private Label labelSerieDocumento;
        private TextBox textBoxNumeroDocumento;
        private Label labelNumeroDocumento;
        private CheckedListBox checkedListBoxTipoViagem;
        private Label labelTipoViagem;
        protected DataGridView dataGridView;
        private Button buttonGerarCSV;
        private TextBox textBoxDiretorio;
        private Label labelDiretorio;
        private Label labelEmissor;
        private ComboBox comboBoxMotorista;
        private ComboBox comboBoxEmissor;
        private Label labelTitulo;
        private Panel panelActions;
        private FolderBrowserDialog folderBrowserDialog;
        private Button buttonFolder;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
