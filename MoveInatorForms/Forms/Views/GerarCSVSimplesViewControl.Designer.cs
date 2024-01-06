namespace MoveInatorForms.Forms.Views
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelDiretorio = new Label();
            textBoxDiretorio = new TextBox();
            buttonLimparViagens = new Button();
            dataGridView = new DataGridView();
            buttonGerarCSV = new Button();
            buttonLimpar = new Button();
            buttonGerar = new Button();
            buttonAdicionar = new Button();
            panelSuperior = new Panel();
            numericUpDownQuantidade = new NumericUpDown();
            maskedTextBoxCpfCnpjDestinatario = new MaskedTextBox();
            labelCpfCnpjDestinatario = new Label();
            textBoxNomeDestinatario = new TextBox();
            labelNomeDestinatario = new Label();
            textBoxSerieInicial = new TextBox();
            labelSerieInicial = new Label();
            textBoxNumeroInicial = new TextBox();
            labelNumeroInicial = new Label();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            labelNomeMotorista = new Label();
            labelQuantidadeDocumentos = new Label();
            checkedListBoxTipoDocumento = new CheckedListBox();
            labelTipoDocumento = new Label();
            maskedTextBoxCnpjEmissor = new MaskedTextBox();
            labelCnpjEmissor = new Label();
            maskedTextBoxDataEmissao = new MaskedTextBox();
            labelDataEmissao = new Label();
            textBoxSerieDocumento = new TextBox();
            labelSerieDocumento = new Label();
            textBoxNumeroDocumento = new TextBox();
            labelNumeroDocumento = new Label();
            checkedListBoxTipoViagem = new CheckedListBox();
            labelTipoViagem = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // labelDiretorio
            // 
            labelDiretorio.AutoSize = true;
            labelDiretorio.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiretorio.Location = new Point(3, 476);
            labelDiretorio.Name = "labelDiretorio";
            labelDiretorio.Size = new Size(71, 17);
            labelDiretorio.TabIndex = 36;
            labelDiretorio.Text = "Diretório";
            // 
            // textBoxDiretorio
            // 
            textBoxDiretorio.Location = new Point(3, 494);
            textBoxDiretorio.Name = "textBoxDiretorio";
            textBoxDiretorio.Size = new Size(391, 23);
            textBoxDiretorio.TabIndex = 35;
            // 
            // buttonLimparViagens
            // 
            buttonLimparViagens.BackColor = Color.FromArgb(41, 41, 41);
            buttonLimparViagens.Enabled = false;
            buttonLimparViagens.FlatAppearance.BorderSize = 0;
            buttonLimparViagens.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimparViagens.FlatStyle = FlatStyle.Flat;
            buttonLimparViagens.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimparViagens.Location = new Point(583, 476);
            buttonLimparViagens.Name = "buttonLimparViagens";
            buttonLimparViagens.Size = new Size(104, 41);
            buttonLimparViagens.TabIndex = 34;
            buttonLimparViagens.Text = "Limpar";
            buttonLimparViagens.UseVisualStyleBackColor = false;
            buttonLimparViagens.Click += LimparViagensGrid_ClickEvent;
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
            dataGridViewCellStyle1.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 166);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle4.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(800, 304);
            dataGridView.TabIndex = 33;
            // 
            // buttonGerarCSV
            // 
            buttonGerarCSV.BackColor = Color.FromArgb(41, 41, 41);
            buttonGerarCSV.Enabled = false;
            buttonGerarCSV.FlatAppearance.BorderSize = 0;
            buttonGerarCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarCSV.FlatStyle = FlatStyle.Flat;
            buttonGerarCSV.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarCSV.Location = new Point(693, 476);
            buttonGerarCSV.Name = "buttonGerarCSV";
            buttonGerarCSV.Size = new Size(104, 41);
            buttonGerarCSV.TabIndex = 32;
            buttonGerarCSV.Text = "Gerar CSV";
            buttonGerarCSV.UseVisualStyleBackColor = false;
            buttonGerarCSV.Click += GenerateCSV_ClickEvent;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.FromArgb(41, 41, 41);
            buttonLimpar.FlatAppearance.BorderSize = 0;
            buttonLimpar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(714, 54);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(83, 28);
            buttonLimpar.TabIndex = 31;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += ClearFields_ClickEvent;
            // 
            // buttonGerar
            // 
            buttonGerar.BackColor = Color.FromArgb(41, 41, 41);
            buttonGerar.FlatAppearance.BorderSize = 0;
            buttonGerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerar.FlatStyle = FlatStyle.Flat;
            buttonGerar.Location = new Point(714, 88);
            buttonGerar.Name = "buttonGerar";
            buttonGerar.Size = new Size(83, 28);
            buttonGerar.TabIndex = 30;
            buttonGerar.Text = "Auto";
            buttonGerar.UseVisualStyleBackColor = false;
            buttonGerar.Click += AutoComplete_ClickEvent;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.FromArgb(41, 41, 41);
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Location = new Point(714, 125);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(83, 28);
            buttonAdicionar.TabIndex = 29;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += AddViagemViewModel_ClickEventAsync;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(23, 23, 23);
            panelSuperior.Controls.Add(numericUpDownQuantidade);
            panelSuperior.Controls.Add(maskedTextBoxCpfCnpjDestinatario);
            panelSuperior.Controls.Add(labelCpfCnpjDestinatario);
            panelSuperior.Controls.Add(textBoxNomeDestinatario);
            panelSuperior.Controls.Add(labelNomeDestinatario);
            panelSuperior.Controls.Add(buttonLimpar);
            panelSuperior.Controls.Add(textBoxSerieInicial);
            panelSuperior.Controls.Add(buttonGerar);
            panelSuperior.Controls.Add(labelSerieInicial);
            panelSuperior.Controls.Add(buttonAdicionar);
            panelSuperior.Controls.Add(textBoxNumeroInicial);
            panelSuperior.Controls.Add(labelNumeroInicial);
            panelSuperior.Controls.Add(maskedTextBoxCpfMotorista);
            panelSuperior.Controls.Add(labelCpfMotorista);
            panelSuperior.Controls.Add(textBoxNomeMotorista);
            panelSuperior.Controls.Add(labelNomeMotorista);
            panelSuperior.Controls.Add(labelQuantidadeDocumentos);
            panelSuperior.Controls.Add(checkedListBoxTipoDocumento);
            panelSuperior.Controls.Add(labelTipoDocumento);
            panelSuperior.Controls.Add(maskedTextBoxCnpjEmissor);
            panelSuperior.Controls.Add(labelCnpjEmissor);
            panelSuperior.Controls.Add(maskedTextBoxDataEmissao);
            panelSuperior.Controls.Add(labelDataEmissao);
            panelSuperior.Controls.Add(textBoxSerieDocumento);
            panelSuperior.Controls.Add(labelSerieDocumento);
            panelSuperior.Controls.Add(textBoxNumeroDocumento);
            panelSuperior.Controls.Add(labelNumeroDocumento);
            panelSuperior.Controls.Add(checkedListBoxTipoViagem);
            panelSuperior.Controls.Add(labelTipoViagem);
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(800, 160);
            panelSuperior.TabIndex = 28;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(313, 130);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(80, 23);
            numericUpDownQuantidade.TabIndex = 26;
            // 
            // maskedTextBoxCpfCnpjDestinatario
            // 
            maskedTextBoxCpfCnpjDestinatario.Location = new Point(405, 130);
            maskedTextBoxCpfCnpjDestinatario.Mask = "00.000.000/0000-00";
            maskedTextBoxCpfCnpjDestinatario.Name = "maskedTextBoxCpfCnpjDestinatario";
            maskedTextBoxCpfCnpjDestinatario.Size = new Size(156, 23);
            maskedTextBoxCpfCnpjDestinatario.TabIndex = 21;
            maskedTextBoxCpfCnpjDestinatario.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfCnpjDestinatario
            // 
            labelCpfCnpjDestinatario.AutoSize = true;
            labelCpfCnpjDestinatario.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfCnpjDestinatario.Location = new Point(406, 111);
            labelCpfCnpjDestinatario.Name = "labelCpfCnpjDestinatario";
            labelCpfCnpjDestinatario.Size = new Size(155, 17);
            labelCpfCnpjDestinatario.TabIndex = 20;
            labelCpfCnpjDestinatario.Text = "CPF/CNPJ Destinatário";
            // 
            // textBoxNomeDestinatario
            // 
            textBoxNomeDestinatario.Location = new Point(406, 85);
            textBoxNomeDestinatario.Name = "textBoxNomeDestinatario";
            textBoxNomeDestinatario.Size = new Size(156, 23);
            textBoxNomeDestinatario.TabIndex = 19;
            // 
            // labelNomeDestinatario
            // 
            labelNomeDestinatario.AutoSize = true;
            labelNomeDestinatario.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeDestinatario.Location = new Point(406, 65);
            labelNomeDestinatario.Name = "labelNomeDestinatario";
            labelNomeDestinatario.Size = new Size(127, 17);
            labelNomeDestinatario.TabIndex = 18;
            labelNomeDestinatario.Text = "Nome Destinatário";
            // 
            // textBoxSerieInicial
            // 
            textBoxSerieInicial.Location = new Point(188, 131);
            textBoxSerieInicial.MaxLength = 3;
            textBoxSerieInicial.Name = "textBoxSerieInicial";
            textBoxSerieInicial.Size = new Size(106, 23);
            textBoxSerieInicial.TabIndex = 11;
            // 
            // labelSerieInicial
            // 
            labelSerieInicial.AutoSize = true;
            labelSerieInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieInicial.Location = new Point(188, 111);
            labelSerieInicial.Name = "labelSerieInicial";
            labelSerieInicial.Size = new Size(43, 17);
            labelSerieInicial.TabIndex = 10;
            labelSerieInicial.Text = "Série";
            // 
            // textBoxNumeroInicial
            // 
            textBoxNumeroInicial.Location = new Point(188, 85);
            textBoxNumeroInicial.Name = "textBoxNumeroInicial";
            textBoxNumeroInicial.Size = new Size(106, 23);
            textBoxNumeroInicial.TabIndex = 9;
            // 
            // labelNumeroInicial
            // 
            labelNumeroInicial.AutoSize = true;
            labelNumeroInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroInicial.Location = new Point(188, 65);
            labelNumeroInicial.Name = "labelNumeroInicial";
            labelNumeroInicial.Size = new Size(106, 17);
            labelNumeroInicial.TabIndex = 8;
            labelNumeroInicial.Text = "Numero Inicial";
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(572, 130);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(120, 23);
            maskedTextBoxCpfMotorista.TabIndex = 25;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.Location = new Point(572, 110);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(99, 17);
            labelCpfMotorista.TabIndex = 24;
            labelCpfMotorista.Text = "CPF Motorista";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(573, 85);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(120, 23);
            textBoxNomeMotorista.TabIndex = 23;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.Location = new Point(573, 65);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(106, 17);
            labelNomeMotorista.TabIndex = 22;
            labelNomeMotorista.Text = "Nome Motorista";
            // 
            // labelQuantidadeDocumentos
            // 
            labelQuantidadeDocumentos.AutoSize = true;
            labelQuantidadeDocumentos.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeDocumentos.Location = new Point(313, 111);
            labelQuantidadeDocumentos.Name = "labelQuantidadeDocumentos";
            labelQuantidadeDocumentos.Size = new Size(78, 17);
            labelQuantidadeDocumentos.TabIndex = 12;
            labelQuantidadeDocumentos.Text = "Quantidade";
            // 
            // checkedListBoxTipoDocumento
            // 
            checkedListBoxTipoDocumento.BackColor = Color.FromArgb(23, 23, 23);
            checkedListBoxTipoDocumento.BorderStyle = BorderStyle.None;
            checkedListBoxTipoDocumento.CheckOnClick = true;
            checkedListBoxTipoDocumento.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoDocumento.FormattingEnabled = true;
            checkedListBoxTipoDocumento.Items.AddRange(new object[] { "CT-e", "NF-e" });
            checkedListBoxTipoDocumento.Location = new Point(188, 26);
            checkedListBoxTipoDocumento.Name = "checkedListBoxTipoDocumento";
            checkedListBoxTipoDocumento.Size = new Size(97, 36);
            checkedListBoxTipoDocumento.TabIndex = 7;
            checkedListBoxTipoDocumento.ItemCheck += ResetCheckedListDocumento_ItemCheckEvent;
            // 
            // labelTipoDocumento
            // 
            labelTipoDocumento.AutoSize = true;
            labelTipoDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoDocumento.Location = new Point(188, 6);
            labelTipoDocumento.Name = "labelTipoDocumento";
            labelTipoDocumento.Size = new Size(106, 17);
            labelTipoDocumento.TabIndex = 6;
            labelTipoDocumento.Text = "Tipo Documento";
            // 
            // maskedTextBoxCnpjEmissor
            // 
            maskedTextBoxCnpjEmissor.Location = new Point(553, 26);
            maskedTextBoxCnpjEmissor.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmissor.Name = "maskedTextBoxCnpjEmissor";
            maskedTextBoxCnpjEmissor.Size = new Size(140, 23);
            maskedTextBoxCnpjEmissor.TabIndex = 17;
            maskedTextBoxCnpjEmissor.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmissor.ValidatingType = typeof(DateTime);
            // 
            // labelCnpjEmissor
            // 
            labelCnpjEmissor.AutoSize = true;
            labelCnpjEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmissor.Location = new Point(553, 6);
            labelCnpjEmissor.Name = "labelCnpjEmissor";
            labelCnpjEmissor.Size = new Size(92, 17);
            labelCnpjEmissor.TabIndex = 16;
            labelCnpjEmissor.Text = "CNPJ Emissor";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Location = new Point(443, 26);
            maskedTextBoxDataEmissao.Mask = "00/00/0000";
            maskedTextBoxDataEmissao.Name = "maskedTextBoxDataEmissao";
            maskedTextBoxDataEmissao.Size = new Size(100, 23);
            maskedTextBoxDataEmissao.TabIndex = 15;
            maskedTextBoxDataEmissao.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxDataEmissao.ValidatingType = typeof(DateTime);
            // 
            // labelDataEmissao
            // 
            labelDataEmissao.AutoSize = true;
            labelDataEmissao.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataEmissao.Location = new Point(443, 6);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(92, 17);
            labelDataEmissao.TabIndex = 14;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // textBoxSerieDocumento
            // 
            textBoxSerieDocumento.Enabled = false;
            textBoxSerieDocumento.Location = new Point(17, 131);
            textBoxSerieDocumento.MaxLength = 3;
            textBoxSerieDocumento.Name = "textBoxSerieDocumento";
            textBoxSerieDocumento.Size = new Size(106, 23);
            textBoxSerieDocumento.TabIndex = 5;
            // 
            // labelSerieDocumento
            // 
            labelSerieDocumento.AutoSize = true;
            labelSerieDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieDocumento.Location = new Point(17, 111);
            labelSerieDocumento.Name = "labelSerieDocumento";
            labelSerieDocumento.Size = new Size(78, 17);
            labelSerieDocumento.TabIndex = 4;
            labelSerieDocumento.Text = "Série Doc.";
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Location = new Point(17, 85);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(106, 23);
            textBoxNumeroDocumento.TabIndex = 3;
            // 
            // labelNumeroDocumento
            // 
            labelNumeroDocumento.AutoSize = true;
            labelNumeroDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroDocumento.Location = new Point(17, 65);
            labelNumeroDocumento.Name = "labelNumeroDocumento";
            labelNumeroDocumento.Size = new Size(85, 17);
            labelNumeroDocumento.TabIndex = 2;
            labelNumeroDocumento.Text = "Numero Doc.";
            // 
            // checkedListBoxTipoViagem
            // 
            checkedListBoxTipoViagem.BackColor = Color.FromArgb(23, 23, 23);
            checkedListBoxTipoViagem.BorderStyle = BorderStyle.None;
            checkedListBoxTipoViagem.CheckOnClick = true;
            checkedListBoxTipoViagem.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoViagem.FormattingEnabled = true;
            checkedListBoxTipoViagem.Items.AddRange(new object[] { "MDF-e", "Manifesto" });
            checkedListBoxTipoViagem.Location = new Point(17, 26);
            checkedListBoxTipoViagem.Name = "checkedListBoxTipoViagem";
            checkedListBoxTipoViagem.Size = new Size(97, 36);
            checkedListBoxTipoViagem.TabIndex = 1;
            checkedListBoxTipoViagem.ItemCheck += ResetCheckedListViagem_ItemCheckEvent;
            // 
            // labelTipoViagem
            // 
            labelTipoViagem.AutoSize = true;
            labelTipoViagem.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoViagem.Location = new Point(17, 6);
            labelTipoViagem.Name = "labelTipoViagem";
            labelTipoViagem.Size = new Size(85, 17);
            labelTipoViagem.TabIndex = 0;
            labelTipoViagem.Text = "Tipo Viagem";
            // 
            // GerarCSVSimplesViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(labelDiretorio);
            Controls.Add(textBoxDiretorio);
            Controls.Add(buttonLimparViagens);
            Controls.Add(dataGridView);
            Controls.Add(buttonGerarCSV);
            Controls.Add(panelSuperior);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(0);
            Name = "GerarCSVSimplesViewControl";
            Size = new Size(800, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDiretorio;
        private TextBox textBoxDiretorio;
        private Button buttonLimparViagens;
        protected DataGridView dataGridView;
        private Button buttonGerarCSV;
        private Button buttonLimpar;
        private Button buttonGerar;
        private Button buttonAdicionar;
        private Panel panelSuperior;
        private NumericUpDown numericUpDownQuantidade;
        private MaskedTextBox maskedTextBoxCpfCnpjDestinatario;
        private Label labelCpfCnpjDestinatario;
        private TextBox textBoxNomeDestinatario;
        private Label labelNomeDestinatario;
        private TextBox textBoxSerieInicial;
        private Label labelSerieInicial;
        private TextBox textBoxNumeroInicial;
        private Label labelNumeroInicial;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
        private Label labelNomeMotorista;
        private Label labelQuantidadeDocumentos;
        private CheckedListBox checkedListBoxTipoDocumento;
        private Label labelTipoDocumento;
        private MaskedTextBox maskedTextBoxCnpjEmissor;
        private Label labelCnpjEmissor;
        private MaskedTextBox maskedTextBoxDataEmissao;
        private Label labelDataEmissao;
        private TextBox textBoxSerieDocumento;
        private Label labelSerieDocumento;
        private TextBox textBoxNumeroDocumento;
        private Label labelNumeroDocumento;
        private CheckedListBox checkedListBoxTipoViagem;
        private Label labelTipoViagem;
    }
}
