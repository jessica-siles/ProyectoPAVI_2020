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


namespace ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaPerfiles
{
    public partial class frmEstadisticaPerfil : Form
    {
        Reporte report = new Reporte();

        public frmEstadisticaPerfil()
        {
            InitializeComponent();
        }

        private void frmEstadisticaPerfil_Load(object sender, EventArgs e)
        {
            reportPerfilEstadistica.LocalReport.SetParameters(new ReportParameter[]{ new
            ReportParameter("todasFechas", "S"), new ReportParameter("fechaHasta", dtpHasta.Text)});

            reportPerfilEstadistica.LocalReport.DataSources.Clear();
            reportPerfilEstadistica.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report.loadEstadisticaPerfil()));
            reportPerfilEstadistica.RefreshReport();
            

            
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DateTime des = Convert.ToDateTime(dtpDesde.Text);
            DateTime has = Convert.ToDateTime(dtpHasta.Text);
            string desde = "";
            string hasta = "";

            if (des > has)
            {
                MessageBox.Show("Debe ingresar fechas validas");
            }

            if (des < has)
            {
                desde = des.ToString("yyyy-MM-dd");

                hasta = has.ToString("yyyy-MM-dd");
            }
            reportPerfilEstadistica.LocalReport.SetParameters(new ReportParameter[]{
            new ReportParameter("fechaDesde", dtpDesde.Text) ,new ReportParameter("todasFechas", "desde"), new ReportParameter("fechaHasta", dtpHasta.Text)});

            reportPerfilEstadistica.LocalReport.DataSources.Clear();
            reportPerfilEstadistica.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report.cantidadPorPerfil(desde, hasta)));
            reportPerfilEstadistica.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
