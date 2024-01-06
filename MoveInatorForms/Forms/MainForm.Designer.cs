namespace MoveInatorForms.Forms
{
    partial class MainForm
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
            panelView = new Panel();
            buttonExit = new Button();
            labelTitulo = new Label();
            labelSubTitulo = new Label();
            SuspendLayout();
            // 
            // panelView
            // 
            panelView.BackColor = Color.Red;
            panelView.Location = new Point(0, 80);
            panelView.Margin = new Padding(0);
            panelView.Name = "panelView";
            panelView.Size = new Size(800, 520);
            panelView.TabIndex = 9;
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderColor = Color.FromArgb(48, 48, 48);
            buttonExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("MesloLGL NF", 6F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLight;
            buttonExit.Location = new Point(760, 8);
            buttonExit.Margin = new Padding(1);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(32, 22);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += Exit_ClickEvent;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MesloLGL NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(16, 9);
            labelTitulo.Margin = new Padding(7, 0, 7, 5);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(178, 42);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "MoveInator";
            // 
            // labelSubTitulo
            // 
            labelSubTitulo.AutoSize = true;
            labelSubTitulo.Font = new Font("MesloLGL NF", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelSubTitulo.Location = new Point(20, 48);
            labelSubTitulo.Margin = new Padding(0);
            labelSubTitulo.Name = "labelSubTitulo";
            labelSubTitulo.Size = new Size(106, 18);
            labelSubTitulo.TabIndex = 7;
            labelSubTitulo.Text = "Created by LAG";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(panelView);
            Controls.Add(buttonExit);
            Controls.Add(labelTitulo);
            Controls.Add(labelSubTitulo);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            MouseDown += SetPoint_MouseDownEvent;
            MouseMove += MoveForm_MouseMoveEvent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelView;
        private Button buttonExit;
        private Label labelTitulo;
        private Label labelSubTitulo;
    }
}