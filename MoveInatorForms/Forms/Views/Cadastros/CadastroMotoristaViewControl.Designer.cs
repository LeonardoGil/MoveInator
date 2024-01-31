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
            textBoxPassword = new TextBox();
            labelSenha = new Label();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelNomeMotorista = new Label();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Size = new Size(145, 33);
            labelTitulo.Text = "Motoristas";
            // 
            // buttonSalvar
            // 
            buttonSalvar.FlatAppearance.BorderSize = 0;
            buttonSalvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            // 
            // buttonRemover
            // 
            buttonRemover.FlatAppearance.BorderSize = 0;
            buttonRemover.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(145, 170);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(170, 25);
            textBoxPassword.TabIndex = 89;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.ForeColor = SystemColors.ControlLightLight;
            labelSenha.Location = new Point(145, 145);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(43, 17);
            labelSenha.TabIndex = 88;
            labelSenha.Text = "Senha";
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(10, 170);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(119, 25);
            maskedTextBoxCpfMotorista.TabIndex = 86;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.ForeColor = SystemColors.ControlLightLight;
            labelNomeMotorista.Location = new Point(10, 76);
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
            labelCpfMotorista.Location = new Point(10, 145);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(29, 17);
            labelCpfMotorista.TabIndex = 85;
            labelCpfMotorista.Text = "CPF";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(10, 98);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(305, 25);
            textBoxNomeMotorista.TabIndex = 84;
            // 
            // CadastroMotoristaViewModel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(textBoxPassword);
            Controls.Add(labelSenha);
            Controls.Add(maskedTextBoxCpfMotorista);
            Controls.Add(labelNomeMotorista);
            Controls.Add(labelCpfMotorista);
            Controls.Add(textBoxNomeMotorista);
            Name = "CadastroMotoristaViewModel";
            Controls.SetChildIndex(labelTitulo, 0);
            Controls.SetChildIndex(textBoxNomeMotorista, 0);
            Controls.SetChildIndex(labelCpfMotorista, 0);
            Controls.SetChildIndex(labelNomeMotorista, 0);
            Controls.SetChildIndex(maskedTextBoxCpfMotorista, 0);
            Controls.SetChildIndex(labelSenha, 0);
            Controls.SetChildIndex(textBoxPassword, 0);
            ((System.ComponentModel.ISupportInitialize)BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxPassword;
        private Label labelSenha;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelNomeMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
    }
}
