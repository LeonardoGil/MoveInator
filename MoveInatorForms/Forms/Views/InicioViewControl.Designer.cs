namespace MoveInatorForms.Forms.Views
{
    partial class InicioViewControl
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
            panelView = new Panel();
            linkLabel = new LinkLabel();
            labelInformativa = new Label();
            panelView.SuspendLayout();
            SuspendLayout();
            // 
            // panelView
            // 
            panelView.BackColor = Color.FromArgb(31, 31, 31);
            panelView.Controls.Add(linkLabel);
            panelView.Controls.Add(labelInformativa);
            panelView.Dock = DockStyle.Fill;
            panelView.Location = new Point(0, 0);
            panelView.Name = "panelView";
            panelView.Size = new Size(600, 600);
            panelView.TabIndex = 10;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = SystemColors.HotTrack;
            linkLabel.Location = new Point(158, 290);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(295, 17);
            linkLabel.TabIndex = 1;
            linkLabel.TabStop = true;
            linkLabel.Text = "https://github.com/LeonardoGil/MoveInator";
            linkLabel.LinkClicked += OpenGitHub_LinkClickedEvent;
            // 
            // labelInformativa
            // 
            labelInformativa.AutoSize = true;
            labelInformativa.BackColor = Color.FromArgb(31, 31, 31);
            labelInformativa.FlatStyle = FlatStyle.Flat;
            labelInformativa.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelInformativa.ForeColor = Color.LightSlateGray;
            labelInformativa.Location = new Point(168, 262);
            labelInformativa.Name = "labelInformativa";
            labelInformativa.Size = new Size(264, 21);
            labelInformativa.TabIndex = 0;
            labelInformativa.Text = "Considere apoiar o projeto 💪😁";
            // 
            // InicioViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelView);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "InicioViewControl";
            Size = new Size(600, 600);
            panelView.ResumeLayout(false);
            panelView.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelView;
        private LinkLabel linkLabel;
        private Label labelInformativa;
    }
}
