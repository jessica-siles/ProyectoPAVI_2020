namespace ProyectoGrupalGestionDeUsuarios
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarNuevoPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarNuevoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHistoricoDeUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFormularios = new System.Windows.Forms.ToolStripMenuItem();
            this.PermisostoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignarPermisosPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHistoricoDePermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.resportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReporteHistoricoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstadisticaMovimientosUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportePerfilesUsuariosYestados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstadisticaPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReporteHistoricoPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstadisticaPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReporteIngresosAlSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstadísticaIngresosAlSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumOrchid;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfil,
            this.usuariosToolStripMenuItem,
            this.btnFormularios,
            this.PermisostoolStripMenuItem1,
            this.resportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnPerfil
            // 
            this.btnPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarNuevoPerfil,
            this.btnConsultarPerfiles});
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(103, 36);
            this.btnPerfil.Text = "Perfiles";
            // 
            // btnAgregarNuevoPerfil
            // 
            this.btnAgregarNuevoPerfil.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAgregarNuevoPerfil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevoPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarNuevoPerfil.Name = "btnAgregarNuevoPerfil";
            this.btnAgregarNuevoPerfil.Size = new System.Drawing.Size(312, 36);
            this.btnAgregarNuevoPerfil.Text = "Agregar Nuevo Perfil";
            this.btnAgregarNuevoPerfil.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // btnConsultarPerfiles
            // 
            this.btnConsultarPerfiles.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnConsultarPerfiles.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPerfiles.Name = "btnConsultarPerfiles";
            this.btnConsultarPerfiles.Size = new System.Drawing.Size(312, 36);
            this.btnConsultarPerfiles.Text = "Consultar Perfiles";
            this.btnConsultarPerfiles.Click += new System.EventHandler(this.consultarPerfilesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarNuevoUsuario,
            this.btnConsultarUsuarios,
            this.btnHistoricoDeUsuarios});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(117, 36);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // btnRegistrarNuevoUsuario
            // 
            this.btnRegistrarNuevoUsuario.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnRegistrarNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNuevoUsuario.Name = "btnRegistrarNuevoUsuario";
            this.btnRegistrarNuevoUsuario.Size = new System.Drawing.Size(347, 36);
            this.btnRegistrarNuevoUsuario.Text = "Registrar Nuevo Usuario";
            this.btnRegistrarNuevoUsuario.Click += new System.EventHandler(this.registrarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // btnConsultarUsuarios
            // 
            this.btnConsultarUsuarios.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnConsultarUsuarios.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUsuarios.Name = "btnConsultarUsuarios";
            this.btnConsultarUsuarios.Size = new System.Drawing.Size(347, 36);
            this.btnConsultarUsuarios.Text = "Consultar Usuarios";
            this.btnConsultarUsuarios.Click += new System.EventHandler(this.consultarUsuariosToolStripMenuItem_Click);
            // 
            // btnHistoricoDeUsuarios
            // 
            this.btnHistoricoDeUsuarios.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnHistoricoDeUsuarios.Name = "btnHistoricoDeUsuarios";
            this.btnHistoricoDeUsuarios.Size = new System.Drawing.Size(347, 36);
            this.btnHistoricoDeUsuarios.Text = "Histórico De Usuarios";
            this.btnHistoricoDeUsuarios.Click += new System.EventHandler(this.historicoDeUsuariosToolStripMenuItem_Click);
            // 
            // btnFormularios
            // 
            this.btnFormularios.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormularios.ForeColor = System.Drawing.Color.Black;
            this.btnFormularios.Name = "btnFormularios";
            this.btnFormularios.Size = new System.Drawing.Size(152, 36);
            this.btnFormularios.Text = "Formularios";
            this.btnFormularios.Click += new System.EventHandler(this.formulariosToolStripMenuItem_Click);
            // 
            // PermisostoolStripMenuItem1
            // 
            this.PermisostoolStripMenuItem1.BackColor = System.Drawing.Color.MediumOrchid;
            this.PermisostoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAsignarPermisosPerfiles,
            this.btnConsultarPermisos,
            this.btnHistoricoDePermisos});
            this.PermisostoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermisostoolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.PermisostoolStripMenuItem1.Name = "PermisostoolStripMenuItem1";
            this.PermisostoolStripMenuItem1.Size = new System.Drawing.Size(121, 36);
            this.PermisostoolStripMenuItem1.Text = "Permisos";
            this.PermisostoolStripMenuItem1.Click += new System.EventHandler(this.PermisostoolStripMenuItem1_Click);
            // 
            // btnAsignarPermisosPerfiles
            // 
            this.btnAsignarPermisosPerfiles.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAsignarPermisosPerfiles.Name = "btnAsignarPermisosPerfiles";
            this.btnAsignarPermisosPerfiles.Size = new System.Drawing.Size(375, 36);
            this.btnAsignarPermisosPerfiles.Text = "Asignar Permisos A Perfiles";
            this.btnAsignarPermisosPerfiles.Click += new System.EventHandler(this.asignarPermisosAPerfilesToolStripMenuItem_Click);
            // 
            // btnConsultarPermisos
            // 
            this.btnConsultarPermisos.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnConsultarPermisos.Name = "btnConsultarPermisos";
            this.btnConsultarPermisos.Size = new System.Drawing.Size(375, 36);
            this.btnConsultarPermisos.Text = "Consultar Permisos";
            this.btnConsultarPermisos.Click += new System.EventHandler(this.consultarPermisosToolStripMenuItem_Click);
            // 
            // btnHistoricoDePermisos
            // 
            this.btnHistoricoDePermisos.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnHistoricoDePermisos.Name = "btnHistoricoDePermisos";
            this.btnHistoricoDePermisos.Size = new System.Drawing.Size(375, 36);
            this.btnHistoricoDePermisos.Text = "Historico De Permisos";
            this.btnHistoricoDePermisos.Click += new System.EventHandler(this.historicoDeToolStripMenuItem_Click);
            // 
            // resportesToolStripMenuItem
            // 
            this.resportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReporteHistoricoUsuarios,
            this.btnEstadisticaMovimientosUsuarios,
            this.btnReportePerfilesUsuariosYestados,
            this.btnEstadisticaPerfiles,
            this.btnReporteHistoricoPermisos,
            this.btnEstadisticaPermisos,
            this.btnReporteIngresosAlSistema,
            this.btnEstadísticaIngresosAlSistema});
            this.resportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.resportesToolStripMenuItem.Name = "resportesToolStripMenuItem";
            this.resportesToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.resportesToolStripMenuItem.Text = "Reportes";
            // 
            // btnReporteHistoricoUsuarios
            // 
            this.btnReporteHistoricoUsuarios.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnReporteHistoricoUsuarios.Name = "btnReporteHistoricoUsuarios";
            this.btnReporteHistoricoUsuarios.Size = new System.Drawing.Size(482, 36);
            this.btnReporteHistoricoUsuarios.Text = "Reporte De Histórico De Usuarios";
            this.btnReporteHistoricoUsuarios.Click += new System.EventHandler(this.reporteDeHistoricoDeUsuariosToolStripMenuItem_Click);
            // 
            // btnEstadisticaMovimientosUsuarios
            // 
            this.btnEstadisticaMovimientosUsuarios.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnEstadisticaMovimientosUsuarios.Name = "btnEstadisticaMovimientosUsuarios";
            this.btnEstadisticaMovimientosUsuarios.Size = new System.Drawing.Size(482, 36);
            this.btnEstadisticaMovimientosUsuarios.Text = "Estadistica Movimiento de Usuarios";
            this.btnEstadisticaMovimientosUsuarios.Click += new System.EventHandler(this.estadisticaMovimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // btnReportePerfilesUsuariosYestados
            // 
            this.btnReportePerfilesUsuariosYestados.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnReportePerfilesUsuariosYestados.Name = "btnReportePerfilesUsuariosYestados";
            this.btnReportePerfilesUsuariosYestados.Size = new System.Drawing.Size(482, 36);
            this.btnReportePerfilesUsuariosYestados.Text = "Reporte Perfiles por Usuario y Estado";
            this.btnReportePerfilesUsuariosYestados.Click += new System.EventHandler(this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem_Click);
            // 
            // btnEstadisticaPerfiles
            // 
            this.btnEstadisticaPerfiles.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnEstadisticaPerfiles.Name = "btnEstadisticaPerfiles";
            this.btnEstadisticaPerfiles.Size = new System.Drawing.Size(482, 36);
            this.btnEstadisticaPerfiles.Text = "Estadística De Perfiles";
            this.btnEstadisticaPerfiles.Click += new System.EventHandler(this.estadisticaDePerfilesToolStripMenuItem_Click);
            // 
            // btnReporteHistoricoPermisos
            // 
            this.btnReporteHistoricoPermisos.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnReporteHistoricoPermisos.Name = "btnReporteHistoricoPermisos";
            this.btnReporteHistoricoPermisos.Size = new System.Drawing.Size(482, 36);
            this.btnReporteHistoricoPermisos.Text = "Reporte De Histórico De Permisos";
            this.btnReporteHistoricoPermisos.Click += new System.EventHandler(this.reporteDeHistoricoDePermisosToolStripMenuItem_Click);
            // 
            // btnEstadisticaPermisos
            // 
            this.btnEstadisticaPermisos.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnEstadisticaPermisos.Name = "btnEstadisticaPermisos";
            this.btnEstadisticaPermisos.Size = new System.Drawing.Size(482, 36);
            this.btnEstadisticaPermisos.Text = "Estadística De Permisos";
            this.btnEstadisticaPermisos.Click += new System.EventHandler(this.estadísticaDePermisosToolStripMenuItem_Click);
            // 
            // btnReporteIngresosAlSistema
            // 
            this.btnReporteIngresosAlSistema.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnReporteIngresosAlSistema.Name = "btnReporteIngresosAlSistema";
            this.btnReporteIngresosAlSistema.Size = new System.Drawing.Size(482, 36);
            this.btnReporteIngresosAlSistema.Text = "Reporte Ingresos al Sistema";
            this.btnReporteIngresosAlSistema.Click += new System.EventHandler(this.reporteIngresosAlSistemaToolStripMenuItem_Click);
            // 
            // btnEstadísticaIngresosAlSistema
            // 
            this.btnEstadísticaIngresosAlSistema.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnEstadísticaIngresosAlSistema.Name = "btnEstadísticaIngresosAlSistema";
            this.btnEstadísticaIngresosAlSistema.Size = new System.Drawing.Size(482, 36);
            this.btnEstadísticaIngresosAlSistema.Text = "Estadística Ingresos al Sistema";
            this.btnEstadísticaIngresosAlSistema.Click += new System.EventHandler(this.estadísticaIngresosAlSistemaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 653);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarNuevoPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarPerfiles;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRegistrarNuevoUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnFormularios;
        private System.Windows.Forms.ToolStripMenuItem btnHistoricoDeUsuarios;
        private System.Windows.Forms.ToolStripMenuItem PermisostoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnReporteHistoricoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnEstadisticaPerfiles;
        private System.Windows.Forms.ToolStripMenuItem btnAsignarPermisosPerfiles;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarPermisos;
        private System.Windows.Forms.ToolStripMenuItem btnHistoricoDePermisos;
        private System.Windows.Forms.ToolStripMenuItem btnReporteHistoricoPermisos;
        private System.Windows.Forms.ToolStripMenuItem btnEstadisticaPermisos;
        private System.Windows.Forms.ToolStripMenuItem btnEstadisticaMovimientosUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnReportePerfilesUsuariosYestados;
        private System.Windows.Forms.ToolStripMenuItem btnReporteIngresosAlSistema;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEstadísticaIngresosAlSistema;
    }
}

