using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoGrupalGestionDeUsuarios.Entities;

namespace ProyectoGrupalGestionDeUsuarios.DataAccessLayer
{
    class PerfilDao
    {       
        //DBHelper oDatos = new DBHelper();
        
        public IList<Perfil> GetAll()
        {
            List<Perfil> listadoPerfiles = new List<Perfil>();

            String strSql = string.Concat("SELECT id_perfil, nombre, borrado, descripcion FROM Perfiles WHERE borrado=0");

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPerfiles.Add(MappingPerfil(row));
            }

            return listadoPerfiles;
        }      

        //Mapear los datos obtenidos de la tabla
        private Perfil MappingPerfil(DataRow row)
        {
            Perfil oPerfil = new Perfil

            {
                IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                Nombre = row["nombre"].ToString(),
                //Estado = Convert.ToBoolean(row["borrado"].ToString())
                Estado = row["borrado"].ToString(),
                Descripcion = row["descripcion"].ToString()
            };

            oPerfil.cambiarEstado();
            return oPerfil;
        }

        //comando insert
        public string InsertarPerfil(string Nombre, string Descripcion)
        {
            string InsertPerfil = "INSERT INTO Perfiles (nombre,borrado,descripcion) VALUES ('" + Nombre + "',0,'" + Descripcion + "')";

            return InsertPerfil;
        }
        //llamando a dbhelper para realizar la conexion
        public void actualizar(string SQLactualizar)
        {
            DBHelper.GetDBHelper().EjecutarSQL(SQLactualizar);

        }

        internal bool Update(Perfil oPerfil)
        {
            //SIN PARAMETROS

            string str_sql = "UPDATE Perfiles " +
                             "SET nombre=" + "'" + oPerfil.Nombre + "'" + "," +
                             " descripcion=" + "'" + oPerfil.Descripcion + "'," +
                             "borrado= "+oPerfil.Borrado+" "+
                             " WHERE id_perfil=" + oPerfil.IdPerfil+ "";

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        public Perfil GetPerfilSinParametros(string nombrePerfil)
        {
            //Construimos la consulta sql para buscar el perfil en la base de datos.
            String strSql = string.Concat(" SELECT id_perfil, ",
                                          "        nombre, ",
                                          "        borrado, ",
                                          "        descripcion ",
                                          "  FROM Perfiles");                                
                                          //"  WHERE borrado = 0");

            strSql += " WHERE nombre=" + "'" + nombrePerfil + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return MappingPerfil(resultado.Rows[0]);
            }

            return null;
        }
        public void EliminarPorId(int idAEliminar)
        {
            string buscarEliminar = "UPDATE Perfiles SET borrado = 1 WHERE id_perfil = " + idAEliminar + "";
            DBHelper.GetDBHelper().EjecutarSQL(buscarEliminar);

            string perfilPorDefecto = "UPDATE Usuarios SET ";
        }
    }
}
