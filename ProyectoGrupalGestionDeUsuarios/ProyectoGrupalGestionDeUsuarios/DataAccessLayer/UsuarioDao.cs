

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using ProyectoGrupalGestionDeUsuarios.Entities;
using System.Data;

namespace ProyectoGrupalGestionDeUsuarios.DataAccessLayer
{
    public class UsuarioDao
    {
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoBugs = new List<Usuario>();

            var strSql = "SELECT id_usuario, usuario, email, estado from Usuarios  where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;
        }

        public Usuario GetUser(string pUsuario)
        {        
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT id_usuario, usuario, email, estado, password ",
                                               "   FROM Usuarios ",
                                               "  WHERE borrado=0 and usuario =  '", pUsuario, "'");

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
             if (resultado.Rows.Count > 0)
            {
                return MappingBug(resultado.Rows[0]);
            }

            return null;
        }

        private Usuario MappingBug(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                NombreUsuario = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Estado = row["estado"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null
            };

            return oUsuario;
        }
    }

}