using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class ConexionDb
    {
        private SqlConnection con;
        private SqlCommand Cmd;
    

        public ConexionDb(){

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
            Cmd =new SqlCommand();
           
            }
        public bool Ejecutar(String ComandoSql)
        {
            bool retorno = false;

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;
                Cmd.ExecuteNonQuery();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }

        public DataTable ObtenerDatos(String ComandoSql)
        {

            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = ComandoSql;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        public bool Login(String Usuario,string Contrasena)
        {
            try
            {
                con.Open();
                SqlCommand Cmd = new SqlCommand("SELECT Nombres,Apellidos,TipoUsuario FROM Usuarios WHERE NombreUsuario =@nombreUsuario AND Contrasena = @contrasena", con);
                    Cmd.Parameters.AddWithValue("nombreUsuario",Usuario);
                    Cmd.Parameters.AddWithValue("contrasena", Contrasena);
                    SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
    
