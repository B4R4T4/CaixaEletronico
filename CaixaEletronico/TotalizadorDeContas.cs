using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class TotalizadorDeContas
    {
        public double Taxa { get; private set; }

        public TotalizadorDeContas(double taxa)
        {

            this.Taxa = taxa;

        }
        
        public void Roda (Conta c)
        {

            c.Atualiza(this.Taxa);

        }
       

    }
}
