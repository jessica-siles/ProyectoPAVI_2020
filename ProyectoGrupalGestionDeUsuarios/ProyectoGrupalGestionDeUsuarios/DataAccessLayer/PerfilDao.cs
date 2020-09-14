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

            String strSql = string.Concat("SELECT id_perfil, nombre, borrado, descripcion FROM Perfiles");

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPerfiles.Add(MappingBug(row));
            }

            return listadoPerfiles;
        }      

        private Perfil MappingBug(DataRow row)
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
        public string BuscarPorNombre(string nombre)
        {
            string consultaPorNombre = "SELECT id_perfil FROM Perfiles WHERE nombre='" + nombre + "'";
            var id = DBHelper.GetDBHelper().ConsultaSQL(consultaPorNombre);
            
            string id_per = id.Rows[0]["id_perfil"].ToString();
            return id_per;
        }


    }
}
