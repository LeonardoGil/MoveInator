namespace MoveInatorForms.Forms.Views
{
    partial class GerarMDFeSimplesViewControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelSuperior = new Panel();
            dataGridView = new DataGridView();
            textBoxDiretorio = new TextBox();
            labelDiretorio = new Label();
            buttonGerarMDFe = new Button();
            buttonLimparViagens = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(27, 27, 27);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(800, 180);
            panelSuperior.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle4.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 188);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle6.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(800, 280);
            dataGridView.TabIndex = 34;
            // 
            // textBoxDiretorio
            // 
            textBoxDiretorio.Location = new Point(4, 489);
            textBoxDiretorio.Name = "textBoxDiretorio";
            textBoxDiretorio.Size = new Size(391, 25);
            textBoxDiretorio.TabIndex = 48;
            // 
            // labelDiretorio
            // 
            labelDiretorio.AutoSize = true;
            labelDiretorio.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiretorio.ForeColor = SystemColors.ControlLightLight;
            labelDiretorio.Location = new Point(4, 471);
            labelDiretorio.Name = "labelDiretorio";
            labelDiretorio.Size = new Size(71, 17);
            labelDiretorio.TabIndex = 49;
            labelDiretorio.Text = "Diretório";
            // 
            // buttonGerarMDFe
            // 
            buttonGerarMDFe.BackColor = Color.FromArgb(38, 38, 38);
            buttonGerarMDFe.Enabled = false;
            buttonGerarMDFe.FlatAppearance.BorderSize = 0;
            buttonGerarMDFe.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonGerarMDFe.FlatStyle = FlatStyle.Flat;
            buttonGerarMDFe.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarMDFe.Location = new Point(695, 475);
            buttonGerarMDFe.Margin = new Padding(5);
            buttonGerarMDFe.Name = "buttonGerarMDFe";
            buttonGerarMDFe.Size = new Size(100, 40);
            buttonGerarMDFe.TabIndex = 46;
            buttonGerarMDFe.Text = "Gerar MDFe";
            buttonGerarMDFe.UseVisualStyleBackColor = false;
            // 
            // buttonLimparViagens
            // 
            buttonLimparViagens.BackColor = Color.FromArgb(38, 38, 38);
            buttonLimparViagens.Enabled = false;
            buttonLimparViagens.FlatAppearance.BorderSize = 0;
            buttonLimparViagens.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonLimparViagens.FlatStyle = FlatStyle.Flat;
            buttonLimparViagens.Font = new Font("MesloLGL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimparViagens.Location = new Point(590, 475);
            buttonLimparViagens.Margin = new Padding(5);
            buttonLimparViagens.Name = "buttonLimparViagens";
            buttonLimparViagens.Size = new Size(100, 40);
            buttonLimparViagens.TabIndex = 47;
            buttonLimparViagens.Text = "Limpar";
            buttonLimparViagens.UseVisualStyleBackColor = false;
            // 
            // GerarMDFeSimplesViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(textBoxDiretorio);
            Controls.Add(dataGridView);
            Controls.Add(labelDiretorio);
            Controls.Add(panelSuperior);
            Controls.Add(buttonGerarMDFe);
            Controls.Add(buttonLimparViagens);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Name = "GerarMDFeSimplesViewControl";
            Size = new Size(800, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        protected DataGridView dataGridView;
        private TextBox textBoxDiretorio;
        private Label labelDiretorio;
        private Button buttonGerarMDFe;
        private Button buttonLimparViagens;
    }
}
