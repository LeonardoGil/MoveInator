namespace MoveInatorForms.Forms.Views.Manifestos
{
    partial class GerarManifestoSimplificadoViewControl
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tableLayoutPanel = new TableLayoutPanel();
            dataGridView = new DataGridView();
            labelTitulo = new Label();
            panelActions = new Panel();
            buttonLimpar = new Button();
            buttonGerarCSV = new Button();
            buttonAdicionar = new Button();
            buttonGerar = new Button();
            labelNumeroViagem = new Label();
            textBoxNumeroDocumento = new TextBox();
            labelSerieDocumento = new Label();
            textBoxSerieDocumento = new TextBox();
            comboBoxEmissor = new ComboBox();
            labelEmissor = new Label();
            labelDataEmissao = new Label();
            maskedTextBoxDataEmissao = new MaskedTextBox();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Controls.Add(labelDataEmissao, 3, 1);
            tableLayoutPanel.Controls.Add(maskedTextBoxDataEmissao, 3, 2);
            tableLayoutPanel.Controls.Add(comboBoxEmissor, 2, 2);
            tableLayoutPanel.Controls.Add(labelEmissor, 2, 1);
            tableLayoutPanel.Controls.Add(labelNumeroViagem, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxNumeroDocumento, 0, 2);
            tableLayoutPanel.Controls.Add(labelSerieDocumento, 1, 1);
            tableLayoutPanel.Controls.Add(textBoxSerieDocumento, 1, 2);
            tableLayoutPanel.Controls.Add(panelActions, 0, 7);
            tableLayoutPanel.Controls.Add(labelTitulo, 0, 0);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 8;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(600, 300);
            tableLayoutPanel.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 300);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(600, 300);
            dataGridView.TabIndex = 34;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelTitulo, 2);
            labelTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(20, 10);
            labelTitulo.Margin = new Padding(20, 10, 0, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(173, 30);
            labelTitulo.TabIndex = 47;
            labelTitulo.Text = "CSV Simplificado";
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(panelActions, 4);
            panelActions.Controls.Add(buttonLimpar);
            panelActions.Controls.Add(buttonGerarCSV);
            panelActions.Controls.Add(buttonAdicionar);
            panelActions.Controls.Add(buttonGerar);
            panelActions.Location = new Point(270, 270);
            panelActions.Margin = new Padding(0, 3, 0, 3);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(330, 27);
            panelActions.TabIndex = 48;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.FromArgb(31, 31, 31);
            buttonLimpar.FlatAppearance.BorderSize = 0;
            buttonLimpar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpar.ForeColor = SystemColors.ControlLightLight;
            buttonLimpar.Image = Properties.Resources.vassoura_16;
            buttonLimpar.Location = new Point(0, 0);
            buttonLimpar.Margin = new Padding(0);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(85, 27);
            buttonLimpar.TabIndex = 31;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLimpar.UseVisualStyleBackColor = false;
            // 
            // buttonGerarCSV
            // 
            buttonGerarCSV.Enabled = false;
            buttonGerarCSV.FlatAppearance.BorderSize = 0;
            buttonGerarCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarCSV.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            buttonGerarCSV.FlatStyle = FlatStyle.Flat;
            buttonGerarCSV.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarCSV.ForeColor = SystemColors.ControlLightLight;
            buttonGerarCSV.Image = Properties.Resources.arquivo_csv_16;
            buttonGerarCSV.Location = new Point(250, 0);
            buttonGerarCSV.Margin = new Padding(0);
            buttonGerarCSV.Name = "buttonGerarCSV";
            buttonGerarCSV.Size = new Size(80, 27);
            buttonGerarCSV.TabIndex = 42;
            buttonGerarCSV.Text = " Gerar";
            buttonGerarCSV.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGerarCSV.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.ForeColor = SystemColors.ControlLightLight;
            buttonAdicionar.Image = Properties.Resources.adicionar_16;
            buttonAdicionar.Location = new Point(155, 0);
            buttonAdicionar.Margin = new Padding(0);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(95, 27);
            buttonAdicionar.TabIndex = 29;
            buttonAdicionar.Text = " Adicionar";
            buttonAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionar.UseVisualStyleBackColor = false;
            // 
            // buttonGerar
            // 
            buttonGerar.BackColor = Color.FromArgb(31, 31, 31);
            buttonGerar.FlatAppearance.BorderSize = 0;
            buttonGerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerar.FlatStyle = FlatStyle.Flat;
            buttonGerar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerar.ForeColor = SystemColors.ControlLightLight;
            buttonGerar.Image = Properties.Resources.dados_16;
            buttonGerar.Location = new Point(85, 0);
            buttonGerar.Margin = new Padding(0);
            buttonGerar.Name = "buttonGerar";
            buttonGerar.Size = new Size(70, 27);
            buttonGerar.TabIndex = 30;
            buttonGerar.Text = " Auto";
            buttonGerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGerar.UseVisualStyleBackColor = false;
            // 
            // labelNumeroViagem
            // 
            labelNumeroViagem.AutoSize = true;
            labelNumeroViagem.ForeColor = SystemColors.ControlLightLight;
            labelNumeroViagem.Location = new Point(20, 65);
            labelNumeroViagem.Margin = new Padding(20, 5, 0, 5);
            labelNumeroViagem.Name = "labelNumeroViagem";
            labelNumeroViagem.Size = new Size(104, 17);
            labelNumeroViagem.TabIndex = 49;
            labelNumeroViagem.Text = "Numero Viagem";
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNumeroDocumento.Location = new Point(20, 87);
            textBoxNumeroDocumento.Margin = new Padding(20, 0, 5, 0);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(125, 25);
            textBoxNumeroDocumento.TabIndex = 50;
            // 
            // labelSerieDocumento
            // 
            labelSerieDocumento.AutoSize = true;
            labelSerieDocumento.ForeColor = SystemColors.ControlLightLight;
            labelSerieDocumento.Location = new Point(170, 65);
            labelSerieDocumento.Margin = new Padding(20, 5, 0, 5);
            labelSerieDocumento.Name = "labelSerieDocumento";
            labelSerieDocumento.Size = new Size(67, 17);
            labelSerieDocumento.TabIndex = 51;
            labelSerieDocumento.Text = "Série Doc.";
            // 
            // textBoxSerieDocumento
            // 
            textBoxSerieDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSerieDocumento.Enabled = false;
            textBoxSerieDocumento.Location = new Point(155, 87);
            textBoxSerieDocumento.Margin = new Padding(5, 0, 5, 0);
            textBoxSerieDocumento.MaxLength = 3;
            textBoxSerieDocumento.Name = "textBoxSerieDocumento";
            textBoxSerieDocumento.Size = new Size(140, 25);
            textBoxSerieDocumento.TabIndex = 52;
            // 
            // comboBoxEmissor
            // 
            comboBoxEmissor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEmissor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmissor.FormattingEnabled = true;
            comboBoxEmissor.Location = new Point(305, 87);
            comboBoxEmissor.Margin = new Padding(5, 0, 5, 0);
            comboBoxEmissor.Name = "comboBoxEmissor";
            comboBoxEmissor.Size = new Size(140, 25);
            comboBoxEmissor.TabIndex = 54;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(305, 65);
            labelEmissor.Margin = new Padding(5, 5, 0, 5);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(54, 17);
            labelEmissor.TabIndex = 53;
            labelEmissor.Text = "Emissor";
            // 
            // labelDataEmissao
            // 
            labelDataEmissao.AutoSize = true;
            labelDataEmissao.ForeColor = SystemColors.ControlLightLight;
            labelDataEmissao.Location = new Point(455, 65);
            labelDataEmissao.Margin = new Padding(5, 5, 0, 5);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(87, 17);
            labelDataEmissao.TabIndex = 55;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxDataEmissao.Location = new Point(455, 87);
            maskedTextBoxDataEmissao.Margin = new Padding(5, 0, 5, 0);
            maskedTextBoxDataEmissao.Mask = "00/00/0000";
            maskedTextBoxDataEmissao.Name = "maskedTextBoxDataEmissao";
            maskedTextBoxDataEmissao.Size = new Size(140, 25);
            maskedTextBoxDataEmissao.TabIndex = 56;
            maskedTextBoxDataEmissao.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxDataEmissao.ValidatingType = typeof(DateTime);
            // 
            // GerarManifestoSimplificadoViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView);
            Controls.Add(tableLayoutPanel);
            Name = "GerarManifestoSimplificadoViewControl";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        protected DataGridView dataGridView;
        private Label labelTitulo;
        private Panel panelActions;
        private Button buttonLimpar;
        private Button buttonGerarCSV;
        private Button buttonAdicionar;
        private Button buttonGerar;
        private Label labelNumeroViagem;
        private TextBox textBoxNumeroDocumento;
        private Label labelSerieDocumento;
        private TextBox textBoxSerieDocumento;
        private ComboBox comboBoxEmissor;
        private Label labelEmissor;
        private Label labelDataEmissao;
        private MaskedTextBox maskedTextBoxDataEmissao;
    }
}
