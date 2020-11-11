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
using Microsoft.Reporting.WinForms;

namespace ProyectoGrupalGestionDeUsuarios.Reportes.ReporteLogin
{
    public partial class frmLogueo : Form
    {
        private readonly UsuarioService usuarioService;
        private readonly FormularioService formularioService;
        string usuario = "";
        string perfil = "";
        string desde = "";
        string hasta = "";
        bool conFecha = false;      

        public frmLogueo()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            formularioService = new FormularioService();
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            formularioService.cargarCombo(cboPerfil, "Perfiles");           
        }

        private void LogueoFrm_Load(object sender, EventArgs e)
        {
            this.dtLoginBindingSource.DataSource = usuarioService.obtenerLogueos(usuario,perfil,desde,hasta,conFecha);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", "Todos las fechas registradas"),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetearCampos()
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;
            txtUsuario.Text = "";
            usuario = "";
            perfil = "";
            cboPerfil.SelectedIndex = -1;
            conFecha = false;
        }

        private void habilitar(bool x)
        {            
            cboPerfil.Enabled = x;
            dtpFechaDesde.Enabled = x;
            dtpFechaHasta.Enabled = x;            
            txtUsuario.Enabled = x;
            cboPerfil.SelectedIndex = -1;
            btnLimpiar.Enabled = x;
        }                      
        
        private void chkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTodos.Checked)
            {
                habilitar(false);
                chkBoxFechas.Checked = false;
                chkBoxFechas.Enabled = false;
                resetearCampos();
            }
            else
            {
                habilitar(true);
                chkBoxFechas.Checked = true;
                chkBoxFechas.Enabled = true;
            }
        }

        private void chkBoxFechas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBoxFechas.Checked)
            {
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
                dtpFechaDesde.Value = DateTime.Now;
                dtpFechaHasta.Value = DateTime.Now;
            }
            else
            {
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            resetearCampos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //string usuario, perfil, desde, hasta; usuario = perfil = desde = hasta = "";
            //bool conFecha = false;
            string prmFechaDesde = "";

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Las fechas ingresadas son erroneas");
                dtpFechaDesde.Focus();
                return;
            }
            
            if (txtUsuario.Text != "")
                usuario = txtUsuario.Text;
            if (cboPerfil.SelectedIndex != -1)
                perfil = cboPerfil.SelectedValue.ToString();
            desde = dtpFechaDesde.Value.ToString("yyyy-MM-dd");
            hasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");
            

            if (chkBoxTodos.Checked)
            {
                this.dtLoginBindingSource.DataSource = usuarioService.obtenerLogueos(usuario,perfil,desde,hasta,conFecha);
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
                    prmFechaDesde = dtpFechaDesde.Value.ToShortDateString();
                }
                else
                {
                    conFecha = false;
                    prmFechaDesde = "Todas las fechas registradas";
                }

                DataTable tabla = new DataTable();
                tabla = usuarioService.obtenerLogueos(usuario, perfil, desde, hasta, conFecha);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existen permisos con esas condiciones...");
                    this.dtLoginBindingSource.DataSource = tabla;
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", prmFechaDesde),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
                    this.reportViewer1.RefreshReport();
                    resetearCampos();
                }
                else
                {
                    this.dtLoginBindingSource.DataSource = tabla;
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", prmFechaDesde),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
                    this.reportViewer1.RefreshReport();
                }
            }

        }
    }
}
