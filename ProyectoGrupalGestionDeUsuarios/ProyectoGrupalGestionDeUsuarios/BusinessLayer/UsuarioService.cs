using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using System.Windows.Forms;
using System.Data;

namespace ProyectoGrupalGestionDeUsuarios.BusinessLayer
{
    public class UsuarioService
    {
        Usuario usuario = new Usuario();
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
        public bool busAdmin(ComboBox perfil, int id_usuario)
        {
            DataTable busca = oUsuarioDao.Consultar(oUsuarioDao.buscarAdministrador());
            string user = perfil.Text;
            int id_user = id_usuario;

            int cantidadUsuarios = busca.Rows.Count;
            if (cantidadUsuarios == 0)
            {
                return true;

            }
            if (cantidadUsuarios > 0)
            {
                user = user = busca.Rows[0][0].ToString();
                id_user = int.Parse(busca.Rows[0][1].ToString());
            }
            if (perfil.Text == "Administrador")
            {
                if (cantidadUsuarios >= 1 && id_user == id_usuario)

                    return true;

                else
                    MessageBox.Show("Ya se encuentra un Usuario con Perfil de Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    perfil.Focus();
                    return false;
            }
            else
                return true;
        }

        public bool bus(TextBox usuario, int id_usuario)
        {
            DataTable busca = oUsuarioDao.Consultar(oUsuarioDao.buscarNombreUsuario(usuario.Text));
            string user = usuario.Text;
            int id_user = id_usuario;

            int cantidadUsuarios = busca.Rows.Count;
            if (cantidadUsuarios == 0)
            {
                return true;

            }
            if (cantidadUsuarios > 0)
            {
                user = user = busca.Rows[0][0].ToString();
                id_user = int.Parse(busca.Rows[0][1].ToString());
            }

            if (cantidadUsuarios >= 1 && id_user == id_usuario)
            {
                return true;
            }
            else
                MessageBox.Show("Usuario Registrado, Ingrese un Nombre de Usuario Distinto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usuario.Focus();
                return false;
        }

        public int buscarAdmin(string buscar)
        {
            DataTable admin = oUsuarioDao.Consultar(buscar);
            int cantidadAdministradores = admin.Rows.Count;
            return cantidadAdministradores;
        }
        

        public bool validarCampos(TextBox usuario, TextBox Pass, TextBox Email, ComboBox perfil)
        {
            bool validar = true;
            if ((usuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usuario.Focus();
                return false;
            }
            
            if ((Pass.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Pass.Focus();
                return false;
            }
            if ((Email.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un email.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Email.Focus();
                return false;
            }
            if ((perfil.SelectedIndex == -1))
            {
                MessageBox.Show("Se debe ingresar un Perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                perfil.Focus();
                return false;

            }
            //if (perfil.Text == "Administrador" && buscarAdmin(oUsuarioDao.buscarAdministrador()) == 1)
            //{
            //    MessageBox.Show("Ya se encuentra un Usuario con Perfil de Administrador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    perfil.Focus();
            //    return false;
            //}

            else 

                return true;

        }

        
    }
}
