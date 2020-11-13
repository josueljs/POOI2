using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aluno
    {

        private string nome;
        private double nota1;
        private double nota2;


        public Aluno()
        {
            nome = "";
            nota1 = 0;
            nota2 = 0;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public string CalcularMedia()
        {
            return nome + ", sua média é " + ((nota1 + nota2) / 2).ToString("N2");
        }
    }
}
