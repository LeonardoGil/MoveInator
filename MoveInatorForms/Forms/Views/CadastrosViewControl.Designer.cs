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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            panelEsquerdo = new Panel();
            buttonAdicionar = new Button();
            panel2 = new Panel();
            labelEmpresa = new Label();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            labelNomeMotorista = new Label();
            labelMotoristas = new Label();
            dataGridView1 = new DataGridView();
            buttonGerarCSV = new Button();
            textBoxEmissor = new TextBox();
            labelEmissor = new Label();
            maskedTextBoxCnpjEmissor = new MaskedTextBox();
            labelCnpjEmissor = new Label();
            panelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelEsquerdo
            // 
            panelEsquerdo.BackColor = Color.FromArgb(31, 31, 31);
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
            panelEsquerdo.Size = new Size(398, 468);
            panelEsquerdo.TabIndex = 0;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.FromArgb(38, 38, 38);
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Location = new Point(305, 118);
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
            panel2.Size = new Size(398, 5);
            panel2.TabIndex = 36;
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("MesloLGL NF", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelEmpresa.Location = new Point(292, 10);
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle13.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle15.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(398, 305);
            dataGridView.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(maskedTextBoxCpfMotorista);
            panel1.Controls.Add(labelCpfMotorista);
            panel1.Controls.Add(textBoxNomeMotorista);
            panel1.Controls.Add(labelNomeMotorista);
            panel1.Controls.Add(labelMotoristas);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(402, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 468);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 38, 38);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(303, 118);
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
            panel3.Size = new Size(398, 5);
            panel3.TabIndex = 41;
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(25, 106);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(120, 25);
            maskedTextBoxCpfMotorista.TabIndex = 40;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.ForeColor = SystemColors.ControlLightLight;
            labelCpfMotorista.Location = new Point(25, 84);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(99, 17);
            labelCpfMotorista.TabIndex = 39;
            labelCpfMotorista.Text = "CPF Motorista";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(25, 46);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(160, 25);
            textBoxNomeMotorista.TabIndex = 38;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.ForeColor = SystemColors.ControlLightLight;
            labelNomeMotorista.Location = new Point(25, 24);
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
            labelMotoristas.Location = new Point(268, 10);
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle16.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle18.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(398, 305);
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
            // textBoxEmissor
            // 
            textBoxEmissor.Location = new Point(25, 46);
            textBoxEmissor.Name = "textBoxEmissor";
            textBoxEmissor.Size = new Size(160, 25);
            textBoxEmissor.TabIndex = 74;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(25, 24);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(57, 17);
            labelEmissor.TabIndex = 73;
            labelEmissor.Text = "Emissor";
            // 
            // maskedTextBoxCnpjEmissor
            // 
            maskedTextBoxCnpjEmissor.Location = new Point(25, 107);
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
            labelCnpjEmissor.Location = new Point(25, 84);
            labelCnpjEmissor.Name = "labelCnpjEmissor";
            labelCnpjEmissor.Size = new Size(92, 17);
            labelCnpjEmissor.TabIndex = 71;
            labelCnpjEmissor.Text = "CNPJ Emissor";
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
    }
}
