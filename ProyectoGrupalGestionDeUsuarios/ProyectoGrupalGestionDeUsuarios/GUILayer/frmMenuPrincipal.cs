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

            
            

        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
