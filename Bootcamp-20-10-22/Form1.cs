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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {


            decimal baseRec = Convert.ToDecimal(txtBase.Text);
            decimal alturaRec = Convert.ToDecimal(txtAltura.Text);
            decimal areaRec = Area(baseRec,alturaRec);

            Imprimir("El área del rectángulo es: " + areaRec);



        }

        public void Imprimir(string texto)
        {
            MessageBox.Show(texto);
        }

        public decimal Area(decimal baseRec,decimal alturaRec)
        {
            decimal areaRec = baseRec * alturaRec;
            return areaRec;
        }
        
    }
}
