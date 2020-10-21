﻿using System;
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
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Usuarios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.ABM_Formularios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_de_Usuarios;
using ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Permisos;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.Reportes;
using ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaUsuarios;

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
    }
}
