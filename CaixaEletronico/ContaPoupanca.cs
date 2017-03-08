using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta, ITributavel
    {
       

        public override void Deposita (double valor)
        {
            this.Saldo = +valor;

        }

        public override void Saca(double valor)
        {
            this.Saldo = -valor;
        }

        public override void Transfere(Conta destino, double valor)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;

        }



    }
    }
    
    
    

