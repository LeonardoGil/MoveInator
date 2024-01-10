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
            panelEsquerdo = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panelEsquerdo
            // 
            panelEsquerdo.BackColor = Color.FromArgb(31, 31, 31);
            panelEsquerdo.Dock = DockStyle.Left;
            panelEsquerdo.Location = new Point(0, 0);
            panelEsquerdo.Name = "panelEsquerdo";
            panelEsquerdo.Size = new Size(390, 520);
            panelEsquerdo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(410, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 520);
            panel1.TabIndex = 1;
            // 
            // CadastrosViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(panel1);
            Controls.Add(panelEsquerdo);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkGray;
            Name = "CadastrosViewControl";
            Size = new Size(800, 520);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEsquerdo;
        private Panel panel1;
    }
}
