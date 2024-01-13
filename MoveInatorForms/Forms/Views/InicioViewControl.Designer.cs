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
            labelVersion = new Label();
            linkLabel = new LinkLabel();
            labelInformativa = new Label();
            panelView.SuspendLayout();
            SuspendLayout();
            // 
            // panelView
            // 
            panelView.BackColor = Color.FromArgb(31, 31, 31);
            panelView.Controls.Add(labelVersion);
            panelView.Controls.Add(linkLabel);
            panelView.Controls.Add(labelInformativa);
            panelView.Dock = DockStyle.Fill;
            panelView.Location = new Point(0, 0);
            panelView.Name = "panelView";
            panelView.Size = new Size(800, 520);
            panelView.TabIndex = 10;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.BackColor = Color.FromArgb(31, 31, 31);
            labelVersion.Cursor = Cursors.Hand;
            labelVersion.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelVersion.ForeColor = Color.Brown;
            labelVersion.Location = new Point(3, 501);
            labelVersion.Margin = new Padding(0);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(71, 17);
            labelVersion.TabIndex = 11;
            labelVersion.Text = "Version: ";
            labelVersion.Click += DownloadVersion_ClickEvent;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = SystemColors.HotTrack;
            linkLabel.Location = new Point(258, 263);
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
            labelInformativa.Location = new Point(268, 235);
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
            Size = new Size(800, 520);
            panelView.ResumeLayout(false);
            panelView.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelView;
        private Label labelVersion;
        private LinkLabel linkLabel;
        private Label labelInformativa;
    }
}
