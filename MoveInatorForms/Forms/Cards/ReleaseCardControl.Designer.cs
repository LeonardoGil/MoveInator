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
            labelVersao.Font = new Font("MesloLGL NF", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelVersao.Location = new Point(10, 25);
            labelVersao.MaximumSize = new Size(165, 30);
            labelVersao.Name = "labelVersao";
            labelVersao.Size = new Size(93, 30);
            labelVersao.TabIndex = 0;
            labelVersao.Text = "Versao";
            labelVersao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.ForeColor = Color.DarkGray;
            labelDescricao.Location = new Point(5, 65);
            labelDescricao.MaximumSize = new Size(170, 370);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(106, 17);
            labelDescricao.TabIndex = 1;
            labelDescricao.Text = "labelDescricao";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("MesloLGL NF", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel.LinkColor = SystemColors.HotTrack;
            linkLabel.Location = new Point(5, 400);
            linkLabel.MaximumSize = new Size(170, 50);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(27, 14);
            linkLabel.TabIndex = 2;
            linkLabel.TabStop = true;
            linkLabel.Text = "Link";
            linkLabel.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel.LinkClicked += DownloadVersion_LinkClickedEvent;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.ForeColor = Color.DarkGray;
            labelData.Location = new Point(104, 4);
            labelData.MaximumSize = new Size(175, 380);
            labelData.Name = "labelData";
            labelData.Size = new Size(78, 17);
            labelData.TabIndex = 3;
            labelData.Text = "01/01/1990";
            // 
            // ReleaseCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            Controls.Add(labelData);
            Controls.Add(linkLabel);
            Controls.Add(labelDescricao);
            Controls.Add(labelVersao);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(5);
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
