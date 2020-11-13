using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio3
{
    public partial class FormIMC : Form
    {


        public FormIMC()
        {
            InitializeComponent();
        }

        private void buttonIMC_Click(object sender, EventArgs e)
        {
            
            IMC calcimc = new IMC(Convert.ToDouble(textBoxPeso.Text), Convert.ToDouble(textBoxAltura.Text));

            labelIMC.Text = calcimc.CalcularIMC();

        }
    }
}
