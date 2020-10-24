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

namespace ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaPermisos
{
    public partial class frmEstadisticaPermisos : Form
    {
        private readonly PermisoService permisoService;
        public frmEstadisticaPermisos()
        {
            InitializeComponent();
            permisoService = new PermisoService();
        }

        private void frmEstadisticaPermisos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = permisoService.cantidadPermisosPerfil();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("EstadisticaPermisosDS", tabla));
            this.reportViewer1.RefreshReport();
        }
    }
}
