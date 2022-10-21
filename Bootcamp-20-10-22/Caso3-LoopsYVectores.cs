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
    public partial class Caso3_LoopsYVectores : Form
    {

        string[] operarios = new string[4];
        decimal[] sueldos1 = new decimal[3];
        decimal[] sueldos2 = new decimal[3];
        decimal[] sueldos3 = new decimal[3];
        decimal[] sueldos4 = new decimal[3];


        public Caso3_LoopsYVectores()
        {
            InitializeComponent();
        }

        private void btnOpe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < operarios.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Nombre");
                operarios[i] = nombre;
            }

            MostrarOperarios();

        }


        private void MostrarOperarios()
        {
            foreach (string item in operarios)
            {
                lbOpe.Items.Add(item);
            }
        }

        private void MostrarSueldos()
        {
            foreach (decimal item in sueldos1)
            {
                lbSue.Items.Add(item);
            }
            foreach (decimal item in sueldos2)
            {
                lbSue.Items.Add(item);
            }
            foreach (decimal item in sueldos3)
            {
                lbSue.Items.Add(item);
            }
            foreach (decimal item in sueldos4)
            {
                lbSue.Items.Add(item);
            }
        }

        private void btnSue_Click(object sender, EventArgs e)
        {
            sueldos1 = AgregarSueldos(sueldos1, operarios[0]);
            sueldos2 = AgregarSueldos(sueldos2, operarios[1]);
            sueldos3 = AgregarSueldos(sueldos3, operarios[2]);
            sueldos4 = AgregarSueldos(sueldos4, operarios[3]);



            MostrarSueldos();
        }


        private decimal[] AgregarSueldos(decimal[] sueldos, string operario)
        {
            for (int i = 0; i < 3; i++)
            {
                int nota = Convert.ToInt32(Interaction.InputBox("Ingrese el sueldo número: "+ (i++) + " de " + operario));
                sueldos[i] = nota;
            }
            return sueldos;
        }

        private void btnTot_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            foreach (decimal item in sueldos1)
            {
                suma = suma + item;
            }
            foreach (decimal item in sueldos2)
            {
                suma = suma + item;
            }
            foreach (decimal item in sueldos3)
            {
                suma = suma + item;
            }
            foreach (decimal item in sueldos4)
            {
                suma = suma + item;
            }
            MessageBox.Show("La suma de precios en total es: " + suma);
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            decimal sueldo1 = 0;
            decimal sueldo2 = 0;
            decimal sueldo3 = 0;
            decimal sueldo4 = 0;

            foreach (decimal item in sueldos1)
            {
                sueldo1 = sueldo1 + item;
            }
            foreach (decimal item in sueldos2)
            {
                sueldo2 = sueldo2 + item;
            }
            foreach (decimal item in sueldos3)
            {
                sueldo3 = sueldo3 + item;
            }
            foreach (decimal item in sueldos4)
            {
                sueldo4 = sueldo4 + item;
            }

            if ((sueldo1 > sueldo2) && (sueldo1 > sueldo3) && (sueldo1 > sueldo4))
            {
                MessageBox.Show(operarios[0]+" es el mejor pago siendo su sueldo: " + sueldo1);
            }
            else if ((sueldo2 > sueldo1) && (sueldo2 > sueldo3) && (sueldo2 > sueldo4))
            {
                MessageBox.Show(operarios[1] + " es el mejor pago siendo su sueldo: " + sueldo2);

            }
            else if ((sueldo3 > sueldo1) && (sueldo3 > sueldo2) && (sueldo3 > sueldo4))
            {
                MessageBox.Show(operarios[2] + " es el mejor pago siendo su sueldo: " + sueldo3);
            }
            else if ((sueldo4 > sueldo1) && (sueldo4 > sueldo2) && (sueldo4 > sueldo3))
            {
                MessageBox.Show(operarios[3] + " es el mejor pago siendo su sueldo: " + sueldo4);
            }
            else
            {
                MessageBox.Show("Hay Sueldos totales iguales");
            }




        }
    }
}
