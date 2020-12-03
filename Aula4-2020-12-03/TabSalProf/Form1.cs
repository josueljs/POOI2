using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabSalProf
{
    public partial class FormCalculoSalario : System.Windows.Forms.Form
    {
        public FormCalculoSalario()
        {
            InitializeComponent();
        }

        Mensalista pMensalista = new Mensalista();
        Aulista pAulista = new Aulista();

        private void ButtonCalcularMensalista_Click(object sender, EventArgs e)
        {
            pMensalista.Matricula = textBoxMatriculaProfessor.Text;
            pMensalista.Nome = textBoxNomeProfessor.Text;

            pMensalista.CalcularHoraAtividade(Convert.ToDouble(textBoxSalarioMensalista.Text));
            textBoxHoraAtividadeMensalista.Text = (pMensalista.HoraAtividade).ToString("N2");

            pMensalista.CalcularSalarioMensalista();
            textBoxSalarioTotalMensalista.Text = (pMensalista.SalarioTotalMensalista).ToString("N2");
        }

        private void ButtonCalcularAulista_Click(object sender, EventArgs e)
        {
            pAulista.Matricula = textBoxMatriculaProfessor.Text;
            pAulista.Nome = textBoxNomeProfessor.Text;

            pAulista.CalcularSalarioBaseAulista(Convert.ToInt32(textBoxAulasSemanaisAulista.Text),Convert.ToDouble(textBoxValorHoraAulista.Text));
            textBoxSalarioBaseAulista.Text = (pAulista.SalarioProfessorAulista).ToString("N2");

            pAulista.CalcularHoraAtividade(Convert.ToDouble(textBoxSalarioBaseAulista.Text));
            textBoxHoraAtividadeAulista.Text = (pAulista.HoraAtividade).ToString("N2");

            pAulista.CalcularDSR();
            textBoxDSRAulista.Text = (pAulista.DSR).ToString("N2");

            pAulista.CalcularSalarioAulista();
            textBoxSalarioTotalAulista.Text = (pAulista.SalarioTotalAulista).ToString("N2");

            MessageBox.Show(pAulista.Matricula + " - " + pAulista.Nome + "\nSalario: " + (pAulista.SalarioTotalAulista).ToString("N2"));
        }
    }
}
