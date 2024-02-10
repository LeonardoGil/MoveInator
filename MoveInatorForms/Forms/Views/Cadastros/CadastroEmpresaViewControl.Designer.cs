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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            textBoxClientSecret = new TextBox();
            labelClientSecret = new Label();
            textBoxClientId = new TextBox();
            labelClientId = new Label();
            textBoxNomeRazaoSocial = new TextBox();
            labelEmissor = new Label();
            maskedTextBoxCnpjEmpresa = new MaskedTextBox();
            labelCnpjEmpresa = new Label();
            panelActions = new Panel();
            button1 = new Button();
            button2 = new Button();
            buttonRemover = new Button();
            button3 = new Button();
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
            textBoxClientSecret.Location = new Point(20, 221);
            textBoxClientSecret.Margin = new Padding(20, 0, 20, 0);
            textBoxClientSecret.Name = "textBoxClientSecret";
            textBoxClientSecret.Size = new Size(560, 25);
            textBoxClientSecret.TabIndex = 89;
            // 
            // labelClientSecret
            // 
            labelClientSecret.AutoSize = true;
            labelClientSecret.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientSecret.ForeColor = SystemColors.ControlLightLight;
            labelClientSecret.Location = new Point(20, 199);
            labelClientSecret.Margin = new Padding(20, 5, 0, 5);
            labelClientSecret.Name = "labelClientSecret";
            labelClientSecret.Size = new Size(99, 17);
            labelClientSecret.TabIndex = 88;
            labelClientSecret.Text = "Client Secret";
            // 
            // textBoxClientId
            // 
            textBoxClientId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBoxClientId, 2);
            textBoxClientId.Location = new Point(20, 149);
            textBoxClientId.Margin = new Padding(20, 0, 20, 0);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(560, 25);
            textBoxClientId.TabIndex = 87;
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientId.ForeColor = SystemColors.ControlLightLight;
            labelClientId.Location = new Point(20, 127);
            labelClientId.Margin = new Padding(20, 5, 0, 5);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(64, 17);
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
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(20, 55);
            labelEmissor.Margin = new Padding(20, 5, 0, 5);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(92, 17);
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
            labelCnpjEmpresa.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelCnpjEmpresa.Location = new Point(425, 55);
            labelCnpjEmpresa.Margin = new Padding(5, 5, 0, 5);
            labelCnpjEmpresa.Name = "labelCnpjEmpresa";
            labelCnpjEmpresa.Size = new Size(36, 17);
            labelCnpjEmpresa.TabIndex = 82;
            labelCnpjEmpresa.Text = "CNPJ";
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(panelActions, 2);
            panelActions.Controls.Add(button1);
            panelActions.Controls.Add(button2);
            panelActions.Controls.Add(buttonRemover);
            panelActions.Controls.Add(button3);
            panelActions.Controls.Add(buttonAdicionar);
            panelActions.Controls.Add(buttonSalvar);
            panelActions.Location = new Point(333, 269);
            panelActions.Margin = new Padding(0, 3, 0, 3);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(267, 27);
            panelActions.TabIndex = 94;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.lixeira_16;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0, 3, 0, 3);
            button1.Name = "button1";
            button1.Size = new Size(91, 27);
            button1.TabIndex = 97;
            button1.Text = " Remover";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.adicionar_16;
            button2.Location = new Point(91, 0);
            button2.Margin = new Padding(0, 3, 0, 3);
            button2.Name = "button2";
            button2.Size = new Size(104, 27);
            button2.TabIndex = 96;
            button2.Text = " Adicionar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
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
            buttonRemover.Location = new Point(28, -37);
            buttonRemover.Margin = new Padding(0, 3, 0, 3);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(91, 27);
            buttonRemover.TabIndex = 92;
            buttonRemover.Text = " Remover";
            buttonRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemover.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Enabled = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(195, 0);
            button3.Margin = new Padding(0, 3, 0, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 95;
            button3.Text = " Salvar";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
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
            buttonAdicionar.Location = new Point(119, -37);
            buttonAdicionar.Margin = new Padding(0, 3, 0, 3);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(104, 27);
            buttonAdicionar.TabIndex = 91;
            buttonAdicionar.Text = " Adicionar";
            buttonAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionar.UseVisualStyleBackColor = false;
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
            buttonSalvar.Location = new Point(223, -37);
            buttonSalvar.Margin = new Padding(0, 3, 0, 3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 27);
            buttonSalvar.TabIndex = 43;
            buttonSalvar.Text = " Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 300);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle6.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
        protected Button button1;
        protected Button button2;
        protected Button button3;
        protected DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelTitulo;
    }
}
