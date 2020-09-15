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
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles;
using ProyectoGrupalGestionDeUsuarios.Entities;


namespace ProyectoGrupalGestionDeUsuarios
{
    public partial class frmMenuPrincipal : Form
    {

        
       

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
    }
}
