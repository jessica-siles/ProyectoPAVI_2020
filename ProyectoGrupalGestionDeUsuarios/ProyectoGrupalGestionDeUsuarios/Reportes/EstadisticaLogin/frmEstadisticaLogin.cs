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

namespace ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaLogins
{    
    public partial class frmEstadisticaLogin : Form
    {
        string usuario;
        bool conFecha;
        string desde, hasta;
        DataTable tabla = new DataTable();
        private readonly UsuarioService usuarioService;

        public frmEstadisticaLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();            
        }        

        private void frmEstadisticaLogin_Load(object sender, EventArgs e)
        {
            usuario = "";
            conFecha = false;
            desde = "";
            hasta = "";            

            tabla = usuarioService.cantidadLogueos(desde,hasta,conFecha);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", "Todas las fechas registradas"),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
            
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("EstadisticaLoginDS",tabla));
            this.reportViewer1.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Las fechas ingresadas son erroneas");
                dtpFechaDesde.Focus();
                return;
            }

            conFecha = true;
            desde = dtpFechaDesde.Value.ToString("yyyy-MM-dd");
            hasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");

            tabla = usuarioService.cantidadLogueos(desde, hasta, conFecha);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ new ReportParameter
                                                                ("prFechaDesde", dtpFechaDesde.Value.ToShortDateString()),
                                                                 new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("EstadisticaLoginDS", tabla));
            this.reportViewer1.RefreshReport();
        }            

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
