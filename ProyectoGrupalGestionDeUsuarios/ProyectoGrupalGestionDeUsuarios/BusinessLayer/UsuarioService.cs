using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.BusinessLayer
{
    public class UsuarioService
    {
        private UsuarioDao oUsuarioDao;

        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }
        public IList<Usuario> ObtenerTodos()
        {
            return oUsuarioDao.GetAll();
        }

        //public Usuario ValidarUsuario(string usuario, string password)
        //{
        //    var usr = oUsuarioDao.GetUser(usuario);

        //    if (usr.Password != null && usr.Password.Equals(password))
        //    {
        //        return usr;
        //    }

        //    return null;
        //}
        public Usuario ValidarUsuario(string usuario, string password)
        {
            var usr = oUsuarioDao.GetUser(usuario);

            if (usr != null)
            {
                if (usr.Password != null && usr.Password.Equals(password))
                {
                    return usr;
                }
            }

            return null;
        }
    }
}
