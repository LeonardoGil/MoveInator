﻿namespace MoveInatorForms.Forms.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarMDFeSimplesViewControl));
            comboBoxMotorista = new ComboBox();
            comboBoxEmissor = new ComboBox();
            labelMotorista = new Label();
            labelEmissor = new Label();
            textBoxSerieMDFe = new TextBox();
            labelSerieMDFe = new Label();
            textBoxNumeroMDFe = new TextBox();
            labelNumeroMDFe = new Label();
            textBoxSerieCTe = new TextBox();
            labelSerie = new Label();
            textBoxNumeroCTe = new TextBox();
            labelNumero = new Label();
            maskedTextBoxDataEmissao = new MaskedTextBox();
            labelDataEmissao = new Label();
            buttonAdicionar = new Button();
            buttonLimpar = new Button();
            dataGridView = new DataGridView();
            textBoxDiretorio = new TextBox();
            labelDiretorio = new Label();
            buttonGerarMDFe = new Button();
            buttonLimparMDFeCTes = new Button();
            labelTitulo = new Label();
            panelActions = new Panel();
            buttonFolder = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxMotorista
            // 
            comboBoxMotorista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotorista.FormattingEnabled = true;
            comboBoxMotorista.Location = new Point(273, 157);
            comboBoxMotorista.Name = "comboBoxMotorista";
            comboBoxMotorista.Size = new Size(191, 25);
            comboBoxMotorista.TabIndex = 53;
            // 
            // comboBoxEmissor
            // 
            comboBoxEmissor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmissor.FormattingEnabled = true;
            comboBoxEmissor.Location = new Point(273, 99);
            comboBoxEmissor.Name = "comboBoxEmissor";
            comboBoxEmissor.Size = new Size(191, 25);
            comboBoxEmissor.TabIndex = 52;
            // 
            // labelMotorista
            // 
            labelMotorista.AutoSize = true;
            labelMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMotorista.ForeColor = SystemColors.ControlLightLight;
            labelMotorista.Location = new Point(273, 135);
            labelMotorista.Name = "labelMotorista";
            labelMotorista.Size = new Size(71, 17);
            labelMotorista.TabIndex = 51;
            labelMotorista.Text = "Motorista";
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(273, 76);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(57, 17);
            labelEmissor.TabIndex = 50;
            labelEmissor.Text = "Emissor";
            // 
            // textBoxSerieMDFe
            // 
            textBoxSerieMDFe.Location = new Point(140, 98);
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
            labelSerieMDFe.Location = new Point(140, 76);
            labelSerieMDFe.Name = "labelSerieMDFe";
            labelSerieMDFe.Size = new Size(78, 17);
            labelSerieMDFe.TabIndex = 67;
            labelSerieMDFe.Text = "Série MDFe";
            // 
            // textBoxNumeroMDFe
            // 
            textBoxNumeroMDFe.Location = new Point(10, 98);
            textBoxNumeroMDFe.Name = "textBoxNumeroMDFe";
            textBoxNumeroMDFe.Size = new Size(106, 25);
            textBoxNumeroMDFe.TabIndex = 66;
            // 
            // labelNumeroMDFe
            // 
            labelNumeroMDFe.AutoSize = true;
            labelNumeroMDFe.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroMDFe.ForeColor = SystemColors.ControlLightLight;
            labelNumeroMDFe.Location = new Point(10, 76);
            labelNumeroMDFe.Name = "labelNumeroMDFe";
            labelNumeroMDFe.Size = new Size(85, 17);
            labelNumeroMDFe.TabIndex = 65;
            labelNumeroMDFe.Text = "Numero MDFe";
            // 
            // textBoxSerieCTe
            // 
            textBoxSerieCTe.Location = new Point(140, 157);
            textBoxSerieCTe.MaxLength = 3;
            textBoxSerieCTe.Name = "textBoxSerieCTe";
            textBoxSerieCTe.Size = new Size(106, 25);
            textBoxSerieCTe.TabIndex = 64;
            // 
            // labelSerie
            // 
            labelSerie.AutoSize = true;
            labelSerie.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerie.ForeColor = SystemColors.ControlLightLight;
            labelSerie.Location = new Point(140, 135);
            labelSerie.Name = "labelSerie";
            labelSerie.Size = new Size(71, 17);
            labelSerie.TabIndex = 63;
            labelSerie.Text = "Série CTe";
            // 
            // textBoxNumeroCTe
            // 
            textBoxNumeroCTe.Location = new Point(10, 157);
            textBoxNumeroCTe.Name = "textBoxNumeroCTe";
            textBoxNumeroCTe.Size = new Size(106, 25);
            textBoxNumeroCTe.TabIndex = 62;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.ForeColor = SystemColors.ControlLightLight;
            labelNumero.Location = new Point(10, 135);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(78, 17);
            labelNumero.TabIndex = 61;
            labelNumero.Text = "Numero CTe";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Location = new Point(10, 218);
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
            labelDataEmissao.Location = new Point(10, 195);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(92, 17);
            labelDataEmissao.TabIndex = 53;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.Image = Properties.Resources.adicionar_16;
            buttonAdicionar.ImageAlign = ContentAlignment.TopLeft;
            buttonAdicionar.Location = new Point(180, 0);
            buttonAdicionar.Margin = new Padding(0);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(102, 27);
            buttonAdicionar.TabIndex = 50;
            buttonAdicionar.Text = " Adicionar";
            buttonAdicionar.TextAlign = ContentAlignment.BottomRight;
            buttonAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += AddMDfeView_ClickEvent;
            // 
            // buttonLimpar
            // 
            buttonLimpar.FlatAppearance.BorderSize = 0;
            buttonLimpar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpar.Image = Properties.Resources.vassoura_16;
            buttonLimpar.ImageAlign = ContentAlignment.TopLeft;
            buttonLimpar.Location = new Point(90, 0);
            buttonLimpar.Margin = new Padding(0);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(90, 27);
            buttonLimpar.TabIndex = 52;
            buttonLimpar.Text = " Limpar";
            buttonLimpar.TextAlign = ContentAlignment.BottomRight;
            buttonLimpar.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 300);
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
            dataGridView.Size = new Size(600, 300);
            dataGridView.TabIndex = 34;
            // 
            // textBoxDiretorio
            // 
            textBoxDiretorio.Location = new Point(140, 218);
            textBoxDiretorio.Margin = new Padding(0);
            textBoxDiretorio.Name = "textBoxDiretorio";
            textBoxDiretorio.Size = new Size(324, 25);
            textBoxDiretorio.TabIndex = 48;
            // 
            // labelDiretorio
            // 
            labelDiretorio.AutoSize = true;
            labelDiretorio.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiretorio.ForeColor = SystemColors.ControlLightLight;
            labelDiretorio.Location = new Point(140, 195);
            labelDiretorio.Name = "labelDiretorio";
            labelDiretorio.Size = new Size(71, 17);
            labelDiretorio.TabIndex = 49;
            labelDiretorio.Text = "Diretório";
            // 
            // buttonGerarMDFe
            // 
            buttonGerarMDFe.Enabled = false;
            buttonGerarMDFe.FlatAppearance.BorderSize = 0;
            buttonGerarMDFe.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarMDFe.FlatStyle = FlatStyle.Flat;
            buttonGerarMDFe.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarMDFe.Image = (Image)resources.GetObject("buttonGerarMDFe.Image");
            buttonGerarMDFe.ImageAlign = ContentAlignment.TopLeft;
            buttonGerarMDFe.Location = new Point(280, 0);
            buttonGerarMDFe.Margin = new Padding(0);
            buttonGerarMDFe.Name = "buttonGerarMDFe";
            buttonGerarMDFe.Size = new Size(80, 27);
            buttonGerarMDFe.TabIndex = 46;
            buttonGerarMDFe.Text = " Gerar";
            buttonGerarMDFe.TextAlign = ContentAlignment.BottomRight;
            buttonGerarMDFe.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGerarMDFe.UseVisualStyleBackColor = false;
            buttonGerarMDFe.Click += GenerateMDFe_ClickEvent;
            // 
            // buttonLimparMDFeCTes
            // 
            buttonLimparMDFeCTes.Enabled = false;
            buttonLimparMDFeCTes.FlatAppearance.BorderSize = 0;
            buttonLimparMDFeCTes.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimparMDFeCTes.FlatStyle = FlatStyle.Flat;
            buttonLimparMDFeCTes.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimparMDFeCTes.Image = Properties.Resources.lixeira_16;
            buttonLimparMDFeCTes.ImageAlign = ContentAlignment.TopLeft;
            buttonLimparMDFeCTes.Location = new Point(0, 0);
            buttonLimparMDFeCTes.Margin = new Padding(0);
            buttonLimparMDFeCTes.Name = "buttonLimparMDFeCTes";
            buttonLimparMDFeCTes.Size = new Size(90, 27);
            buttonLimparMDFeCTes.TabIndex = 47;
            buttonLimparMDFeCTes.Text = " Excluir";
            buttonLimparMDFeCTes.TextAlign = ContentAlignment.BottomRight;
            buttonLimparMDFeCTes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLimparMDFeCTes.UseVisualStyleBackColor = false;
            buttonLimparMDFeCTes.Click += ClearMDFeCTesGrid_ClickEvent;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MesloLGL NF", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.DarkGray;
            labelTitulo.Location = new Point(10, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(171, 33);
            labelTitulo.TabIndex = 69;
            labelTitulo.Text = "MDFe Simples";
            // 
            // panelActions
            // 
            panelActions.Controls.Add(buttonLimparMDFeCTes);
            panelActions.Controls.Add(buttonLimpar);
            panelActions.Controls.Add(buttonAdicionar);
            panelActions.Controls.Add(buttonGerarMDFe);
            panelActions.Location = new Point(240, 270);
            panelActions.Margin = new Padding(0, 3, 0, 3);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(360, 27);
            panelActions.TabIndex = 70;
            // 
            // buttonFolder
            // 
            buttonFolder.FlatAppearance.BorderSize = 0;
            buttonFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonFolder.FlatStyle = FlatStyle.Flat;
            buttonFolder.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFolder.ForeColor = SystemColors.ControlLightLight;
            buttonFolder.Image = (Image)resources.GetObject("buttonFolder.Image");
            buttonFolder.Location = new Point(464, 217);
            buttonFolder.Margin = new Padding(0, 0, 10, 0);
            buttonFolder.Name = "buttonFolder";
            buttonFolder.Size = new Size(30, 25);
            buttonFolder.TabIndex = 71;
            buttonFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFolder.UseVisualStyleBackColor = false;
            buttonFolder.Click += Folder_ClickEvent;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.SelectedPath = "C:\\Temp";
            // 
            // GerarMDFeSimplesViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonFolder);
            Controls.Add(panelActions);
            Controls.Add(labelTitulo);
            Controls.Add(comboBoxMotorista);
            Controls.Add(textBoxDiretorio);
            Controls.Add(comboBoxEmissor);
            Controls.Add(dataGridView);
            Controls.Add(labelMotorista);
            Controls.Add(labelDiretorio);
            Controls.Add(labelEmissor);
            Controls.Add(textBoxSerieMDFe);
            Controls.Add(labelSerieMDFe);
            Controls.Add(textBoxNumeroMDFe);
            Controls.Add(labelNumeroMDFe);
            Controls.Add(textBoxSerieCTe);
            Controls.Add(labelSerie);
            Controls.Add(labelDataEmissao);
            Controls.Add(textBoxNumeroCTe);
            Controls.Add(maskedTextBoxDataEmissao);
            Controls.Add(labelNumero);
            ForeColor = SystemColors.ControlLightLight;
            Name = "GerarMDFeSimplesViewControl";
            Resize += View_ResizeEvent;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected DataGridView dataGridView;
        private TextBox textBoxDiretorio;
        private Label labelDiretorio;
        private Button buttonGerarMDFe;
        private Button buttonLimparMDFeCTes;
        private Button buttonAdicionar;
        private Button buttonLimpar;
        private MaskedTextBox maskedTextBoxDataEmissao;
        private Label labelDataEmissao;
        private Label labelMotorista;
        private TextBox textBoxSerieCTe;
        private Label labelSerie;
        private TextBox textBoxNumeroCTe;
        private Label labelNumero;
        private TextBox textBoxSerieMDFe;
        private Label labelSerieMDFe;
        private TextBox textBoxNumeroMDFe;
        private Label labelNumeroMDFe;
        private ComboBox comboBoxMotorista;
        private ComboBox comboBoxEmissor;
        private Label labelEmissor;
        private Label labelTitulo;
        private Panel panelActions;
        private Button buttonFolder;
        private FolderBrowserDialog folderBrowserDialog;
    }
}
