using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;

namespace ProyectoGrupalGestionDeUsuarios.Reportes.ReportePermisos
{
    public partial class frmListadoPermisosHistorico : Form
    {
        private readonly PermisoService permisoService;
        private readonly FormularioService formularioService;

        public frmListadoPermisosHistorico()
        {
            InitializeComponent();
            permisoService = new PermisoService();
            formularioService = new FormularioService();
        }

        private void frmListadoPermisosHistorico_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            formularioService.cargarCombo(cboPerfil, "Perfiles");
            formularioService.cargarCombo(cboFormulario, "Formularios");           

            this.dtPermisosHistoricoBindingSource.DataSource = permisoService.obtenerHistorialPermisos();           
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", "Todos las fechas registradas"),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _formulario, _perfil; bool conFecha = false;
            _formulario = _perfil = ""; string prmFecha = "";


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
                this.dtPermisosHistoricoBindingSource.DataSource = permisoService.obtenerHistorialPermisos();
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", "Todas las fechas registradas"),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
                this.reportViewer1.RefreshReport();
            }
            else
            {

                if (chkBoxFechas.Checked)
                {
                    conFecha = true;
                    prmFecha = dtpFechaDesde.Value.ToShortDateString();
                }
                else
                {
                    conFecha = false;
                    prmFecha = "Todas las fechas registradas";
                }
                
                DataTable tabla = new DataTable();
                tabla = permisoService.obtenerHistorialPermisosFiltrados(dtpFechaDesde.Value.ToShortDateString(),
                                                                         dtpFechaHasta.Value.ToShortDateString(),
                                                                         _formulario, _perfil, conFecha);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existen permisos con esas condiciones...");
                    this.dtPermisosHistoricoBindingSource.DataSource = tabla;
                    this.reportViewer1.RefreshReport();
                    resetearCampos();
                }
                else
                {
                    this.dtPermisosHistoricoBindingSource.DataSource = tabla;                    
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", prmFecha),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
                    this.reportViewer1.RefreshReport();
                }
            }
        }

        private void resetearCampos()
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboFormulario.SelectedIndex = -1;
            cboPerfil.SelectedIndex = -1;
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

        private void chkBoxTodos_CheckedChanged_1(object sender, EventArgs e)
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
               
        private void chkBoxFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxFechas.Checked)
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

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            cboFormulario.SelectedIndex = -1;
            cboPerfil.SelectedIndex = -1;
        }       
        
    }
}
