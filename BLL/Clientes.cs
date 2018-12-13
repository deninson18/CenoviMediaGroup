using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Clientes : ClaseMaestra
    {
        public int ClienteId { get; set; }
        public int RutaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Apodos { get; set; }
        public int Sexo { get; set; }
        public string Direccion { get; set; }
        public string Referencia { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }

        public override bool Insertar()
        {
         
        }
        public override bool Buscar(int IdBuscar)
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

       

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }

        public override bool Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
