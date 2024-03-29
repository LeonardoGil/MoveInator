﻿namespace MoveInatorForms.Forms
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
            labelTitulo = new Label();
            labelSubTitulo = new Label();
            panelView = new Panel();
            panelLateral = new Panel();
            panelVersion = new Panel();
            labelVersion = new Label();
            buttonMotoristas = new Button();
            buttonNovidades = new Button();
            buttonEmpresas = new Button();
            buttonTokens = new Button();
            buttonImportacaoMDFe = new Button();
            buttonInicio = new Button();
            buttonImportacaoCSV = new Button();
            panelLateral.SuspendLayout();
            panelVersion.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.FromArgb(85, 35, 35);
            labelTitulo.Location = new Point(21, 18);
            labelTitulo.Margin = new Padding(7, 0, 7, 5);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(169, 37);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "MoveInator";
            // 
            // labelSubTitulo
            // 
            labelSubTitulo.AutoSize = true;
            labelSubTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelSubTitulo.ForeColor = Color.DarkGray;
            labelSubTitulo.Location = new Point(52, 51);
            labelSubTitulo.Margin = new Padding(0);
            labelSubTitulo.Name = "labelSubTitulo";
            labelSubTitulo.Size = new Size(95, 17);
            labelSubTitulo.TabIndex = 7;
            labelSubTitulo.Text = "Created by LAG";
            // 
            // panelView
            // 
            panelView.BackColor = Color.FromArgb(29, 29, 29);
            panelView.Dock = DockStyle.Fill;
            panelView.Location = new Point(200, 0);
            panelView.Margin = new Padding(0, 3, 0, 0);
            panelView.MinimumSize = new Size(600, 600);
            panelView.Name = "panelView";
            panelView.Size = new Size(600, 600);
            panelView.TabIndex = 9;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(17, 17, 17);
            panelLateral.Controls.Add(panelVersion);
            panelLateral.Controls.Add(buttonMotoristas);
            panelLateral.Controls.Add(buttonNovidades);
            panelLateral.Controls.Add(buttonEmpresas);
            panelLateral.Controls.Add(buttonTokens);
            panelLateral.Controls.Add(buttonImportacaoMDFe);
            panelLateral.Controls.Add(buttonInicio);
            panelLateral.Controls.Add(buttonImportacaoCSV);
            panelLateral.Controls.Add(labelSubTitulo);
            panelLateral.Controls.Add(labelTitulo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Margin = new Padding(0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(200, 600);
            panelLateral.TabIndex = 13;
            // 
            // panelVersion
            // 
            panelVersion.Controls.Add(labelVersion);
            panelVersion.Dock = DockStyle.Bottom;
            panelVersion.Location = new Point(0, 560);
            panelVersion.Name = "panelVersion";
            panelVersion.Size = new Size(200, 40);
            panelVersion.TabIndex = 16;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Cursor = Cursors.Hand;
            labelVersion.ForeColor = Color.Brown;
            labelVersion.Location = new Point(5, 19);
            labelVersion.Margin = new Padding(0);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(58, 17);
            labelVersion.TabIndex = 14;
            labelVersion.Text = "Version: ";
            // 
            // buttonMotoristas
            // 
            buttonMotoristas.FlatAppearance.BorderSize = 0;
            buttonMotoristas.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            buttonMotoristas.FlatStyle = FlatStyle.Flat;
            buttonMotoristas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMotoristas.ForeColor = Color.DarkGray;
            buttonMotoristas.Location = new Point(0, 360);
            buttonMotoristas.Margin = new Padding(0);
            buttonMotoristas.Name = "buttonMotoristas";
            buttonMotoristas.Size = new Size(200, 50);
            buttonMotoristas.TabIndex = 15;
            buttonMotoristas.Text = "Motoristas";
            buttonMotoristas.UseVisualStyleBackColor = true;
            buttonMotoristas.Click += LoadCadastroMotorista_ClickEvent;
            // 
            // buttonNovidades
            // 
            buttonNovidades.FlatAppearance.BorderSize = 0;
            buttonNovidades.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            buttonNovidades.FlatStyle = FlatStyle.Flat;
            buttonNovidades.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNovidades.ForeColor = Color.DarkGray;
            buttonNovidades.Location = new Point(0, 410);
            buttonNovidades.Margin = new Padding(0);
            buttonNovidades.Name = "buttonNovidades";
            buttonNovidades.Size = new Size(200, 50);
            buttonNovidades.TabIndex = 13;
            buttonNovidades.Text = "Novidades";
            buttonNovidades.UseVisualStyleBackColor = true;
            buttonNovidades.Click += LoadNovidades_ClickEvent;
            // 
            // buttonEmpresas
            // 
            buttonEmpresas.FlatAppearance.BorderSize = 0;
            buttonEmpresas.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            buttonEmpresas.FlatStyle = FlatStyle.Flat;
            buttonEmpresas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmpresas.ForeColor = Color.DarkGray;
            buttonEmpresas.Location = new Point(0, 310);
            buttonEmpresas.Margin = new Padding(0);
            buttonEmpresas.Name = "buttonEmpresas";
            buttonEmpresas.Size = new Size(200, 50);
            buttonEmpresas.TabIndex = 12;
            buttonEmpresas.Text = "Empresas";
            buttonEmpresas.UseVisualStyleBackColor = true;
            buttonEmpresas.Click += LoadCadastroEmpresa_ClickEvent;
            // 
            // buttonTokens
            // 
            buttonTokens.FlatAppearance.BorderSize = 0;
            buttonTokens.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            buttonTokens.FlatStyle = FlatStyle.Flat;
            buttonTokens.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTokens.ForeColor = Color.DarkGray;
            buttonTokens.Location = new Point(0, 260);
            buttonTokens.Margin = new Padding(0);
            buttonTokens.Name = "buttonTokens";
            buttonTokens.Size = new Size(200, 50);
            buttonTokens.TabIndex = 11;
            buttonTokens.Text = "Tokens";
            buttonTokens.UseVisualStyleBackColor = true;
            buttonTokens.Click += LoadTokens_ClickEvent;
            // 
            // buttonImportacaoMDFe
            // 
            buttonImportacaoMDFe.FlatAppearance.BorderSize = 0;
            buttonImportacaoMDFe.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            buttonImportacaoMDFe.FlatStyle = FlatStyle.Flat;
            buttonImportacaoMDFe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonImportacaoMDFe.ForeColor = Color.DarkGray;
            buttonImportacaoMDFe.Location = new Point(0, 210);
            buttonImportacaoMDFe.Margin = new Padding(0);
            buttonImportacaoMDFe.Name = "buttonImportacaoMDFe";
            buttonImportacaoMDFe.Size = new Size(200, 50);
            buttonImportacaoMDFe.TabIndex = 10;
            buttonImportacaoMDFe.Text = "MDFe";
            buttonImportacaoMDFe.UseVisualStyleBackColor = true;
            buttonImportacaoMDFe.Click += LoadMDFeSimples_ClickEvent;
            // 
            // buttonInicio
            // 
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInicio.ForeColor = Color.DarkGray;
            buttonInicio.Location = new Point(0, 110);
            buttonInicio.Margin = new Padding(0);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(200, 50);
            buttonInicio.TabIndex = 9;
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += LoadInicio_ClickEvent;
            // 
            // buttonImportacaoCSV
            // 
            buttonImportacaoCSV.FlatAppearance.BorderSize = 0;
            buttonImportacaoCSV.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            buttonImportacaoCSV.FlatStyle = FlatStyle.Flat;
            buttonImportacaoCSV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonImportacaoCSV.ForeColor = Color.DarkGray;
            buttonImportacaoCSV.Location = new Point(0, 160);
            buttonImportacaoCSV.Margin = new Padding(0);
            buttonImportacaoCSV.Name = "buttonImportacaoCSV";
            buttonImportacaoCSV.Size = new Size(200, 50);
            buttonImportacaoCSV.TabIndex = 8;
            buttonImportacaoCSV.Text = "CSV";
            buttonImportacaoCSV.UseVisualStyleBackColor = true;
            buttonImportacaoCSV.Click += LoadCSVSimples_ClickEvent;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(800, 600);
            Controls.Add(panelView);
            Controls.Add(panelLateral);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            MinimumSize = new Size(816, 639);
            Name = "MainForm";
            Opacity = 0.98D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MainForm_FormClosingEvent;
            MouseDown += SetPoint_MouseDownEvent;
            MouseMove += MoveForm_MouseMoveEvent;
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            panelVersion.ResumeLayout(false);
            panelVersion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelTitulo;
        private Label labelSubTitulo;
        private Panel panelView;
        private Panel panelLateral;
        private Button buttonImportacaoCSV;
        private Button buttonInicio;
        private Button buttonEmpresas;
        private Button buttonTokens;
        private Button buttonImportacaoMDFe;
        private Button buttonNovidades;
        private Label labelVersion;
        private Button buttonMotoristas;
        private Panel panelVersion;
    }
}