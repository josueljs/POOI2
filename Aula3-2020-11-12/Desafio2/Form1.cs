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
    public partial class FormAntSuc : Form
    {
        public FormAntSuc()
        {
            InitializeComponent();
        }

        AntecessorSucessor antsuc = new AntecessorSucessor();

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            antsuc.Num = Convert.ToDouble(textBoxNum.Text);
            labelAntecessor.Text = antsuc.CalcularAntecessor();
            labelSucessor.Text = antsuc.CalcularSucessor();
        }
    }
}
