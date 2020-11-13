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

namespace ProyectoGrupalGestionDeUsuarios.Reportes.ReportePerfilesUsuario
{
    public partial class frmReportePerfiles : Form
    {
        Reporte reporte = new Reporte();
        PermisoService permisoService = new PermisoService();
        FormularioService formService = new FormularioService();
        PermisosDao permisosDao = new PermisosDao();
        
        public frmReportePerfiles()
        {
            InitializeComponent();
        }

        private void frmReportePerfiles_Load(object sender, EventArgs e)
        {
            
            permisoService.cargarComboGenerico(reporte.cboUsers(),cboUsuarios);
            formService.cargarCombo(cboPerfiles,"Perfiles");
            cboEstado.Items.Add("");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            report.LocalReport.SetParameters(new ReportParameter[] {
            new ReportParameter("cargar","S"),new ReportParameter("fechaHasta",dtpHasta.Text)});

            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(new ReportDataSource("usuariosPerfiles", reporte.TodosPerfilesYusuarios()));
            report.RefreshReport();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                desde = des.ToString("MM/dd/yyyy");

                hasta = has.ToString("MM/dd/yyyy");
            }

            int id_perfil = Convert.ToInt32(cboPerfiles.SelectedValue);
            int id_usuario = Convert.ToInt32(cboUsuarios.SelectedValue);
            string estado = "";
            if (cboEstado.Text == "Activo")
            {
                estado = "S";
            }
            if (cboEstado.Text == "Inactivo")
            {
                estado = "N";
            }

           
            report.LocalReport.SetParameters(new ReportParameter[] {
            new ReportParameter("fechaDesde",dtpDesde.Text),new ReportParameter("cargar",dtpDesde.Text),new ReportParameter("fechaHasta",dtpHasta.Text)});

            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(new ReportDataSource("usuariosPerfiles", reporte.PerfilesYusuarios(desde, hasta, id_perfil, id_usuario, estado)));
            report.RefreshReport();
  
        }
    }
}
