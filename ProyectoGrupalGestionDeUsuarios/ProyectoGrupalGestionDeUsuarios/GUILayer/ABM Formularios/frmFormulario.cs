using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;
using ProyectoGrupalGestionDeUsuarios.Entities;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.ABM_Formularios
{
    public partial class frmFormulario : Form
    {
        private readonly FormularioService formularioService;
        bool esNuevo = false;
        Formulario oFormulario = new Formulario();
        bool esEliminado = false;

        public frmFormulario()
        {
            InitializeComponent();
            formularioService = new FormularioService();
            cboBorrado.Items.Add("Activo");
            cboBorrado.Items.Add("Inactivo");
            cboBorrado.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarGrilla(grdFormularios, formularioService.obtenerFormularios());            
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            this.HabilitarFrm(false);
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_formulario"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["borrado"]);              
            }            
        }

        private void HabilitarFrm(bool x)
        {
            //txtID.Enabled = x;
            txtNombre.Enabled = x;
            cboBorrado.Enabled = x;
            txtDescripción.Enabled = x;
            btnCancelar.Enabled = x;
            btnGuardar.Enabled = x;
            btnAgregar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnEliminar.Enabled = !x;
            btnSalir.Enabled = !x;
            grdFormularios.Enabled = !x;
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            cboBorrado.SelectedIndex = 0;
            txtDescripción.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.esNuevo = true;
            LimpiarCampos();
            HabilitarFrm(true);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdFormularios.Rows.Count > 0)
            {
                HabilitarFrm(true);
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("No existen registros de Formularios en la Base de Datos", "INFORMACIÓN"
                                     , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.HabilitarFrm(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Cargar objeto Formulario            
            oFormulario.Nombre = txtNombre.Text;
            oFormulario.Descripcion = txtDescripción.Text;
            oFormulario.Borrado = cboBorrado.SelectedIndex;

            if (oFormulario.ValidarFormulario())
            {
                if (this.esNuevo)
                {
                    if (!formularioService.YaExiste(oFormulario.Nombre))
                    {
                        formularioService.grabarFormulario(oFormulario);
                        MessageBox.Show("El formulario se ha añadido con exito", "Añadir"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El formulario: ''" + txtNombre.Text + "'' Existe");
                        txtNombre.Focus();
                    }
                }
                else
                {
                    oFormulario.IdFormulario = int.Parse(txtID.Text);
                    formularioService.actualizarFormulario(oFormulario);
                    MessageBox.Show("El formulario ha sido actualizado con exito", "Actualizacion"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarGrilla(grdFormularios, formularioService.obtenerFormularios());
            }
            this.HabilitarFrm(false);
            this.esNuevo = false;
        }

        private void ActualizarCampos(int id)
        {
            oFormulario = formularioService.obtenerFormulariosPorId(id);
            txtID.Text = oFormulario.IdFormulario.ToString();
            txtNombre.Text = oFormulario.Nombre;
            txtDescripción.Text = oFormulario.Descripcion;
            cboBorrado.SelectedIndex = oFormulario.Borrado;
        }

        private void grdFormularios_SelectionChanged(object sender, EventArgs e)
        {
            if (!esEliminado)
                this.ActualizarCampos((int)grdFormularios.CurrentRow.Cells[0].Value);
            esEliminado = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdFormularios.Rows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de deshabilitar el usuario: " + txtNombre.Text,
                                    "DESHABILITANDO",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
                {
                    //formularioService.eliminarFormulario(oFormulario.IdFormulario);
                    oFormulario.Borrado = 1;
                    formularioService.actualizarFormulario(oFormulario);             
                    esEliminado = true;
                    CargarGrilla(grdFormularios, formularioService.obtenerFormularios());
                }
            }
            else
            {
                MessageBox.Show("No existen registros de Formularios en la Base de Datos", "INFORMACIÓN"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
