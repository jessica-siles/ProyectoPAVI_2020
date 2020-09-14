using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles
{
    public partial class frmAgregarNuevoPerfil : Form

    {
        Perfil obPerfil = new Perfil();
        PerfilService servicioPerfiles = new PerfilService();
        public frmAgregarNuevoPerfil()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarNuevoPerfil_Load(object sender, EventArgs e)
        {
            cboEstado.Enabled = false;
            cboEstado.Text = "Activo";
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            obPerfil.Nombre = txtNombre.Text;
            obPerfil.Descripcion = txtDescripcion.Text;
            servicioPerfiles.insertarPerfil(txtNombre.Text, txtDescripcion.Text);
            limpiarCampos();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescripcion.Focus();
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnGuardar.Focus();
            }
        }
    }
}
