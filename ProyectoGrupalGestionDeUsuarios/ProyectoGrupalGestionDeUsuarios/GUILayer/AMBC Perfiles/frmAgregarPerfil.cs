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
    public partial class frmAgregarPerfil : Form
    {
        Perfil obPerfil = new Perfil();

        PerfilService servicioPerfiles = new PerfilService();
        frmConsultaPerfiles oConsulta = new frmConsultaPerfiles();
        public frmAgregarPerfil()
        {
            InitializeComponent();
        }

        private void frmAgregarPerfil_Load(object sender, EventArgs e)
        {
            
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            return true;
        }

        private bool ExistePerfil()
        {           
            return servicioPerfiles.ObtenerPerfil(txtNombre.Text) != null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ExistePerfil() == false)
            {
                if (ValidarCampos())
                {
                    var oPerfil = new Perfil();                    
                    oPerfil.Nombre = txtNombre.Text;
                    oPerfil.Descripcion = txtDescripcion.Text;
                    servicioPerfiles.insertarPerfil(txtNombre.Text, txtDescripcion.Text);
                    limpiarCampos();
                }
            }
            else
                MessageBox.Show("Nombre de perfil encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
