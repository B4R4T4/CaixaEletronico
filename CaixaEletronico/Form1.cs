using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int quantidadeDeContas;
        
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new ContaCorrente[20];
            /*
            var marcos = new Cliente();
            marcos.Nome = "Marcos";

            var victor = new Cliente();
            victor.Nome = "Victor";

            var david = new Cliente();
            david.Nome = "David";

            var joaopaulo = new Cliente();
            joaopaulo.Nome = "João Paulo";

            var conta0 = new ContaPoupanca();
            conta0.Numero = 666;
            conta0.Titular = joaopaulo;
            conta0.Titular.cpf = "098.345.234.13";


            

            var conta1 = new ContaCorrente();
            conta1.Numero = 1;
            conta1.Titular = marcos;
            conta1.Titular.cpf = "134.232.580-02";
            

            var conta2 = new ContaPoupanca();
            conta2.Numero = 2;
            conta2.Titular = victor;
            conta2.Titular.cpf = "323.234.678-55";

            var conta3 = new ContaCorrente();

            conta3.Numero = 3;
            conta3.Titular = david;
            conta3.Titular.cpf = "121.060.304-19";

            textTotalCc.Text = Convert.ToString(ContaCorrente.TotalDeContas);
            textTotalCp.Text = Convert.ToString(ContaPoupanca.TotalDeContas);

            this.contas = new Conta[10];
            this.contas[0] = conta1;
            this.contas[1] = conta2;
            this.contas[2] = conta3;
            this.contas[3] = conta0;*/
            

         
        }

             private void formularioDeCadastro_Click(object sender, EventArgs e)
        {
            CadastroDeContas formularioDeCadastro = new CadastroDeContas(this);
            formularioDeCadastro.ShowDialog();
        

            

            /*
            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular);
                destinoDaTransferencia.Items.Add(conta);
                
            }
            */

}

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

            this.MostraConta(contaSelecionada);
            this.BuscaContaSelecionada();
        }

        private Conta BuscaContaSelecionada()
        {

            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];

        }

        private void MostraConta(Conta contaSelecionada)
        {

            
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoTitular.Text = Convert.ToString(contaSelecionada.Titular);
            textoCpfOrigem.Text = Convert.ToString(contaSelecionada.Titular.cpf);
           

        }


        private void MostraContaDestino(Conta contaSelecionada)
        {
            
            textoNumeroDestino.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldoDestino.Text = Convert.ToString(contaSelecionada.Saldo);
            textoTitularDestino.Text = Convert.ToString(contaSelecionada.Titular);
            textoCpfDestino.Text = Convert.ToString(contaSelecionada.Titular.cpf);


        }
        private void destinoDaTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = destinoDaTransferencia.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];

            this.MostraContaDestino(contaSelecionada);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void Deposita_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValorDeposito.Text;

            if (String.IsNullOrEmpty(textoDoValorDoDeposito))
            {

                MessageBox.Show("Digite uma valor a ser depositado!");

            }
            else
            {
                {
                    double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);


                }
                Conta contaSelecionada = this.BuscaContaSelecionada();



                {
                    MessageBox.Show("Valor Depositado!");

                }
                try
                {
                    double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
                    contaSelecionada.Deposita(valorDeposito);

                }
                catch (System.ArgumentException)
                {

                    MessageBox.Show("Valor inválido para depósito!");
                }

                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Digite um valor!");
                }


                this.MostraConta(contaSelecionada);


            }
        }

        private void Saca_Click(object sender, EventArgs e)
        {
            string textoValorDoSaque = textoValorSaque.Text;
           

            if (String.IsNullOrEmpty(textoValorDoSaque))
            {
                MessageBox.Show("Digite algum valor a ser sacado!");
            }
            else
            {
                double valorSaque = Convert.ToDouble(textoValorDoSaque);
                Conta contaSelecionada = this.BuscaContaSelecionada();
                try
                {
                    contaSelecionada.Saca(valorSaque);
                    MessageBox.Show("Dinheiro liberado! ");

                }
                catch (SaldoInsuficienteExeception)
                {
                    MessageBox.Show("Saldo Insuficiente.");

                }
                catch (System.ArgumentException)
                {

                    MessageBox.Show("Valor digitado para saque inválido. ");


                }
                this.MostraConta(contaSelecionada);
            }
        }
        
        private void Transfere_Click(object sender, EventArgs e)
        {
           

            string textoValor = valorOperacao.Text;
            if (String.IsNullOrEmpty(textoValor))
            {

                MessageBox.Show("Digite algum valor a ser transferido!");
            }
            else
            {
                Conta contaSelecionada = this.BuscaContaSelecionada();

                int indiceDaContaDestino = destinoDaTransferencia.SelectedIndex;

                Conta contaDestino = this.contas[indiceDaContaDestino];

                double valorTransferencia = Convert.ToDouble(textoValor);

                contaSelecionada.Transfere(contaDestino, valorTransferencia);
                textoSaldoDestino.Text = Convert.ToString(contaDestino.Saldo);

                this.MostraConta(contaSelecionada);

            }

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textoValorSaque_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoSaldo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void valorOperacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoTitular_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textoSaldoDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoCpfDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GerarImpostos_Click(object sender, EventArgs e)
        {
            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
            ContaPoupanca cp = new ContaPoupanca();
            SeguroDeVida sv = new SeguroDeVida();
            cp.Deposita(100);
            sv.tributo = 100;
            gerenciador.Adciona(cp);
            gerenciador.Adciona(sv);
            MessageBox.Show("O total de impostos é: " + gerenciador.Total);

        }

        private void textTotalCc_TextChanged(object sender, EventArgs e)
        {


            textTotalCc.Text = Convert.ToString(ContaCorrente.TotalDeContas);

        }

        private void textTotalCp_TextChanged(object sender, EventArgs e)
        {
            textTotalCp.Text = Convert.ToString(ContaPoupanca.TotalDeContas);
        }
        public void AdcionaContas(Conta conta)
        {
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;

            {
                comboContas.Items.Add(conta);
            } 
        }

       
    }
}
