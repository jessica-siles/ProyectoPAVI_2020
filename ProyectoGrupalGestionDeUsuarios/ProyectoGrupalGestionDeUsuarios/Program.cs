using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.GUILayer;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Usuarios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.ABM_Formularios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Permisos;
using ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_de_Usuarios;
using ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaPerfiles;
using ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_Permisos;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReportePermisos;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReporteLogin;
using ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaLogins;

namespace ProyectoGrupalGestionDeUsuarios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPrincipal());
            //Application.Run(new frmConsultarUsuario());
            //Application.Run(new frmListadoPermisosHistorico());
            //Application.Run(new frmAltaPermisos());
            //Application.Run(new frmAgregarPerfil());            
            //Application.Run(new frmConsultaPerfiles());
            //Application.Run(new frmConsultarUsuario());
            //Application.Run(new frmHistoricoUsuario());
            //Application.Run(new frmFormulario());
            //Application.Run(new frmAltaPermisos());
            //Application.Run(new frmListadoPermisosHistorico());
            //Application.Run(new frmLogueo());
            //Application.Run(new frmEstadisticaLogin());
          
        }
    }
}
