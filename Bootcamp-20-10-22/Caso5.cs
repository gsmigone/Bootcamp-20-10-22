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
    public partial class Caso5 : Form
    {
        public Caso5()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            string rol = txtRol.Text;
            ValidarRol(rol);
        }

        private void ValidarRol(string rol)
        {
            switch (rol)
            {
                case "Administrador":
                    Imprimir("El rol es Administrador");
                    break;
                case "Estandar":
                    Imprimir("El rol es Estandar");
                    break;
                case "Invitado":
                    Imprimir("El rol es Invitado");
                    break;

            }
        }

        public void Imprimir(string texto)
        {
            MessageBox.Show(texto);
        }
    }
}
