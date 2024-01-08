namespace MoveInatorForms.Forms.Views
{
    partial class GerarMDFeSimplesViewControl
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
            panelSuperior = new Panel();
            textBoxSerieMDFe = new TextBox();
            labelSerieMDFe = new Label();
            textBoxNumeroMDFe = new TextBox();
            labelNumeroMDFe = new Label();
            textBoxSerieCTe = new TextBox();
            labelSerieInicial = new Label();
            textBoxNumeroCTe = new TextBox();
            labelNumeroInicial = new Label();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            labelNomeMotorista = new Label();
            maskedTextBoxCnpjEmissor = new MaskedTextBox();
            labelCnpjEmissor = new Label();
            maskedTextBoxDataEmissao = new MaskedTextBox();
            labelDataEmissao = new Label();
            buttonAdicionar = new Button();
            buttonLimpar = new Button();
            dataGridView = new DataGridView();
            textBoxDiretorio = new TextBox();
            labelDiretorio = new Label();
            buttonGerarMDFe = new Button();
            buttonLimparMDFeCTes = new Button();
            textBoxEmissor = new TextBox();
            labelEmissor = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(27, 27, 27);
            panelSuperior.Controls.Add(textBoxEmissor);
            panelSuperior.Controls.Add(labelEmissor);
            panelSuperior.Controls.Add(textBoxSerieMDFe);
            panelSuperior.Controls.Add(labelSerieMDFe);
            panelSuperior.Controls.Add(textBoxNumeroMDFe);
            panelSuperior.Controls.Add(labelNumeroMDFe);
            panelSuperior.Controls.Add(textBoxSerieCTe);
            panelSuperior.Controls.Add(labelSerieInicial);
            panelSuperior.Controls.Add(textBoxNumeroCTe);
            panelSuperior.Controls.Add(labelNumeroInicial);
            panelSuperior.Controls.Add(maskedTextBoxCpfMotorista);
            panelSuperior.Controls.Add(labelCpfMotorista);
            panelSuperior.Controls.Add(textBoxNomeMotorista);
            panelSuperior.Controls.Add(labelNomeMotorista);
            panelSuperior.Controls.Add(maskedTextBoxCnpjEmissor);
            panelSuperior.Controls.Add(labelCnpjEmissor);
            panelSuperior.Controls.Add(maskedTextBoxDataEmissao);
            panelSuperior.Controls.Add(labelDataEmissao);
            panelSuperior.Controls.Add(buttonAdicionar);
            panelSuperior.Controls.Add(buttonLimpar);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(800, 130);
            panelSuperior.TabIndex = 0;
            // 
            // textBoxSerieMDFe
            // 
            textBoxSerieMDFe.Location = new Point(133, 30);
            textBoxSerieMDFe.MaxLength = 3;
            textBoxSerieMDFe.Name = "textBoxSerieMDFe";
            textBoxSerieMDFe.Size = new Size(106, 25);
            textBoxSerieMDFe.TabIndex = 68;
            // 
            // labelSerieMDFe
            // 
            labelSerieMDFe.AutoSize = true;
            labelSerieMDFe.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieMDFe.ForeColor = SystemColors.ControlLightLight;
            labelSerieMDFe.Location = new Point(133, 8);
            labelSerieMDFe.Name = "labelSerieMDFe";
            labelSerieMDFe.Size = new Size(78, 17);
            labelSerieMDFe.TabIndex = 67;
            labelSerieMDFe.Text = "Série MDFe";
            // 
            // textBoxNumeroMDFe
            // 
            textBoxNumeroMDFe.Location = new Point(12, 30);
            textBoxNumeroMDFe.Name = "textBoxNumeroMDFe";
            textBoxNumeroMDFe.Size = new Size(106, 25);
            textBoxNumeroMDFe.TabIndex = 66;
            // 
            // labelNumeroMDFe
            // 
            labelNumeroMDFe.AutoSize = true;
            labelNumeroMDFe.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroMDFe.ForeColor = SystemColors.ControlLightLight;
            labelNumeroMDFe.Location = new Point(12, 8);
            labelNumeroMDFe.Name = "labelNumeroMDFe";
            labelNumeroMDFe.Size = new Size(85, 17);
            labelNumeroMDFe.TabIndex = 65;
            labelNumeroMDFe.Text = "Numero MDFe";
            // 
            // textBoxSerieCTe
            // 
            textBoxSerieCTe.Location = new Point(133, 92);
            textBoxSerieCTe.MaxLength = 3;
            textBoxSerieCTe.Name = "textBoxSerieCTe";
            textBoxSerieCTe.Size = new Size(106, 25);
            textBoxSerieCTe.TabIndex = 64;
            // 
            // labelSerieInicial
            // 
            labelSerieInicial.AutoSize = true;
            labelSerieInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieInicial.ForeColor = SystemColors.ControlLightLight;
            labelSerieInicial.Location = new Point(133, 70);
            labelSerieInicial.Name = "labelSerieInicial";
            labelSerieInicial.Size = new Size(71, 17);
            labelSerieInicial.TabIndex = 63;
            labelSerieInicial.Text = "Série CTe";
            // 
            // textBoxNumeroCTe
            // 
            textBoxNumeroCTe.Location = new Point(12, 92);
            textBoxNumeroCTe.Name = "textBoxNumeroCTe";
            textBoxNumeroCTe.Size = new Size(106, 25);
            textBoxNumeroCTe.TabIndex = 62;
            // 
            // labelNumeroInicial
            // 
            labelNumeroInicial.AutoSize = true;
            labelNumeroInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroInicial.ForeColor = SystemColors.ControlLightLight;
            labelNumeroInicial.Location = new Point(12, 70);
            labelNumeroInicial.Name = "labelNumeroInicial";
            labelNumeroInicial.Size = new Size(78, 17);
            labelNumeroInicial.TabIndex = 61;
            labelNumeroInicial.Text = "Numero CTe";
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(567, 92);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(120, 25);
            maskedTextBoxCpfMotorista.TabIndex = 60;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.ForeColor = SystemColors.ControlLightLight;
            labelCpfMotorista.Location = new Point(567, 70);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(99, 17);
            labelCpfMotorista.TabIndex = 59;
            labelCpfMotorista.Text = "CPF Motorista";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(567, 30);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(120, 25);
            textBoxNomeMotorista.TabIndex = 58;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.ForeColor = SystemColors.ControlLightLight;
            labelNomeMotorista.Location = new Point(567, 8);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(106, 17);
            labelNomeMotorista.TabIndex = 57;
            labelNomeMotorista.Text = "Nome Motorista";
            // 
            // maskedTextBoxCnpjEmissor
            // 
            maskedTextBoxCnpjEmissor.Location = new Point(390, 92);
            maskedTextBoxCnpjEmissor.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmissor.Name = "maskedTextBoxCnpjEmissor";
            maskedTextBoxCnpjEmissor.Size = new Size(140, 25);
            maskedTextBoxCnpjEmissor.TabIndex = 56;
            maskedTextBoxCnpjEmissor.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmissor.ValidatingType = typeof(DateTime);
            // 
            // labelCnpjEmissor
            // 
            labelCnpjEmissor.AutoSize = true;
            labelCnpjEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmissor.ForeColor = SystemColors.ControlLightLight;
            labelCnpjEmissor.Location = new Point(390, 69);
            labelCnpjEmissor.Name = "labelCnpjEmissor";
            labelCnpjEmissor.Size = new Size(92, 17);
            labelCnpjEmissor.TabIndex = 55;
            labelCnpjEmissor.Text = "CNPJ Emissor";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Location = new Point(254, 31);
            maskedTextBoxDataEmissao.Mask = "00/00/0000";
            maskedTextBoxDataEmissao.Name = "maskedTextBoxDataEmissao";
            maskedTextBoxDataEmissao.Size = new Size(100, 25);
            maskedTextBoxDataEmissao.TabIndex = 54;
            maskedTextBoxDataEmissao.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxDataEmissao.ValidatingType = typeof(DateTime);
            // 
            // labelDataEmissao
            // 
            labelDataEmissao.AutoSize = true;
            labelDataEmissao.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataEmissao.ForeColor = SystemColors.ControlLightLight;
            labelDataEmissao.Location = new Point(254, 8);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(92, 17);
            labelDataEmissao.TabIndex = 53;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.FromArgb(38, 38, 38);
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Location = new Point(705, 90);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(90, 34);
            buttonAdicionar.TabIndex = 50;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += AddMDfeView_ClickEvent;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.FromArgb(38, 38, 38);
            buttonLimpar.FlatAppearance.BorderSize = 0;
            buttonLimpar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(705, 49);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(90, 34);
            buttonLimpar.TabIndex = 52;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += ClearFields_ClickEvent;
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
            dataGridViewCellStyle1.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 138);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            dataGridView.Size = new Size(800, 330);
            dataGridView.TabIndex = 34;
            // 
            // textBoxDiretorio
            // 
            textBoxDiretorio.Location = new Point(4, 489);
            textBoxDiretorio.Name = "textBoxDiretorio";
            textBoxDiretorio.Size = new Size(391, 25);
            textBoxDiretorio.TabIndex = 48;
            // 
            // labelDiretorio
            // 
            labelDiretorio.AutoSize = true;
            labelDiretorio.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiretorio.ForeColor = SystemColors.ControlLightLight;
            labelDiretorio.Location = new Point(4, 471);
            labelDiretorio.Name = "labelDiretorio";
            labelDiretorio.Size = new Size(71, 17);
            labelDiretorio.TabIndex = 49;
            labelDiretorio.Text = "Diretório";
            // 
            // buttonGerarMDFe
            // 
            buttonGerarMDFe.BackColor = Color.FromArgb(38, 38, 38);
            buttonGerarMDFe.Enabled = false;
            buttonGerarMDFe.FlatAppearance.BorderSize = 0;
            buttonGerarMDFe.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarMDFe.FlatStyle = FlatStyle.Flat;
            buttonGerarMDFe.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarMDFe.Location = new Point(695, 475);
            buttonGerarMDFe.Margin = new Padding(5);
            buttonGerarMDFe.Name = "buttonGerarMDFe";
            buttonGerarMDFe.Size = new Size(100, 40);
            buttonGerarMDFe.TabIndex = 46;
            buttonGerarMDFe.Text = "Gerar MDFe";
            buttonGerarMDFe.UseVisualStyleBackColor = false;
            buttonGerarMDFe.Click += GenerateMDFe_ClickEvent;
            // 
            // buttonLimparMDFeCTes
            // 
            buttonLimparMDFeCTes.BackColor = Color.FromArgb(38, 38, 38);
            buttonLimparMDFeCTes.Enabled = false;
            buttonLimparMDFeCTes.FlatAppearance.BorderSize = 0;
            buttonLimparMDFeCTes.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimparMDFeCTes.FlatStyle = FlatStyle.Flat;
            buttonLimparMDFeCTes.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimparMDFeCTes.Location = new Point(590, 475);
            buttonLimparMDFeCTes.Margin = new Padding(5);
            buttonLimparMDFeCTes.Name = "buttonLimparMDFeCTes";
            buttonLimparMDFeCTes.Size = new Size(100, 40);
            buttonLimparMDFeCTes.TabIndex = 47;
            buttonLimparMDFeCTes.Text = "Limpar";
            buttonLimparMDFeCTes.UseVisualStyleBackColor = false;
            buttonLimparMDFeCTes.Click += ClearMDFeCTesGrid_ClickEvent;
            // 
            // textBoxEmissor
            // 
            textBoxEmissor.Location = new Point(254, 92);
            textBoxEmissor.Name = "textBoxEmissor";
            textBoxEmissor.Size = new Size(119, 25);
            textBoxEmissor.TabIndex = 70;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(254, 70);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(57, 17);
            labelEmissor.TabIndex = 69;
            labelEmissor.Text = "Emissor";
            // 
            // GerarMDFeSimplesViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(textBoxDiretorio);
            Controls.Add(dataGridView);
            Controls.Add(labelDiretorio);
            Controls.Add(panelSuperior);
            Controls.Add(buttonGerarMDFe);
            Controls.Add(buttonLimparMDFeCTes);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Name = "GerarMDFeSimplesViewControl";
            Size = new Size(800, 520);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        protected DataGridView dataGridView;
        private TextBox textBoxDiretorio;
        private Label labelDiretorio;
        private Button buttonGerarMDFe;
        private Button buttonLimparMDFeCTes;
        private Button buttonAdicionar;
        private Button buttonLimpar;
        private MaskedTextBox maskedTextBoxCnpjEmissor;
        private Label labelCnpjEmissor;
        private MaskedTextBox maskedTextBoxDataEmissao;
        private Label labelDataEmissao;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
        private Label labelNomeMotorista;
        private TextBox textBoxSerieCTe;
        private Label labelSerieInicial;
        private TextBox textBoxNumeroCTe;
        private Label labelNumeroInicial;
        private TextBox textBoxSerieMDFe;
        private Label labelSerieMDFe;
        private TextBox textBoxNumeroMDFe;
        private Label labelNumeroMDFe;
        private TextBox textBoxEmissor;
        private Label labelEmissor;
    }
}
