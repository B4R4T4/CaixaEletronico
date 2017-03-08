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
            if (valor <= 0.0 )
            {
                throw new ArgumentException();

            }
           
            else {


                this.Saldo = +valor;
            }

        }

        public override void Saca(double valor)
        {
            if (valor <= 0.0 )
            {
                throw new ArgumentException();
            }


            if (valor > this.Saldo)
            {

                throw new SaldoInsuficienteExeception();
            }
            else
            {

                this.Saldo -= valor;
            }
        }

        public override void Transfere(Conta destino, double valor=0)
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
    
    
    

