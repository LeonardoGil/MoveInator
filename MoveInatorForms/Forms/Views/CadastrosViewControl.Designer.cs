namespace MoveInatorForms.Forms.Views
{
    partial class CadastrosViewControl
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panelEsquerdo = new Panel();
            textBoxClientSecret = new TextBox();
            labelClientSecret = new Label();
            textBoxClientId = new TextBox();
            labelClientId = new Label();
            textBoxEmissor = new TextBox();
            labelEmissor = new Label();
            maskedTextBoxCnpjEmissor = new MaskedTextBox();
            labelCnpjEmissor = new Label();
            buttonAdicionar = new Button();
            panel2 = new Panel();
            labelEmpresa = new Label();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            button1 = new Button();
            panel3 = new Panel();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            labelNomeMotorista = new Label();
            labelMotoristas = new Label();
            dataGridView1 = new DataGridView();
            buttonGerarCSV = new Button();
            panelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelEsquerdo
            // 
            panelEsquerdo.BackColor = Color.FromArgb(31, 31, 31);
            panelEsquerdo.Controls.Add(textBoxClientSecret);
            panelEsquerdo.Controls.Add(labelClientSecret);
            panelEsquerdo.Controls.Add(textBoxClientId);
            panelEsquerdo.Controls.Add(labelClientId);
            panelEsquerdo.Controls.Add(textBoxEmissor);
            panelEsquerdo.Controls.Add(labelEmissor);
            panelEsquerdo.Controls.Add(maskedTextBoxCnpjEmissor);
            panelEsquerdo.Controls.Add(labelCnpjEmissor);
            panelEsquerdo.Controls.Add(buttonAdicionar);
            panelEsquerdo.Controls.Add(panel2);
            panelEsquerdo.Controls.Add(labelEmpresa);
            panelEsquerdo.Controls.Add(dataGridView);
            panelEsquerdo.Location = new Point(0, 0);
            panelEsquerdo.Name = "panelEsquerdo";
            panelEsquerdo.Size = new Size(475, 468);
            panelEsquerdo.TabIndex = 0;
            // 
            // textBoxClientSecret
            // 
            textBoxClientSecret.Location = new Point(161, 120);
            textBoxClientSecret.Name = "textBoxClientSecret";
            textBoxClientSecret.Size = new Size(204, 25);
            textBoxClientSecret.TabIndex = 78;
            // 
            // labelClientSecret
            // 
            labelClientSecret.AutoSize = true;
            labelClientSecret.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientSecret.ForeColor = SystemColors.ControlLightLight;
            labelClientSecret.Location = new Point(161, 100);
            labelClientSecret.Name = "labelClientSecret";
            labelClientSecret.Size = new Size(92, 17);
            labelClientSecret.TabIndex = 77;
            labelClientSecret.Text = "ClientSecret";
            // 
            // textBoxClientId
            // 
            textBoxClientId.Location = new Point(161, 67);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(204, 25);
            textBoxClientId.TabIndex = 76;
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientId.ForeColor = SystemColors.ControlLightLight;
            labelClientId.Location = new Point(161, 48);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(64, 17);
            labelClientId.TabIndex = 75;
            labelClientId.Text = "ClientId";
            // 
            // textBoxEmissor
            // 
            textBoxEmissor.Location = new Point(13, 67);
            textBoxEmissor.Name = "textBoxEmissor";
            textBoxEmissor.Size = new Size(140, 25);
            textBoxEmissor.TabIndex = 74;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(13, 48);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(57, 17);
            labelEmissor.TabIndex = 73;
            labelEmissor.Text = "Emissor";
            // 
            // maskedTextBoxCnpjEmissor
            // 
            maskedTextBoxCnpjEmissor.Location = new Point(13, 120);
            maskedTextBoxCnpjEmissor.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmissor.Name = "maskedTextBoxCnpjEmissor";
            maskedTextBoxCnpjEmissor.Size = new Size(140, 25);
            maskedTextBoxCnpjEmissor.TabIndex = 72;
            maskedTextBoxCnpjEmissor.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmissor.ValidatingType = typeof(DateTime);
            // 
            // labelCnpjEmissor
            // 
            labelCnpjEmissor.AutoSize = true;
            labelCnpjEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmissor.ForeColor = SystemColors.ControlLightLight;
            labelCnpjEmissor.Location = new Point(13, 100);
            labelCnpjEmissor.Name = "labelCnpjEmissor";
            labelCnpjEmissor.Size = new Size(92, 17);
            labelCnpjEmissor.TabIndex = 71;
            labelCnpjEmissor.Text = "CNPJ Emissor";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.FromArgb(38, 38, 38);
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Location = new Point(377, 117);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(90, 34);
            buttonAdicionar.TabIndex = 37;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(10, 10, 10);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 5);
            panel2.TabIndex = 36;
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("MesloLGL NF", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelEmpresa.Location = new Point(10, 10);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(101, 29);
            labelEmpresa.TabIndex = 35;
            labelEmpresa.Text = "Empresas";
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle7.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 163);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle9.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(475, 305);
            dataGridView.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(maskedTextBoxCpfMotorista);
            panel1.Controls.Add(labelCpfMotorista);
            panel1.Controls.Add(textBoxNomeMotorista);
            panel1.Controls.Add(labelNomeMotorista);
            panel1.Controls.Add(labelMotoristas);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(481, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 468);
            panel1.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(13, 122);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(147, 25);
            textBoxPassword.TabIndex = 80;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.ControlLightLight;
            labelPassword.Location = new Point(13, 100);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(64, 17);
            labelPassword.TabIndex = 79;
            labelPassword.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 38, 38);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(224, 118);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 42;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(10, 10, 10);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 5);
            panel3.TabIndex = 41;
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(168, 67);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(130, 25);
            maskedTextBoxCpfMotorista.TabIndex = 40;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.ForeColor = SystemColors.ControlLightLight;
            labelCpfMotorista.Location = new Point(168, 48);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(99, 17);
            labelCpfMotorista.TabIndex = 39;
            labelCpfMotorista.Text = "CPF Motorista";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(13, 67);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(147, 25);
            textBoxNomeMotorista.TabIndex = 38;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.ForeColor = SystemColors.ControlLightLight;
            labelNomeMotorista.Location = new Point(13, 48);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(106, 17);
            labelNomeMotorista.TabIndex = 37;
            labelNomeMotorista.Text = "Nome Motorista";
            // 
            // labelMotoristas
            // 
            labelMotoristas.AutoSize = true;
            labelMotoristas.Font = new Font("MesloLGL NF", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMotoristas.ForeColor = SystemColors.ControlLightLight;
            labelMotoristas.Location = new Point(10, 10);
            labelMotoristas.Name = "labelMotoristas";
            labelMotoristas.Size = new Size(123, 29);
            labelMotoristas.TabIndex = 36;
            labelMotoristas.Text = "Motoristas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle10.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView1.Location = new Point(0, 163);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle12.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(319, 305);
            dataGridView1.TabIndex = 35;
            // 
            // buttonGerarCSV
            // 
            buttonGerarCSV.BackColor = Color.FromArgb(38, 38, 38);
            buttonGerarCSV.Enabled = false;
            buttonGerarCSV.FlatAppearance.BorderSize = 0;
            buttonGerarCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarCSV.FlatStyle = FlatStyle.Flat;
            buttonGerarCSV.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarCSV.Location = new Point(695, 475);
            buttonGerarCSV.Margin = new Padding(5);
            buttonGerarCSV.Name = "buttonGerarCSV";
            buttonGerarCSV.Size = new Size(100, 40);
            buttonGerarCSV.TabIndex = 43;
            buttonGerarCSV.Text = "Salvar";
            buttonGerarCSV.UseVisualStyleBackColor = false;
            // 
            // CadastrosViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(buttonGerarCSV);
            Controls.Add(panel1);
            Controls.Add(panelEsquerdo);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkGray;
            Name = "CadastrosViewControl";
            Size = new Size(800, 520);
            panelEsquerdo.ResumeLayout(false);
            panelEsquerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEsquerdo;
        private Panel panel1;
        private Button buttonGerarCSV;
        protected DataGridView dataGridView;
        protected DataGridView dataGridView1;
        private Label labelEmpresa;
        private Label labelMotoristas;
        private Panel panel2;
        private Panel panel3;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
        private Label labelNomeMotorista;
        private Button buttonAdicionar;
        private Button button1;
        private TextBox textBoxEmissor;
        private Label labelEmissor;
        private MaskedTextBox maskedTextBoxCnpjEmissor;
        private Label labelCnpjEmissor;
        private TextBox textBoxClientId;
        private Label label1;
        private TextBox textBoxClientSecret;
        private Label labelClientSecret;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Label labelClientId;
    }
}
