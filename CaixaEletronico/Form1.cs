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
           
            

         
        }

           

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];

       

            this.MostraConta(contaSelecionada);
            
            
        }

        private Conta BuscaContaSelecionada()
        {

            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];

        }

        private void MostraConta(Conta contaSelecionada)
        {

            textoTitular.Text = Convert.ToString(contaSelecionada.Titular);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
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

            if (string.IsNullOrEmpty(textoTitular.Text))
            {
                MessageBox.Show("Selecione um cliente! ");

            }
            else
            {
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
                        MessageBox.Show("Valor depositado com êxito!");
                        textoValorDeposito.Text = ("");
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
        }

        private void Saca_Click(object sender, EventArgs e)
        {

            string textoValorDoSaque = textoValorSaque.Text;
            if (string.IsNullOrEmpty(textoTitular.Text))
            {
                MessageBox.Show("Selecione um cliente! ");

            }
            else
            {

                if (String.IsNullOrEmpty(textoValorDoSaque))
                {
                    MessageBox.Show("Digite algum valor a ser sacado!");
                    textoValorSaque.Text = ("");
                }
                else
                {
                    double valorSaque = Convert.ToDouble(textoValorDoSaque);
                    Conta contaSelecionada = this.BuscaContaSelecionada();

                    try
                    {
                        contaSelecionada.Saca(valorSaque);
                        MessageBox.Show("Dinheiro liberado! ");
                        textoValorSaque.Text = ("");
                    }
                    catch (SaldoInsuficienteExeception)
                    {
                        MessageBox.Show("Saldo Insuficiente.");
                        textoValorSaque.Text = ("");

                    }
                    catch (System.ArgumentException)
                    {

                        MessageBox.Show("Valor digitado para saque inválido. ");
                        textoValorSaque.Text = ("");

                    }
                    this.MostraConta(contaSelecionada);
                }
            }
        }

        private void Transfere_Click(object sender, EventArgs e)
        {


            string textoValor = valorOperacao.Text;

            if (string.IsNullOrEmpty(textoTitular.Text))
            {
                MessageBox.Show("Selecione um cliente origem!");

            }
            else
            {
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

        private void formularioDeCadastro_Click(object sender, EventArgs e)
        {
            CadastroDeContas formularioDeCadastro = new CadastroDeContas(this);
            formularioDeCadastro.ShowDialog();
                }

        public void AdcionaContas(Conta conta)
        {
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;

            {
                comboContas.Items.Add(conta);
                destinoDaTransferencia.Items.Add(conta);
            } 
        }

        private void FormularioRemocao_Click(object sender, EventArgs e)
        {
            CadastroDeContas FormularioRemocao = new RemocaoDeContas(this);
            FormularioRemocao.ShowDialog();

        }

        public void RemocaoDeContas(Conta conta)
        {
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas--;

            {
                comboContas.Remove(conta);
                destinoDaTransferencia.Remove(conta);
            }
        }
    }
}
