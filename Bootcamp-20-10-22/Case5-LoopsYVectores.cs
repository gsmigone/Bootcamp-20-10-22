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
    public partial class Case5_LoopsYVectores : Form
    {
        string[] provincias = new string[4];
        decimal[] temperaturas1 = new decimal[3];
        decimal[] temperaturas2 = new decimal[3];
        decimal[] temperaturas3 = new decimal[3];
        decimal[] temperaturas4 = new decimal[3];

        public Case5_LoopsYVectores()
        {
            InitializeComponent();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < provincias.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Nombre de Provincia");
                provincias[i] = nombre;
                switch (i)
                {
                    case 0:
                        AgregarTemperaturas(temperaturas1,i);
                        break;
                    case 1:
                        AgregarTemperaturas(temperaturas2, i);
                        break;
                    case 2:
                        AgregarTemperaturas(temperaturas3, i);
                        break;
                    case 3:
                        AgregarTemperaturas(temperaturas4, i);
                        break;
                }
                
            }

            MostrarProvincias();
            MostrarTemperaturas();
        }

        private void AgregarTemperaturas(decimal[] temp,int indice)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                decimal temperatura = Convert.ToInt16(Interaction.InputBox("Ingrese temperatura de " + provincias[indice]));
                temp[i] = temperatura;
            }
        }



        private void MostrarTemperaturas()
        {
            foreach (decimal item in temperaturas1)
            {
                lbTemp1.Items.Add(item);
            }
            foreach (decimal item in temperaturas2)
            {
                lbTemp2.Items.Add(item);
            }
            foreach (decimal item in temperaturas3)
            {
                lbTemp3.Items.Add(item);
            }
            foreach (decimal item in temperaturas4)
            {
                lbTemp4.Items.Add(item);
            }
        }


        private void MostrarProvincias()
        {
            foreach (string item in provincias)
            {
                lbPro.Items.Add(item);
            }
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            decimal media1 = 0;
            decimal media2 = 0;
            decimal media3 = 0;
            decimal media4 = 0;


            foreach (decimal item in temperaturas1)
            {
                media1 = media1 + item;
            }
            foreach (decimal item in temperaturas2)
            {
                media2 = media2 + item;
            }
            foreach (decimal item in temperaturas3)
            {
                media3 = media3 + item;
            }
            foreach (decimal item in temperaturas4)
            {
                media4 = media4 + item;
            }

            media1 = media1 / 3;
            media2 = media2 / 3;
            media3 = media3 / 3;
            media4 = media4 / 3;

            if ((media1 > media2) && (media1 > media3) && (media1 > media4))
            {
                MessageBox.Show(provincias[0] + " tiene la mayor temperatura media: " + media1);
            }
            else if ((media2 > media1) && (media2 > media3) && (media2 > media4))
            {
                MessageBox.Show(provincias[1] + " tiene la mayor temperatura media: " + media2);
            }
            else if ((media3 > media1) && (media3 > media2) && (media3 > media4))
            {
                MessageBox.Show(provincias[2] + " tiene la mayor temperatura media: " + media3);
            }
            else if ((media4 > media1) && (media4 > media2) && (media4 > media3))
            {
                MessageBox.Show(provincias[3] + " tiene la mayor temperatura media: " + media4);
            }
            else
            {
                MessageBox.Show("Hay Temperaturas medias totales iguales");
            }

        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            decimal media1 = 0;
            decimal media2 = 0;
            decimal media3 = 0;
            decimal media4 = 0;


            foreach (decimal item in temperaturas1)
            {
                media1 = media1 + item;
            }
            foreach (decimal item in temperaturas2)
            {
                media2 = media2 + item;
            }
            foreach (decimal item in temperaturas3)
            {
                media3 = media3 + item;
            }
            foreach (decimal item in temperaturas4)
            {
                media4 = media4 + item;
            }

            MessageBox.Show("Temperatura media de " + provincias[0]+ " es de:"+ (media1/3));
            MessageBox.Show("Temperatura media de " + provincias[1] + " es de:" + (media2 / 3));
            MessageBox.Show("Temperatura media de " + provincias[2] + " es de:" + (media3 / 3));
            MessageBox.Show("Temperatura media de " + provincias[3] + " es de:" + (media4 / 3));
        }
    }
}
