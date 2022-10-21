using Microsoft.VisualBasic;
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
    public partial class Caso2_LoopsYVectores : Form
    {

        string[] productos = new string[8];
        decimal[] precios = new decimal[8];


        public Caso2_LoopsYVectores()
        {
            InitializeComponent();
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Nombre del Producto: ");
                productos[i] = nombre;
                decimal precio = Convert.ToDecimal(Interaction.InputBox("Ingrese precio del Producto: " + productos[i]));
                precios[i] = precio;
            }

            MostrarProductos();
            MostrarPrecios();





        }


        private void MostrarProductos()
        {
            foreach (string item in productos)
            {
                lbPro.Items.Add(item);
            }
        }

        private void MostrarPrecios()
        {
            foreach (decimal item in precios)
            {
                lbPre.Items.Add(item);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            foreach (decimal item in precios)
            {
                suma = suma + item;
            }
            MessageBox.Show("La suma de precios en total es: " + suma);
        }
    }
}
