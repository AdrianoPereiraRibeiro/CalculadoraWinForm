namespace CalculadoraWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Adição = new RadioButton();
            Subtração = new RadioButton();
            Multiplicação = new RadioButton();
            Divisão = new RadioButton();
            Titulo = new Label();
            Numero1Str = new Label();
            Numero2Str = new Label();
            PrimeiroNumero = new TextBox();
            SegundoNumero = new TextBox();
            Calcular = new Button();
            Limpar = new Button();
            Resposta = new TextBox();
            RespostaStr = new Label();
            InformacoesContas = new TextBox();
            SuspendLayout();
            // 
            // Adição
            // 
            Adição.AutoSize = true;
            Adição.BackColor = Color.Black;
            Adição.ForeColor = SystemColors.ButtonHighlight;
            Adição.Location = new Point(14, 158);
            Adição.Name = "Adição";
            Adição.Size = new Size(77, 24);
            Adição.TabIndex = 1;
            Adição.TabStop = true;
            Adição.Text = "Adição";
            Adição.UseVisualStyleBackColor = false;
            Adição.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Subtração
            // 
            Subtração.AutoSize = true;
            Subtração.BackColor = Color.Black;
            Subtração.CheckAlign = ContentAlignment.TopLeft;
            Subtração.ForeColor = SystemColors.Control;
            Subtração.Location = new Point(14, 188);
            Subtração.Name = "Subtração";
            Subtração.Size = new Size(97, 24);
            Subtração.TabIndex = 2;
            Subtração.TabStop = true;
            Subtração.Text = "Subtração";
            Subtração.UseVisualStyleBackColor = false;
            Subtração.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // Multiplicação
            // 
            Multiplicação.AutoSize = true;
            Multiplicação.BackColor = Color.Black;
            Multiplicação.ForeColor = SystemColors.ButtonHighlight;
            Multiplicação.Location = new Point(14, 218);
            Multiplicação.Name = "Multiplicação";
            Multiplicação.Size = new Size(120, 24);
            Multiplicação.TabIndex = 3;
            Multiplicação.TabStop = true;
            Multiplicação.Text = "Multiplicação";
            Multiplicação.UseVisualStyleBackColor = false;
            Multiplicação.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Divisão
            // 
            Divisão.AutoSize = true;
            Divisão.BackColor = Color.Black;
            Divisão.ForeColor = SystemColors.ButtonHighlight;
            Divisão.Location = new Point(14, 248);
            Divisão.Name = "Divisão";
            Divisão.Size = new Size(79, 24);
            Divisão.TabIndex = 4;
            Divisão.TabStop = true;
            Divisão.Text = "Divisão";
            Divisão.UseVisualStyleBackColor = false;
            Divisão.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.FromArgb(192, 0, 192);
            Titulo.Location = new Point(10, 21);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(692, 100);
            Titulo.TabIndex = 5;
            Titulo.Text = "                        CALCULADORA\r\nAcademia do Programador-2024";
            Titulo.Click += label1_Click;
            // 
            // Numero1Str
            // 
            Numero1Str.AutoSize = true;
            Numero1Str.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Numero1Str.ForeColor = Color.Transparent;
            Numero1Str.Location = new Point(14, 293);
            Numero1Str.Name = "Numero1Str";
            Numero1Str.Size = new Size(194, 31);
            Numero1Str.TabIndex = 7;
            Numero1Str.Text = "Primeiro Número:";
            Numero1Str.Click += label1_Click_1;
            // 
            // Numero2Str
            // 
            Numero2Str.AutoSize = true;
            Numero2Str.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Numero2Str.ForeColor = Color.Transparent;
            Numero2Str.Location = new Point(12, 353);
            Numero2Str.Name = "Numero2Str";
            Numero2Str.Size = new Size(199, 31);
            Numero2Str.TabIndex = 8;
            Numero2Str.Text = "Segundo Número:";
            // 
            // PrimeiroNumero
            // 
            PrimeiroNumero.Location = new Point(214, 299);
            PrimeiroNumero.Name = "PrimeiroNumero";
            PrimeiroNumero.Size = new Size(62, 27);
            PrimeiroNumero.TabIndex = 9;
            // 
            // SegundoNumero
            // 
            SegundoNumero.Location = new Point(214, 359);
            SegundoNumero.Name = "SegundoNumero";
            SegundoNumero.Size = new Size(62, 27);
            SegundoNumero.TabIndex = 10;
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.GhostWhite;
            Calcular.Location = new Point(347, 334);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(134, 50);
            Calcular.TabIndex = 12;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += button1_Click;
            // 
            // Limpar
            // 
            Limpar.BackColor = SystemColors.HighlightText;
            Limpar.Location = new Point(519, 334);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(134, 50);
            Limpar.TabIndex = 13;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = false;
            Limpar.Click += Limpar_Click;
            // 
            // Resposta
            // 
            Resposta.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resposta.Location = new Point(462, 187);
            Resposta.Multiline = true;
            Resposta.Name = "Resposta";
            Resposta.Size = new Size(153, 55);
            Resposta.TabIndex = 14;
            Resposta.TextAlign = HorizontalAlignment.Center;
            Resposta.TextChanged += textBox3_TextChanged;
            // 
            // RespostaStr
            // 
            RespostaStr.AutoSize = true;
            RespostaStr.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RespostaStr.ForeColor = SystemColors.ButtonHighlight;
            RespostaStr.Location = new Point(462, 143);
            RespostaStr.Name = "RespostaStr";
            RespostaStr.Size = new Size(163, 41);
            RespostaStr.TabIndex = 15;
            RespostaStr.Text = "RESPOSTA:";
            // 
            // InformacoesContas
            // 
            InformacoesContas.BackColor = SystemColors.ActiveCaption;
            InformacoesContas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InformacoesContas.ForeColor = SystemColors.ControlText;
            InformacoesContas.Location = new Point(0, 458);
            InformacoesContas.Multiline = true;
            InformacoesContas.Name = "InformacoesContas";
            InformacoesContas.Size = new Size(702, 420);
            InformacoesContas.TabIndex = 16;
            InformacoesContas.TextChanged += InformacoesContas_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(704, 648);
            Controls.Add(InformacoesContas);
            Controls.Add(RespostaStr);
            Controls.Add(Resposta);
            Controls.Add(Limpar);
            Controls.Add(Calcular);
            Controls.Add(SegundoNumero);
            Controls.Add(PrimeiroNumero);
            Controls.Add(Numero2Str);
            Controls.Add(Numero1Str);
            Controls.Add(Titulo);
            Controls.Add(Divisão);
            Controls.Add(Multiplicação);
            Controls.Add(Subtração);
            Controls.Add(Adição);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton Adição;
        private RadioButton Subtração;
        private RadioButton Multiplicação;
        private RadioButton Divisão;
        private Label Titulo;
        private Label Numero1Str;
        private Label Numero2Str;
        private TextBox PrimeiroNumero;
        private TextBox SegundoNumero;
        private Button Calcular;
        private Button Limpar;
        private TextBox Resposta;
        private Label RespostaStr;
        private TextBox InformacoesContas;
    }
}
