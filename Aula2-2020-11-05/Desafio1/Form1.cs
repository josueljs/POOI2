using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class FormVolume : Form
    {


        public FormVolume()
        {
            InitializeComponent();
        }

        private void buttonCalcularVolume_Click(object sender, EventArgs e)
        {
            CalculoVolume volume1 = new CalculoVolume(Convert.ToInt16(textBoxAltura.Text), Convert.ToInt16(textBoxComprimento.Text), Convert.ToInt16(textBoxLargura.Text));

            labelVolume.Text = volume1.CalcularVolume();
        }
    }
}
