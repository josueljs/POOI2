using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMedia : Form
    {
        public FormMedia()
        {
            InitializeComponent();
        }

        Aluno aluno1 = new Aluno();

        private void buttonCalcularMedia_Click(object sender, EventArgs e)
        {
            aluno1.Nome = textBoxNome.Text;
            aluno1.Nota1 = Convert.ToDouble(textBoxNota1.Text);
            aluno1.Nota2 = Convert.ToDouble(textBoxNota2.Text);
            labelRetornaMedia.Text = aluno1.CalcularMedia();
        }
    }
}
