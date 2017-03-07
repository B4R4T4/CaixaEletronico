using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Banco
    {
        public Conta[] conta = new Conta[10];

        public void Adiciona(Conta c)
        {

            conta[0] = c;

        }

    }
}
