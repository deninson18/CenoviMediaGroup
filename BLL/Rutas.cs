using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Rutas : ClaseMaestra
    {
        public int RutaId { get; set; }
        public string Descripcion { get; set; }

        public Rutas()
        {
            RutaId = 0;
            Descripcion = "";
        }

        public Rutas(int RutaId, string Descripcion)
        {
            this.RutaId = RutaId;
            this.Descripcion = Descripcion;
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert into Rutas(Descripcion) values('{0}')",
                    this.Descripcion));

            } catch (Exception ex)
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
                retorno = conexion.Ejecutar(String.Format("Dele from Rutas Where RutaId={0}", this.RutaId));
            } catch (Exception ex)
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
                retorno = conexion.Ejecutar(string.Format("Update Rutas Set Descripcion='{0}' WHERE RutaId={1}", this.Descripcion, this.RutaId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;

        }

        public override bool Buscar(int IdBuscar)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos(String.Format(" Select * From Rutas Where RutaId={0}", IdBuscar));
            if (dt.Rows.Count > 0)
            {
                this.RutaId = (int)dt.Rows[0]["RutaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return dt.Rows.Count > 0;

        }


        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " From Rutas Where " + Condicion + Orden));
        }
    }

       
    }

