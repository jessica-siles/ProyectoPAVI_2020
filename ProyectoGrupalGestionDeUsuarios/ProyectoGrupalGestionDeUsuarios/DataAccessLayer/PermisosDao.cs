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
            string consultaPorPerfil = "SELECT Formularios.id_formulario, Formularios.nombre, FORMULARIOS.borrado, Formularios.descripcion FROM Formularios INNER JOIN permisos ON Formularios.id_formulario = Permisos.id_formulario WHERE id_perfil = "+  Permisoperfil + " AND Formularios.borrado = 0 AND permisos.borrado = 0";
            DataTable buscarForms = userdao.Consultar(consultaPorPerfil);
            return buscarForms;

        }
        public DataTable MostrarNoRepetidos(int PermisoPerfil)
        {
            string norepetidos = "SELECT * FROM Formularios WHERE id_formulario NOT IN (SELECT id_formulario FROM permisos WHERE id_perfil = "+ PermisoPerfil +" AND borrado = 0) AND borrado = 0";
            DataTable mostrarNOrepetidos = userdao.Consultar(norepetidos);
            return mostrarNOrepetidos;

        }
        public DataTable botonAgregar(int PermisoPerfil, int id_form)
        {
            string quitarNoAsignados = "SELECT * FROM Formularios WHERE id_formulario NOT IN (SELECT id_formulario FROM permisos WHERE id_perfil = "+ PermisoPerfil +" AND borrado = 0) AND id_formulario != " + id_form + " AND borrado = 0";
            DataTable quitNoAsig = userdao.Consultar(quitarNoAsignados);
            return quitNoAsig;
        }

    }
}
