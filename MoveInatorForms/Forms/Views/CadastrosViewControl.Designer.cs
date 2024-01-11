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
            panelEmissor = new Panel();
            textBoxClientSecret = new TextBox();
            labelClientSecret = new Label();
            textBoxClientId = new TextBox();
            labelClientId = new Label();
            textBoxNomeEmpresa = new TextBox();
            labelEmissor = new Label();
            maskedTextBoxCnpjEmissor = new MaskedTextBox();
            labelCnpjEmpresa = new Label();
            buttonAdicionarEmissor = new Button();
            panelEsquerdoPreto = new Panel();
            labelEmpresa = new Label();
            dataGridViewEmpresas = new DataGridView();
            panelMotorista = new Panel();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonAdicionarMotorista = new Button();
            panelDireitoPreto = new Panel();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            labelNomeMotorista = new Label();
            labelMotoristas = new Label();
            dataGridViewMotorista = new DataGridView();
            buttonGerarCSV = new Button();
            panelEmissor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).BeginInit();
            panelMotorista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMotorista).BeginInit();
            SuspendLayout();
            // 
            // panelEmissor
            // 
            panelEmissor.BackColor = Color.FromArgb(31, 31, 31);
            panelEmissor.Controls.Add(textBoxClientSecret);
            panelEmissor.Controls.Add(labelClientSecret);
            panelEmissor.Controls.Add(textBoxClientId);
            panelEmissor.Controls.Add(labelClientId);
            panelEmissor.Controls.Add(textBoxNomeEmpresa);
            panelEmissor.Controls.Add(labelEmissor);
            panelEmissor.Controls.Add(maskedTextBoxCnpjEmissor);
            panelEmissor.Controls.Add(labelCnpjEmpresa);
            panelEmissor.Controls.Add(buttonAdicionarEmissor);
            panelEmissor.Controls.Add(panelEsquerdoPreto);
            panelEmissor.Controls.Add(labelEmpresa);
            panelEmissor.Controls.Add(dataGridViewEmpresas);
            panelEmissor.Location = new Point(0, 0);
            panelEmissor.Name = "panelEmissor";
            panelEmissor.Size = new Size(475, 468);
            panelEmissor.TabIndex = 0;
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
            // textBoxNomeEmpresa
            // 
            textBoxNomeEmpresa.Location = new Point(13, 67);
            textBoxNomeEmpresa.Name = "textBoxNomeEmpresa";
            textBoxNomeEmpresa.Size = new Size(140, 25);
            textBoxNomeEmpresa.TabIndex = 74;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(13, 48);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(36, 17);
            labelEmissor.TabIndex = 73;
            labelEmissor.Text = "Nome";
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
            // labelCnpjEmpresa
            // 
            labelCnpjEmpresa.AutoSize = true;
            labelCnpjEmpresa.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelCnpjEmpresa.Location = new Point(13, 100);
            labelCnpjEmpresa.Name = "labelCnpjEmpresa";
            labelCnpjEmpresa.Size = new Size(36, 17);
            labelCnpjEmpresa.TabIndex = 71;
            labelCnpjEmpresa.Text = "CNPJ";
            // 
            // buttonAdicionarEmissor
            // 
            buttonAdicionarEmissor.BackColor = Color.FromArgb(38, 38, 38);
            buttonAdicionarEmissor.FlatAppearance.BorderSize = 0;
            buttonAdicionarEmissor.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionarEmissor.FlatStyle = FlatStyle.Flat;
            buttonAdicionarEmissor.Location = new Point(377, 117);
            buttonAdicionarEmissor.Name = "buttonAdicionarEmissor";
            buttonAdicionarEmissor.Size = new Size(90, 34);
            buttonAdicionarEmissor.TabIndex = 37;
            buttonAdicionarEmissor.Text = "Adicionar";
            buttonAdicionarEmissor.UseVisualStyleBackColor = false;
            // 
            // panelEsquerdoPreto
            // 
            panelEsquerdoPreto.BackColor = Color.FromArgb(10, 10, 10);
            panelEsquerdoPreto.Dock = DockStyle.Bottom;
            panelEsquerdoPreto.Location = new Point(0, 158);
            panelEsquerdoPreto.Name = "panelEsquerdoPreto";
            panelEsquerdoPreto.Size = new Size(475, 5);
            panelEsquerdoPreto.TabIndex = 36;
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
            // dataGridViewEmpresas
            // 
            dataGridViewEmpresas.AllowUserToAddRows = false;
            dataGridViewEmpresas.AllowUserToDeleteRows = false;
            dataGridViewEmpresas.AllowUserToOrderColumns = true;
            dataGridViewEmpresas.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridViewEmpresas.BorderStyle = BorderStyle.None;
            dataGridViewEmpresas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEmpresas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle7.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpresas.Dock = DockStyle.Bottom;
            dataGridViewEmpresas.EnableHeadersVisualStyles = false;
            dataGridViewEmpresas.GridColor = Color.FromArgb(12, 12, 12);
            dataGridViewEmpresas.Location = new Point(0, 163);
            dataGridViewEmpresas.Margin = new Padding(0);
            dataGridViewEmpresas.MultiSelect = false;
            dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            dataGridViewEmpresas.ReadOnly = true;
            dataGridViewEmpresas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewEmpresas.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle9.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewEmpresas.RowTemplate.Height = 25;
            dataGridViewEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmpresas.ShowCellErrors = false;
            dataGridViewEmpresas.ShowCellToolTips = false;
            dataGridViewEmpresas.ShowRowErrors = false;
            dataGridViewEmpresas.Size = new Size(475, 305);
            dataGridViewEmpresas.TabIndex = 34;
            // 
            // panelMotorista
            // 
            panelMotorista.BackColor = Color.FromArgb(31, 31, 31);
            panelMotorista.Controls.Add(textBoxPassword);
            panelMotorista.Controls.Add(labelPassword);
            panelMotorista.Controls.Add(buttonAdicionarMotorista);
            panelMotorista.Controls.Add(panelDireitoPreto);
            panelMotorista.Controls.Add(maskedTextBoxCpfMotorista);
            panelMotorista.Controls.Add(labelCpfMotorista);
            panelMotorista.Controls.Add(textBoxNomeMotorista);
            panelMotorista.Controls.Add(labelNomeMotorista);
            panelMotorista.Controls.Add(labelMotoristas);
            panelMotorista.Controls.Add(dataGridViewMotorista);
            panelMotorista.Location = new Point(481, 0);
            panelMotorista.Name = "panelMotorista";
            panelMotorista.Size = new Size(319, 468);
            panelMotorista.TabIndex = 1;
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
            // buttonAdicionarMotorista
            // 
            buttonAdicionarMotorista.BackColor = Color.FromArgb(38, 38, 38);
            buttonAdicionarMotorista.FlatAppearance.BorderSize = 0;
            buttonAdicionarMotorista.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionarMotorista.FlatStyle = FlatStyle.Flat;
            buttonAdicionarMotorista.Location = new Point(224, 118);
            buttonAdicionarMotorista.Name = "buttonAdicionarMotorista";
            buttonAdicionarMotorista.Size = new Size(90, 34);
            buttonAdicionarMotorista.TabIndex = 42;
            buttonAdicionarMotorista.Text = "Adicionar";
            buttonAdicionarMotorista.UseVisualStyleBackColor = false;
            // 
            // panelDireitoPreto
            // 
            panelDireitoPreto.BackColor = Color.FromArgb(10, 10, 10);
            panelDireitoPreto.Dock = DockStyle.Bottom;
            panelDireitoPreto.Location = new Point(0, 158);
            panelDireitoPreto.Name = "panelDireitoPreto";
            panelDireitoPreto.Size = new Size(319, 5);
            panelDireitoPreto.TabIndex = 41;
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
            // dataGridViewMotorista
            // 
            dataGridViewMotorista.AllowUserToAddRows = false;
            dataGridViewMotorista.AllowUserToDeleteRows = false;
            dataGridViewMotorista.AllowUserToOrderColumns = true;
            dataGridViewMotorista.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridViewMotorista.BorderStyle = BorderStyle.None;
            dataGridViewMotorista.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMotorista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle10.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewMotorista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewMotorista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMotorista.Dock = DockStyle.Bottom;
            dataGridViewMotorista.EnableHeadersVisualStyles = false;
            dataGridViewMotorista.GridColor = Color.FromArgb(12, 12, 12);
            dataGridViewMotorista.Location = new Point(0, 163);
            dataGridViewMotorista.Margin = new Padding(0);
            dataGridViewMotorista.MultiSelect = false;
            dataGridViewMotorista.Name = "dataGridViewMotorista";
            dataGridViewMotorista.ReadOnly = true;
            dataGridViewMotorista.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMotorista.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewMotorista.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle12.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewMotorista.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewMotorista.RowTemplate.Height = 25;
            dataGridViewMotorista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMotorista.ShowCellErrors = false;
            dataGridViewMotorista.ShowCellToolTips = false;
            dataGridViewMotorista.ShowRowErrors = false;
            dataGridViewMotorista.Size = new Size(319, 305);
            dataGridViewMotorista.TabIndex = 35;
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
            Controls.Add(panelMotorista);
            Controls.Add(panelEmissor);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkGray;
            Name = "CadastrosViewControl";
            Size = new Size(800, 520);
            panelEmissor.ResumeLayout(false);
            panelEmissor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).EndInit();
            panelMotorista.ResumeLayout(false);
            panelMotorista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMotorista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEmissor;
        private Panel panelMotorista;
        private Button buttonGerarCSV;
        protected DataGridView dataGridViewEmpresas;
        protected DataGridView dataGridViewMotorista;
        private Label labelEmpresa;
        private Label labelMotoristas;
        private Panel panelEsquerdoPreto;
        private Panel panelDireitoPreto;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
        private Label labelNomeMotorista;
        private Button buttonAdicionarEmissor;
        private Button buttonAdicionarMotorista;
        private TextBox textBoxNomeEmpresa;
        private Label labelEmissor;
        private MaskedTextBox maskedTextBoxCnpjEmissor;
        private Label labelCnpjEmpresa;
        private TextBox textBoxClientId;
        private Label label1;
        private TextBox textBoxClientSecret;
        private Label labelClientSecret;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Label labelClientId;
    }
}
