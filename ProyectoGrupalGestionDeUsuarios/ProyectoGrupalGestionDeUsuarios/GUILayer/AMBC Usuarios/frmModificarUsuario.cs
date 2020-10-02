using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;

        
namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Usuarios
{
    public partial class frmModificarUsuario : Form
    {
        Usuario usuarioEntities = new Usuario();
        UsuarioDao UsuarioDao = new UsuarioDao();
        UsuarioService servicioUsuario = new UsuarioService();
        HistorialUsuario historial = new HistorialUsuario();

        public frmModificarUsuario(int var)
        {
            InitializeComponent();
            this.var = var;
        }
        int var;
        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
             
            
            cargarTextos(var);
            txtUsuario.Enabled = false;


        }
        private void cargarTextos(int id_usuario)
        {
            DataTable cargaUusuarios = UsuarioDao.Consultar(UsuarioDao.BuscarPorId(var));
            txtUsuario.Text = cargaUusuarios.Rows[0][1].ToString();
            txtPass.Text = cargaUusuarios.Rows[0][2].ToString();
            txtEmail.Text = cargaUusuarios.Rows[0][3].ToString();
            string checkbox = cargaUusuarios.Rows[0][5].ToString();
            if (checkbox == "S")
            {
                chkBoxEstado.Checked = true;
            }
            if (checkbox == "N")
                chkBoxEstado.Checked = false;

            
            cargarComb(cboPerfil);
            cboPerfil.Text = cargaUusuarios.Rows[0][4].ToString();


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void cargarComb(ComboBox combo)
        {

            DataTable perfiles = UsuarioDao.Consultar(UsuarioDao.consultarPerfiles());
            combo.DataSource = perfiles;
            combo.DisplayMember = perfiles.Columns[1].ColumnName;
            combo.ValueMember = perfiles.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            

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

            if (servicioUsuario.validarCampos(txtUsuario, txtPass, txtEmail, cboPerfil) == true && servicioUsuario.bus(txtUsuario,var) == true && servicioUsuario.busAdmin(cboPerfil,var))
            {
                DateTime fecha_actual = DateTime.Today;
                string fecha = fecha_actual.ToString("yyyy-MM-dd 00:00:00");
                historial.Fecha = fecha;
                historial.Titulo = "Modificacion de Usuario";
                



                usuarioEntities.NombreUsuario = txtUsuario.Text;

                usuarioEntities.Password = txtPass.Text;
                usuarioEntities.Email = txtEmail.Text;
                usuarioEntities.Estado = estado;
                usuarioEntities.perfil = int.Parse(cboPerfil.SelectedValue.ToString());

                int contar = servicioUsuario.ValidarModificaciones(usuarioEntities, var, cboPerfil.Text);
               
                if (contar != 0)
                {
                    
                    string descripcion = "Se Modifico el:" + servicioUsuario.Descripcion();
                    historial.Descripcion = descripcion;
                    //MessageBox.Show(historial.Descripcion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (UsuarioDao.UsuarioModificarConHistorial(var, usuarioEntities, historial))
                    {

                        MessageBox.Show(historial.Descripcion + " Usuario " + txtUsuario.Text + " Modificado con Exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.Close();
                    }
                }

                    else
                { 
                    MessageBox.Show("NO SE REALIZARON CAMBIOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                






            }
        }

    }
}


