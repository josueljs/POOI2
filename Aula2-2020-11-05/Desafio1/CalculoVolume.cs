using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class CalculoVolume
    {

        private int comprimento, largura, altura;

        public CalculoVolume(int comp1, int larg1, int alt1)
        {
            comprimento = comp1;
            largura = larg1;
            altura = alt1;
        }


        public string CalcularVolume()
        {
            return string.Format ("O volume é de {0}m³",(altura*comprimento*largura));
        }

    }
}
