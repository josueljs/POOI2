using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabSalProf
{
    class Mensalista:Professor
    {

        private double salariototalmensalista;


        public double SalarioTotalMensalista
        {
            get { return salariototalmensalista; }
        }


        public void CalcularSalarioMensalista()
        {
            salariototalmensalista = salariobase + horaatividade;
        }
    }
}
