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
            buttonExit = new Button();
            labelTitulo = new Label();
            labelSubTitulo = new Label();
            panelView = new Panel();
            menuStrip = new MenuStrip();
            toolStripMenuItemGerarCSV = new ToolStripMenuItem();
            menuItemCsvSimples = new ToolStripMenuItem();
            labelInformativa = new Label();
            linkLabel = new LinkLabel();
            panelView.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(38, 38, 38);
            buttonExit.FlatAppearance.BorderColor = Color.FromArgb(48, 48, 48);
            buttonExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("MesloLGL NF", 6F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLight;
            buttonExit.Location = new Point(763, 5);
            buttonExit.Margin = new Padding(1);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(32, 22);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += Exit_ClickEvent;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(10, 10, 10);
            labelTitulo.Font = new Font("MesloLGL NF", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(9, 27);
            labelTitulo.Margin = new Padding(7, 0, 7, 5);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(212, 50);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "MoveInator";
            // 
            // labelSubTitulo
            // 
            labelSubTitulo.AutoSize = true;
            labelSubTitulo.BackColor = Color.FromArgb(10, 10, 10);
            labelSubTitulo.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelSubTitulo.ForeColor = SystemColors.ControlLightLight;
            labelSubTitulo.Location = new Point(76, 72);
            labelSubTitulo.Margin = new Padding(0);
            labelSubTitulo.Name = "labelSubTitulo";
            labelSubTitulo.Size = new Size(122, 21);
            labelSubTitulo.TabIndex = 7;
            labelSubTitulo.Text = "Created by LAG";
            // 
            // panelView
            // 
            panelView.BackColor = Color.FromArgb(31, 31, 31);
            panelView.Controls.Add(linkLabel);
            panelView.Controls.Add(labelInformativa);
            panelView.Dock = DockStyle.Bottom;
            panelView.Location = new Point(0, 100);
            panelView.Name = "panelView";
            panelView.Size = new Size(800, 500);
            panelView.TabIndex = 9;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(10, 10, 10);
            menuStrip.Dock = DockStyle.None;
            menuStrip.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemGerarCSV });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(211, 25);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItemGerarCSV
            // 
            toolStripMenuItemGerarCSV.BackColor = Color.FromArgb(31, 31, 31);
            toolStripMenuItemGerarCSV.DropDownItems.AddRange(new ToolStripItem[] { menuItemCsvSimples });
            toolStripMenuItemGerarCSV.ForeColor = SystemColors.ControlLightLight;
            toolStripMenuItemGerarCSV.Name = "toolStripMenuItemGerarCSV";
            toolStripMenuItemGerarCSV.Size = new Size(83, 21);
            toolStripMenuItemGerarCSV.Text = "Gerar CSV";
            // 
            // menuItemCsvSimples
            // 
            menuItemCsvSimples.BackColor = Color.FromArgb(31, 31, 31);
            menuItemCsvSimples.Name = "menuItemCsvSimples";
            menuItemCsvSimples.Size = new Size(180, 22);
            menuItemCsvSimples.Text = "CSV Simples";
            menuItemCsvSimples.Click += LoadCSVSimples_ClickEvent;
            // 
            // labelInformativa
            // 
            labelInformativa.AutoSize = true;
            labelInformativa.BackColor = Color.FromArgb(31, 31, 31);
            labelInformativa.FlatStyle = FlatStyle.Flat;
            labelInformativa.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelInformativa.Location = new Point(268, 230);
            labelInformativa.Name = "labelInformativa";
            labelInformativa.Size = new Size(264, 21);
            labelInformativa.TabIndex = 0;
            labelInformativa.Text = "Considere apoiar o projeto 💪😁";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = SystemColors.HotTrack;
            linkLabel.Location = new Point(255, 254);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(295, 17);
            linkLabel.TabIndex = 1;
            linkLabel.TabStop = true;
            linkLabel.Text = "https://github.com/LeonardoGil/MoveInator";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(panelView);
            Controls.Add(buttonExit);
            Controls.Add(labelTitulo);
            Controls.Add(labelSubTitulo);
            Controls.Add(menuStrip);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            MouseDown += SetPoint_MouseDownEvent;
            MouseMove += MoveForm_MouseMoveEvent;
            panelView.ResumeLayout(false);
            panelView.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Label labelTitulo;
        private Label labelSubTitulo;
        private Panel panelView;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemGerarCSV;
        private ToolStripMenuItem menuItemCsvSimples;
        private Label labelInformativa;
        private LinkLabel linkLabel;
    }
}