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
            menuStripDireita = new MenuStrip();
            menuImportacao = new ToolStripMenuItem();
            menuItemCsvSimples = new ToolStripMenuItem();
            menuItemMDFeSimples = new ToolStripMenuItem();
            menuCadastros = new ToolStripMenuItem();
            menuStripEsquerda = new MenuStrip();
            menuInicio = new ToolStripMenuItem();
            menuNovidades = new ToolStripMenuItem();
            menuStripDireita.SuspendLayout();
            menuStripEsquerda.SuspendLayout();
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
            panelView.Dock = DockStyle.Bottom;
            panelView.Location = new Point(0, 80);
            panelView.Name = "panelView";
            panelView.Size = new Size(800, 520);
            panelView.TabIndex = 9;
            // 
            // menuStripDireita
            // 
            menuStripDireita.BackColor = Color.FromArgb(10, 10, 10);
            menuStripDireita.Dock = DockStyle.None;
            menuStripDireita.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            menuStripDireita.Items.AddRange(new ToolStripItem[] { menuImportacao, menuCadastros });
            menuStripDireita.Location = new Point(594, 47);
            menuStripDireita.Name = "menuStripDireita";
            menuStripDireita.Padding = new Padding(4, 3, 0, 2);
            menuStripDireita.Size = new Size(205, 30);
            menuStripDireita.TabIndex = 10;
            menuStripDireita.Text = "menuStrip";
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
            // menuCadastros
            // 
            menuCadastros.BackColor = Color.FromArgb(31, 31, 31);
            menuCadastros.ForeColor = Color.DarkGray;
            menuCadastros.Margin = new Padding(3, 0, 0, 0);
            menuCadastros.Name = "menuCadastros";
            menuCadastros.Size = new Size(94, 25);
            menuCadastros.Text = "Cadastros";
            menuCadastros.Click += LoadCadastros_ClickEvent;
            // 
            // menuStripEsquerda
            // 
            menuStripEsquerda.BackColor = Color.FromArgb(10, 10, 10);
            menuStripEsquerda.Dock = DockStyle.None;
            menuStripEsquerda.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            menuStripEsquerda.Items.AddRange(new ToolStripItem[] { menuInicio, menuNovidades });
            menuStripEsquerda.Location = new Point(-1, 48);
            menuStripEsquerda.Name = "menuStripEsquerda";
            menuStripEsquerda.Size = new Size(295, 29);
            menuStripEsquerda.TabIndex = 12;
            // 
            // menuInicio
            // 
            menuInicio.BackColor = Color.FromArgb(31, 31, 31);
            menuInicio.ForeColor = Color.DarkGray;
            menuInicio.Name = "menuInicio";
            menuInicio.Size = new Size(70, 25);
            menuInicio.Text = "Inicio";
            menuInicio.Click += LoadInicio_ClickEvent;
            // 
            // menuNovidades
            // 
            menuNovidades.BackColor = Color.FromArgb(31, 31, 31);
            menuNovidades.ForeColor = Color.DarkGray;
            menuNovidades.Margin = new Padding(3, 0, 0, 0);
            menuNovidades.Name = "menuNovidades";
            menuNovidades.Size = new Size(94, 25);
            menuNovidades.Text = "Novidades";
            menuNovidades.Click += LoadNovidades_ClickEvent;
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
            Controls.Add(menuStripDireita);
            Controls.Add(menuStripEsquerda);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripDireita;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            MouseDown += SetPoint_MouseDownEvent;
            MouseMove += MoveForm_MouseMoveEvent;
            menuStripDireita.ResumeLayout(false);
            menuStripDireita.PerformLayout();
            menuStripEsquerda.ResumeLayout(false);
            menuStripEsquerda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Label labelTitulo;
        private Label labelSubTitulo;
        private Panel panelView;
        private MenuStrip menuStripDireita;
        private ToolStripMenuItem menuImportacao;
        private ToolStripMenuItem menuItemCsvSimples;
        private ToolStripMenuItem menuItemMDFeSimples;
        private ToolStripMenuItem menuCadastros;
        private MenuStrip menuStripEsquerda;
        private ToolStripMenuItem menuInicio;
        private ToolStripMenuItem menuNovidades;
    }
}