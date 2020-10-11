using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System;
using System.Data;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
namespace ProyectoGrupalGestionDeUsuarios
{
    public class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();
        UsuarioDao UsuarioDao = new UsuarioDao();

        private DBHelper()
        {
            //string_conexion = @"Data Source=DESKTOP-IJEL4J8\SQLEXPRESS;Initial Catalog=Bugs_Extendido;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string_conexion = "Data Source=DESKTOP-MGL5JN4;Initial Catalog=BugsTracker_Ext;User ID=sa;Password=pcN4conexion";
            //string_conexion = "workstation id=ProyectoUsuarios.mssql.somee.com;packet size=4096;user id=jessica_ardi_SQLLogin_1;pwd=ssklwm8k3k;data source=ProyectoUsuarios.mssql.somee.com;persist security info=False;initial catalog=ProyectoUsuarios";

            //base al servidor oficial
            //string_conexion = "workstation id=ProyectoUsuarios.mssql.somee.com;packet size=4096;user id=jessica_ardi_SQLLogin_1;pwd=ssklwm8k3k;data source=ProyectoUsuarios.mssql.somee.com;persist security info=False;initial catalog=ProyectoUsuarios";

            //base al servidor de pruebas
            //string_conexion = "workstation id=ProyectoUsuariosPruebas.mssql.somee.com;packet size=4096;user id=jessi_siles_SQLLogin_1;pwd=z2mxqfv1vc;data source=ProyectoUsuariosPruebas.mssql.somee.com;persist security info=False;initial catalog=ProyectoUsuariosPruebas";
        }

        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public int EjecutarSQL(string strSql)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //comienzo de transaccion...
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = strSql;
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //Commit de transacción...
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        /// Resumen:
        ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ///      La función recibe por valor una sentencia sql como string y un diccionario de objetos como parámetros
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQLConParametros(string sqlStr, Dictionary<string, object> prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in prs)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }


        
    }

}
