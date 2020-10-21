using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using System.Data;

namespace ProyectoGrupalGestionDeUsuarios.BusinessLayer
{
    public class PermisoService
    {
        UsuarioDao userDao = new UsuarioDao();
        PermisosDao oPermisosDao = new PermisosDao();

        public void cargarComb(ComboBox combo)
        {

            DataTable perfiles = userDao.Consultar(userDao.consultarPerfiles());
            combo.DataSource = perfiles;
            combo.DisplayMember = perfiles.Columns[1].ColumnName;
            combo.ValueMember = perfiles.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;

            //if (combo.SelectedIndex == -1)
            //{
            //    combo.DisplayMember = "";
            //    combo.ValueMember = "0";
            //    return;
            //}
                

        }
        public void cargarComboGenerico(DataTable Cargar, ComboBox combo)
        {
            combo.DataSource = Cargar;
            combo.DisplayMember = Cargar.Columns[1].ColumnName;
            combo.ValueMember = Cargar.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        public DataTable obtenerFormulariosPorPerfil(int id)
        {
            return oPermisosDao.recuperarFormulariosPorPerfil(id);
        }
    }
}
