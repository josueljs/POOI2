using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabSalProf
{
    class Aulista:Professor
    {

        private double salarioprofessoraulista;
        private double salariototalaulista;
        private double dsr;


        public double SalarioProfessorAulista
        {
            get { return salarioprofessoraulista; }
        }

        public double SalarioTotalAulista
        {
            get { return salariototalaulista; }
        }

        public double DSR
        {
            get { return dsr; }
        }


        public void CalcularSalarioBaseAulista(int numeroaulas, double valoraulas)
        {
            salarioprofessoraulista = numeroaulas * valoraulas * 4.5;
        }

        public void CalcularDSR()
        {
            dsr = (salariobase + horaatividade) / 6;
        }

        public void CalcularSalarioAulista()
        {
            salariototalaulista = (salariobase + horaatividade + dsr);
        }
    }
}
