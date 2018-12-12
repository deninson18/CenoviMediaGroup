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

namespace IntelligentPrestam.Registros
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        public void CargarDatosUsuario(Usuarios usuario)
        {
            int id = Utility.ConvierteEntero(IdUsertextBox.Text);
            usuario.UsuarioId = id;
            usuario.NombreUsuario = nombreUsertextBox.Text;
            usuario.Contrasena = contrasenaUsertextBox.Text;
            usuario.TipoUsuario = TipoUsertextBox.Text;
        }

        public void DevolverDatos(Usuarios usuario)
        {
            IdUsertextBox.Text = usuario.UsuarioId.ToString();
            nombreUsertextBox.Text = usuario.NombreUsuario;
            contrasenaUsertextBox.Text = usuario.Contrasena;
            TipoUsertextBox.Text = usuario.TipoUsuario;
        }

        public void Limpiar()
        {
            IdUsertextBox.Clear();
            nombreUsertextBox.Clear();
            contrasenaUsertextBox.Clear();
            TipoUsertextBox.Clear();
        }

        private void guardarUserbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();


            CargarDatosUsuario(usuario);
            if (IdUsertextBox.Text.Length <= 0)
            {
                if (usuario.Insertar())
                {
                    MessageBox.Show("Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error Al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void modificarUserbutton_Click(object sender, EventArgs e)
        {

        }
    }
    }

