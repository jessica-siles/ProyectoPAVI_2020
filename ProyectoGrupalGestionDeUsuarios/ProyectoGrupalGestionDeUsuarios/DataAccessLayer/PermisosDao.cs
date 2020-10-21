using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoGrupalGestionDeUsuarios.Entities;

namespace ProyectoGrupalGestionDeUsuarios.DataAccessLayer
{
    public class PermisosDao
    {
        UsuarioDao userdao = new UsuarioDao();

        //strings de busqueda de los formularios para asignar
        string dgvSinAsignar = "SELECT id_formulario,nombre,descripcion FROM Formularios WHERE borrado = 0";

        public DataTable cargaFormSinAsignar()
        {
            DataTable formSinAsignar = userdao.Consultar(dgvSinAsignar);
            return formSinAsignar;
        }

        public DataTable buscarPorPerfilForms(int Permisoperfil)
        {
            string consultaPorPerfil = "SELECT Formularios.id_formulario, Formularios.nombre, Formularios.borrado, " +
                                       "Formularios.descripcion FROM Formularios " +
                                       "INNER JOIN Permisos " +
                                       "ON Formularios.id_formulario = Permisos.id_formulario " +
                                       "WHERE id_perfil = " + Permisoperfil + 
                                       " AND Formularios.borrado = 0 AND permisos.borrado = 0";
            DataTable buscarForms = userdao.Consultar(consultaPorPerfil);
            return buscarForms;
        }

        public DataTable MostrarNoRepetidos(int PermisoPerfil)
        {
            string norepetidos = "SELECT * FROM Formularios " +
                                 "WHERE id_formulario " +
                                 "NOT IN (SELECT id_formulario FROM Permisos WHERE id_perfil = " + PermisoPerfil + " AND borrado = 0) " +
                                 "AND borrado = 0";
            DataTable mostrarNOrepetidos = userdao.Consultar(norepetidos);
            return mostrarNOrepetidos;
        }

        public DataTable botonAgregar(int PermisoPerfil, int id_form)
        {
            string quitarNoAsignados = "SELECT * FROM Formularios WHERE id_formulario NOT IN (SELECT id_formulario FROM permisos WHERE id_perfil = " + PermisoPerfil + " AND borrado = 0) AND id_formulario != " + id_form + " AND borrado = 0";
            DataTable quitNoAsig = userdao.Consultar(quitarNoAsignados);
            return quitNoAsig;
        }

        public DataTable buscarFormAsignado(int perfil, int formulario)
        {
            string buscar = "SELECT id_formulario FROM Permisos WHERE id_formulario = " + formulario + " AND id_perfil = " + perfil;
            DataTable resultado = userdao.Consultar(buscar);

            int buscarForm = -1;
            if (resultado.Rows.Count > 0)
            {
                buscarForm = Convert.ToInt32(resultado.Rows[0][0]);
            }

            return resultado;
        }

        

        public void eliminartodos(int perfil)
        {
            string eliminartodos = "UPDATE Permisos SET borrado= 1 WHERE id_perfil = " + perfil;
            DataManager.GetInstance().EjecutarSQL(eliminartodos);
        }

        public bool transaccion(List<int>insertar,List<int>quitar,List<int>modificar,int perfil, int borradoQuitar, int borradoModificar, string fecha)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                
               
               
                    for (int i = 0; i < quitar.Count; i++)
                    {
                    
                        string quitarPermisos = "UPDATE Permisos SET borrado=" + borradoQuitar +
                                               "WHERE id_formulario=" + quitar[i] + " AND id_perfil=" + perfil;

                        dm.EjecutarSQL(quitarPermisos);
                    }
              
                
                    for (int i = 0; i < modificar.Count; i++)
                    {
                                              
                        string modificarPermisos = "UPDATE Permisos SET borrado=" + borradoModificar +
                                               "WHERE id_formulario=" + modificar[i] + " AND id_perfil=" + perfil;

                    
                        dm.EjecutarSQL(modificarPermisos);
                    }
                

                for (int i = 0; i < insertar.Count; i++)
                {
                    string insertarPermisos = "INSERT INTO Permisos (fecha_alta,id_formulario , id_perfil, borrado)" +
                                              "VALUES ('" + fecha +"'," + insertar[i] + "," + perfil + "," + 0 + ")";
                   
                    dm.EjecutarSQL(insertarPermisos);
                }

                dm.Commit();

            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;

        }
        public DataTable recuperarFormulariosPorPerfil(int perfil)
        {
            return DBHelper.GetDBHelper().ConsultaSQL("SELECT f.* FROM Formularios f, Permisos p " +
                                                      "WHERE f.id_formulario = p.id_formulario " +
                                                      "AND p.id_perfil=" + perfil +
                                                      "AND p.borrado=0");
        }



    }
}
