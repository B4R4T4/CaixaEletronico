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
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            
            

            InitializeComponent();
           
        }

        
           

                

        private void criarConta_Click(object sender, EventArgs e)
        {
            tipoDeConta.Items.Add("Poupanca");
            tipoDeConta.Items.Add("Corrente");

            if (String.IsNullOrEmpty(titularConta.Text))
            {
                MessageBox.Show("Preencha o nome do titular!");
            }

            else
            {

                if (String.IsNullOrEmpty(numeroConta.Text))
                {
                    MessageBox.Show("Numero da conta obrigatório!");

                }
                else
                {

                    if (String.IsNullOrEmpty(TextoCpf.Text))
                    {

                        MessageBox.Show("Preencha o cpf do titular!");

                    }

                    else
                    {
                        

                        int index = this.tipoDeConta.SelectedIndex;
                        Conta c = null;
                        if (tipoDeConta.SelectedText == "Poupanca")
                        {
                            c = new ContaPoupanca();
                                                    }
                        else
                        {
                            c = new ContaCorrente();
                        }

                        
                       

                        int numero = Convert.ToInt32(numeroConta.Text);
                        string cpf = Convert.ToString(TextoCpf.Text);
                        string titular = titularConta.Text;
                        


                        var contas = new List<Conta>();

                        Cliente cliente = new Cliente();
                        cliente.Nome = titular;
                        cliente.cpf = cpf;

                        Conta conta = new ContaCorrente();

                        conta.Numero = numero;
                        conta.Titular = cliente;
                        conta.Titular.cpf = cliente.cpf;
                        


                        this.aplicacaoPrincipal.AdcionaContas(conta);


                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        TextoCpf.Text = (" ");
                        numeroConta.Text = ("");
                        titularConta.Text = ("");
                    }
                }
            }
        }
        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            this.tipoDeConta.Items.Add("Poupanca");
            this.tipoDeConta.Items.Add("Corrente");
        }

        private void titularConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoDeConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
