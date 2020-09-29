

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
using System.Windows.Forms;
using System.Data.SqlClient;

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

        //ABMC USUARIOS
        
        public string identCurrent()
        {
            string lastId = "SELECT IDENT_CURRENT('Usuarios')";
            return lastId;
        }
        public string insertarUsuario(string usuario, string pass, string email, string estado, int perfil)
        {
            string insertarUsuario = "INSERT INTO USUARIOS (id_perfil,usuario,password,email,estado,borrado) VALUES (" + perfil + ",'" + usuario + "','" + pass + "','" + email + "','" + estado + "',0)";
           
            return insertarUsuario;
            
        }
        public string modificarUsuario(int id_usuario,int id_perfil,string usuario, string pass, string email,string estado)
        {
            string modificar = "UPDATE Usuarios SET borrado = 0,id_perfil = "+ id_perfil +", usuario = '"+ usuario +"', password = '"+ pass +"',email = '"+ email +"', estado = '"+ estado +"' WHERE id_usuario = " + id_usuario;
            return modificar;
        }
        public void actualizarusuario(string SQLactualizar)
        {
            DBHelper.GetDBHelper().EjecutarSQL(SQLactualizar);

        }

        public string consultarPerfiles()
        {
            string consultarperfil = "SELECT * FROM Perfiles";
            return consultarperfil;
        }
        public string consultaUsuarios()
        {
            string consultaUusuarios = "SELECT id_usuario,usuario,password,email,nombre,estado FROM Usuarios INNER JOIN Perfiles ON Usuarios.id_perfil = Perfiles.id_perfil WHERE Usuarios.borrado = 0";
            return consultaUusuarios;
        }
        public string buscarPorNombreUsuario(string nombre)
        {
            string nombreUsuario = "SELECT id_usuario,usuario,password,email,nombre,estado FROM Usuarios INNER JOIN Perfiles ON Usuarios.id_perfil = Perfiles.id_perfil WHERE Usuarios.usuario = '"+ nombre +"'";
            return nombreUsuario;
        }
        public DataTable Consultar(string consultarParametro)
        {
            DataTable consulta = DataManager.GetInstance().ConsultaSQL(consultarParametro);
            return consulta;
        }
        public void EliminarPorId(int idAEliminar)
        {
            string buscarEliminar = "UPDATE Usuarios SET borrado = 1 WHERE id_usuario = " + idAEliminar + "";
            actualizarusuario(buscarEliminar);
        }
        public string BuscarPorId(int buscar)
        {
            string buscarId = "SELECT id_usuario,usuario,password,email,nombre,estado FROM Usuarios INNER JOIN Perfiles ON Usuarios.id_perfil = Perfiles.id_perfil WHERE Usuarios.id_usuario = " + buscar + "";
            return buscarId;
        }
        public string buscarAdministrador()
        {
            string administrador = "SELECT nombre, id_usuario FROM Usuarios INNER JOIN Perfiles ON Usuarios.id_perfil = Perfiles.id_perfil WHERE Perfiles.nombre = 'administrador'";
            return administrador;

        }
        public string buscarNombreUsuario(string nombre)
        {
            string nomUsuario = "SELECT usuario,id_usuario FROM Usuarios WHERE usuario = '" + nombre +"'";
            return nomUsuario;
        }
        public void ConectarUsuario(string SQLInsertar)
        {
            //int var, int perfil, TextBox txtUsuario, TextBox txtPass, TextBox txtEmail, string estado
            DataManager.GetInstance().Open();
            DataManager.GetInstance().EjecutarSQL(SQLInsertar);
            DataManager.GetInstance().Close();
        }
        public string insertarHistorico(string fecha, string titulo, string descripcion, int id_usuario)
        {
            string historico = "insert into UsuariosHistorico select '"+ fecha + "','" + titulo + "','" + descripcion + "',id_usuario,"
            + "id_perfil,usuario,password,email,estado,borrado from Usuarios where id_usuario =" + id_usuario;
            return historico;
        }

        
    
        public DataTable prueba()
        {
            DataTable pru = Consultar(identCurrent());
            return pru;
        }

        public bool UsuarioConHistorial(Usuario user, string fecha, string titulo, string descripcion)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                //Ejecuto el insert de usuario
                dm.EjecutarSQL(insertarUsuario(user.NombreUsuario, user.Password, user.Email, user.Estado, user.perfil));
                //MessageBox.Show(insertarUsuario(user.NombreUsuario, user.Password, user.Email, user.Estado, user.perfil), "muestro la sentencia insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var newId = dm.ConsultaSQLScalar(identCurrent());
                //MessageBox.Show(Convert.ToString(newId), "muestro el identity", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Guarda en newId el identity generado

                int Id = Convert.ToInt32(newId);
                //string historico = "insert into UsuariosHistorico select '" + fecha + "','" + titulo + "','" + descripcion + "',id_usuario,"
                //+ "id_perfil,usuario,password,email,estado,borrado from Usuarios where id_usuario =" + Id;

               
                //MessageBox.Show(insertarHistorico(fecha, titulo, descripcion, Id), "muestro la sentencia insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //se envia el newId por parametro para realizar la busqueda en el insert into select
                dm.EjecutarSQL(insertarHistorico(fecha, titulo, descripcion, Id));

                dm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dm.Rollback();
                return false;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

        }
        public bool UsuarioModificarConHistorial(int id_usuario, Usuario user, string fecha, string titulo, string descripcion)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                
                dm.EjecutarSQL(modificarUsuario(id_usuario,user.perfil, user.NombreUsuario, user.Password, user.Email, user.Estado));
                
                dm.EjecutarSQL(insertarHistorico(fecha, titulo, descripcion, id_usuario));

                dm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dm.Rollback();
                return false;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

        }
    }

}

