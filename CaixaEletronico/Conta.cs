using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get;  set; }
        public double Saldo { get; protected set; }



        public abstract void Saca(double valor);
        
        public abstract void Deposita(double valor);

        public abstract void Transfere(Conta destino, double valor);


            
                    }
    }
