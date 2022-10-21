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
    public partial class Caso4_LoopsYVectores : Form
    {

        string[] personas = new string[5];
        int[] edades = new int[5];
        

        public Caso4_LoopsYVectores()
        {
            InitializeComponent();
        }

        private void btnPer_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < personas.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Nombre");
                personas[i] = nombre;
                int edad = Convert.ToInt16(Interaction.InputBox("Ingrese edad"));
                edades[i] = edad;

            }

            MostrarPersonas();
            MostrarEdades();

        }

        private void MostrarPersonas()
        {
            foreach (string item in personas)
            {
                lbPer.Items.Add(item);
            }
        }

        private void MostrarEdades()
        {
            foreach (int item in edades)
            {
                lbEda.Items.Add(item);
            }
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (int item in edades)
            {

                if(item >= 18)
                {
                    MessageBox.Show(personas[contador] + " es mayor de edad");
                }
                contador++;
            }
        }
    }
}
