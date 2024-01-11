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
            panelEmissor = new Panel();
            RemoverEmpresa = new Button();
            textBoxClientSecret = new TextBox();
            labelClientSecret = new Label();
            textBoxClientId = new TextBox();
            labelClientId = new Label();
            textBoxNomeRazaoSocial = new TextBox();
            labelEmissor = new Label();
            maskedTextBoxCnpjEmpresa = new MaskedTextBox();
            labelCnpjEmpresa = new Label();
            buttonAdicionarEmpresa = new Button();
            panelEsquerdoPreto = new Panel();
            labelEmpresa = new Label();
            dataGridViewEmpresas = new DataGridView();
            panelMotorista = new Panel();
            textBoxPassword = new TextBox();
            labelSenha = new Label();
            buttonAdicionarMotorista = new Button();
            panelDireitoPreto = new Panel();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            labelNomeMotorista = new Label();
            labelMotoristas = new Label();
            dataGridViewMotoristas = new DataGridView();
            buttonGerarCSV = new Button();
            button1 = new Button();
            panelEmissor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).BeginInit();
            panelMotorista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMotoristas).BeginInit();
            SuspendLayout();
            // 
            // panelEmissor
            // 
            panelEmissor.BackColor = Color.FromArgb(31, 31, 31);
            panelEmissor.Controls.Add(RemoverEmpresa);
            panelEmissor.Controls.Add(textBoxClientSecret);
            panelEmissor.Controls.Add(labelClientSecret);
            panelEmissor.Controls.Add(textBoxClientId);
            panelEmissor.Controls.Add(labelClientId);
            panelEmissor.Controls.Add(textBoxNomeRazaoSocial);
            panelEmissor.Controls.Add(labelEmissor);
            panelEmissor.Controls.Add(maskedTextBoxCnpjEmpresa);
            panelEmissor.Controls.Add(labelCnpjEmpresa);
            panelEmissor.Controls.Add(buttonAdicionarEmpresa);
            panelEmissor.Controls.Add(panelEsquerdoPreto);
            panelEmissor.Controls.Add(labelEmpresa);
            panelEmissor.Controls.Add(dataGridViewEmpresas);
            panelEmissor.Location = new Point(0, 0);
            panelEmissor.Name = "panelEmissor";
            panelEmissor.Size = new Size(456, 468);
            panelEmissor.TabIndex = 0;
            // 
            // RemoverEmpresa
            // 
            RemoverEmpresa.BackColor = Color.FromArgb(38, 38, 38);
            RemoverEmpresa.FlatAppearance.BorderSize = 0;
            RemoverEmpresa.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            RemoverEmpresa.FlatStyle = FlatStyle.Flat;
            RemoverEmpresa.Location = new Point(361, 80);
            RemoverEmpresa.Name = "RemoverEmpresa";
            RemoverEmpresa.Size = new Size(90, 34);
            RemoverEmpresa.TabIndex = 79;
            RemoverEmpresa.Text = "Remover";
            RemoverEmpresa.UseVisualStyleBackColor = false;
            RemoverEmpresa.Click += RemoverEmpresa_ClickEvent;
            // 
            // textBoxClientSecret
            // 
            textBoxClientSecret.Location = new Point(161, 120);
            textBoxClientSecret.Name = "textBoxClientSecret";
            textBoxClientSecret.Size = new Size(192, 25);
            textBoxClientSecret.TabIndex = 78;
            // 
            // labelClientSecret
            // 
            labelClientSecret.AutoSize = true;
            labelClientSecret.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientSecret.ForeColor = SystemColors.ControlLightLight;
            labelClientSecret.Location = new Point(161, 100);
            labelClientSecret.Name = "labelClientSecret";
            labelClientSecret.Size = new Size(99, 17);
            labelClientSecret.TabIndex = 77;
            labelClientSecret.Text = "Client Secret";
            // 
            // textBoxClientId
            // 
            textBoxClientId.Location = new Point(161, 67);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(192, 25);
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
            // textBoxNomeRazaoSocial
            // 
            textBoxNomeRazaoSocial.Location = new Point(13, 67);
            textBoxNomeRazaoSocial.Name = "textBoxNomeRazaoSocial";
            textBoxNomeRazaoSocial.Size = new Size(140, 25);
            textBoxNomeRazaoSocial.TabIndex = 74;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(13, 48);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(92, 17);
            labelEmissor.TabIndex = 73;
            labelEmissor.Text = "Razao Social";
            // 
            // maskedTextBoxCnpjEmpresa
            // 
            maskedTextBoxCnpjEmpresa.Location = new Point(13, 120);
            maskedTextBoxCnpjEmpresa.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmpresa.Name = "maskedTextBoxCnpjEmpresa";
            maskedTextBoxCnpjEmpresa.Size = new Size(140, 25);
            maskedTextBoxCnpjEmpresa.TabIndex = 72;
            maskedTextBoxCnpjEmpresa.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmpresa.ValidatingType = typeof(DateTime);
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
            // buttonAdicionarEmpresa
            // 
            buttonAdicionarEmpresa.BackColor = Color.FromArgb(38, 38, 38);
            buttonAdicionarEmpresa.FlatAppearance.BorderSize = 0;
            buttonAdicionarEmpresa.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionarEmpresa.FlatStyle = FlatStyle.Flat;
            buttonAdicionarEmpresa.Location = new Point(361, 120);
            buttonAdicionarEmpresa.Name = "buttonAdicionarEmpresa";
            buttonAdicionarEmpresa.Size = new Size(90, 34);
            buttonAdicionarEmpresa.TabIndex = 37;
            buttonAdicionarEmpresa.Text = "Adicionar";
            buttonAdicionarEmpresa.UseVisualStyleBackColor = false;
            buttonAdicionarEmpresa.Click += AdicionarEmpresa_ClickEvent;
            // 
            // panelEsquerdoPreto
            // 
            panelEsquerdoPreto.BackColor = Color.FromArgb(10, 10, 10);
            panelEsquerdoPreto.Dock = DockStyle.Bottom;
            panelEsquerdoPreto.Location = new Point(0, 158);
            panelEsquerdoPreto.Name = "panelEsquerdoPreto";
            panelEsquerdoPreto.Size = new Size(456, 5);
            panelEsquerdoPreto.TabIndex = 36;
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("MesloLGL NF", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelEmpresa.Location = new Point(11, 13);
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle13.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridViewEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewEmpresas.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle15.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewEmpresas.RowTemplate.Height = 25;
            dataGridViewEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmpresas.ShowCellErrors = false;
            dataGridViewEmpresas.ShowCellToolTips = false;
            dataGridViewEmpresas.ShowRowErrors = false;
            dataGridViewEmpresas.Size = new Size(456, 305);
            dataGridViewEmpresas.TabIndex = 34;
            // 
            // panelMotorista
            // 
            panelMotorista.BackColor = Color.FromArgb(31, 31, 31);
            panelMotorista.Controls.Add(button1);
            panelMotorista.Controls.Add(textBoxPassword);
            panelMotorista.Controls.Add(labelSenha);
            panelMotorista.Controls.Add(buttonAdicionarMotorista);
            panelMotorista.Controls.Add(panelDireitoPreto);
            panelMotorista.Controls.Add(maskedTextBoxCpfMotorista);
            panelMotorista.Controls.Add(labelCpfMotorista);
            panelMotorista.Controls.Add(textBoxNomeMotorista);
            panelMotorista.Controls.Add(labelNomeMotorista);
            panelMotorista.Controls.Add(labelMotoristas);
            panelMotorista.Controls.Add(dataGridViewMotoristas);
            panelMotorista.Location = new Point(459, 0);
            panelMotorista.Name = "panelMotorista";
            panelMotorista.Size = new Size(341, 468);
            panelMotorista.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(127, 120);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(112, 25);
            textBoxPassword.TabIndex = 80;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.ForeColor = SystemColors.ControlLightLight;
            labelSenha.Location = new Point(127, 98);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(43, 17);
            labelSenha.TabIndex = 79;
            labelSenha.Text = "Senha";
            // 
            // buttonAdicionarMotorista
            // 
            buttonAdicionarMotorista.BackColor = Color.FromArgb(38, 38, 38);
            buttonAdicionarMotorista.FlatAppearance.BorderSize = 0;
            buttonAdicionarMotorista.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAdicionarMotorista.FlatStyle = FlatStyle.Flat;
            buttonAdicionarMotorista.Location = new Point(246, 118);
            buttonAdicionarMotorista.Name = "buttonAdicionarMotorista";
            buttonAdicionarMotorista.Size = new Size(90, 34);
            buttonAdicionarMotorista.TabIndex = 42;
            buttonAdicionarMotorista.Text = "Adicionar";
            buttonAdicionarMotorista.UseVisualStyleBackColor = false;
            buttonAdicionarMotorista.Click += AdicionarMotorista_ClickEvent;
            // 
            // panelDireitoPreto
            // 
            panelDireitoPreto.BackColor = Color.FromArgb(10, 10, 10);
            panelDireitoPreto.Dock = DockStyle.Bottom;
            panelDireitoPreto.Location = new Point(0, 158);
            panelDireitoPreto.Name = "panelDireitoPreto";
            panelDireitoPreto.Size = new Size(341, 5);
            panelDireitoPreto.TabIndex = 41;
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(13, 120);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(108, 25);
            maskedTextBoxCpfMotorista.TabIndex = 40;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.ForeColor = SystemColors.ControlLightLight;
            labelCpfMotorista.Location = new Point(13, 98);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(29, 17);
            labelCpfMotorista.TabIndex = 39;
            labelCpfMotorista.Text = "CPF";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(13, 67);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(226, 25);
            textBoxNomeMotorista.TabIndex = 38;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.ForeColor = SystemColors.ControlLightLight;
            labelNomeMotorista.Location = new Point(13, 48);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(36, 17);
            labelNomeMotorista.TabIndex = 37;
            labelNomeMotorista.Text = "Nome";
            // 
            // labelMotoristas
            // 
            labelMotoristas.AutoSize = true;
            labelMotoristas.Font = new Font("MesloLGL NF", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMotoristas.ForeColor = SystemColors.ControlLightLight;
            labelMotoristas.Location = new Point(11, 13);
            labelMotoristas.Name = "labelMotoristas";
            labelMotoristas.Size = new Size(123, 29);
            labelMotoristas.TabIndex = 36;
            labelMotoristas.Text = "Motoristas";
            // 
            // dataGridViewMotoristas
            // 
            dataGridViewMotoristas.AllowUserToAddRows = false;
            dataGridViewMotoristas.AllowUserToDeleteRows = false;
            dataGridViewMotoristas.AllowUserToOrderColumns = true;
            dataGridViewMotoristas.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridViewMotoristas.BorderStyle = BorderStyle.None;
            dataGridViewMotoristas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMotoristas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle16.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridViewMotoristas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewMotoristas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMotoristas.Dock = DockStyle.Bottom;
            dataGridViewMotoristas.EnableHeadersVisualStyles = false;
            dataGridViewMotoristas.GridColor = Color.FromArgb(12, 12, 12);
            dataGridViewMotoristas.Location = new Point(0, 163);
            dataGridViewMotoristas.Margin = new Padding(0);
            dataGridViewMotoristas.MultiSelect = false;
            dataGridViewMotoristas.Name = "dataGridViewMotoristas";
            dataGridViewMotoristas.ReadOnly = true;
            dataGridViewMotoristas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMotoristas.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewMotoristas.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle18.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewMotoristas.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewMotoristas.RowTemplate.Height = 25;
            dataGridViewMotoristas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMotoristas.ShowCellErrors = false;
            dataGridViewMotoristas.ShowCellToolTips = false;
            dataGridViewMotoristas.ShowRowErrors = false;
            dataGridViewMotoristas.Size = new Size(341, 305);
            dataGridViewMotoristas.TabIndex = 35;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 38, 38);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(246, 80);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 81;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = false;
            button1.Click += RemoverMotorista_ClickEvent;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewMotoristas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEmissor;
        private Panel panelMotorista;
        private Button buttonGerarCSV;
        protected DataGridView dataGridViewEmpresas;
        protected DataGridView dataGridViewMotoristas;
        private Label labelEmpresa;
        private Label labelMotoristas;
        private Panel panelEsquerdoPreto;
        private Panel panelDireitoPreto;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
        private Label labelNomeMotorista;
        private Button buttonAdicionarEmpresa;
        private Button buttonAdicionarMotorista;
        private TextBox textBoxNomeRazaoSocial;
        private Label labelEmissor;
        private MaskedTextBox maskedTextBoxCnpjEmpresa;
        private Label labelCnpjEmpresa;
        private TextBox textBoxClientId;
        private Label label1;
        private TextBox textBoxClientSecret;
        private Label labelClientSecret;
        private TextBox textBoxPassword;
        private Label labelSenha;
        private Label labelClientId;
        private Button RemoverEmpresa;
        private Button button1;
    }
}
