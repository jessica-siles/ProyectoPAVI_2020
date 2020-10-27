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
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReportePermisos;

namespace ProyectoGrupalGestionDeUsuarios.Reportes
{
    public partial class frmDatosUsuarios : Form
    {
        PermisoService permisoService = new PermisoService();
        Reporte reporte = new Reporte();
        public frmDatosUsuarios()
        {
            InitializeComponent();
        }

        private void frmDatosUsuarios_Load(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.SetParameters(new ReportParameter[]{
            new ReportParameter("todasFechas", "Todas las fechas") , new ReportParameter("fechaHasta", dtpHasta.Text)});

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("UsuariosDatos", reporte.mostrartodo()));
            reportViewer2.RefreshReport();

            permisoService.cargarComboGenerico(reporte.CboTodosUsuarios(), cboUsuario);
            cboTitulo.Items.Add("Registro de Usuario");
            cboTitulo.Items.Add("Modificacion de Usuario");
            cboTitulo.Items.Add("Eliminacion de Usuario");
            cboTitulo.Items.Add("");
            cboTitulo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DateTime des = Convert.ToDateTime(dtpDesde.Text);
            DateTime has = Convert.ToDateTime(dtpHasta.Text);
            string desde = "";
            string hasta = "";

            string titulo = cboTitulo.Text;
            int usuario = Convert.ToInt32(cboUsuario.SelectedValue);
            if (des > has)
            {
                MessageBox.Show("Debe ingresar fechas validas");
            }

            if(des < has)
            {
                 desde = des.ToString("yyyy-MM-dd");

                 hasta = has.ToString("yyyy-MM-dd");
            }

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.SetParameters(new ReportParameter[]{ new
            ReportParameter("fechaDesde", dtpDesde.Text),new ReportParameter("fechaHasta", dtpHasta.Text)});
            reportViewer2.LocalReport.DataSources.Clear();
            
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("UsuariosDatos", reporte.reporteHistoricoUsuarios(usuario,titulo,desde,hasta)));
            
            reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerarEstadistica_Click(object sender, EventArgs e)
        {
           
        }
    }
}