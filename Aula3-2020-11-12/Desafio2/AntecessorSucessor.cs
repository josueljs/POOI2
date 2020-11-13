using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class AntecessorSucessor
    {

        private double num;


        public AntecessorSucessor()
        {
            num = 0;
        }


        public double Num
        {
            get { return num; }
            set { num = value; }
        }


        public string CalcularAntecessor()
        {
            return "O antecessor de " + num + " é " + (num - 1).ToString("N0");
        }

        public string CalcularSucessor()
        {
            return "O sucessor de " + num + " é " + (num + 1).ToString("N0");
        }

    }
}
