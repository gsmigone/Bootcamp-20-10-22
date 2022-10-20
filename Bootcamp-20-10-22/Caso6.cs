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
    public partial class Caso6 : Form
    {

        string nombre = "";
        string apellido = "";
        DateTimePicker fecha = new DateTimePicker();

        public Caso6()
        {
            InitializeComponent();
            
            
        }

        private void bntGua_Click(object sender, EventArgs e)
        {
            nombre = txtNom.Text;
            apellido = txtApe.Text;
            fecha.Value = dtpNac.Value;
        }

        private void btnImpA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + nombre + " Apellido: " + apellido);
        }

        private void btnTod_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + nombre + " Apellido: " + apellido + " Edad: " + Convert.ToInt16(DateTime.Now.Year - Convert.ToInt16(fecha.Value.Year)));
        }
    }
}
