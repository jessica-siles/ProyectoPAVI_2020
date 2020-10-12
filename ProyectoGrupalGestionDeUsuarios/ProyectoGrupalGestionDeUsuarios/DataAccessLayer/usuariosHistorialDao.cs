using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.DataAccessLayer
{
    public class usuariosHistorialDao
    {

        //public string cargarGrilla()
        //{
        //    string historico = "select * from usuariosHistorico";
        //    return historico;
        //}

        public string cargarGrilla()
        {
            string historico = "SELECT h.* , p.nombre " +
                               "FROM usuariosHistorico h INNER JOIN Perfiles p " +
                               "ON h.id_perfil=p.id_perfil";
            return historico;
        }

        public DataTable grilla(string consulta)
        {
            DataTable grillaHistorico = DataManager.GetInstance().ConsultaSQL(consulta);
            return grillaHistorico;
        }
        public string buscarNombre(string nombreUsuario)
        {
            string nombre = "SELECT * FROM UsuariosHistorico WHERE usuario = '"+ nombreUsuario + "'";
            return nombre;
        }

    }
}
