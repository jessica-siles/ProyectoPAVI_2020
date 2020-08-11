using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formularioYconsultaBaseDeDatos.Clases;

namespace formularioYconsultaBaseDeDatos
{
    public partial class frmMenuPrincipal : Form
    {
        Usuarios usuarioActual;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            LoginPrueba formularioLogin;
            formularioLogin = new LoginPrueba();
            formularioLogin.ShowDialog();

            this.usuarioActual = formularioLogin.MiUusuario;

            if (this.usuarioActual.Id_usuario == 0)
                this.Close();
            else
                this.Text = this.Text + " - Usuario ---> :D " + this.usuarioActual.Nom_usuario;

            formularioLogin.Dispose();

        }
    }
}
