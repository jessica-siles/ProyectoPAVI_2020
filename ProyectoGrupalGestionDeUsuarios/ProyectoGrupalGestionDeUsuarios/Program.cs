using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.GUILayer;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles;

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
            //Application.Run(new frmMenuPrincipal());
            //Application.Run(new frmAgregarNuevoPerfil());
            Application.Run(new frmMenuPrincipal());
        }
    }
}
