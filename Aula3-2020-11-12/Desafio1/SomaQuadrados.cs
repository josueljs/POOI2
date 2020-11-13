using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class SomaQuadrados
    {

        private double Num1;
        private double Num2;
        private double Num3;

        public SomaQuadrados()
        {
            Num1 = 0;
            Num2 = 0;
            Num3 = 0;
        }

        public double num1
        {
            get { return Num1; }
            set { Num1 = value; }
        }

        public double num2
        {
            get { return Num2; }
            set { Num2 = value; }
        }

        public double num3
        {
            get { return Num3; }
            set { Num3 = value; }
        }

        public string Calcular()
        {
            return "A soma dos quadrados de " + Num1 + ", " + Num2 + " e " + Num3 + " é " + (Math.Pow(Num1, 2) + Math.Pow(Num2, 2) + Math.Pow(Num3, 2)).ToString("N0");
        }

    }
}
