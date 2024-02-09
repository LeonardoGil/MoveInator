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
            linkLabel = new LinkLabel();
            labelInformativa = new Label();
            SuspendLayout();
            // 
            // linkLabel
            // 
            linkLabel.Anchor = AnchorStyles.None;
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = SystemColors.HotTrack;
            linkLabel.Location = new Point(153, 306);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(295, 17);
            linkLabel.TabIndex = 3;
            linkLabel.TabStop = true;
            linkLabel.Text = "https://github.com/LeonardoGil/MoveInator";
            linkLabel.LinkClicked += OpenGitHub_LinkClickedEvent;
            // 
            // labelInformativa
            // 
            labelInformativa.Anchor = AnchorStyles.None;
            labelInformativa.AutoSize = true;
            labelInformativa.FlatStyle = FlatStyle.Flat;
            labelInformativa.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelInformativa.ForeColor = Color.LightSlateGray;
            labelInformativa.Location = new Point(163, 278);
            labelInformativa.Name = "labelInformativa";
            labelInformativa.Size = new Size(264, 21);
            labelInformativa.TabIndex = 2;
            labelInformativa.Text = "Considere apoiar o projeto 💪😁";
            // 
            // InicioViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabel);
            Controls.Add(labelInformativa);
            Name = "InicioViewControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel;
        private Label labelInformativa;
    }
}
