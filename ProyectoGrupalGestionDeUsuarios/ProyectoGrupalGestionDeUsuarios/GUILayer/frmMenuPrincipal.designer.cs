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
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermisostoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosAPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeHistoricoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaMovimientoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaDePerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeHistoricoDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteIngresosAlSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.formulariosToolStripMenuItem,
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
            this.usuarioToolStripMenuItem,
            this.consultarPerfilesToolStripMenuItem});
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(103, 36);
            this.btnPerfil.Text = "Perfiles";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(312, 36);
            this.usuarioToolStripMenuItem.Text = "Agregar Nuevo Perfil";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // consultarPerfilesToolStripMenuItem
            // 
            this.consultarPerfilesToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.consultarPerfilesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarPerfilesToolStripMenuItem.Name = "consultarPerfilesToolStripMenuItem";
            this.consultarPerfilesToolStripMenuItem.Size = new System.Drawing.Size(312, 36);
            this.consultarPerfilesToolStripMenuItem.Text = "Consultar Perfiles";
            this.consultarPerfilesToolStripMenuItem.Click += new System.EventHandler(this.consultarPerfilesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoUsuarioToolStripMenuItem,
            this.consultarUsuariosToolStripMenuItem,
            this.historicoDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(117, 36);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarNuevoUsuarioToolStripMenuItem
            // 
            this.registrarNuevoUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.registrarNuevoUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarNuevoUsuarioToolStripMenuItem.Name = "registrarNuevoUsuarioToolStripMenuItem";
            this.registrarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.registrarNuevoUsuarioToolStripMenuItem.Text = "Registrar Nuevo Usuario";
            this.registrarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.consultarUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            this.consultarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuariosToolStripMenuItem_Click);
            // 
            // historicoDeUsuariosToolStripMenuItem
            // 
            this.historicoDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.historicoDeUsuariosToolStripMenuItem.Name = "historicoDeUsuariosToolStripMenuItem";
            this.historicoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.historicoDeUsuariosToolStripMenuItem.Text = "Histórico De Usuarios";
            this.historicoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.historicoDeUsuariosToolStripMenuItem_Click);
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            this.formulariosToolStripMenuItem.Click += new System.EventHandler(this.formulariosToolStripMenuItem_Click);
            // 
            // PermisostoolStripMenuItem1
            // 
            this.PermisostoolStripMenuItem1.BackColor = System.Drawing.Color.MediumOrchid;
            this.PermisostoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarPermisosAPerfilesToolStripMenuItem,
            this.consultarPermisosToolStripMenuItem,
            this.historicoDeToolStripMenuItem});
            this.PermisostoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermisostoolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.PermisostoolStripMenuItem1.Name = "PermisostoolStripMenuItem1";
            this.PermisostoolStripMenuItem1.Size = new System.Drawing.Size(121, 36);
            this.PermisostoolStripMenuItem1.Text = "Permisos";
            this.PermisostoolStripMenuItem1.Click += new System.EventHandler(this.PermisostoolStripMenuItem1_Click);
            // 
            // asignarPermisosAPerfilesToolStripMenuItem
            // 
            this.asignarPermisosAPerfilesToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.asignarPermisosAPerfilesToolStripMenuItem.Name = "asignarPermisosAPerfilesToolStripMenuItem";
            this.asignarPermisosAPerfilesToolStripMenuItem.Size = new System.Drawing.Size(375, 36);
            this.asignarPermisosAPerfilesToolStripMenuItem.Text = "Asignar Permisos A Perfiles";
            this.asignarPermisosAPerfilesToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosAPerfilesToolStripMenuItem_Click);
            // 
            // consultarPermisosToolStripMenuItem
            // 
            this.consultarPermisosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.consultarPermisosToolStripMenuItem.Name = "consultarPermisosToolStripMenuItem";
            this.consultarPermisosToolStripMenuItem.Size = new System.Drawing.Size(375, 36);
            this.consultarPermisosToolStripMenuItem.Text = "Consultar Permisos";
            this.consultarPermisosToolStripMenuItem.Click += new System.EventHandler(this.consultarPermisosToolStripMenuItem_Click);
            // 
            // historicoDeToolStripMenuItem
            // 
            this.historicoDeToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.historicoDeToolStripMenuItem.Name = "historicoDeToolStripMenuItem";
            this.historicoDeToolStripMenuItem.Size = new System.Drawing.Size(375, 36);
            this.historicoDeToolStripMenuItem.Text = "Historico De Permisos";
            this.historicoDeToolStripMenuItem.Click += new System.EventHandler(this.historicoDeToolStripMenuItem_Click);
            // 
            // resportesToolStripMenuItem
            // 
            this.resportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeHistoricoDeUsuariosToolStripMenuItem,
            this.estadisticaMovimientoDeUsuariosToolStripMenuItem,
            this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem,
            this.estadisticaDePerfilesToolStripMenuItem,
            this.reporteDeHistoricoDePermisosToolStripMenuItem,
            this.estadísticaDePermisosToolStripMenuItem,
            this.reporteIngresosAlSistemaToolStripMenuItem});
            this.resportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.resportesToolStripMenuItem.Name = "resportesToolStripMenuItem";
            this.resportesToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.resportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeHistoricoDeUsuariosToolStripMenuItem
            // 
            this.reporteDeHistoricoDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.reporteDeHistoricoDeUsuariosToolStripMenuItem.Name = "reporteDeHistoricoDeUsuariosToolStripMenuItem";
            this.reporteDeHistoricoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(482, 36);
            this.reporteDeHistoricoDeUsuariosToolStripMenuItem.Text = "Reporte De Histórico De Usuarios";
            this.reporteDeHistoricoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeHistoricoDeUsuariosToolStripMenuItem_Click);
            // 
            // estadisticaMovimientoDeUsuariosToolStripMenuItem
            // 
            this.estadisticaMovimientoDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.estadisticaMovimientoDeUsuariosToolStripMenuItem.Name = "estadisticaMovimientoDeUsuariosToolStripMenuItem";
            this.estadisticaMovimientoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(482, 36);
            this.estadisticaMovimientoDeUsuariosToolStripMenuItem.Text = "Estadistica Movimiento de Usuarios";
            this.estadisticaMovimientoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.estadisticaMovimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // reportePerfilesPorUsuarioYEstadoToolStripMenuItem
            // 
            this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem.Name = "reportePerfilesPorUsuarioYEstadoToolStripMenuItem";
            this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem.Size = new System.Drawing.Size(482, 36);
            this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem.Text = "Reporte Perfiles por Usuario y Estado";
            this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem.Click += new System.EventHandler(this.reportePerfilesPorUsuarioYEstadoToolStripMenuItem_Click);
            // 
            // estadisticaDePerfilesToolStripMenuItem
            // 
            this.estadisticaDePerfilesToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.estadisticaDePerfilesToolStripMenuItem.Name = "estadisticaDePerfilesToolStripMenuItem";
            this.estadisticaDePerfilesToolStripMenuItem.Size = new System.Drawing.Size(482, 36);
            this.estadisticaDePerfilesToolStripMenuItem.Text = "Estadística De Perfiles";
            this.estadisticaDePerfilesToolStripMenuItem.Click += new System.EventHandler(this.estadisticaDePerfilesToolStripMenuItem_Click);
            // 
            // reporteDeHistoricoDePermisosToolStripMenuItem
            // 
            this.reporteDeHistoricoDePermisosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.reporteDeHistoricoDePermisosToolStripMenuItem.Name = "reporteDeHistoricoDePermisosToolStripMenuItem";
            this.reporteDeHistoricoDePermisosToolStripMenuItem.Size = new System.Drawing.Size(482, 36);
            this.reporteDeHistoricoDePermisosToolStripMenuItem.Text = "Reporte De Histórico De Permisos";
            this.reporteDeHistoricoDePermisosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeHistoricoDePermisosToolStripMenuItem_Click);
            // 
            // estadísticaDePermisosToolStripMenuItem
            // 
            this.estadísticaDePermisosToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.estadísticaDePermisosToolStripMenuItem.Name = "estadísticaDePermisosToolStripMenuItem";
            this.estadísticaDePermisosToolStripMenuItem.Size = new System.Drawing.Size(482, 36);
            this.estadísticaDePermisosToolStripMenuItem.Text = "Estadística De Permisos";
            this.estadísticaDePermisosToolStripMenuItem.Click += new System.EventHandler(this.estadísticaDePermisosToolStripMenuItem_Click);
            // 
            // reporteIngresosAlSistemaToolStripMenuItem
            // 
            this.reporteIngresosAlSistemaToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.reporteIngresosAlSistemaToolStripMenuItem.Name = "reporteIngresosAlSistemaToolStripMenuItem";
            this.reporteIngresosAlSistemaToolStripMenuItem.Size = new System.Drawing.Size(482, 36);
            this.reporteIngresosAlSistemaToolStripMenuItem.Text = "Reporte Ingresos al Sistema";
            this.reporteIngresosAlSistemaToolStripMenuItem.Click += new System.EventHandler(this.reporteIngresosAlSistemaToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PermisostoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeHistoricoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaDePerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosAPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeHistoricoDePermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaDePermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaMovimientoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePerfilesPorUsuarioYEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteIngresosAlSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

