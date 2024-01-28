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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            comboBoxUrls = new ComboBox();
            comboBoxMotorista = new ComboBox();
            comboBoxEmpresa = new ComboBox();
            labelMotorista = new Label();
            labelEmpresa = new Label();
            labelNumeroDocumento = new Label();
            buttonRequest = new Button();
            checkedListBoxAPI = new CheckedListBox();
            labelAPI = new Label();
            dataGridView = new DataGridView();
            backgroundWorkerRequest = new System.ComponentModel.BackgroundWorker();
            labelTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUrls
            // 
            comboBoxUrls.FormattingEnabled = true;
            comboBoxUrls.Location = new Point(10, 168);
            comboBoxUrls.Name = "comboBoxUrls";
            comboBoxUrls.Size = new Size(392, 25);
            comboBoxUrls.TabIndex = 38;
            // 
            // comboBoxMotorista
            // 
            comboBoxMotorista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotorista.FormattingEnabled = true;
            comboBoxMotorista.Location = new Point(420, 168);
            comboBoxMotorista.Margin = new Padding(3, 3, 10, 3);
            comboBoxMotorista.Name = "comboBoxMotorista";
            comboBoxMotorista.Size = new Size(170, 25);
            comboBoxMotorista.TabIndex = 37;
            // 
            // comboBoxEmpresa
            // 
            comboBoxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpresa.FormattingEnabled = true;
            comboBoxEmpresa.Location = new Point(420, 98);
            comboBoxEmpresa.Margin = new Padding(3, 3, 10, 3);
            comboBoxEmpresa.Name = "comboBoxEmpresa";
            comboBoxEmpresa.Size = new Size(170, 25);
            comboBoxEmpresa.TabIndex = 36;
            // 
            // labelMotorista
            // 
            labelMotorista.AutoSize = true;
            labelMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMotorista.ForeColor = SystemColors.ControlLightLight;
            labelMotorista.Location = new Point(420, 148);
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
            labelEmpresa.Location = new Point(420, 76);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(57, 17);
            labelEmpresa.TabIndex = 34;
            labelEmpresa.Text = "Empresa";
            // 
            // labelNumeroDocumento
            // 
            labelNumeroDocumento.AutoSize = true;
            labelNumeroDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroDocumento.ForeColor = SystemColors.ControlLightLight;
            labelNumeroDocumento.Location = new Point(10, 148);
            labelNumeroDocumento.Name = "labelNumeroDocumento";
            labelNumeroDocumento.Size = new Size(29, 17);
            labelNumeroDocumento.TabIndex = 31;
            labelNumeroDocumento.Text = "URL";
            // 
            // buttonRequest
            // 
            buttonRequest.FlatAppearance.BorderSize = 0;
            buttonRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRequest.FlatStyle = FlatStyle.Flat;
            buttonRequest.Font = new Font("MesloLGL NF", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRequest.ForeColor = SystemColors.ControlLightLight;
            buttonRequest.Image = Properties.Resources.requisicao_16;
            buttonRequest.ImageAlign = ContentAlignment.TopLeft;
            buttonRequest.Location = new Point(500, 270);
            buttonRequest.Margin = new Padding(0, 3, 0, 3);
            buttonRequest.Name = "buttonRequest";
            buttonRequest.Size = new Size(100, 27);
            buttonRequest.TabIndex = 30;
            buttonRequest.Text = "Solicitar";
            buttonRequest.TextAlign = ContentAlignment.BottomRight;
            buttonRequest.UseVisualStyleBackColor = false;
            buttonRequest.Click += Request_ClickEvent;
            // 
            // checkedListBoxAPI
            // 
            checkedListBoxAPI.BackColor = Color.FromArgb(31, 31, 31);
            checkedListBoxAPI.BorderStyle = BorderStyle.None;
            checkedListBoxAPI.CheckOnClick = true;
            checkedListBoxAPI.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxAPI.FormattingEnabled = true;
            checkedListBoxAPI.Items.AddRange(new object[] { "Portal", "Mobile" });
            checkedListBoxAPI.Location = new Point(10, 98);
            checkedListBoxAPI.Name = "checkedListBoxAPI";
            checkedListBoxAPI.Size = new Size(97, 40);
            checkedListBoxAPI.TabIndex = 3;
            checkedListBoxAPI.ItemCheck += ResetListBoxAPI_ItemCheckEvent;
            // 
            // labelAPI
            // 
            labelAPI.AutoSize = true;
            labelAPI.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAPI.ForeColor = SystemColors.ControlLightLight;
            labelAPI.Location = new Point(10, 76);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 300);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle3.Font = new Font("MesloLGL NF", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(600, 300);
            dataGridView.TabIndex = 45;
            // 
            // backgroundWorkerRequest
            // 
            backgroundWorkerRequest.DoWork += Request_DoWorkEvent;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MesloLGL NF", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.Location = new Point(10, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(93, 33);
            labelTitulo.TabIndex = 47;
            labelTitulo.Text = "Tokens";
            // 
            // GerarTokenViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTitulo);
            Controls.Add(comboBoxUrls);
            Controls.Add(dataGridView);
            Controls.Add(comboBoxMotorista);
            Controls.Add(comboBoxEmpresa);
            Controls.Add(labelAPI);
            Controls.Add(labelMotorista);
            Controls.Add(checkedListBoxAPI);
            Controls.Add(labelEmpresa);
            Controls.Add(buttonRequest);
            Controls.Add(labelNumeroDocumento);
            Name = "GerarTokenViewControl";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBoxAPI;
        private Label labelAPI;
        protected DataGridView dataGridView;
        private Button buttonRequest;
        private Label labelNumeroDocumento;
        private ComboBox comboBoxMotorista;
        private ComboBox comboBoxEmpresa;
        private Label labelMotorista;
        private Label labelEmpresa;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRequest;
        private ComboBox comboBoxUrls;
        private Label labelTitulo;
    }
}
