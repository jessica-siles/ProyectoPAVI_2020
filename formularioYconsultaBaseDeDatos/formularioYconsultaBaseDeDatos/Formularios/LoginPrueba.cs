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
    public partial class LoginPrueba : Form
       
    {
        Usuarios miUusuario = new Usuarios();

        internal Usuarios MiUusuario { get => miUusuario; set => miUusuario = value; }

        public LoginPrueba()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.lblUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar Usuario","Ingreso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.lblUsuario.Focus();
                return;
            }
            if(this.lblContrasena.Text =="")
            {
                MessageBox.Show("Debe ingresar Contraseña","Ingreso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.lblContrasena.Focus();
                return;
            }

            MiUusuario.Nom_usuario = lblUsuario.Text;
            MiUusuario.Password = lblContrasena.Text;

            MiUusuario.Id_usuario = MiUusuario.validarUsuario(MiUusuario.Nom_usuario,MiUusuario.Password);
            String mensaje = "";
            if (MiUusuario.Id_usuario != 0) { 
                mensaje = "Correcto, usted es un Winner!! :D";
                this.Close();
            }
            else
            { 
                mensaje = "Ups, Usuario y/o Contraseña no validos";
            }

            MessageBox.Show(mensaje,"Ingreso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            this.lblUsuario.Clear();
            this.lblContrasena.Clear();
            this.lblUsuario.Focus();
            return;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPrueba_Load(object sender, EventArgs e)
        {

        }
    }
}
