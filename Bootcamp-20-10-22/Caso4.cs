using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bootcamp_20_10_22
{
    public partial class Caso4 : Form
    {
        public Caso4()
        {
            InitializeComponent();
            cmbOpc.Items.Add("Rectangulo");
            cmbOpc.Items.Add("Trapecio");
            cmbOpc.Items.Add("Circulo");
       

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (cmbOpc.SelectedItem != null)
            {
                MessageBox.Show(cmbOpc.SelectedItem.ToString());
            }
            switch (cmbOpc.SelectedItem)
            {
                case "Rectangulo":
                    decimal baseRec = Convert.ToDecimal(txtBRec.Text);
                    decimal alturaRec = Convert.ToDecimal(txtARec.Text);
                    MessageBox.Show("El área del rectángulo es: " + baseRec* alturaRec);
                    break;
                case "Trapecio":
                    decimal alturaTra = Convert.ToDecimal(txtATra.Text);
                    decimal base2Tra = Convert.ToDecimal(txtB2Tra.Text);
                    decimal base1Tra = Convert.ToDecimal(txtB1Tra.Text);
                    MessageBox.Show("El área del trapecio es: " + ((base2Tra + base1Tra)* alturaTra)/2);
                    break;
                case "Circulo":
                    double diametroCir = Convert.ToDouble(txtDCir.Text);
                    MessageBox.Show("El área del circulo es: " + Math.PI * 2 * (diametroCir / 2));
                    break;
            }
        }
    }
}
