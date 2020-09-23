using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Usuarios
{
    public partial class frmAltaUsuario : Form
    {
        Usuario usuarioEntities = new Usuario();
        UsuarioDao UsuarioDao = new UsuarioDao();
        UsuarioService servicioUsuario = new UsuarioService();



        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargarComb(cboPerfil);
        }
        private void limpiarCampos()
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtEmail.Text = "";
            chkBoxEstado.Checked = false;
            cboPerfil.SelectedIndex = -1;
        }
        private bool ValidarCampos(TextBox campo)
        {
            // campos obligatorios
            if (campo.Text == string.Empty)
            {
                campo.BackColor = Color.Red;
                campo.Focus();
                return false;
            }

            else
                txtUsuario.BackColor = Color.White;

            return true;
        }
        
        private void cargarComb(ComboBox combo)
        {
            
            DataTable perfiles = UsuarioDao.Consultar(UsuarioDao.consultarPerfiles());
            combo.DataSource = perfiles;
            combo.DisplayMember = perfiles.Columns[1].ColumnName;
            combo.ValueMember = perfiles.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;

        }
        //public void validarRepetido()
        //{
        //    servicioUsuario.ad(UsuarioDao.buscarNombreUsuario(txtUsuario.Text));
        //}
        public bool buscaAdmin(ComboBox perfil)
        {
            DataTable busca = UsuarioDao.Consultar(UsuarioDao.buscarAdministrador());
            
            

            int cantidadUsuarios = busca.Rows.Count;

            if (perfil.Text == "Administrador")
            {
                if (cantidadUsuarios >= 1)

                    MessageBox.Show("Ya se encuentra un Usuario con Perfil de Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    perfil.Focus();
                    return false;
            }
            else
                return true;

        }
        public bool busUsuario(TextBox usuario)
        {
            DataTable busca = UsuarioDao.Consultar(UsuarioDao.buscarNombreUsuario(usuario.Text));
            string user = usuario.Text;
            

            int cantidadUsuarios = busca.Rows.Count;

            if (cantidadUsuarios >= 1)
            {

                MessageBox.Show("Usuario Registrado, Ingrese un Nombre de Usuario Distinto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usuario.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool check = chkBoxEstado.Checked;
            string estado = "";
            if (check)
            {
                estado = "S";
            }
            else
                estado = "N";

            if (servicioUsuario.validarCampos(txtUsuario, txtPass, txtEmail, cboPerfil) && buscaAdmin(cboPerfil) && busUsuario(txtUsuario))
            {
                usuarioEntities.NombreUsuario = txtUsuario.Text;
                usuarioEntities.Password = txtPass.Text;
                usuarioEntities.Email = txtEmail.Text;
                
                usuarioEntities.Estado = estado;
                
                usuarioEntities.perfil = int.Parse(cboPerfil.SelectedValue.ToString());
               
                UsuarioDao.ConectarUsuario(UsuarioDao.insertarUsuario(txtUsuario.Text, txtPass.Text, txtEmail.Text, estado, usuarioEntities.perfil));
                
                MessageBox.Show("Usuario "+ txtUsuario.Text + " Registrado con Exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarCampos();
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
