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
            linkLabel = new LinkLabel();
            labelInformativa = new Label();
            menuStrip = new MenuStrip();
            menuImportacao = new ToolStripMenuItem();
            menuItemCsvSimples = new ToolStripMenuItem();
            menuItemMDFeSimples = new ToolStripMenuItem();
            stripMenuCadastros = new ToolStripMenuItem();
            labelVersion = new Label();
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
            labelTitulo.ForeColor = Color.FromArgb(85, 35, 35);
            labelTitulo.Location = new Point(294, 5);
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
            labelSubTitulo.ForeColor = Color.DarkGray;
            labelSubTitulo.Location = new Point(338, 51);
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
            panelView.Location = new Point(0, 80);
            panelView.Name = "panelView";
            panelView.Size = new Size(800, 520);
            panelView.TabIndex = 9;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = SystemColors.HotTrack;
            linkLabel.Location = new Point(255, 245);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(295, 17);
            linkLabel.TabIndex = 1;
            linkLabel.TabStop = true;
            linkLabel.Text = "https://github.com/LeonardoGil/MoveInator";
            // 
            // labelInformativa
            // 
            labelInformativa.AutoSize = true;
            labelInformativa.BackColor = Color.FromArgb(31, 31, 31);
            labelInformativa.FlatStyle = FlatStyle.Flat;
            labelInformativa.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelInformativa.ForeColor = Color.LightSlateGray;
            labelInformativa.Location = new Point(268, 221);
            labelInformativa.Name = "labelInformativa";
            labelInformativa.Size = new Size(264, 21);
            labelInformativa.TabIndex = 0;
            labelInformativa.Text = "Considere apoiar o projeto 💪😁";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(10, 10, 10);
            menuStrip.Dock = DockStyle.None;
            menuStrip.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuImportacao, stripMenuCadastros });
            menuStrip.Location = new Point(595, 47);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(4, 3, 0, 2);
            menuStrip.Size = new Size(204, 30);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "menuStrip";
            // 
            // menuImportacao
            // 
            menuImportacao.BackColor = Color.FromArgb(31, 31, 31);
            menuImportacao.DropDownItems.AddRange(new ToolStripItem[] { menuItemCsvSimples, menuItemMDFeSimples });
            menuImportacao.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            menuImportacao.ForeColor = Color.DarkGray;
            menuImportacao.Name = "menuImportacao";
            menuImportacao.Size = new Size(102, 25);
            menuImportacao.Text = "Importação";
            // 
            // menuItemCsvSimples
            // 
            menuItemCsvSimples.BackColor = Color.FromArgb(31, 31, 31);
            menuItemCsvSimples.ForeColor = Color.DarkGray;
            menuItemCsvSimples.Name = "menuItemCsvSimples";
            menuItemCsvSimples.Size = new Size(184, 26);
            menuItemCsvSimples.Text = "CSV Simples";
            menuItemCsvSimples.Click += LoadCSVSimples_ClickEvent;
            // 
            // menuItemMDFeSimples
            // 
            menuItemMDFeSimples.BackColor = Color.FromArgb(31, 31, 31);
            menuItemMDFeSimples.ForeColor = Color.DarkGray;
            menuItemMDFeSimples.Name = "menuItemMDFeSimples";
            menuItemMDFeSimples.Size = new Size(184, 26);
            menuItemMDFeSimples.Text = "MDF-e Simples";
            menuItemMDFeSimples.Click += LoadMDFeSimples_ClickEvent;
            // 
            // stripMenuCadastros
            // 
            stripMenuCadastros.BackColor = Color.FromArgb(31, 31, 31);
            stripMenuCadastros.ForeColor = Color.DarkGray;
            stripMenuCadastros.Margin = new Padding(2, 0, 0, 0);
            stripMenuCadastros.Name = "stripMenuCadastros";
            stripMenuCadastros.Size = new Size(94, 25);
            stripMenuCadastros.Text = "Cadastros";
            stripMenuCadastros.Click += LoadCadastros_ClickEvent;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.BackColor = Color.FromArgb(10, 10, 10);
            labelVersion.Font = new Font("MesloLGL NF", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelVersion.ForeColor = Color.FromArgb(128, 0, 3);
            labelVersion.Location = new Point(2, 5);
            labelVersion.Margin = new Padding(0);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(52, 14);
            labelVersion.TabIndex = 11;
            labelVersion.Text = "Version: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(labelVersion);
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
        private ToolStripMenuItem menuImportacao;
        private ToolStripMenuItem menuItemCsvSimples;
        private Label labelInformativa;
        private LinkLabel linkLabel;
        private ToolStripMenuItem menuItemMDFeSimples;
        private ToolStripMenuItem stripMenuCadastros;
        private Label labelVersion;
    }
}