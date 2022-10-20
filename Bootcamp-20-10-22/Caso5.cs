using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Bootcamp_20_10_22
{
    public partial class Caso5 : Form
    {
        public Caso5()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            string rol = txtRol.Text.ToLower();
            rol = ValidarRol(rol);
            string sexo = txtSex.Text.ToLower();
            sexo = ValidarRol(sexo);
            string nombre = txtNom.Text.ToLower();
            Imprimir(nombre, sexo, rol);
        }

        private string ValidarRol(string rol)
        {
            string validador = "no";
            while (validador != "no" )
            {
                switch (rol) 
            { 
            
                case "administrador":
                        validador = "validado";
                    break;
                case "estandar":
                        validador = "validado";
                        break;
                case "invitado":
                        validador = "validado";
                        break;

            }
                if(validador != "validado")
                {
                    rol = Interaction.InputBox("Error!! Ingresar rol nuevamente : ", "Rol").ToLower();
                }
                
            }
            return rol;
            
        }


        private string ValidarSexo(string sexo)
        {

            string validador = "no";
            while (sexo != "validado")
            {
                switch (sexo)
                {

                    case "femenino":
                        validador = "validado";
                        break;
                    case "masculino":
                        validador = "validado";
                        break;
                 

                }
                if (validador != "validado")
                {
                    sexo = Interaction.InputBox("Error!! Ingresar sexo (masculino/femenino) nuevamente : ", "Sexo").ToLower();
                }

            }
            return sexo;

        }



        public void Imprimir(string nombre,string sexo, string rol)
        {
            MessageBox.Show("Nombre: "+nombre+" Sexo: "+sexo+" Rol: "+ rol);
        }

    }
}
