namespace MoveInatorForms.Forms.Views.Cadastros
{
    partial class CadastroEmpresaViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpresaViewControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBoxClientSecret = new TextBox();
            labelClientSecret = new Label();
            textBoxClientId = new TextBox();
            labelClientId = new Label();
            textBoxNomeRazaoSocial = new TextBox();
            labelEmissor = new Label();
            maskedTextBoxCnpjEmpresa = new MaskedTextBox();
            labelCnpjEmpresa = new Label();
            panelActions = new Panel();
            buttonRemover = new Button();
            buttonAdicionar = new Button();
            buttonSalvar = new Button();
            dataGridView = new DataGridView();
            tableLayoutPanel = new TableLayoutPanel();
            labelTitulo = new Label();
            panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxClientSecret
            // 
            textBoxClientSecret.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBoxClientSecret, 2);
            textBoxClientSecret.Location = new Point(20, 225);
            textBoxClientSecret.Margin = new Padding(20, 0, 20, 0);
            textBoxClientSecret.Name = "textBoxClientSecret";
            textBoxClientSecret.Size = new Size(560, 25);
            textBoxClientSecret.TabIndex = 89;
            // 
            // labelClientSecret
            // 
            labelClientSecret.AutoSize = true;
            labelClientSecret.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelClientSecret.ForeColor = SystemColors.ControlLightLight;
            labelClientSecret.Location = new Point(20, 203);
            labelClientSecret.Margin = new Padding(20, 5, 0, 5);
            labelClientSecret.Name = "labelClientSecret";
            labelClientSecret.Size = new Size(80, 17);
            labelClientSecret.TabIndex = 88;
            labelClientSecret.Text = "Client Secret";
            // 
            // textBoxClientId
            // 
            textBoxClientId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBoxClientId, 2);
            textBoxClientId.Location = new Point(20, 151);
            textBoxClientId.Margin = new Padding(20, 0, 20, 0);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(560, 25);
            textBoxClientId.TabIndex = 87;
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelClientId.ForeColor = SystemColors.ControlLightLight;
            labelClientId.Location = new Point(20, 129);
            labelClientId.Margin = new Padding(20, 5, 0, 5);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(51, 17);
            labelClientId.TabIndex = 86;
            labelClientId.Text = "ClientId";
            // 
            // textBoxNomeRazaoSocial
            // 
            textBoxNomeRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNomeRazaoSocial.Location = new Point(20, 77);
            textBoxNomeRazaoSocial.Margin = new Padding(20, 0, 0, 0);
            textBoxNomeRazaoSocial.Name = "textBoxNomeRazaoSocial";
            textBoxNomeRazaoSocial.Size = new Size(400, 25);
            textBoxNomeRazaoSocial.TabIndex = 85;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(20, 55);
            labelEmissor.Margin = new Padding(20, 5, 0, 5);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(82, 17);
            labelEmissor.TabIndex = 84;
            labelEmissor.Text = "Razao Social";
            // 
            // maskedTextBoxCnpjEmpresa
            // 
            maskedTextBoxCnpjEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxCnpjEmpresa.Location = new Point(425, 77);
            maskedTextBoxCnpjEmpresa.Margin = new Padding(5, 0, 20, 0);
            maskedTextBoxCnpjEmpresa.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmpresa.Name = "maskedTextBoxCnpjEmpresa";
            maskedTextBoxCnpjEmpresa.Size = new Size(155, 25);
            maskedTextBoxCnpjEmpresa.TabIndex = 83;
            maskedTextBoxCnpjEmpresa.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmpresa.ValidatingType = typeof(DateTime);
            // 
            // labelCnpjEmpresa
            // 
            labelCnpjEmpresa.AutoSize = true;
            labelCnpjEmpresa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCnpjEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelCnpjEmpresa.Location = new Point(425, 55);
            labelCnpjEmpresa.Margin = new Padding(5, 5, 0, 5);
            labelCnpjEmpresa.Name = "labelCnpjEmpresa";
            labelCnpjEmpresa.Size = new Size(37, 17);
            labelCnpjEmpresa.TabIndex = 82;
            labelCnpjEmpresa.Text = "CNPJ";
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(panelActions, 2);
            panelActions.Controls.Add(buttonRemover);
            panelActions.Controls.Add(buttonAdicionar);
            panelActions.Controls.Add(buttonSalvar);
            panelActions.Location = new Point(333, 272);
            panelActions.Margin = new Padding(0);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(267, 27);
            panelActions.TabIndex = 94;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.None;
            buttonRemover.FlatAppearance.BorderSize = 0;
            buttonRemover.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemover.ForeColor = SystemColors.ControlLightLight;
            buttonRemover.Image = Properties.Resources.lixeira_16;
            buttonRemover.Location = new Point(0, 0);
            buttonRemover.Margin = new Padding(0, 3, 0, 3);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(91, 27);
            buttonRemover.TabIndex = 92;
            buttonRemover.Text = " Remover";
            buttonRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += RemoveEmpresa_ClickEvent;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Anchor = AnchorStyles.None;
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.ForeColor = SystemColors.ControlLightLight;
            buttonAdicionar.Image = Properties.Resources.adicionar_16;
            buttonAdicionar.Location = new Point(92, 0);
            buttonAdicionar.Margin = new Padding(0, 3, 0, 3);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(104, 27);
            buttonAdicionar.TabIndex = 91;
            buttonAdicionar.Text = " Adicionar";
            buttonAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += AddEmpresa_ClickEvent;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.None;
            buttonSalvar.Enabled = false;
            buttonSalvar.FlatAppearance.BorderSize = 0;
            buttonSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = SystemColors.ControlLightLight;
            buttonSalvar.Image = (Image)resources.GetObject("buttonSalvar.Image");
            buttonSalvar.Location = new Point(192, 1);
            buttonSalvar.Margin = new Padding(0, 3, 0, 3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 27);
            buttonSalvar.TabIndex = 43;
            buttonSalvar.Text = " Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += Salvar_ClickEvent;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
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
            dataGridView.TabIndex = 95;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Controls.Add(labelTitulo, 0, 0);
            tableLayoutPanel.Controls.Add(labelEmissor, 0, 1);
            tableLayoutPanel.Controls.Add(panelActions, 0, 7);
            tableLayoutPanel.Controls.Add(textBoxNomeRazaoSocial, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxClientSecret, 0, 6);
            tableLayoutPanel.Controls.Add(labelClientId, 0, 3);
            tableLayoutPanel.Controls.Add(labelClientSecret, 0, 5);
            tableLayoutPanel.Controls.Add(textBoxClientId, 0, 4);
            tableLayoutPanel.Controls.Add(maskedTextBoxCnpjEmpresa, 1, 2);
            tableLayoutPanel.Controls.Add(labelCnpjEmpresa, 1, 1);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.MaximumSize = new Size(9999, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 8;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(600, 300);
            tableLayoutPanel.TabIndex = 96;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(labelTitulo, 2);
            labelTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = SystemColors.ControlLightLight;
            labelTitulo.Location = new Point(20, 10);
            labelTitulo.Margin = new Padding(20, 10, 0, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(187, 30);
            labelTitulo.TabIndex = 97;
            labelTitulo.Text = "Cadastro Empresa";
            // 
            // CadastroEmpresaViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridView);
            Name = "CadastroEmpresaViewControl";
            SizeChanged += View_SizeChangedEvent;
            panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxClientSecret;
        private Label labelClientSecret;
        private TextBox textBoxClientId;
        private Label labelClientId;
        private TextBox textBoxNomeRazaoSocial;
        private Label labelEmissor;
        private MaskedTextBox maskedTextBoxCnpjEmpresa;
        private Label labelCnpjEmpresa;
        private Panel panelActions;
        protected Button buttonRemover;
        protected Button buttonAdicionar;
        protected Button buttonSalvar;
        protected DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelTitulo;
    }
}
