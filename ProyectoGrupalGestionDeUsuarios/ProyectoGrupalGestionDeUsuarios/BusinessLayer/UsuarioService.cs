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
        Usuario valCamposUsuario = new Usuario();

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

        public int ValidarModificaciones(Usuario usuario, int ID, string perfilSelec)
        {
            
            int contador = 0;
            DataTable validar = oUsuarioDao.Consultar(oUsuarioDao.BuscarPorId(ID));
            
            
            if (validar.Rows[0][2].ToString() != usuario.Password)
            {
               
                
                
                contador += 1;
                valCamposUsuario.Password = "S";
            }
            
            if (validar.Rows[0][3].ToString() != usuario.Email)
            {

                
                contador += 1;
                valCamposUsuario.Email = "S";
            }
            
            if (validar.Rows[0][5].ToString() != usuario.Estado)
            {
                

                
                contador += 1;
                valCamposUsuario.Estado = "S";
            }

            if (validar.Rows[0][4].ToString() != perfilSelec.ToString())
            {
                
                contador += 1;
                valCamposUsuario.perfil = 1;
            }
            else
            { 
                //nothing

            }


            return contador;
            

        }
        public string Descripcion()
        {
            string desc = "";
            
            if (valCamposUsuario.Password == "S")
            {
                desc += " Password,";
            }
            if (valCamposUsuario.Email == "S")
            {
                desc += " Email,";
            }
            if (valCamposUsuario.Estado == "S")
            {
                desc += " Estado,";
            }
            if (valCamposUsuario.perfil == 1)
            {
                desc += " Perfil,";
            }
            else
            {
                //nothing

            }

            return desc;
        }
    }
}
