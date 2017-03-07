using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

       

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public virtual void Deposita (double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Atualiza (double taxa)
        {
            this.Saldo += this.Saldo * taxa;

        }

        public void Transfere(Conta destino, double valor)
        {
            this.Saca(valor);
            destino.Deposita(valor);


            
                    }
    }
}
