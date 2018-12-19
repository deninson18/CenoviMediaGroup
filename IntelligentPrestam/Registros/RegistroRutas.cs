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
    public partial class RegistroRutas : Form
    {
        public RegistroRutas()
        {
            InitializeComponent();
        }

        public void LlenarDataGrid()
        {
            Rutas ruta = new Rutas();
            RutadataGridView.DataSource = ruta.Listado(" * ", " 1=1 ", "  ");
        }

        public void Limpiar()
        {
            idRutatextBox.Clear();
            descripcionRutatextBox.Clear();
        }

        public void CargarDatosRutas(Rutas ruta)
        {
            int id = Utility.ConvierteEntero(idRutatextBox.Text);
            ruta.RutaId = id;
            ruta.Descripcion = descripcionRutatextBox.Text;
        }
        public void DelvoverDatosRutas(Rutas ruta)
        {
            idRutatextBox.Text = ruta.RutaId.ToString();
            descripcionRutatextBox.Text = ruta.Descripcion;
        }
        private void Asignar()
        {
            if(RutadataGridView.SelectedRows.Count > 0)
            {
                idRutatextBox.Text = RutadataGridView.CurrentRow.Cells["RutaId"].Value.ToString();
                descripcionRutatextBox.Text = RutadataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE UNA FILA");
            }
        }

        private void guardarRutabutton_Click(object sender, EventArgs e)
        {
            Rutas ruta = new Rutas();
            CargarDatosRutas(ruta);
            if (idRutatextBox.Text == "")
            {
                if (descripcionRutatextBox.Text != "")
                {

                    if (ruta.Insertar())
                    {
                        Limpiar();
                        MessageBox.Show("Guardo Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar los campos obligatorios", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
                
            
        }

        private void nuevoRutabutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RegistroRutas_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void eliminarRutabutton_Click(object sender, EventArgs e)
        {

        }
    }
}
