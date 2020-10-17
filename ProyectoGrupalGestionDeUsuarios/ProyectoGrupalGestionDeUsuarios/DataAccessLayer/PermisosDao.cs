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

        public void agregarInsertDeForms(List<int> insertar, int perfil)
        {
            //hacer transaccion con for de varios forms con el id asignado
            for (int i = 0; i < insertar.Count; i++)
            {
                string insertarPermisos = "INSERT INTO Permisos (id_formulario , id_perfil, borrado)" +
                                          "VALUES (" + insertar[i] + "," + perfil + ","+ 0 +")";
                DBHelper.GetDBHelper().EjecutarSQL(insertarPermisos);
            }
        }

        public void modificarFormsUpdate(List<int> update, int perfil, int borrado)
        {
            //agregar transaccion con for de varios forms con el id seleccionado, asignandole
            //el borrado = 0
            for (int i = 0; i < update.Count ; i++)
            {
                //string modificarPermisos = "DELETE FROM Permisos " +
                //                           "WHERE id_formulario=" + update[i] + "AND id_perfil=" + perfil;
                string modificarPermisos = "UPDATE Permisos SET borrado="+borrado+
                                           "WHERE id_formulario="+update[i]+" AND id_perfil="+perfil;

                DBHelper.GetDBHelper().EjecutarSQL(modificarPermisos);
            }
        }
    }
}
