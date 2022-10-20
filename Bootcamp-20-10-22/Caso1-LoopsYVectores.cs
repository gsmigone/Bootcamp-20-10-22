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


        public Caso1_LoopsYVectores()
        {
            InitializeComponent();
        }

        private void btnAlu_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < alumnos.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Nombre");
                alumnos[i] = nombre;
            }
        }
    }
}
