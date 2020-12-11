using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Amigo:Pessoa
    {
        protected string local;
        protected int ano;

        public Amigo()
        {
            local = "";
            ano = 2000;
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }


    }
}
