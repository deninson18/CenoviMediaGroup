using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }
        
        public Usuarios()
        {
            UsuarioId = 0;
            NombreUsuario = "";
            Contrasena = "";
            TipoUsuario = "";

       }

        public Usuarios(int UsuarioId,string NombreUsuario,string Contrasena,string TipoUsuario)
        {
            this.UsuarioId = UsuarioId;
            this.NombreUsuario = NombreUsuario;
            this.Contrasena = Contrasena;
            this.TipoUsuario = TipoUsuario;
        }

        public bool Logeo(string nombreUsuario, string contrasena)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.Login(nombreUsuario, contrasena);
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert into Usuarios(NombreUsuario,Contrasena,TipoUsuario) values('{0}','{1}','{2}')",
                    this.NombreUsuario, this.Contrasena, this.TipoUsuario));

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
                retorno = conexion.Ejecutar(string.Format("Delete from Usuarios where UsuarioId={0}", this.UsuarioId));
            }catch(Exception ex)
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
                dt = conexion.ObtenerDatos(String.Format("select from Usuarios where Usuarioid={0}", IdBuscar));
                if (dt.Rows.Count > 0) { 
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                this.TipoUsuario = dt.Rows[0]["TipoUsuario"].ToString();
                }

                return dt.Rows.Count > 0;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }

       


        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }

        public override bool Modificar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;

            try
            {
                retorno = conexion.Ejecutar(String.Format("update Usuarios set Usuario='{0}', Contrasena='{1}', TipoUsuario='{2}' where UsuarioId={3}",
                    this.NombreUsuario, this.Contrasena, this.TipoUsuario, this.UsuarioId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}
