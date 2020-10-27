using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios
{
    public partial class frmEstadisticaHistoricoUsuarios : Form
    {
        Reporte reporte = new Reporte();
        public frmEstadisticaHistoricoUsuarios()
        {
            InitializeComponent();
        }

        private void frmEstadisticaHistoricoUsuarios_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new
            ReportParameter("todasFechas", "S"), new ReportParameter("fechaHas", dtpHasta.Text)});

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("EstadisticaUsuarios", reporte.TodoHistUsuarios()));
            reportViewer1.RefreshReport();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime des = Convert.ToDateTime(dtpDesde.Text);
            DateTime has = Convert.ToDateTime(dtpHasta.Text);
            string desde = "";
            string hasta = "";
            desde = des.ToString("yyyy-MM-dd");

            hasta = has.ToString("yyyy-MM-dd");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
            new ReportParameter("fechaDes", dtpDesde.Text) ,new ReportParameter("todasFechas", "FechaDesde") , new ReportParameter("fechaHas", dtpHasta.Text)});

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("EstadisticaUsuarios", reporte.estadisticaHistUsuarios(desde, hasta)));
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
