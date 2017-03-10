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
            string titular = titularConta.Text;
            int numero = Convert.ToInt32(numeroConta.Text);

            Cliente cliente = new Cliente(titularConta.Text);

            Conta conta = new ContaCorrente
            {
                Numero = numero

            };

            Cliente c = new Cliente()
            {
                Nome = titular

            };
            this.aplicacaoPrincipal.AdcionaContas(conta);


        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {

        }

        private void titularConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
