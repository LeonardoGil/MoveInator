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
            textBoxClientSecret = new TextBox();
            labelClientSecret = new Label();
            textBoxClientId = new TextBox();
            labelClientId = new Label();
            textBoxNomeRazaoSocial = new TextBox();
            labelEmissor = new Label();
            maskedTextBoxCnpjEmpresa = new MaskedTextBox();
            labelCnpjEmpresa = new Label();
            ((System.ComponentModel.ISupportInitialize)BindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Location = new Point(10, 23);
            labelTitulo.Text = "Empresas";
            // 
            // textBoxClientSecret
            // 
            textBoxClientSecret.Location = new Point(10, 217);
            textBoxClientSecret.Name = "textBoxClientSecret";
            textBoxClientSecret.Size = new Size(474, 25);
            textBoxClientSecret.TabIndex = 89;
            // 
            // labelClientSecret
            // 
            labelClientSecret.AutoSize = true;
            labelClientSecret.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientSecret.ForeColor = SystemColors.ControlLightLight;
            labelClientSecret.Location = new Point(10, 195);
            labelClientSecret.Name = "labelClientSecret";
            labelClientSecret.Size = new Size(99, 17);
            labelClientSecret.TabIndex = 88;
            labelClientSecret.Text = "Client Secret";
            // 
            // textBoxClientId
            // 
            textBoxClientId.Location = new Point(10, 157);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(474, 25);
            textBoxClientId.TabIndex = 87;
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientId.ForeColor = SystemColors.ControlLightLight;
            labelClientId.Location = new Point(10, 136);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(64, 17);
            labelClientId.TabIndex = 86;
            labelClientId.Text = "ClientId";
            // 
            // textBoxNomeRazaoSocial
            // 
            textBoxNomeRazaoSocial.Location = new Point(10, 96);
            textBoxNomeRazaoSocial.Name = "textBoxNomeRazaoSocial";
            textBoxNomeRazaoSocial.Size = new Size(306, 25);
            textBoxNomeRazaoSocial.TabIndex = 85;
            // 
            // labelEmissor
            // 
            labelEmissor.AutoSize = true;
            labelEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmissor.ForeColor = SystemColors.ControlLightLight;
            labelEmissor.Location = new Point(10, 75);
            labelEmissor.Name = "labelEmissor";
            labelEmissor.Size = new Size(92, 17);
            labelEmissor.TabIndex = 84;
            labelEmissor.Text = "Razao Social";
            // 
            // maskedTextBoxCnpjEmpresa
            // 
            maskedTextBoxCnpjEmpresa.Location = new Point(335, 96);
            maskedTextBoxCnpjEmpresa.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmpresa.Name = "maskedTextBoxCnpjEmpresa";
            maskedTextBoxCnpjEmpresa.Size = new Size(149, 25);
            maskedTextBoxCnpjEmpresa.TabIndex = 83;
            maskedTextBoxCnpjEmpresa.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmpresa.ValidatingType = typeof(DateTime);
            // 
            // labelCnpjEmpresa
            // 
            labelCnpjEmpresa.AutoSize = true;
            labelCnpjEmpresa.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelCnpjEmpresa.Location = new Point(335, 74);
            labelCnpjEmpresa.Name = "labelCnpjEmpresa";
            labelCnpjEmpresa.Size = new Size(36, 17);
            labelCnpjEmpresa.TabIndex = 82;
            labelCnpjEmpresa.Text = "CNPJ";
            // 
            // CadastroEmpresaViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(textBoxClientSecret);
            Controls.Add(labelClientSecret);
            Controls.Add(textBoxClientId);
            Controls.Add(labelClientId);
            Controls.Add(textBoxNomeRazaoSocial);
            Controls.Add(labelEmissor);
            Controls.Add(maskedTextBoxCnpjEmpresa);
            Controls.Add(labelCnpjEmpresa);
            Name = "CadastroEmpresaViewControl";
            Controls.SetChildIndex(labelCnpjEmpresa, 0);
            Controls.SetChildIndex(maskedTextBoxCnpjEmpresa, 0);
            Controls.SetChildIndex(labelEmissor, 0);
            Controls.SetChildIndex(textBoxNomeRazaoSocial, 0);
            Controls.SetChildIndex(labelClientId, 0);
            Controls.SetChildIndex(textBoxClientId, 0);
            Controls.SetChildIndex(labelClientSecret, 0);
            Controls.SetChildIndex(textBoxClientSecret, 0);
            Controls.SetChildIndex(buttonSalvar, 0);
            Controls.SetChildIndex(labelTitulo, 0);
            Controls.SetChildIndex(buttonAdicionar, 0);
            Controls.SetChildIndex(buttonRemover, 0);
            ((System.ComponentModel.ISupportInitialize)BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
