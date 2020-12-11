using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Propriedade
    {
        protected string proprietario;
        protected int numfiscal;

        public Propriedade()
        {
            proprietario = "";
            numfiscal = 0;
        }

        public string Proprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }

        public int Numfiscal
        {
            get { return numfiscal; }
            set { numfiscal = value; }
        }

        public void CalcularRendaMinima()
        {

        }
    }
}
