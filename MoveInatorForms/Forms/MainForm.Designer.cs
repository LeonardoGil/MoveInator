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
            labelTitulo = new Label();
            labelSubTitulo = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            maskedTextBoxCpfCnpjDestinatario = new MaskedTextBox();
            labelCpfCnpjDestinatario = new Label();
            textBoxNomeDestinatario = new TextBox();
            labelNomeDestinatario = new Label();
            textBoxSerieInicial = new TextBox();
            labelSerieInicial = new Label();
            textBoxNumeroInicial = new TextBox();
            labelNumeroInicial = new Label();
            maskedTextBoxCpfMotorista = new MaskedTextBox();
            labelCpfMotorista = new Label();
            textBoxNomeMotorista = new TextBox();
            labelNomeMotorista = new Label();
            textBoxQuantidadeDocumentos = new TextBox();
            labelQuantidadeDocumentos = new Label();
            checkedListBoxTipoDocumento = new CheckedListBox();
            labelTipoDocumento = new Label();
            maskedTextBoxCnpjEmissor = new MaskedTextBox();
            labelCnpjEmissor = new Label();
            maskedTextBoxDataEmissao = new MaskedTextBox();
            labelDataEmissao = new Label();
            textBoxSerieDocumento = new TextBox();
            labelSerieDocumento = new Label();
            textBoxNumeroDocumento = new TextBox();
            labelNumeroDocumento = new Label();
            checkedListBoxTipoViagem = new CheckedListBox();
            labelTipoViagem = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MesloLGL NF", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(21, 18);
            labelTitulo.Margin = new Padding(7, 0, 7, 5);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(178, 42);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "MoveInator";
            // 
            // labelSubTitulo
            // 
            labelSubTitulo.AutoSize = true;
            labelSubTitulo.Font = new Font("MesloLGL NF", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelSubTitulo.Location = new Point(25, 57);
            labelSubTitulo.Margin = new Padding(0);
            labelSubTitulo.Name = "labelSubTitulo";
            labelSubTitulo.Size = new Size(106, 18);
            labelSubTitulo.TabIndex = 1;
            labelSubTitulo.Text = "Created by LAG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 31, 31);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(labelTitulo);
            panel2.Controls.Add(labelSubTitulo);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 592);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 27, 27);
            panel1.Controls.Add(maskedTextBoxCpfCnpjDestinatario);
            panel1.Controls.Add(labelCpfCnpjDestinatario);
            panel1.Controls.Add(textBoxNomeDestinatario);
            panel1.Controls.Add(labelNomeDestinatario);
            panel1.Controls.Add(textBoxSerieInicial);
            panel1.Controls.Add(labelSerieInicial);
            panel1.Controls.Add(textBoxNumeroInicial);
            panel1.Controls.Add(labelNumeroInicial);
            panel1.Controls.Add(maskedTextBoxCpfMotorista);
            panel1.Controls.Add(labelCpfMotorista);
            panel1.Controls.Add(textBoxNomeMotorista);
            panel1.Controls.Add(labelNomeMotorista);
            panel1.Controls.Add(textBoxQuantidadeDocumentos);
            panel1.Controls.Add(labelQuantidadeDocumentos);
            panel1.Controls.Add(checkedListBoxTipoDocumento);
            panel1.Controls.Add(labelTipoDocumento);
            panel1.Controls.Add(maskedTextBoxCnpjEmissor);
            panel1.Controls.Add(labelCnpjEmissor);
            panel1.Controls.Add(maskedTextBoxDataEmissao);
            panel1.Controls.Add(labelDataEmissao);
            panel1.Controls.Add(textBoxSerieDocumento);
            panel1.Controls.Add(labelSerieDocumento);
            panel1.Controls.Add(textBoxNumeroDocumento);
            panel1.Controls.Add(labelNumeroDocumento);
            panel1.Controls.Add(checkedListBoxTipoViagem);
            panel1.Controls.Add(labelTipoViagem);
            panel1.Location = new Point(8, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 201);
            panel1.TabIndex = 2;
            // 
            // maskedTextBoxCpfCnpjDestinatario
            // 
            maskedTextBoxCpfCnpjDestinatario.Location = new Point(476, 157);
            maskedTextBoxCpfCnpjDestinatario.Mask = "00.000.000/0000-00";
            maskedTextBoxCpfCnpjDestinatario.Name = "maskedTextBoxCpfCnpjDestinatario";
            maskedTextBoxCpfCnpjDestinatario.Size = new Size(156, 25);
            maskedTextBoxCpfCnpjDestinatario.TabIndex = 21;
            maskedTextBoxCpfCnpjDestinatario.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfCnpjDestinatario
            // 
            labelCpfCnpjDestinatario.AutoSize = true;
            labelCpfCnpjDestinatario.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfCnpjDestinatario.Location = new Point(477, 138);
            labelCpfCnpjDestinatario.Name = "labelCpfCnpjDestinatario";
            labelCpfCnpjDestinatario.Size = new Size(155, 17);
            labelCpfCnpjDestinatario.TabIndex = 20;
            labelCpfCnpjDestinatario.Text = "CPF/CNPJ Destinatário";
            // 
            // textBoxNomeDestinatario
            // 
            textBoxNomeDestinatario.Location = new Point(477, 103);
            textBoxNomeDestinatario.Name = "textBoxNomeDestinatario";
            textBoxNomeDestinatario.Size = new Size(156, 25);
            textBoxNomeDestinatario.TabIndex = 19;
            // 
            // labelNomeDestinatario
            // 
            labelNomeDestinatario.AutoSize = true;
            labelNomeDestinatario.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeDestinatario.Location = new Point(477, 83);
            labelNomeDestinatario.Name = "labelNomeDestinatario";
            labelNomeDestinatario.Size = new Size(127, 17);
            labelNomeDestinatario.TabIndex = 18;
            labelNomeDestinatario.Text = "Nome Destinatário";
            // 
            // textBoxSerieInicial
            // 
            textBoxSerieInicial.Location = new Point(188, 158);
            textBoxSerieInicial.Name = "textBoxSerieInicial";
            textBoxSerieInicial.Size = new Size(97, 25);
            textBoxSerieInicial.TabIndex = 11;
            // 
            // labelSerieInicial
            // 
            labelSerieInicial.AutoSize = true;
            labelSerieInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieInicial.Location = new Point(188, 138);
            labelSerieInicial.Name = "labelSerieInicial";
            labelSerieInicial.Size = new Size(99, 17);
            labelSerieInicial.TabIndex = 10;
            labelSerieInicial.Text = "Série Inicial";
            // 
            // textBoxNumeroInicial
            // 
            textBoxNumeroInicial.Location = new Point(188, 103);
            textBoxNumeroInicial.Name = "textBoxNumeroInicial";
            textBoxNumeroInicial.Size = new Size(97, 25);
            textBoxNumeroInicial.TabIndex = 9;
            // 
            // labelNumeroInicial
            // 
            labelNumeroInicial.AutoSize = true;
            labelNumeroInicial.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroInicial.Location = new Point(188, 83);
            labelNumeroInicial.Name = "labelNumeroInicial";
            labelNumeroInicial.Size = new Size(106, 17);
            labelNumeroInicial.TabIndex = 8;
            labelNumeroInicial.Text = "Numero Inicial";
            // 
            // maskedTextBoxCpfMotorista
            // 
            maskedTextBoxCpfMotorista.Location = new Point(643, 157);
            maskedTextBoxCpfMotorista.Mask = "000.000.000-00";
            maskedTextBoxCpfMotorista.Name = "maskedTextBoxCpfMotorista";
            maskedTextBoxCpfMotorista.Size = new Size(120, 25);
            maskedTextBoxCpfMotorista.TabIndex = 25;
            maskedTextBoxCpfMotorista.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCpfMotorista
            // 
            labelCpfMotorista.AutoSize = true;
            labelCpfMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCpfMotorista.Location = new Point(643, 137);
            labelCpfMotorista.Name = "labelCpfMotorista";
            labelCpfMotorista.Size = new Size(99, 17);
            labelCpfMotorista.TabIndex = 24;
            labelCpfMotorista.Text = "CPF Motorista";
            // 
            // textBoxNomeMotorista
            // 
            textBoxNomeMotorista.Location = new Point(644, 103);
            textBoxNomeMotorista.Name = "textBoxNomeMotorista";
            textBoxNomeMotorista.Size = new Size(120, 25);
            textBoxNomeMotorista.TabIndex = 23;
            // 
            // labelNomeMotorista
            // 
            labelNomeMotorista.AutoSize = true;
            labelNomeMotorista.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeMotorista.Location = new Point(644, 83);
            labelNomeMotorista.Name = "labelNomeMotorista";
            labelNomeMotorista.Size = new Size(106, 17);
            labelNomeMotorista.TabIndex = 22;
            labelNomeMotorista.Text = "Nome Motorista";
            // 
            // textBoxQuantidadeDocumentos
            // 
            textBoxQuantidadeDocumentos.Location = new Point(293, 158);
            textBoxQuantidadeDocumentos.Name = "textBoxQuantidadeDocumentos";
            textBoxQuantidadeDocumentos.Size = new Size(78, 25);
            textBoxQuantidadeDocumentos.TabIndex = 13;
            // 
            // labelQuantidadeDocumentos
            // 
            labelQuantidadeDocumentos.AutoSize = true;
            labelQuantidadeDocumentos.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeDocumentos.Location = new Point(293, 138);
            labelQuantidadeDocumentos.Name = "labelQuantidadeDocumentos";
            labelQuantidadeDocumentos.Size = new Size(78, 17);
            labelQuantidadeDocumentos.TabIndex = 12;
            labelQuantidadeDocumentos.Text = "Quantidade";
            // 
            // checkedListBoxTipoDocumento
            // 
            checkedListBoxTipoDocumento.BackColor = Color.FromArgb(27, 27, 27);
            checkedListBoxTipoDocumento.BorderStyle = BorderStyle.None;
            checkedListBoxTipoDocumento.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoDocumento.FormattingEnabled = true;
            checkedListBoxTipoDocumento.Items.AddRange(new object[] { "CT-e", "NF-e" });
            checkedListBoxTipoDocumento.Location = new Point(188, 32);
            checkedListBoxTipoDocumento.Name = "checkedListBoxTipoDocumento";
            checkedListBoxTipoDocumento.Size = new Size(97, 40);
            checkedListBoxTipoDocumento.TabIndex = 7;
            // 
            // labelTipoDocumento
            // 
            labelTipoDocumento.AutoSize = true;
            labelTipoDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoDocumento.Location = new Point(188, 12);
            labelTipoDocumento.Name = "labelTipoDocumento";
            labelTipoDocumento.Size = new Size(106, 17);
            labelTipoDocumento.TabIndex = 6;
            labelTipoDocumento.Text = "Tipo Documento";
            // 
            // maskedTextBoxCnpjEmissor
            // 
            maskedTextBoxCnpjEmissor.Location = new Point(624, 32);
            maskedTextBoxCnpjEmissor.Mask = "00.000.000/0000-00";
            maskedTextBoxCnpjEmissor.Name = "maskedTextBoxCnpjEmissor";
            maskedTextBoxCnpjEmissor.Size = new Size(140, 25);
            maskedTextBoxCnpjEmissor.TabIndex = 17;
            maskedTextBoxCnpjEmissor.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCnpjEmissor.ValidatingType = typeof(DateTime);
            // 
            // labelCnpjEmissor
            // 
            labelCnpjEmissor.AutoSize = true;
            labelCnpjEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmissor.Location = new Point(624, 12);
            labelCnpjEmissor.Name = "labelCnpjEmissor";
            labelCnpjEmissor.Size = new Size(92, 17);
            labelCnpjEmissor.TabIndex = 16;
            labelCnpjEmissor.Text = "CNPJ Emissor";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Location = new Point(514, 32);
            maskedTextBoxDataEmissao.Mask = "00/00/0000";
            maskedTextBoxDataEmissao.Name = "maskedTextBoxDataEmissao";
            maskedTextBoxDataEmissao.Size = new Size(100, 25);
            maskedTextBoxDataEmissao.TabIndex = 15;
            maskedTextBoxDataEmissao.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxDataEmissao.ValidatingType = typeof(DateTime);
            // 
            // labelDataEmissao
            // 
            labelDataEmissao.AutoSize = true;
            labelDataEmissao.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataEmissao.Location = new Point(514, 12);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(92, 17);
            labelDataEmissao.TabIndex = 14;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // textBoxSerieDocumento
            // 
            textBoxSerieDocumento.Location = new Point(17, 158);
            textBoxSerieDocumento.Name = "textBoxSerieDocumento";
            textBoxSerieDocumento.Size = new Size(97, 25);
            textBoxSerieDocumento.TabIndex = 5;
            // 
            // labelSerieDocumento
            // 
            labelSerieDocumento.AutoSize = true;
            labelSerieDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSerieDocumento.Location = new Point(17, 138);
            labelSerieDocumento.Name = "labelSerieDocumento";
            labelSerieDocumento.Size = new Size(78, 17);
            labelSerieDocumento.TabIndex = 4;
            labelSerieDocumento.Text = "Série Doc.";
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Location = new Point(17, 103);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(97, 25);
            textBoxNumeroDocumento.TabIndex = 3;
            // 
            // labelNumeroDocumento
            // 
            labelNumeroDocumento.AutoSize = true;
            labelNumeroDocumento.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroDocumento.Location = new Point(17, 83);
            labelNumeroDocumento.Name = "labelNumeroDocumento";
            labelNumeroDocumento.Size = new Size(85, 17);
            labelNumeroDocumento.TabIndex = 2;
            labelNumeroDocumento.Text = "Numero Doc.";
            // 
            // checkedListBoxTipoViagem
            // 
            checkedListBoxTipoViagem.BackColor = Color.FromArgb(27, 27, 27);
            checkedListBoxTipoViagem.BorderStyle = BorderStyle.None;
            checkedListBoxTipoViagem.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoViagem.FormattingEnabled = true;
            checkedListBoxTipoViagem.Items.AddRange(new object[] { "MDF-e", "Manifesto" });
            checkedListBoxTipoViagem.Location = new Point(17, 32);
            checkedListBoxTipoViagem.Name = "checkedListBoxTipoViagem";
            checkedListBoxTipoViagem.Size = new Size(97, 40);
            checkedListBoxTipoViagem.TabIndex = 1;
            // 
            // labelTipoViagem
            // 
            labelTipoViagem.AutoSize = true;
            labelTipoViagem.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoViagem.Location = new Point(17, 12);
            labelTipoViagem.Name = "labelTipoViagem";
            labelTipoViagem.Size = new Size(85, 17);
            labelTipoViagem.TabIndex = 0;
            labelTipoViagem.Text = "Tipo Viagem";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(panel2);
            Font = new Font("MesloLGL NF", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitulo;
        private Label labelSubTitulo;
        private Panel panel2;
        private Panel panel1;
        private CheckedListBox checkedListBoxTipoViagem;
        private Label labelTipoViagem;
        private TextBox textBoxSerieDocumento;
        private Label labelSerieDocumento;
        private TextBox textBoxNumeroDocumento;
        private Label labelNumeroDocumento;
        private CheckedListBox checkedListBoxTipoDocumento;
        private Label labelTipoDocumento;
        private MaskedTextBox maskedTextBoxCnpjEmissor;
        private Label labelCnpjEmissor;
        private MaskedTextBox maskedTextBoxDataEmissao;
        private Label labelDataEmissao;
        private TextBox textBoxQuantidadeDocumentos;
        private Label labelQuantidadeDocumentos;
        private MaskedTextBox maskedTextBoxCpfCnpjDestinatario;
        private Label labelCpfCnpjDestinatario;
        private TextBox textBoxNomeDestinatario;
        private Label labelNomeDestinatario;
        private TextBox textBoxSerieInicial;
        private Label labelSerieInicial;
        private TextBox textBoxNumeroInicial;
        private Label labelNumeroInicial;
        private MaskedTextBox maskedTextBoxCpfMotorista;
        private Label labelCpfMotorista;
        private TextBox textBoxNomeMotorista;
        private Label labelNomeMotorista;
    }
}