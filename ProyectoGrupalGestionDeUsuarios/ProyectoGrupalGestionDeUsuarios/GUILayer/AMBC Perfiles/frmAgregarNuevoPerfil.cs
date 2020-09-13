using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles
{
    public partial class frmAgregarNuevoPerfil : Form
    {
        public frmAgregarNuevoPerfil()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
