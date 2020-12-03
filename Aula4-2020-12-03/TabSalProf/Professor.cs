using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabSalProf
{
    class Professor
    {

        protected string nome;
        protected string matricula;
        protected double salariobase;
        protected double horaatividade;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public double SalarioBase
        {
            get { return salariobase; }
        }

        public double HoraAtividade
        {
            get { return horaatividade; }
        }


        public void CalcularHoraAtividade(double salarioprofessor)
        {
            salariobase = salarioprofessor;
            horaatividade = salariobase * 0.05;
        }

    }
}
