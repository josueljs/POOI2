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
    public partial class FormSomaQuad : Form
    {
        public FormSomaQuad()
        {
            InitializeComponent();
        }

        SomaQuadrados soma = new SomaQuadrados();

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            soma.num1 = Convert.ToDouble(textBoxNum1.Text);
            soma.num2 = Convert.ToDouble(textBoxNum2.Text);
            soma.num3 = Convert.ToDouble(textBoxNum3.Text);
            labelResultado.Text = soma.Calcular();
        }
    }
}
