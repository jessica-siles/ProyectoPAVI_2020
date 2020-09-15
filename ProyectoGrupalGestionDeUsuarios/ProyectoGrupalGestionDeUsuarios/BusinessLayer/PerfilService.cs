using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using System.Data;
using System.Windows.Forms;

namespace ProyectoGrupalGestionDeUsuarios.BusinessLayer
{
    class PerfilService
    {
        private PerfilDao oPerfilDao;
        public PerfilService()
        {
            oPerfilDao = new PerfilDao();
        }

        public IList<Perfil> obtenerPerfiles()
        {
            return oPerfilDao.GetAll();
        }

        //llamando al dbhelper para enviarle el texto de los campos (nombre de perfil y descripcion) para agregar en la tabla sql
        public void insertarPerfil(string nombre, string descripcion)
        {
            if (validarCampos(nombre) == -1)
            {
                Perfil objperfil = new Perfil();
                string inserta = oPerfilDao.InsertarPerfil(nombre, descripcion);
                oPerfilDao.actualizar(inserta);
            }
        }
        //validacion del campo nombre de perfil
        public int validarCampos(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Se debe ingresar un nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            else
            {
                MessageBox.Show("Perfil Generado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return -1;
            }
        }

        public void eliminarPerfil(int perfil)
        {

            oPerfilDao.EliminarPorId(perfil);



        }
        


    }
}
