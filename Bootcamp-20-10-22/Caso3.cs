using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bootcamp_20_10_22
{
    public partial class Caso3 : Form
    {
        public Caso3()
        {
            InitializeComponent();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt16(txtNum.Text);
            TablaDeMultiplicar(numero);
        }


        public void TablaDeMultiplicar(int numero)
        {

            
            for (int a = 1; a <= 12; a++)
            {
                listBox1.Items.Add(numero + " * " + a + "\n = " + numero * a);
               
            }

        }

    }
}
