namespace MoveInatorForms.Forms
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            textBoxConnectionString = new TextBox();
            buttonConectar = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MesloLGL NF", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = SystemColors.ControlLight;
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(242, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Bem vindo ao MoveInator";
            // 
            // textBoxConnectionString
            // 
            textBoxConnectionString.Location = new Point(12, 64);
            textBoxConnectionString.Name = "textBoxConnectionString";
            textBoxConnectionString.Size = new Size(326, 23);
            textBoxConnectionString.TabIndex = 1;
            // 
            // buttonConectar
            // 
            buttonConectar.FlatAppearance.BorderColor = Color.FromArgb(48, 48, 48);
            buttonConectar.FlatAppearance.BorderSize = 2;
            buttonConectar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonConectar.FlatStyle = FlatStyle.Flat;
            buttonConectar.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConectar.ForeColor = SystemColors.ControlLightLight;
            buttonConectar.Location = new Point(258, 98);
            buttonConectar.Name = "buttonConectar";
            buttonConectar.Size = new Size(80, 40);
            buttonConectar.TabIndex = 2;
            buttonConectar.Text = "Conectar";
            buttonConectar.UseVisualStyleBackColor = true;
            buttonConectar.Click += Conectar_ClickEvent;
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderColor = Color.FromArgb(48, 48, 48);
            buttonExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("MesloLGL NF", 6F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLight;
            buttonExit.Location = new Point(308, 9);
            buttonExit.Margin = new Padding(1);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(32, 22);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += Exit_ClickEvent;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(350, 150);
            ControlBox = false;
            Controls.Add(buttonExit);
            Controls.Add(buttonConectar);
            Controls.Add(textBoxConnectionString);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBoxConnectionString;
        private Button buttonConectar;
        private Button buttonExit;
    }
}