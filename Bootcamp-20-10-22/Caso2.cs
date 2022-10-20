using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootcamp_20_10_22
{
    public partial class Caso2 : Form
    {
        public Caso2()
        {
            InitializeComponent();
        }

        private void btnIdent_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt16(txtEdad.Text);
            
            IdentificarEdad(edad);
        }

        public void IdentificarEdad(int edad)
        {
            switch (edad)
            {
                case 0:
                    Imprimir("ERROR");
                    break;
                case int n when (n < 18 && n > 0):
                    Imprimir("Es menor de edad");
                    break ;
                case int n when (n < 60 && n >= 18 ):
                    Imprimir("Es mayor de edad");
                    break;
                default:
                    Imprimir("Es adulto mayor");
                    break;

            }
               
        }

        public void Imprimir(string texto)
        {
            MessageBox.Show(texto);
        }

    }
}
