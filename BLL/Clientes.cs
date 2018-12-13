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
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;

            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Clientes(RutaId,Nombres,Apellidos,Apodos,Sexo,Direccion,Referencia,Cedula,Telefono,Celular) Values ({0},'{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}')",
                    this.RutaId,this.Nombres,this.Apellidos,this.Apodos,this.Sexo,this.Direccion,this.Referencia,this.Cedula,this.Telefono,this.Celular));
            }catch(Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Delete From Clientes Where ClienteId={0} ",this.ClienteId));
            }catch(Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Modificar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Clientes Set RutaId={0}, Nombres='{1}', Apellidos='{2}', Apodos='{3}', Sexo={4} Direccion='{5}', Referencia='{6}', Cedula='{7}', Telefono='{8}', Celular='{9}' WHERE ClienteId={10}",
                    this.RutaId, this.Nombres, this.Apellidos, this.Apodos,this.Sexo, this.Direccion, this.Referencia, this.Cedula, this.Telefono, this.Celular, this.ClienteId));
            }
            catch(Exception ex)
            {
                throw ex;

            }
            return retorno;
        }
        public override bool Buscar(int IdBuscar)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(String.Format("Select * From Clientes Where ClienteId={0}",this.ClienteId));
                if(dt.Rows.Count > 0)
                {
                    this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                    this.RutaId = (int)dt.Rows[0]["RutaId"];
                    this.Nombres = dt.Rows[0]["Nombres"].ToString();
                    this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                    this.Apodos = dt.Rows[0]["Apodos"].ToString();
                    this.Sexo = (int)dt.Rows[0]["Sexo"];
                    this.Direccion = dt.Rows[0]["Direccion"].ToString();
                    this.Referencia = dt.Rows[0]["Referencia"].ToString();
                    this.Cedula = dt.Rows[0]["Cedula"].ToString();
                    this.Telefono = dt.Rows[0]["Telefono"].ToString();
                    this.Celular = dt.Rows[0]["Celular"].ToString();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenar;
            if (!Orden.Equals(""))
                ordenar = "Orden by" + Orden;
            try
            {
                return conexion.ObtenerDatos(("Select " + Campos + "From Clientes Where " + Condicion + Orden));
            }catch(Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
