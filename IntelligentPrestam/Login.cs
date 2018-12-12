using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace IntelligentPrestam
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            UsuarioLtextBox.Clear();
            ContrasenaLtextBox.Clear();
        }


        private void accesoUserbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Logeo(UsuarioLtextBox.Text, ContrasenaLtextBox.Text);
            if (UsuarioLtextBox.Text == "")
            {
                MessageBox.Show("Por Favor Llene los Campos Requeridos ");
               
                
            }
            else if (ContrasenaLtextBox.Text == "")
            {
                MessageBox.Show("Por Favor Llene los Campos Requeridos ");
                
            }
            else
            {

                if (usuario.Logeo(UsuarioLtextBox.Text, ContrasenaLtextBox.Text) == true)
                {
                    this.Hide();
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                  
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña estan Incorrectos, Por Favor intente de Nuevo");
                    Limpiar();
                    UsuarioLtextBox.Focus();

                   
                }
                              
            }

        }

        private void SalirUserbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿SEGURO QUE DESEA SALIR DEL SISTEMA ?", "ADVERTENCIA !", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        


    }
}
