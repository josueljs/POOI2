using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class IMC
    {

        private double peso, altura;

        public IMC(double pes, double alt)
        {
            peso = pes;
            altura = alt;
        }

        public string CalcularIMC()
        {
            double mass;
            mass = (peso / (altura * altura));

            if (mass<20)
            {
                return string.Format("Abaixo do peso.");
            }

            else
            {
                if (mass < 25)
                {
                    return string.Format("Peso normal.");
                }

                else
                {
                    if (mass < 30)
                    {
                        return string.Format("Acima do peso.");
                    }

                    else
                    {
                        if (mass<40)
                        {
                            return string.Format("Obeso.");

                        }

                        else
                        {
                            return string.Format("Obesidade mórbida!");
                        }
                    }
                }
            }
        }

    }
}
