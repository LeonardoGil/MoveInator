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
            tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxUrls
            // 
            comboBoxUrls.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxUrls.FormattingEnabled = true;
            comboBoxUrls.Location = new Point(20, 185);
            comboBoxUrls.Margin = new Padding(20, 0, 5, 0);
            comboBoxUrls.Name = "comboBoxUrls";
            comboBoxUrls.Size = new Size(302, 25);
            comboBoxUrls.TabIndex = 38;
            // 
            // comboBoxMotorista
            // 
            comboBoxMotorista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMotorista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotorista.FormattingEnabled = true;
            comboBoxMotorista.Location = new Point(332, 185);
            comboBoxMotorista.Margin = new Padding(5, 0, 20, 0);
            comboBoxMotorista.Name = "comboBoxMotorista";
            comboBoxMotorista.Size = new Size(248, 25);
            comboBoxMotorista.TabIndex = 37;
            // 
            // comboBoxEmpresa
            // 
            comboBoxEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpresa.FormattingEnabled = true;
            comboBoxEmpresa.Location = new Point(332, 77);
            comboBoxEmpresa.Margin = new Padding(5, 0, 20, 0);
            comboBoxEmpresa.Name = "comboBoxEmpresa";
            comboBoxEmpresa.Size = new Size(248, 25);
            comboBoxEmpresa.TabIndex = 36;
            // 
            // labelMotorista
            // 
            labelMotorista.AutoSize = true;
            labelMotorista.ForeColor = SystemColors.ControlLightLight;
            labelMotorista.Location = new Point(332, 163);
            labelMotorista.Margin = new Padding(5, 5, 0, 5);
            labelMotorista.Name = "labelMotorista";
            labelMotorista.Size = new Size(65, 17);
            labelMotorista.TabIndex = 35;
            labelMotorista.Text = "Motorista";
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.ForeColor = SystemColors.ControlLightLight;
            labelEmpresa.Location = new Point(332, 55);
            labelEmpresa.Margin = new Padding(5, 5, 0, 5);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(59, 17);
            labelEmpresa.TabIndex = 34;
            labelEmpresa.Text = "Empresa";
            // 
            // labelNumeroDocumento
            // 
            labelNumeroDocumento.AutoSize = true;
            labelNumeroDocumento.ForeColor = SystemColors.ControlLightLight;
            labelNumeroDocumento.Location = new Point(20, 163);
            labelNumeroDocumento.Margin = new Padding(20, 5, 0, 5);
            labelNumeroDocumento.Name = "labelNumeroDocumento";
            labelNumeroDocumento.Size = new Size(31, 17);
            labelNumeroDocumento.TabIndex = 31;
            labelNumeroDocumento.Text = "URL";
            // 
            // buttonRequest
            // 
            buttonRequest.Anchor = AnchorStyles.Right;
            buttonRequest.FlatAppearance.BorderSize = 0;
            buttonRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRequest.FlatStyle = FlatStyle.Flat;
            buttonRequest.ForeColor = SystemColors.ControlLightLight;
            buttonRequest.Image = Properties.Resources.requisicao_16;
            buttonRequest.ImageAlign = ContentAlignment.TopLeft;
            buttonRequest.Location = new Point(500, 269);
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
            checkedListBoxAPI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxAPI.BackColor = Color.FromArgb(31, 31, 31);
            checkedListBoxAPI.BorderStyle = BorderStyle.None;
            checkedListBoxAPI.CheckOnClick = true;
            checkedListBoxAPI.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxAPI.FormattingEnabled = true;
            checkedListBoxAPI.Items.AddRange(new object[] { "Portal", "Mobile" });
            checkedListBoxAPI.Location = new Point(20, 77);
            checkedListBoxAPI.Margin = new Padding(20, 0, 5, 0);
            checkedListBoxAPI.Name = "checkedListBoxAPI";
            checkedListBoxAPI.Size = new Size(302, 80);
            checkedListBoxAPI.TabIndex = 3;
            checkedListBoxAPI.ItemCheck += ResetListBoxAPI_ItemCheckEvent;
            // 
            // labelAPI
            // 
            labelAPI.AutoSize = true;
            labelAPI.ForeColor = SystemColors.ControlLightLight;
            labelAPI.Location = new Point(20, 55);
            labelAPI.Margin = new Padding(20, 5, 0, 5);
            labelAPI.Name = "labelAPI";
            labelAPI.Size = new Size(26, 17);
            labelAPI.TabIndex = 2;
            labelAPI.Text = "API";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(75, 25, 25);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(12, 12, 12);
            dataGridView.Location = new Point(0, 300);
            dataGridView.Margin = new Padding(0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 46, 46);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
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
            tableLayoutPanel.SetColumnSpan(labelTitulo, 2);
            labelTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(20, 10);
            labelTitulo.Margin = new Padding(20, 10, 0, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(79, 30);
            labelTitulo.TabIndex = 47;
            labelTitulo.Text = "Tokens";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel.Controls.Add(buttonRequest, 1, 5);
            tableLayoutPanel.Controls.Add(comboBoxUrls, 0, 4);
            tableLayoutPanel.Controls.Add(labelTitulo, 0, 0);
            tableLayoutPanel.Controls.Add(labelAPI, 0, 1);
            tableLayoutPanel.Controls.Add(labelNumeroDocumento, 0, 3);
            tableLayoutPanel.Controls.Add(comboBoxMotorista, 1, 4);
            tableLayoutPanel.Controls.Add(checkedListBoxAPI, 0, 2);
            tableLayoutPanel.Controls.Add(labelMotorista, 1, 3);
            tableLayoutPanel.Controls.Add(comboBoxEmpresa, 1, 2);
            tableLayoutPanel.Controls.Add(labelEmpresa, 1, 1);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.MaximumSize = new Size(9999, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(600, 300);
            tableLayoutPanel.TabIndex = 48;
            // 
            // GerarTokenViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridView);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Name = "GerarTokenViewControl";
            SizeChanged += View_SizeChangedEvent;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel;
    }
}
