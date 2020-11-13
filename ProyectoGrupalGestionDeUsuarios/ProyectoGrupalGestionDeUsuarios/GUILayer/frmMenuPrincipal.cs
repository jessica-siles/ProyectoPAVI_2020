using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.GUILayer;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Usuarios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.ABM_Formularios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_de_Usuarios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Permisos;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.Reportes;
using ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaPerfiles;
using ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_Permisos;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReportePermisos;
using ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaPermisos;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReportePerfilesUsuario;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReporteLogin;
using ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaLogins;

namespace ProyectoGrupalGestionDeUsuarios
{
    public partial class frmMenuPrincipal : Form
    {
        PermisosDao permisos = new PermisosDao();
        string nombreLogeado;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin formularioLogin;
            formularioLogin = new frmLogin();
            formularioLogin.ShowDialog();

            this.Text = this.Text + " - Usuario: " + formularioLogin.UsuarioLogueado;
            nombreLogeado = formularioLogin.UsuarioLogueado;
            //Lista();
        }
        private void Lista()
        {
            DataTable permisosMenuPrincipal = permisos.permisosPorPerfil(nombreLogeado);
            List<ToolStripMenuItem> items = new List<ToolStripMenuItem>();
            List<string> nombreItemsBase = new List<string>();

            items.Add(btnAgregarNuevoPerfil);
            items.Add(btnConsultarPerfiles);
            items.Add(btnRegistrarNuevoUsuario);
            items.Add(btnConsultarUsuarios);
            items.Add(btnHistoricoDeUsuarios);
            items.Add(btnFormularios);
            items.Add(btnAsignarPermisosPerfiles);
            items.Add(btnConsultarPermisos);
            items.Add(btnHistoricoDePermisos);
            items.Add(btnReporteHistoricoUsuarios);
            items.Add(btnEstadisticaMovimientosUsuarios);
            items.Add(btnReportePerfilesUsuariosYestados);
            items.Add(btnEstadisticaPerfiles);
            items.Add(btnReporteHistoricoPermisos);
            items.Add(btnEstadisticaPermisos);
            items.Add(btnReporteIngresosAlSistema);
            items.Add(btnEstadísticaIngresosAlSistema);

            foreach (DataRow row in permisosMenuPrincipal.Rows)
            {
                nombreItemsBase.Add(row["boton_name"].ToString());
            }

            List<ToolStripMenuItem> m = new List<ToolStripMenuItem>();

            for (int i = 0; i < nombreItemsBase.Count(); i++)
            {
                for (int j = 0; j < items.Count(); j++)
                {

                    if (items[j].Name.ToString() == nombreItemsBase[i])
                    {

                        items.Remove(items[j]);

                    }

                }

            }
            foreach (ToolStripMenuItem botones in items)
            {
                botones.Visible = false;
            }
        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarPerfil AgregarPerfil;
            AgregarPerfil = new frmAgregarPerfil();
            AgregarPerfil.ShowDialog();
            

        }

        private void consultarPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPerfiles ConsultarPerfiles;
            ConsultarPerfiles = new frmConsultaPerfiles();
            ConsultarPerfiles.ShowDialog();
            

        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaUsuario altausuario;
            altausuario = new frmAltaUsuario();
            altausuario.ShowDialog();
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario consultausuario;
            consultausuario = new frmConsultarUsuario();
            consultausuario.ShowDialog();
        }

        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormulario formulario;
            formulario = new frmFormulario();
            formulario.ShowDialog();
        }

        private void historicoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoricoUsuario usersHistory = new frmHistoricoUsuario();
            usersHistory.ShowDialog();
        }

        private void PermisostoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteDeHistoricoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosUsuarios historicoReport = new frmDatosUsuarios();
            historicoReport.ShowDialog();
        }

        private void estadisticaDePerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaPerfil estadisticaPerfil = new frmEstadisticaPerfil();
            estadisticaPerfil.ShowDialog();
        }

        private void asignarPermisosAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPermisos Permiso = new frmAltaPermisos(-1);
            Permiso.ShowDialog();
        }

        private void consultarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsltarPermisos consultaPermisos = new frmConsltarPermisos();
            consultaPermisos.ShowDialog();
        }

        private void historicoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermisosHistorico consultarPermisosHistorico = new frmPermisosHistorico();
            consultarPermisosHistorico.ShowDialog();
        }

        private void reporteDeHistoricoDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoPermisosHistorico permisosHistorico = new frmListadoPermisosHistorico();
            permisosHistorico.ShowDialog();
        }

        private void estadísticaDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaPermisos estadisticaPermisos = new frmEstadisticaPermisos();
            estadisticaPermisos.ShowDialog();
        }

        private void estadisticaMovimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaHistoricoUsuarios movUsuarios = new frmEstadisticaHistoricoUsuarios();
            movUsuarios.ShowDialog();
        }

        private void reportePerfilesPorUsuarioYEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePerfiles reportPerfiles = new frmReportePerfiles();
            reportPerfiles.ShowDialog();
        }

        private void reporteIngresosAlSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogueo logueos = new frmLogueo();
            logueos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Salir del programa", "Salir",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button2)
                                     == DialogResult.Yes)
            {
                Environment.Exit(0);
            }              
        }

        private void estadísticaIngresosAlSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaLogin logins = new frmEstadisticaLogin();
            logins.ShowDialog();
        }
    }
}
