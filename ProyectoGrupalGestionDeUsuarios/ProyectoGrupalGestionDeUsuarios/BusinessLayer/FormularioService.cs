using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using System.Data;

namespace ProyectoGrupalGestionDeUsuarios.BusinessLayer
{
    public class FormularioService
    {
        private FormularioDao oFormularioDao;

        public FormularioService()
        {
            oFormularioDao = new FormularioDao();
        }

        public DataTable obtenerFormularios()
        {
            return oFormularioDao.RecuperarFormularios();
        }

        public Formulario obtenerFormulariosPorId(int id)
        {
            return oFormularioDao.recuperarFormularioPorID(id);
        }

        public bool YaExiste(string nombreF)
        {
            return oFormularioDao.existeFormulario(nombreF);
        }

        public void grabarFormulario(Formulario UnFormulario)
        {
            oFormularioDao.InsertarFormulario(UnFormulario);
        }

        public void actualizarFormulario(Formulario UnFormularioSeleccionado)
        {
            oFormularioDao.UpdateFormulario(UnFormularioSeleccionado);
        }

        public void eliminarFormulario(int id)
        {
            oFormularioDao.DeleteFormulario(id);
        }
    }
}
