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
    public partial class frmModificarPerfil : Form

    {
        Perfil obPerfil = new Perfil();

        PerfilService servicioPerfiles = new PerfilService();
        frmConsultaPerfiles oConsulta = new frmConsultaPerfiles();

        private FormMode formMode = FormMode.insert;

        public frmModificarPerfil()
        {
            InitializeComponent();

            cboEstado.Items.Add("Activo"); 
            cboEstado.Items.Add("No Activo");
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }


        private void frmAgregarNuevoPerfil_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Perfil";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Perfil";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtNombre.Enabled = true;
                        txtDescripcion.Enabled = true;
                        break;
                    }
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //obPerfil.Nombre = txtNombre.Text;
            //obPerfil.Descripcion = txtDescripcion.Text;
            //servicioPerfiles.insertarPerfil(txtNombre.Text, txtDescripcion.Text);
            //limpiarCampos();
            
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            obPerfil.Nombre = txtNombre.Text;
                            obPerfil.Descripcion = txtDescripcion.Text;
                            obPerfil.Borrado = cboEstado.SelectedIndex;
                            //obPerfil.Estado = "Activo";                       

                            if (servicioPerfiles.ActualizarPerfil(obPerfil))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }

                        break;
                    }
            }
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

        public void SeleccionarPerfil(FormMode op, Perfil perfilSelected)
        {
            formMode = op;
            obPerfil = perfilSelected;
        }

        private void MostrarDatos()
        {
            if (obPerfil != null)
            {
                txtNombre.Text = obPerfil.Nombre;
                txtDescripcion.Text = obPerfil.Descripcion;
                //cboPerfil.Text = oUsuarioSelected.Perfil.Nombre;
            }
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

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
            //cboEstado.DisplayMember = "activo";
            //cboEstado.ValueMember = "0";
            
        }
    }
}
