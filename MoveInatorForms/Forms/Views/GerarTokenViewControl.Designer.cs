namespace MoveInatorForms.Forms.Views
{
    partial class GerarTokenViewControl
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
            textBoxUrl = new TextBox();
            labelNumeroDocumento = new Label();
            buttonRequest = new Button();
            checkedListBoxTipoViagem = new CheckedListBox();
            labelAPI = new Label();
            dataGridView = new DataGridView();
            comboBoxMotorista = new ComboBox();
            comboBoxEmpresa = new ComboBox();
            labelMotorista = new Label();
            labelEmpresa = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(27, 27, 27);
            panelSuperior.Controls.Add(comboBoxMotorista);
            panelSuperior.Controls.Add(comboBoxEmpresa);
            panelSuperior.Controls.Add(labelMotorista);
            panelSuperior.Controls.Add(labelEmpresa);
            panelSuperior.Controls.Add(textBoxUrl);
            panelSuperior.Controls.Add(labelNumeroDocumento);
            panelSuperior.Controls.Add(buttonRequest);
            panelSuperior.Controls.Add(checkedListBoxTipoViagem);
            panelSuperior.Controls.Add(labelAPI);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(800, 180);
            panelSuperior.TabIndex = 44;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(14, 112);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(400, 25);
            textBoxUrl.TabIndex = 32;
            // 
            // labelNumeroDocumento
            // 
            labelNumeroDocumento.AutoSize = true;
            labelNumeroDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroDocumento.ForeColor = SystemColors.ControlLightLight;
            labelNumeroDocumento.Location = new Point(14, 92);
            labelNumeroDocumento.Name = "labelNumeroDocumento";
            labelNumeroDocumento.Size = new Size(29, 17);
            labelNumeroDocumento.TabIndex = 31;
            labelNumeroDocumento.Text = "URL";
            // 
            // buttonRequest
            // 
            buttonRequest.BackColor = Color.FromArgb(38, 38, 38);
            buttonRequest.FlatAppearance.BorderSize = 0;
            buttonRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRequest.FlatStyle = FlatStyle.Flat;
            buttonRequest.Location = new Point(705, 140);
            buttonRequest.Name = "buttonRequest";
            buttonRequest.Size = new Size(90, 34);
            buttonRequest.TabIndex = 30;
            buttonRequest.Text = "Request";
            buttonRequest.UseVisualStyleBackColor = false;
            // 
            // checkedListBoxTipoViagem
            // 
            checkedListBoxTipoViagem.BackColor = Color.FromArgb(27, 27, 27);
            checkedListBoxTipoViagem.BorderStyle = BorderStyle.None;
            checkedListBoxTipoViagem.CheckOnClick = true;
            checkedListBoxTipoViagem.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoViagem.FormattingEnabled = true;
            checkedListBoxTipoViagem.Items.AddRange(new object[] { "Portal", "Mobile" });
            checkedListBoxTipoViagem.Location = new Point(14, 38);
            checkedListBoxTipoViagem.Name = "checkedListBoxTipoViagem";
            checkedListBoxTipoViagem.Size = new Size(97, 40);
            checkedListBoxTipoViagem.TabIndex = 3;
            checkedListBoxTipoViagem.ItemCheck += ResetListBoxAPI_ItemCheckEvent;
            // 
            // labelAPI
            // 
            labelAPI.AutoSize = true;
            labelAPI.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAPI.ForeColor = SystemColors.ControlLightLight;
            labelAPI.Location = new Point(14, 16);
            labelAPI.Name = "labelAPI";
            labelAPI.Size = new Size(29, 17);
            labelAPI.TabIndex = 2;
            labelAPI.Text = "API";
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
            dataGridView.TabIndex = 45;
            // 
            // comboBoxMotorista
            // 
            comboBoxMotorista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotorista.FormattingEnabled = true;
            comboBoxMotorista.Location = new Point(461, 112);
            comboBoxMotorista.Name = "comboBoxMotorista";
            comboBoxMotorista.Size = new Size(170, 25);
            comboBoxMotorista.TabIndex = 37;
            // 
            // comboBoxEmissor
            // 
            comboBoxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpresa.FormattingEnabled = true;
            comboBoxEmpresa.Location = new Point(461, 38);
            comboBoxEmpresa.Name = "comboBoxEmissor";
            comboBoxEmpresa.Size = new Size(170, 25);
            comboBoxEmpresa.TabIndex = 36;
            // 
            // labelMotorista
            // 
            labelMotorista.AutoSize = true;
            labelMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMotorista.ForeColor = SystemColors.ControlLightLight;
            labelMotorista.Location = new Point(461, 92);
            labelMotorista.Name = "labelMotorista";
            labelMotorista.Size = new Size(71, 17);
            labelMotorista.TabIndex = 35;
            labelMotorista.Text = "Motorista";
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelEmpresa.Location = new Point(461, 16);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(57, 17);
            labelEmpresa.TabIndex = 34;
            labelEmpresa.Text = "Empresa";
            // 
            // GerarTokenViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            Controls.Add(dataGridView);
            Controls.Add(panelSuperior);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkGray;
            Name = "GerarTokenViewControl";
            Size = new Size(800, 520);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSuperior;
        private CheckedListBox checkedListBoxTipoViagem;
        private Label labelAPI;
        protected DataGridView dataGridView;
        private Button buttonRequest;
        private TextBox textBoxUrl;
        private Label labelNumeroDocumento;
        private ComboBox comboBoxMotorista;
        private ComboBox comboBoxEmpresa;
        private Label labelMotorista;
        private Label labelEmpresa;
    }
}
