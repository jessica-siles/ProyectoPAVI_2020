using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginPrueba : Form
       
    {   
        //Declaración e inicialización de variables
        String usuario = "admin";
        String contrasena = "4862";
        public LoginPrueba()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //evento bonton aceptar
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
            String mensaje = "";
            if (this.lblUsuario.Text == this.usuario && this.lblContrasena.Text == this.contrasena)
                mensaje = "Correcto, usted es un Winner!! :D";
            else
                mensaje = "Ups, Usuario y/o Contraseña no validos";
            
            MessageBox.Show(mensaje,"Ingreso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            this.lblUsuario.Clear();
            this.lblContrasena.Clear();
            this.lblUsuario.Focus();
            return;
            
        }
        //Salir del sistema
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Cambiar contrasena
        private void lblContrasena_TextChanged(object sender, EventArgs e)
        {

        }
        //Cambiar nombre de usuario
        private void lblUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        //Iniciar sesion de prueba
        private void LoginPrueba_Load(object sender, EventArgs e)
        {

        }
    }
}
