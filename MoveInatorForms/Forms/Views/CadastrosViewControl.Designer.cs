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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelEmissor = new Panel();
            buttonRemoverEmpresa = new Button();
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
            buttonRemoverMotorista = new Button();
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
            buttonSalvar = new Button();
            panelEmissor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).BeginInit();
            panelMotorista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMotoristas).BeginInit();
            SuspendLayout();
            // 
            // panelEmissor
            // 
            panelEmissor.BackColor = Color.FromArgb(27, 27, 27);
            panelEmissor.Controls.Add(buttonRemoverEmpresa);
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
            // buttonRemoverEmpresa
            // 
            buttonRemoverEmpresa.BackColor = Color.FromArgb(38, 38, 38);
            buttonRemoverEmpresa.FlatAppearance.BorderSize = 0;
            buttonRemoverEmpresa.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRemoverEmpresa.FlatStyle = FlatStyle.Flat;
            buttonRemoverEmpresa.Location = new Point(361, 80);
            buttonRemoverEmpresa.Name = "buttonRemoverEmpresa";
            buttonRemoverEmpresa.Size = new Size(90, 34);
            buttonRemoverEmpresa.TabIndex = 79;
            buttonRemoverEmpresa.Text = "Remover";
            buttonRemoverEmpresa.UseVisualStyleBackColor = false;
            buttonRemoverEmpresa.Click += RemoverEmpresa_ClickEvent;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEmpresas.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle3.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            panelMotorista.BackColor = Color.FromArgb(27, 27, 27);
            panelMotorista.Controls.Add(buttonRemoverMotorista);
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
            // buttonRemoverMotorista
            // 
            buttonRemoverMotorista.BackColor = Color.FromArgb(38, 38, 38);
            buttonRemoverMotorista.FlatAppearance.BorderSize = 0;
            buttonRemoverMotorista.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRemoverMotorista.FlatStyle = FlatStyle.Flat;
            buttonRemoverMotorista.Location = new Point(246, 80);
            buttonRemoverMotorista.Name = "buttonRemoverMotorista";
            buttonRemoverMotorista.Size = new Size(90, 34);
            buttonRemoverMotorista.TabIndex = 81;
            buttonRemoverMotorista.Text = "Remover";
            buttonRemoverMotorista.UseVisualStyleBackColor = false;
            buttonRemoverMotorista.Click += RemoverMotorista_ClickEvent;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle4.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewMotoristas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewMotoristas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewMotoristas.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle6.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewMotoristas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewMotoristas.RowTemplate.Height = 25;
            dataGridViewMotoristas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMotoristas.ShowCellErrors = false;
            dataGridViewMotoristas.ShowCellToolTips = false;
            dataGridViewMotoristas.ShowRowErrors = false;
            dataGridViewMotoristas.Size = new Size(341, 305);
            dataGridViewMotoristas.TabIndex = 35;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.FromArgb(38, 38, 38);
            buttonSalvar.Enabled = false;
            buttonSalvar.FlatAppearance.BorderSize = 0;
            buttonSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(695, 475);
            buttonSalvar.Margin = new Padding(5);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(100, 40);
            buttonSalvar.TabIndex = 43;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += Salvar_ClickEvent;
            // 
            // CadastrosViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(buttonSalvar);
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
        private Button buttonSalvar;
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
        private Button buttonRemoverEmpresa;
        private Button buttonRemoverMotorista;
    }
}
