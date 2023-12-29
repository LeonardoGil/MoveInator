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
            textBoxSerieDocumento = new TextBox();
            labelSerieDocumento = new Label();
            textBoxNumeroDocumento = new TextBox();
            labelNumeroDocumento = new Label();
            checkedListBoxTipoDocumento = new CheckedListBox();
            labelTipoViagem = new Label();
            labelDataEmissao = new Label();
            maskedTextBoxDataEmissao = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            labelCnpjEmissor = new Label();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            labelQuantidadeDocumentos = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
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
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelQuantidadeDocumentos);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(labelCnpjEmissor);
            panel1.Controls.Add(maskedTextBoxDataEmissao);
            panel1.Controls.Add(labelDataEmissao);
            panel1.Controls.Add(textBoxSerieDocumento);
            panel1.Controls.Add(labelSerieDocumento);
            panel1.Controls.Add(textBoxNumeroDocumento);
            panel1.Controls.Add(labelNumeroDocumento);
            panel1.Controls.Add(checkedListBoxTipoDocumento);
            panel1.Controls.Add(labelTipoViagem);
            panel1.Location = new Point(8, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 197);
            panel1.TabIndex = 2;
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
            // checkedListBoxTipoDocumento
            // 
            checkedListBoxTipoDocumento.BackColor = Color.FromArgb(27, 27, 27);
            checkedListBoxTipoDocumento.BorderStyle = BorderStyle.None;
            checkedListBoxTipoDocumento.ForeColor = SystemColors.ControlLightLight;
            checkedListBoxTipoDocumento.FormattingEnabled = true;
            checkedListBoxTipoDocumento.Items.AddRange(new object[] { "MDF-e", "Manifesto" });
            checkedListBoxTipoDocumento.Location = new Point(17, 32);
            checkedListBoxTipoDocumento.Name = "checkedListBoxTipoDocumento";
            checkedListBoxTipoDocumento.Size = new Size(97, 40);
            checkedListBoxTipoDocumento.TabIndex = 1;
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
            // labelDataEmissao
            // 
            labelDataEmissao.AutoSize = true;
            labelDataEmissao.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataEmissao.Location = new Point(552, 12);
            labelDataEmissao.Name = "labelDataEmissao";
            labelDataEmissao.Size = new Size(92, 17);
            labelDataEmissao.TabIndex = 6;
            labelDataEmissao.Text = "Data Emissão";
            // 
            // maskedTextBoxDataEmissao
            // 
            maskedTextBoxDataEmissao.Location = new Point(552, 32);
            maskedTextBoxDataEmissao.Name = "maskedTextBoxDataEmissao";
            maskedTextBoxDataEmissao.Size = new Size(100, 25);
            maskedTextBoxDataEmissao.TabIndex = 7;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(658, 32);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 25);
            maskedTextBox3.TabIndex = 11;
            // 
            // labelCnpjEmissor
            // 
            labelCnpjEmissor.AutoSize = true;
            labelCnpjEmissor.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnpjEmissor.Location = new Point(658, 12);
            labelCnpjEmissor.Name = "labelCnpjEmissor";
            labelCnpjEmissor.Size = new Size(92, 17);
            labelCnpjEmissor.TabIndex = 10;
            labelCnpjEmissor.Text = "CNPJ Emissor";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(27, 27, 27);
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.ForeColor = SystemColors.ControlLightLight;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "CT-e", "NF-e" });
            checkedListBox1.Location = new Point(170, 32);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(97, 40);
            checkedListBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 12;
            label1.Text = "Tipo Documento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 25);
            textBox1.TabIndex = 15;
            // 
            // labelQuantidadeDocumentos
            // 
            labelQuantidadeDocumentos.AutoSize = true;
            labelQuantidadeDocumentos.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeDocumentos.Location = new Point(275, 138);
            labelQuantidadeDocumentos.Name = "labelQuantidadeDocumentos";
            labelQuantidadeDocumentos.Size = new Size(78, 17);
            labelQuantidadeDocumentos.TabIndex = 14;
            labelQuantidadeDocumentos.Text = "Quantidade";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(609, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 25);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(609, 83);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 16;
            label2.Text = "Nome Motorista";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(608, 157);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(156, 25);
            maskedTextBox1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(608, 137);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 18;
            label3.Text = "CPF Motorista";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 25);
            textBox3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(170, 138);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 22;
            label4.Text = "Série Inicial";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 25);
            textBox4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(170, 83);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 20;
            label5.Text = "Numero Inicial";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(441, 157);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(156, 25);
            maskedTextBox2.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(442, 138);
            label6.Name = "label6";
            label6.Size = new Size(155, 17);
            label6.TabIndex = 26;
            label6.Text = "CPF/CNPJ Destinatário";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(442, 103);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 25);
            textBox5.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MesloLGL NF", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(442, 83);
            label7.Name = "label7";
            label7.Size = new Size(127, 17);
            label7.TabIndex = 24;
            label7.Text = "Nome Destinatário";
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
        private CheckedListBox checkedListBoxTipoDocumento;
        private Label labelTipoViagem;
        private TextBox textBoxSerieDocumento;
        private Label labelSerieDocumento;
        private TextBox textBoxNumeroDocumento;
        private Label labelNumeroDocumento;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox3;
        private Label labelCnpjEmissor;
        private MaskedTextBox maskedTextBoxDataEmissao;
        private Label labelDataEmissao;
        private TextBox textBox1;
        private Label labelQuantidadeDocumentos;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
    }
}