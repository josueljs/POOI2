using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class FormNadador : System.Windows.Forms.Form
    {
        public FormNadador()
        {
            InitializeComponent();
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            Categoria nadador = new Categoria(Convert.ToInt16(textBoxIdade.Text));

            labelCategoria.Text = nadador.DefinirCategoria();
        }
    }
}
