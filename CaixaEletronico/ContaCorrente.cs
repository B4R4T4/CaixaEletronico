using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
     class ContaCorrente :Conta

       
    {
        public static int TotalDeContas { get; private set; } = 0;
        public ContaCorrente()
        {
            ContaCorrente.TotalDeContas++;
                       

        }
        public override void Saca(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();
            }
            if (valor < this.Saldo)
            {


                throw new SaldoInsuficienteExeception();
            }
            else { 

            this.Saldo -= valor * 0.02;
            }
        }
        public override void Deposita(double valor)
        {
            if (valor <= 0.0)
            {

                throw new ArgumentException();
            }
            else
            {

                this.Saldo += valor;
            }
        }

        public override void Transfere(Conta destino, double valor)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
