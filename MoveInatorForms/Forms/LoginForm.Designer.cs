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
            textBoxServer = new TextBox();
            buttonConectar = new Button();
            buttonExit = new Button();
            textBoxDatabase = new TextBox();
            labelServer = new Label();
            labelDatabase = new Label();
            labelPassword = new Label();
            labelUser = new Label();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
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
            // textBoxServer
            // 
            textBoxServer.Location = new Point(12, 69);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(90, 23);
            textBoxServer.TabIndex = 1;
            // 
            // buttonConectar
            // 
            buttonConectar.FlatAppearance.BorderColor = Color.FromArgb(48, 48, 48);
            buttonConectar.FlatAppearance.BorderSize = 2;
            buttonConectar.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonConectar.FlatStyle = FlatStyle.Flat;
            buttonConectar.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConectar.ForeColor = SystemColors.ControlLightLight;
            buttonConectar.Location = new Point(226, 98);
            buttonConectar.Name = "buttonConectar";
            buttonConectar.Size = new Size(81, 40);
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
            buttonExit.Location = new Point(275, 9);
            buttonExit.Margin = new Padding(1);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(32, 22);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += Exit_ClickEvent;
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Location = new Point(12, 115);
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new Size(90, 23);
            textBoxDatabase.TabIndex = 4;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelServer.ForeColor = SystemColors.ControlLight;
            labelServer.Location = new Point(12, 49);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(50, 17);
            labelServer.TabIndex = 7;
            labelServer.Text = "Server";
            // 
            // labelDatabase
            // 
            labelDatabase.AutoSize = true;
            labelDatabase.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatabase.ForeColor = SystemColors.ControlLight;
            labelDatabase.Location = new Point(12, 95);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(64, 17);
            labelDatabase.TabIndex = 8;
            labelDatabase.Text = "Database";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.ControlLight;
            labelPassword.Location = new Point(117, 95);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(64, 17);
            labelPassword.TabIndex = 12;
            labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = SystemColors.ControlLight;
            labelUser.Location = new Point(117, 49);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(36, 17);
            labelUser.TabIndex = 11;
            labelUser.Text = "User";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(117, 115);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(90, 23);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(117, 69);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(90, 23);
            textBoxUser.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(316, 150);
            ControlBox = false;
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(labelDatabase);
            Controls.Add(labelServer);
            Controls.Add(textBoxDatabase);
            Controls.Add(buttonExit);
            Controls.Add(buttonConectar);
            Controls.Add(textBoxServer);
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
        private TextBox textBoxServer;
        private Button buttonConectar;
        private Button buttonExit;
        private TextBox textBoxDatabase;
        private Label labelServer;
        private Label labelDatabase;
        private Label labelPassword;
        private Label labelUser;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
    }
}