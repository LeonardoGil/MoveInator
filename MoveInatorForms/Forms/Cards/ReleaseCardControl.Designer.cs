namespace MoveInatorForms.Forms.Cards
{
    partial class ReleaseCardControl
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
            labelVersao = new Label();
            labelDescricao = new Label();
            linkLabel = new LinkLabel();
            labelData = new Label();
            SuspendLayout();
            // 
            // labelVersao
            // 
            labelVersao.AutoSize = true;
            labelVersao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelVersao.Location = new Point(10, 22);
            labelVersao.MaximumSize = new Size(165, 26);
            labelVersao.Name = "labelVersao";
            labelVersao.Size = new Size(77, 26);
            labelVersao.TabIndex = 0;
            labelVersao.Text = "Versao";
            labelVersao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.ForeColor = Color.DarkGray;
            labelDescricao.Location = new Point(10, 60);
            labelDescricao.MaximumSize = new Size(170, 326);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(83, 15);
            labelDescricao.TabIndex = 1;
            labelDescricao.Text = "labelDescricao";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel.LinkColor = SystemColors.HotTrack;
            linkLabel.Location = new Point(5, 400);
            linkLabel.MaximumSize = new Size(170, 44);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(28, 13);
            linkLabel.TabIndex = 2;
            linkLabel.TabStop = true;
            linkLabel.Text = "Link";
            linkLabel.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel.LinkClicked += DownloadVersion_LinkClickedEvent;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.ForeColor = Color.DarkGray;
            labelData.Location = new Point(113, 5);
            labelData.MaximumSize = new Size(175, 335);
            labelData.Name = "labelData";
            labelData.Size = new Size(63, 13);
            labelData.TabIndex = 3;
            labelData.Text = "01/01/1990";
            // 
            // ReleaseCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            Controls.Add(labelData);
            Controls.Add(linkLabel);
            Controls.Add(labelDescricao);
            Controls.Add(labelVersao);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(5, 4, 5, 4);
            Name = "ReleaseCardControl";
            Size = new Size(180, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVersao;
        private Label labelDescricao;
        private LinkLabel linkLabel;
        private Label labelData;
    }
}
