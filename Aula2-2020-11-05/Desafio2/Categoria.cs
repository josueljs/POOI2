using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Categoria
    {

        private int idade;

        public Categoria (int anos)
        {
            idade = anos;
        }

        public string DefinirCategoria()
        {
            if (idade<5)
            {
                return string.Format("Idade inválida!");
            }

            else
            {
                if (idade<8)
                {
                    return string.Format("Categoria Infantil A");
                }

                else
                {
                    if (idade<11)
                    {
                        return string.Format("Categoria Infantil B");
                    }

                    else
                    {
                        if (idade<14)
                        {
                            return string.Format("Categoria Juvenil A");
                        }

                        else
                        {
                            if (idade<18)
                            {
                                return string.Format("Categoria Juvenil B");
                            }

                            else
                            {
                                return string.Format("Categoria Adulto");
                            }
                        }
                    }
                }
            }
        }

    }
}
