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
    public partial class Caso1_LoopsYVectores : Form
    {

        string[] alumnos = new string[4];
        int[] notas1 = new int[4];
        int[] notas2 = new int[4];
        int[] notas3 = new int[4];
        int[] notas4 = new int[4];


        public Caso1_LoopsYVectores()
        {
            InitializeComponent();
        }

        private void btnAlu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Nombre");
                alumnos[i] = nombre;
            }

            MostrarAlumnos();

        }


        private void MostrarAlumnos()
        {
            foreach (string item in alumnos)
            {
                lbAlu.Items.Add(item);
            }
        }


        private void MostrarNotas()
        {
            foreach (int item in notas1)
            {
                lbNot.Items.Add(item);
            }
            foreach (int item in notas2)
            {
                lbNot.Items.Add(item);
            }
            foreach (int item in notas3)
            {
                lbNot.Items.Add(item);
            }
            foreach (int item in notas4)
            {
                lbNot.Items.Add(item);
            }
        }


        private int[] AgregarNotas(int[] notas, string alumno)
        {
            for (int i = 0; i < 4; i++)
            {
                int nota = Convert.ToInt32(Interaction.InputBox("Ingrese Nota de " + alumno));
                notas[i] = nota;
            }
            return notas;
        }


        private void btnNot_Click(object sender, EventArgs e)
        {

                notas1 = AgregarNotas(notas1, alumnos[0]);
                notas2 = AgregarNotas(notas2, alumnos[1]);
                notas3 = AgregarNotas(notas3, alumnos[2]);
                notas4 = AgregarNotas(notas4, alumnos[3]);

 

            MostrarNotas();

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
    
                Imprimir(notas1, alumnos[0]);
                Imprimir(notas2, alumnos[1]);
                Imprimir(notas3, alumnos[2]);
                Imprimir(notas4, alumnos[3]);

        }


        public void Imprimir(int[] notas,string alumno)
        {
            decimal promedio = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
            decimal notaMayor = notas[0];




            if (notaMayor < notas[1])
            {
                notaMayor = notas[1];
            }
            if (notaMayor < notas[2])
            {
                notaMayor = notas[2];
            }
            if (notaMayor < notas[3])
            {
                notaMayor = notas[3];
            }




            if (promedio >= 7)
            {
                MessageBox.Show(alumno + " su promedio es: "+ promedio +", su nota mayor es: " +notaMayor+" calificación: Muy bien");
            }

            else if ((promedio < 7) && (promedio >= 4))
            {
                MessageBox.Show(alumno + " su promedio es: " + promedio + ", su nota mayor es: " + notaMayor + " calificación: Bien");
            }

            else
            {
                MessageBox.Show(alumno + " su promedio es: " + promedio + ", su nota mayor es: " + notaMayor + " calificación: debe recuperar");
            }



        }

        

    }
}
