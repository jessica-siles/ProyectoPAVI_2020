﻿using ProyectoGrupalGestionDeUsuarios.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioService usuarioService;

        public string UsuarioLogueado { get; internal set; }

        public frmLogin()
        {
            //Se inicializan los controles del formulario, si se elimina el formulario se inicia vacio (sin controles ).
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Terminamos la aplicacion dado que el usuario no inicio sesion.
            Environment.Exit(0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario.
            if ((lblUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validamos que se haya ingresado una password
            if ((lblContrasena.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usr = usuarioService.ValidarUsuario(lblUsuario.Text, lblContrasena.Text);
            //Controlamos que las creadenciales sean las correctas. 
            if (usr != null)
            {
                // Login OK
                UsuarioLogueado = usr.NombreUsuario;
                MessageBox.Show("Usuario y Contraseña Correctos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                //Limpiamos el campo password, para que el usuario intente ingresar un usuario distinto.
                lblContrasena.Text = "";
                // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
                lblContrasena.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Mostramos el formulario al centro del formulario padre.
            this.CenterToParent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        
    }

}