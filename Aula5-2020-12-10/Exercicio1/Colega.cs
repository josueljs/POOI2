using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Colega:Pessoa
    {
        protected string local;
        protected string profissao;

        public Colega()
        {
            local = "";
            profissao = "";
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }
    }
}
