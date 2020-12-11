using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Pessoa
    {
        protected string nome;
        protected string telefone;

        public Pessoa()
        {
            nome = "";
            telefone = "999999999";

        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


    }
}
