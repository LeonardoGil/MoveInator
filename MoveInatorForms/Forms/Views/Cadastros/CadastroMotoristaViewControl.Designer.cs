namespace MoveInatorForms.Forms.Views.Cadastros
{
    partial class CadastroMotoristaViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMotoristaViewControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBoxPassword = new TextBox();
            labelSenha = new Label();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelNomeMotorista = new Label();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            panelActions = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonRemover = new Button();
            buttonAdicionar = new Button();
            buttonSalvar = new Button();
            dataGridView = new DataGridView();
            labelTitulo = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(20, 188);
            textBoxPassword.Margin = new Padding(20, 0, 5, 0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(395, 25);
            textBoxPassword.TabIndex = 89;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.ForeColor = SystemColors.ControlLightLight;
            labelSenha.Location = new Point(20, 166);
            labelSenha.Margin = new Padding(20, 5, 0, 5);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(43, 17);
            labelSenha.TabIndex = 88;
            labelSenha.Text = "Senha";
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxCpfMotorista.Location = new Point(425, 77);
            maskedTextBoxCpfMotorista.Margin = new Padding(5, 0, 20, 0);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(155, 25);
            maskedTextBoxCpfMotorista.TabIndex = 86;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.ForeColor = SystemColors.ControlLightLight;
            labelNomeMotorista.Location = new Point(20, 55);
            labelNomeMotorista.Margin = new Padding(20, 5, 0, 5);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(36, 17);
            labelNomeMotorista.TabIndex = 83;
            labelNomeMotorista.Text = "Nome";
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.ForeColor = SystemColors.ControlLightLight;
            labelCpfMotorista.Location = new Point(425, 55);
            labelCpfMotorista.Margin = new Padding(5, 5, 0, 5);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(29, 17);
            labelCpfMotorista.TabIndex = 85;
            labelCpfMotorista.Text = "CPF";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNomeMotorista.Location = new Point(20, 77);
            textBoxNomeMotorista.Margin = new Padding(20, 0, 5, 0);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(395, 25);
            textBoxNomeMotorista.TabIndex = 84;
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(panelActions, 2);
            panelActions.Controls.Add(button1);
            panelActions.Controls.Add(button2);
            panelActions.Controls.Add(button3);
            panelActions.Controls.Add(buttonRemover);
            panelActions.Controls.Add(buttonAdicionar);
            panelActions.Controls.Add(buttonSalvar);
            panelActions.Location = new Point(320, 272);
            panelActions.Margin = new Padding(0);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(280, 27);
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
            button1.TabIndex = 95;
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
            button2.TabIndex = 94;
            button2.Text = " Adicionar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
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
            button3.Size = new Size(85, 27);
            button3.TabIndex = 93;
            button3.Text = " Salvar";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.None;
            buttonRemover.FlatAppearance.BorderSize = 0;
            buttonRemover.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemover.ForeColor = SystemColors.ControlLightLight;
            buttonRemover.Image = Properties.Resources.lixeira_16;
            buttonRemover.ImageAlign = ContentAlignment.TopLeft;
            buttonRemover.Location = new Point(40, -37);
            buttonRemover.Margin = new Padding(0, 3, 0, 3);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(91, 27);
            buttonRemover.TabIndex = 92;
            buttonRemover.Text = " Remover";
            buttonRemover.TextAlign = ContentAlignment.BottomRight;
            buttonRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemover.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Anchor = AnchorStyles.None;
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.ForeColor = SystemColors.ControlLightLight;
            buttonAdicionar.Image = Properties.Resources.adicionar_16;
            buttonAdicionar.ImageAlign = ContentAlignment.TopLeft;
            buttonAdicionar.Location = new Point(131, -37);
            buttonAdicionar.Margin = new Padding(0, 3, 0, 3);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(104, 27);
            buttonAdicionar.TabIndex = 91;
            buttonAdicionar.Text = " Adicionar";
            buttonAdicionar.TextAlign = ContentAlignment.BottomRight;
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
            buttonSalvar.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = SystemColors.ControlLightLight;
            buttonSalvar.Image = (Image)resources.GetObject("buttonSalvar.Image");
            buttonSalvar.ImageAlign = ContentAlignment.TopLeft;
            buttonSalvar.Location = new Point(235, -37);
            buttonSalvar.Margin = new Padding(0, 3, 0, 3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(85, 27);
            buttonSalvar.TabIndex = 43;
            buttonSalvar.Text = " Salvar";
            buttonSalvar.TextAlign = ContentAlignment.BottomRight;
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
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
            dataGridView.TabIndex = 95;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = SystemColors.ControlLightLight;
            labelTitulo.Location = new Point(20, 10);
            labelTitulo.Margin = new Padding(20, 10, 0, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(199, 30);
            labelTitulo.TabIndex = 98;
            labelTitulo.Text = "Cadastro Motorista";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Controls.Add(labelTitulo, 0, 0);
            tableLayoutPanel.Controls.Add(labelNomeMotorista, 0, 1);
            tableLayoutPanel.Controls.Add(panelActions, 0, 5);
            tableLayoutPanel.Controls.Add(textBoxNomeMotorista, 0, 2);
            tableLayoutPanel.Controls.Add(labelCpfMotorista, 1, 1);
            tableLayoutPanel.Controls.Add(labelSenha, 0, 3);
            tableLayoutPanel.Controls.Add(maskedTextBoxCpfMotorista, 1, 2);
            tableLayoutPanel.Controls.Add(textBoxPassword, 0, 4);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.MaximumSize = new Size(9999, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(600, 300);
            tableLayoutPanel.TabIndex = 99;
            tableLayoutPanel.SizeChanged += View_SizeChangedEvent;
            // 
            // CadastroMotoristaViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridView);
            Name = "CadastroMotoristaViewControl";
            panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxPassword;
        private Label labelSenha;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelNomeMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
        private Panel panelActions;
        protected Button buttonRemover;
        protected Button buttonAdicionar;
        protected Button buttonSalvar;
        protected Button button1;
        protected Button button2;
        protected Button button3;
        protected DataGridView dataGridView;
        private Label labelTitulo;
        private TableLayoutPanel tableLayoutPanel;
    }
}
