namespace MoveInatorForms.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            labelTitulo = new Label();
            labelSubTitulo = new Label();
            panel2 = new Panel();
            buttonGerarCSV = new Button();
            buttonLimpar = new Button();
            buttonGerar = new Button();
            buttonAdicionar = new Button();
            panelSuperior = new Panel();
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
            textBoxQuantidadeDocumentos = new TextBox();
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
            dataGridView = new DataGridView();
            panel2.SuspendLayout();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MesloLGL NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(21, 18);
            labelTitulo.Margin = new Padding(7, 0, 7, 5);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(178, 42);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "MoveInator";
            // 
            // labelSubTitulo
            // 
            labelSubTitulo.AutoSize = true;
            labelSubTitulo.Font = new Font("MesloLGL NF", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelSubTitulo.Location = new Point(25, 57);
            labelSubTitulo.Margin = new Padding(0);
            labelSubTitulo.Name = "labelSubTitulo";
            labelSubTitulo.Size = new Size(106, 18);
            labelSubTitulo.TabIndex = 1;
            labelSubTitulo.Text = "Created by LAG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 27, 27);
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(buttonGerarCSV);
            panel2.Controls.Add(buttonLimpar);
            panel2.Controls.Add(buttonGerar);
            panel2.Controls.Add(buttonAdicionar);
            panel2.Controls.Add(panelSuperior);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(labelSubTitulo);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 592);
            panel2.TabIndex = 3;
            // 
            // buttonGerarCSV
            // 
            buttonGerarCSV.BackColor = Color.FromArgb(41, 41, 41);
            buttonGerarCSV.FlatAppearance.BorderSize = 0;
            buttonGerarCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarCSV.FlatStyle = FlatStyle.Flat;
            buttonGerarCSV.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarCSV.Location = new Point(680, 541);
            buttonGerarCSV.Name = "buttonGerarCSV";
            buttonGerarCSV.Size = new Size(104, 43);
            buttonGerarCSV.TabIndex = 6;
            buttonGerarCSV.Text = "Gerar CSV";
            buttonGerarCSV.UseVisualStyleBackColor = false;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.FromArgb(41, 41, 41);
            buttonLimpar.FlatAppearance.BorderSize = 0;
            buttonLimpar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(523, 52);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(83, 28);
            buttonLimpar.TabIndex = 5;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            // 
            // buttonGerar
            // 
            buttonGerar.BackColor = Color.FromArgb(41, 41, 41);
            buttonGerar.FlatAppearance.BorderSize = 0;
            buttonGerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerar.FlatStyle = FlatStyle.Flat;
            buttonGerar.Location = new Point(612, 52);
            buttonGerar.Name = "buttonGerar";
            buttonGerar.Size = new Size(83, 28);
            buttonGerar.TabIndex = 4;
            buttonGerar.Text = "Gerar";
            buttonGerar.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.FromArgb(41, 41, 41);
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Location = new Point(701, 52);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(83, 28);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(23, 23, 23);
            panelSuperior.Controls.Add(maskedTextBoxCpfCnpjDestinatario);
            panelSuperior.Controls.Add(labelCpfCnpjDestinatario);
            panelSuperior.Controls.Add(textBoxNomeDestinatario);
            panelSuperior.Controls.Add(labelNomeDestinatario);
            panelSuperior.Controls.Add(textBoxSerieInicial);
            panelSuperior.Controls.Add(labelSerieInicial);
            panelSuperior.Controls.Add(textBoxNumeroInicial);
            panelSuperior.Controls.Add(labelNumeroInicial);
            panelSuperior.Controls.Add(maskedTextBoxCpfMotorista);
            panelSuperior.Controls.Add(labelCpfMotorista);
            panelSuperior.Controls.Add(textBoxNomeMotorista);
            panelSuperior.Controls.Add(labelNomeMotorista);
            panelSuperior.Controls.Add(textBoxQuantidadeDocumentos);
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
            panelSuperior.Location = new Point(8, 86);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(776, 191);
            panelSuperior.TabIndex = 2;
            // 
            // maskedTextBoxCpfCnpjDestinatario
            // 
            maskedTextBoxCpfCnpjDestinatario.Location = new Point(476, 154);
            maskedTextBoxCpfCnpjDestinatario.Mask = "00.000.000/0000-00";
            maskedTextBoxCpfCnpjDestinatario.Name = "maskedTextBoxCpfCnpjDestinatario";
            maskedTextBoxCpfCnpjDestinatario.Size = new Size(156, 25);
            maskedTextBoxCpfCnpjDestinatario.TabIndex = 21;
            maskedTextBoxCpfCnpjDestinatario.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfCnpjDestinatario
            // 
            labelCpfCnpjDestinatario.AutoSize = true;
            labelCpfCnpjDestinatario.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfCnpjDestinatario.Location = new Point(477, 135);
            labelCpfCnpjDestinatario.Name = "labelCpfCnpjDestinatario";
            labelCpfCnpjDestinatario.Size = new Size(155, 17);
            labelCpfCnpjDestinatario.TabIndex = 20;
            labelCpfCnpjDestinatario.Text = "CPF/CNPJ Destinatário";
            // 
            // textBoxNomeDestinatario
            // 
            textBoxNomeDestinatario.Location = new Point(477, 100);
            textBoxNomeDestinatario.Name = "textBoxNomeDestinatario";
            textBoxNomeDestinatario.Size = new Size(156, 25);
            textBoxNomeDestinatario.TabIndex = 19;
            // 
            // labelNomeDestinatario
            // 
            labelNomeDestinatario.AutoSize = true;
            labelNomeDestinatario.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeDestinatario.Location = new Point(477, 80);
            labelNomeDestinatario.Name = "labelNomeDestinatario";
            labelNomeDestinatario.Size = new Size(127, 17);
            labelNomeDestinatario.TabIndex = 18;
            labelNomeDestinatario.Text = "Nome Destinatário";
            // 
            // textBoxSerieInicial
            // 
            textBoxSerieInicial.Location = new Point(188, 155);
            textBoxSerieInicial.Name = "textBoxSerieInicial";
            textBoxSerieInicial.Size = new Size(97, 25);
            textBoxSerieInicial.TabIndex = 11;
            // 
            // labelSerieInicial
            // 
            labelSerieInicial.AutoSize = true;
            labelSerieInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieInicial.Location = new Point(188, 135);
            labelSerieInicial.Name = "labelSerieInicial";
            labelSerieInicial.Size = new Size(99, 17);
            labelSerieInicial.TabIndex = 10;
            labelSerieInicial.Text = "Série Inicial";
            // 
            // textBoxNumeroInicial
            // 
            textBoxNumeroInicial.Location = new Point(188, 100);
            textBoxNumeroInicial.Name = "textBoxNumeroInicial";
            textBoxNumeroInicial.Size = new Size(97, 25);
            textBoxNumeroInicial.TabIndex = 9;
            // 
            // labelNumeroInicial
            // 
            labelNumeroInicial.AutoSize = true;
            labelNumeroInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroInicial.Location = new Point(188, 80);
            labelNumeroInicial.Name = "labelNumeroInicial";
            labelNumeroInicial.Size = new Size(106, 17);
            labelNumeroInicial.TabIndex = 8;
            labelNumeroInicial.Text = "Numero Inicial";
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(643, 154);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(120, 25);
            maskedTextBoxCpfMotorista.TabIndex = 25;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.Location = new Point(643, 134);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(99, 17);
            labelCpfMotorista.TabIndex = 24;
            labelCpfMotorista.Text = "CPF Motorista";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(644, 100);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(120, 25);
            textBoxNomeMotorista.TabIndex = 23;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.Location = new Point(644, 80);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(106, 17);
            labelNomeMotorista.TabIndex = 22;
            labelNomeMotorista.Text = "Nome Motorista";
            // 
            // textBoxQuantidadeDocumentos
            // 
            textBoxQuantidadeDocumentos.Location = new Point(293, 155);
            textBoxQuantidadeDocumentos.Name = "textBoxQuantidadeDocumentos";
            textBoxQuantidadeDocumentos.Size = new Size(78, 25);
            textBoxQuantidadeDocumentos.TabIndex = 13;
            // 
            // labelQuantidadeDocumentos
            // 
            labelQuantidadeDocumentos.AutoSize = true;
            labelQuantidadeDocumentos.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeDocumentos.Location = new Point(293, 135);
            labelQuantidadeDocumentos.Name = "labelQuantidadeDocumentos";
            labelQuantidadeDocumentos.Size = new Size(78, 17);
            labelQuantidadeDocumentos.TabIndex = 12;
            labelQuantidadeDocumentos.Text = "Quantidade";
            // 
            // checkedListBoxTipoDocumento
            // 
            checkedListBoxTipoDocumento.BackColor = Color.FromArgb(23, 23, 23);
            checkedListBoxTipoDocumento.BorderStyle = BorderStyle.None;
            checkedListBoxTipoDocumento.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoDocumento.FormattingEnabled = true;
            checkedListBoxTipoDocumento.Items.AddRange(new object[] { "CT-e", "NF-e" });
            checkedListBoxTipoDocumento.Location = new Point(188, 29);
            checkedListBoxTipoDocumento.Name = "checkedListBoxTipoDocumento";
            checkedListBoxTipoDocumento.Size = new Size(97, 40);
            checkedListBoxTipoDocumento.TabIndex = 7;
            // 
            // labelTipoDocumento
            // 
            labelTipoDocumento.AutoSize = true;
            labelTipoDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoDocumento.Location = new Point(188, 9);
            labelTipoDocumento.Name = "labelTipoDocumento";
            labelTipoDocumento.Size = new Size(106, 17);
            labelTipoDocumento.TabIndex = 6;
            labelTipoDocumento.Text = "Tipo Documento";
            // 
            // maskedTextBoxCnpjEmissor
            // 
            maskedTextBoxCnpjEmissor.Location = new Point(624, 29);
            maskedTextBoxCnpjEmissor.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmissor.Name = "maskedTextBoxCnpjEmissor";
            maskedTextBoxCnpjEmissor.Size = new Size(140, 25);
            maskedTextBoxCnpjEmissor.TabIndex = 17;
            maskedTextBoxCnpjEmissor.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmissor.ValidatingType = typeof(DateTime);
            // 
            // labelCnpjEmissor
            // 
            labelCnpjEmissor.AutoSize = true;
            labelCnpjEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmissor.Location = new Point(624, 9);
            labelCnpjEmissor.Name = "labelCnpjEmissor";
            labelCnpjEmissor.Size = new Size(92, 17);
            labelCnpjEmissor.TabIndex = 16;
            labelCnpjEmissor.Text = "CNPJ Emissor";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Location = new Point(514, 29);
            maskedTextBoxDataEmissao.Mask = "00/00/0000";
            maskedTextBoxDataEmissao.Name = "maskedTextBoxDataEmissao";
            maskedTextBoxDataEmissao.Size = new Size(100, 25);
            maskedTextBoxDataEmissao.TabIndex = 15;
            maskedTextBoxDataEmissao.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxDataEmissao.ValidatingType = typeof(DateTime);
            // 
            // labelDataEmissao
            // 
            labelDataEmissao.AutoSize = true;
            labelDataEmissao.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataEmissao.Location = new Point(514, 9);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(92, 17);
            labelDataEmissao.TabIndex = 14;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // textBoxSerieDocumento
            // 
            textBoxSerieDocumento.Location = new Point(17, 155);
            textBoxSerieDocumento.Name = "textBoxSerieDocumento";
            textBoxSerieDocumento.Size = new Size(97, 25);
            textBoxSerieDocumento.TabIndex = 5;
            // 
            // labelSerieDocumento
            // 
            labelSerieDocumento.AutoSize = true;
            labelSerieDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieDocumento.Location = new Point(17, 135);
            labelSerieDocumento.Name = "labelSerieDocumento";
            labelSerieDocumento.Size = new Size(78, 17);
            labelSerieDocumento.TabIndex = 4;
            labelSerieDocumento.Text = "Série Doc.";
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Location = new Point(17, 100);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(97, 25);
            textBoxNumeroDocumento.TabIndex = 3;
            // 
            // labelNumeroDocumento
            // 
            labelNumeroDocumento.AutoSize = true;
            labelNumeroDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroDocumento.Location = new Point(17, 80);
            labelNumeroDocumento.Name = "labelNumeroDocumento";
            labelNumeroDocumento.Size = new Size(85, 17);
            labelNumeroDocumento.TabIndex = 2;
            labelNumeroDocumento.Text = "Numero Doc.";
            // 
            // checkedListBoxTipoViagem
            // 
            checkedListBoxTipoViagem.BackColor = Color.FromArgb(23, 23, 23);
            checkedListBoxTipoViagem.BorderStyle = BorderStyle.None;
            checkedListBoxTipoViagem.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoViagem.FormattingEnabled = true;
            checkedListBoxTipoViagem.Items.AddRange(new object[] { "MDF-e", "Manifesto" });
            checkedListBoxTipoViagem.Location = new Point(17, 29);
            checkedListBoxTipoViagem.Name = "checkedListBoxTipoViagem";
            checkedListBoxTipoViagem.Size = new Size(97, 40);
            checkedListBoxTipoViagem.TabIndex = 1;
            // 
            // labelTipoViagem
            // 
            labelTipoViagem.AutoSize = true;
            labelTipoViagem.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoViagem.Location = new Point(17, 9);
            labelTipoViagem.Name = "labelTipoViagem";
            labelTipoViagem.Size = new Size(85, 17);
            labelTipoViagem.TabIndex = 0;
            labelTipoViagem.Text = "Tipo Viagem";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.BackgroundColor = Color.FromArgb(23, 23, 23);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle5.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(8, 283);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle8.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(776, 252);
            dataGridView.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(panel2);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitulo;
        private Label labelSubTitulo;
        private Panel panel2;
        private Panel panelSuperior;
        private CheckedListBox checkedListBoxTipoViagem;
        private Label labelTipoViagem;
        private TextBox textBoxSerieDocumento;
        private Label labelSerieDocumento;
        private TextBox textBoxNumeroDocumento;
        private Label labelNumeroDocumento;
        private CheckedListBox checkedListBoxTipoDocumento;
        private Label labelTipoDocumento;
        private MaskedTextBox maskedTextBoxCnpjEmissor;
        private Label labelCnpjEmissor;
        private MaskedTextBox maskedTextBoxDataEmissao;
        private Label labelDataEmissao;
        private TextBox textBoxQuantidadeDocumentos;
        private Label labelQuantidadeDocumentos;
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
        private Button buttonAdicionar;
        private Button buttonGerarCSV;
        private Button buttonLimpar;
        private Button buttonGerar;
        protected DataGridView dataGridView;
    }
}