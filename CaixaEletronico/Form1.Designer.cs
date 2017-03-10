namespace CaixaEletronico
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.Deposita = new System.Windows.Forms.Button();
            this.Saca = new System.Windows.Forms.Button();
            this.textoValorDeposito = new System.Windows.Forms.TextBox();
            this.textoValorSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.destinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Transfere = new System.Windows.Forms.Button();
            this.valorOperacao = new System.Windows.Forms.TextBox();
            this.textoTitularDestino = new System.Windows.Forms.TextBox();
            this.textoNumeroDestino = new System.Windows.Forms.TextBox();
            this.textoSaldoDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textoCpfOrigem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textoCpfDestino = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textoImpostoSeguro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textoImpostoPoupanca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textTotalCc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textTotalCp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.formularioDeCadastro = new System.Windows.Forms.Button();
            this.formularioRemocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(70, 68);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(122, 21);
            this.comboContas.TabIndex = 0;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(70, 119);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.ReadOnly = true;
            this.textoTitular.Size = new System.Drawing.Size(122, 20);
            this.textoTitular.TabIndex = 1;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged_1);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(70, 145);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            this.textoNumero.Size = new System.Drawing.Size(122, 20);
            this.textoNumero.TabIndex = 2;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(70, 171);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.ReadOnly = true;
            this.textoSaldo.Size = new System.Drawing.Size(122, 20);
            this.textoSaldo.TabIndex = 3;
            this.textoSaldo.TextChanged += new System.EventHandler(this.textoSaldo_TextChanged_1);
            // 
            // Deposita
            // 
            this.Deposita.Location = new System.Drawing.Point(27, 210);
            this.Deposita.Name = "Deposita";
            this.Deposita.Size = new System.Drawing.Size(75, 23);
            this.Deposita.TabIndex = 5;
            this.Deposita.Text = "Deposita";
            this.Deposita.UseVisualStyleBackColor = true;
            this.Deposita.Click += new System.EventHandler(this.Deposita_Click);
            // 
            // Saca
            // 
            this.Saca.Location = new System.Drawing.Point(117, 210);
            this.Saca.Name = "Saca";
            this.Saca.Size = new System.Drawing.Size(75, 23);
            this.Saca.TabIndex = 6;
            this.Saca.Text = "Saca";
            this.Saca.UseVisualStyleBackColor = true;
            this.Saca.Click += new System.EventHandler(this.Saca_Click);
            // 
            // textoValorDeposito
            // 
            this.textoValorDeposito.Location = new System.Drawing.Point(27, 239);
            this.textoValorDeposito.Name = "textoValorDeposito";
            this.textoValorDeposito.Size = new System.Drawing.Size(75, 20);
            this.textoValorDeposito.TabIndex = 7;
            this.textoValorDeposito.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoValorSaque
            // 
            this.textoValorSaque.Location = new System.Drawing.Point(117, 239);
            this.textoValorSaque.Name = "textoValorSaque";
            this.textoValorSaque.Size = new System.Drawing.Size(75, 20);
            this.textoValorSaque.TabIndex = 8;
            this.textoValorSaque.TextChanged += new System.EventHandler(this.textoValorSaque_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Origem";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Saldo";
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(300, 71);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(123, 21);
            this.destinoDaTransferencia.TabIndex = 13;
            this.destinoDaTransferencia.SelectedIndexChanged += new System.EventHandler(this.destinoDaTransferencia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Destino";
            // 
            // Transfere
            // 
            this.Transfere.Location = new System.Drawing.Point(81, 278);
            this.Transfere.Name = "Transfere";
            this.Transfere.Size = new System.Drawing.Size(75, 23);
            this.Transfere.TabIndex = 15;
            this.Transfere.Text = "Transfere";
            this.Transfere.UseVisualStyleBackColor = true;
            this.Transfere.Click += new System.EventHandler(this.Transfere_Click);
            // 
            // valorOperacao
            // 
            this.valorOperacao.Location = new System.Drawing.Point(81, 307);
            this.valorOperacao.Name = "valorOperacao";
            this.valorOperacao.Size = new System.Drawing.Size(75, 20);
            this.valorOperacao.TabIndex = 16;
            this.valorOperacao.TabStop = false;
            this.valorOperacao.TextChanged += new System.EventHandler(this.valorOperacao_TextChanged);
            // 
            // textoTitularDestino
            // 
            this.textoTitularDestino.Location = new System.Drawing.Point(300, 122);
            this.textoTitularDestino.Name = "textoTitularDestino";
            this.textoTitularDestino.ReadOnly = true;
            this.textoTitularDestino.Size = new System.Drawing.Size(123, 20);
            this.textoTitularDestino.TabIndex = 17;
            // 
            // textoNumeroDestino
            // 
            this.textoNumeroDestino.Location = new System.Drawing.Point(300, 148);
            this.textoNumeroDestino.Name = "textoNumeroDestino";
            this.textoNumeroDestino.ReadOnly = true;
            this.textoNumeroDestino.Size = new System.Drawing.Size(123, 20);
            this.textoNumeroDestino.TabIndex = 18;
            // 
            // textoSaldoDestino
            // 
            this.textoSaldoDestino.Location = new System.Drawing.Point(300, 177);
            this.textoSaldoDestino.Name = "textoSaldoDestino";
            this.textoSaldoDestino.ReadOnly = true;
            this.textoSaldoDestino.Size = new System.Drawing.Size(123, 20);
            this.textoSaldoDestino.TabIndex = 19;
            this.textoSaldoDestino.TextChanged += new System.EventHandler(this.textoSaldoDestino_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Titular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Conta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Saldo";
            // 
            // textoCpfOrigem
            // 
            this.textoCpfOrigem.Location = new System.Drawing.Point(70, 95);
            this.textoCpfOrigem.Name = "textoCpfOrigem";
            this.textoCpfOrigem.ReadOnly = true;
            this.textoCpfOrigem.Size = new System.Drawing.Size(122, 20);
            this.textoCpfOrigem.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "CPF";
            // 
            // textoCpfDestino
            // 
            this.textoCpfDestino.Location = new System.Drawing.Point(300, 98);
            this.textoCpfDestino.Name = "textoCpfDestino";
            this.textoCpfDestino.ReadOnly = true;
            this.textoCpfDestino.Size = new System.Drawing.Size(123, 20);
            this.textoCpfDestino.TabIndex = 25;
            this.textoCpfDestino.TextChanged += new System.EventHandler(this.textoCpfDestino_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 137);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textoImpostoSeguro
            // 
            this.textoImpostoSeguro.Location = new System.Drawing.Point(100, 19);
            this.textoImpostoSeguro.Name = "textoImpostoSeguro";
            this.textoImpostoSeguro.Size = new System.Drawing.Size(100, 20);
            this.textoImpostoSeguro.TabIndex = 28;
            this.textoImpostoSeguro.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Gerar Impostos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GerarImpostos_Click);
            // 
            // textoImpostoPoupanca
            // 
            this.textoImpostoPoupanca.Location = new System.Drawing.Point(100, 56);
            this.textoImpostoPoupanca.Name = "textoImpostoPoupanca";
            this.textoImpostoPoupanca.Size = new System.Drawing.Size(100, 20);
            this.textoImpostoPoupanca.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Seguro de vida";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Poupanca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoImpostoSeguro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textoImpostoPoupanca);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(517, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impostos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textTotalCc);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textTotalCp);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(17, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 88);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totalizador de Contas";
            // 
            // textTotalCc
            // 
            this.textTotalCc.Location = new System.Drawing.Point(89, 19);
            this.textTotalCc.Name = "textTotalCc";
            this.textTotalCc.Size = new System.Drawing.Size(51, 20);
            this.textTotalCc.TabIndex = 28;
            this.textTotalCc.TextChanged += new System.EventHandler(this.textTotalCc_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Poupanca";
            // 
            // textTotalCp
            // 
            this.textTotalCp.Location = new System.Drawing.Point(89, 53);
            this.textTotalCp.Name = "textTotalCp";
            this.textTotalCp.Size = new System.Drawing.Size(51, 20);
            this.textTotalCp.TabIndex = 30;
            this.textTotalCp.TextChanged += new System.EventHandler(this.textTotalCp_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Corrente";
            // 
            // formularioDeCadastro
            // 
            this.formularioDeCadastro.Location = new System.Drawing.Point(41, 24);
            this.formularioDeCadastro.Name = "formularioDeCadastro";
            this.formularioDeCadastro.Size = new System.Drawing.Size(116, 26);
            this.formularioDeCadastro.TabIndex = 35;
            this.formularioDeCadastro.Text = "Cadastrar Contas";
            this.formularioDeCadastro.UseVisualStyleBackColor = true;
            this.formularioDeCadastro.Click += new System.EventHandler(this.formularioDeCadastro_Click);
            // 
            // formularioRemocao
            // 
            this.formularioRemocao.Location = new System.Drawing.Point(249, 24);
            this.formularioRemocao.Name = "formularioRemocao";
            this.formularioRemocao.Size = new System.Drawing.Size(123, 26);
            this.formularioRemocao.TabIndex = 36;
            this.formularioRemocao.Text = "Remover Contas";
            this.formularioRemocao.UseVisualStyleBackColor = true;
            this.formularioRemocao.Click += new System.EventHandler(this.FormularioRemocao_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(827, 438);
            this.Controls.Add(this.formularioRemocao);
            this.Controls.Add(this.formularioDeCadastro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textoCpfDestino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textoCpfOrigem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoSaldoDestino);
            this.Controls.Add(this.textoNumeroDestino);
            this.Controls.Add(this.textoTitularDestino);
            this.Controls.Add(this.valorOperacao);
            this.Controls.Add(this.Transfere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destinoDaTransferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoValorSaque);
            this.Controls.Add(this.textoValorDeposito);
            this.Controls.Add(this.Saca);
            this.Controls.Add(this.Deposita);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.comboContas);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Button Deposita;
        private System.Windows.Forms.Button Saca;
        private System.Windows.Forms.TextBox textoValorDeposito;
        private System.Windows.Forms.TextBox textoValorSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox destinoDaTransferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Transfere;
        private System.Windows.Forms.TextBox valorOperacao;
        private System.Windows.Forms.TextBox textoTitularDestino;
        private System.Windows.Forms.TextBox textoNumeroDestino;
        private System.Windows.Forms.TextBox textoSaldoDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textoCpfOrigem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textoCpfDestino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textoImpostoSeguro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoImpostoPoupanca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textTotalCc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textTotalCp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button formularioDeCadastro;
        private System.Windows.Forms.Button formularioRemocao;
    }
}

