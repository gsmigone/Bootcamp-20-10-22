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
    }
}
