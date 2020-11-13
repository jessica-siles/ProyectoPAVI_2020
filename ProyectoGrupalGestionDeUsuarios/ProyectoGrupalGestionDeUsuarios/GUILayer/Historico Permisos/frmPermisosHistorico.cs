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

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_Permisos
{
    public partial class frmPermisosHistorico : Form
    {
        private readonly PermisoService permisoService;
        private readonly FormularioService formularioService;        

        public frmPermisosHistorico()
        {
            InitializeComponent();
            permisoService = new PermisoService();
            formularioService = new FormularioService();
        }

        private void frmPermisosHistorico_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            formularioService.cargarCombo(cboPerfil, "Perfiles");
            formularioService.cargarCombo(cboFormulario, "Formularios");
            cargarGrilla(grdHistorialPermisos, permisoService.obtenerHistorialPermisos());
        }

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {            
            grilla.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_phistorico"],
                                tabla.Rows[i]["fecha"],
                                tabla.Rows[i]["formulario"],
                                tabla.Rows[i]["perfil"],
                                tabla.Rows[i]["descripcion"]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _formulario, _perfil; bool conFecha = false;
            _formulario = _perfil = "";


            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Las fechas ingresadas son erroneas");
                dtpFechaDesde.Focus();
                return;
            }

            if (cboFormulario.SelectedIndex != -1)            
                _formulario = cboFormulario.SelectedValue.ToString();            
            if (cboPerfil.SelectedIndex != -1)            
                _perfil = cboPerfil.SelectedValue.ToString();

            if (chkBoxTodos.Checked)
            {
                cargarGrilla(grdHistorialPermisos, permisoService.obtenerHistorialPermisos());
            }
            else
            {

                if(chkBoxFechas.Checked)                
                    conFecha = true;                
                else                
                    conFecha = false;                

                DataTable tablaFiltrados = new DataTable();
                tablaFiltrados = permisoService.obtenerHistorialPermisosFiltrados(dtpFechaDesde.Value.ToShortDateString(),
                                                                                      dtpFechaHasta.Value.ToShortDateString()
                                                                                      , _formulario, _perfil,conFecha);

                if (tablaFiltrados.Rows.Count == 0)
                {
                    MessageBox.Show("No existen permisos con esas condiciones...");
                    //dtpFechaDesde.Value = DateTime.Today;
                    //dtpFechaHasta.Value = DateTime.Today;
                    //cboFormulario.SelectedIndex = -1;
                    //cboPerfil.SelectedIndex = -1;
                    this.cargarGrilla(grdHistorialPermisos, tablaFiltrados);
                }
                else
                    this.cargarGrilla(grdHistorialPermisos, tablaFiltrados);
            }
        }

        private void chkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTodos.Checked)
            {
                habilitar(false);
                chkBoxFechas.Checked = false;
                chkBoxFechas.Enabled = false;
            }
            else
            {
                habilitar(true);
                chkBoxFechas.Checked = true;
                chkBoxFechas.Enabled = true;
            }
        }

        private void habilitar(bool x)
        {
            cboFormulario.Enabled = x;
            cboPerfil.Enabled = x;
            dtpFechaDesde.Enabled = x;
            dtpFechaHasta.Enabled = x;
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboFormulario.SelectedIndex = -1;
            cboPerfil.SelectedIndex = -1;
            btnLimpiar.Enabled = x;
        }

        private void chkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxFechas.Checked)
            {
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
            }   
            else
            {
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboFormulario.SelectedIndex = -1;
            cboPerfil.SelectedIndex = -1;
        }
    }
}
