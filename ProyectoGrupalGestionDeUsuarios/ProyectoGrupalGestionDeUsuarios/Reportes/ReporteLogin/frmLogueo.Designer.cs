namespace ProyectoGrupalGestionDeUsuarios.Reportes.ReporteLogin
{
    partial class frmLogueo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoginDS = new ProyectoGrupalGestionDeUsuarios.Reportes.ReporteLogin.LoginDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grpBoxFiltros = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkBoxFechas = new System.Windows.Forms.CheckBox();
            this.chkBoxTodos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginDS)).BeginInit();
            this.grpBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtLoginBindingSource
            // 
            this.dtLoginBindingSource.DataMember = "dtLogin";
            this.dtLoginBindingSource.DataSource = this.LoginDS;
            // 
            // LoginDS
            // 
            this.LoginDS.DataSetName = "LoginDS";
            this.LoginDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "LoginDS";
            reportDataSource1.Value = this.dtLoginBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoGrupalGestionDeUsuarios.Reportes.ReporteLogin.LoginInforme.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 224);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(859, 325);
            this.reportViewer1.TabIndex = 0;
            // 
            // grpBoxFiltros
            // 
            this.grpBoxFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxFiltros.Controls.Add(this.txtUsuario);
            this.grpBoxFiltros.Controls.Add(this.btnSalir);
            this.grpBoxFiltros.Controls.Add(this.btnLimpiar);
            this.grpBoxFiltros.Controls.Add(this.chkBoxFechas);
            this.grpBoxFiltros.Controls.Add(this.chkBoxTodos);
            this.grpBoxFiltros.Controls.Add(this.btnConsultar);
            this.grpBoxFiltros.Controls.Add(this.lblFechaHasta);
            this.grpBoxFiltros.Controls.Add(this.dtpFechaHasta);
            this.grpBoxFiltros.Controls.Add(this.dtpFechaDesde);
            this.grpBoxFiltros.Controls.Add(this.lblFechaDesde);
            this.grpBoxFiltros.Controls.Add(this.lblPerfil);
            this.grpBoxFiltros.Controls.Add(this.lblUsuario);
            this.grpBoxFiltros.Controls.Add(this.cboPerfil);
            this.grpBoxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFiltros.ForeColor = System.Drawing.Color.White;
            this.grpBoxFiltros.Location = new System.Drawing.Point(13, 12);
            this.grpBoxFiltros.Name = "grpBoxFiltros";
            this.grpBoxFiltros.Size = new System.Drawing.Size(859, 195);
            this.grpBoxFiltros.TabIndex = 1;
            this.grpBoxFiltros.TabStop = false;
            this.grpBoxFiltros.Text = "Filtros";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(196, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 24);
            this.txtUsuario.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(527, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(221, 30);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(196, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(221, 30);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // chkBoxFechas
            // 
            this.chkBoxFechas.AutoSize = true;
            this.chkBoxFechas.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxFechas.Enabled = false;
            this.chkBoxFechas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkBoxFechas.Location = new System.Drawing.Point(326, 68);
            this.chkBoxFechas.Name = "chkBoxFechas";
            this.chkBoxFechas.Size = new System.Drawing.Size(144, 22);
            this.chkBoxFechas.TabIndex = 2;
            this.chkBoxFechas.Text = "Habilitar fechas";
            this.chkBoxFechas.UseVisualStyleBackColor = false;
            this.chkBoxFechas.CheckedChanged += new System.EventHandler(this.chkBoxFechas_CheckedChanged_1);
            // 
            // chkBoxTodos
            // 
            this.chkBoxTodos.AutoSize = true;
            this.chkBoxTodos.Checked = true;
            this.chkBoxTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxTodos.Location = new System.Drawing.Point(527, 68);
            this.chkBoxTodos.Name = "chkBoxTodos";
            this.chkBoxTodos.Size = new System.Drawing.Size(149, 22);
            this.chkBoxTodos.TabIndex = 0;
            this.chkBoxTodos.Text = "Todo el historial";
            this.chkBoxTodos.UseVisualStyleBackColor = true;
            this.chkBoxTodos.CheckedChanged += new System.EventHandler(this.chkBoxTodos_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(527, 103);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(221, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(77, 115);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(105, 18);
            this.lblFechaHasta.TabIndex = 8;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(196, 109);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(110, 24);
            this.dtpFechaHasta.TabIndex = 4;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(196, 68);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(110, 24);
            this.dtpFechaDesde.TabIndex = 3;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(77, 73);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(109, 18);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(454, 29);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(52, 18);
            this.lblPerfil.TabIndex = 4;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(77, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cboPerfil
            // 
            this.cboPerfil.Enabled = false;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(527, 26);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(221, 26);
            this.cboPerfil.TabIndex = 6;
            // 
            // frmLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoGrupalGestionDeUsuarios.Properties.Resources.FondoPerf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.grpBoxFiltros);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmLogueo";
            this.Text = "Reporte de accesos al sistema";
            this.Load += new System.EventHandler(this.LogueoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginDS)).EndInit();
            this.grpBoxFiltros.ResumeLayout(false);
            this.grpBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtLoginBindingSource;
        private LoginDS LoginDS;
        private System.Windows.Forms.GroupBox grpBoxFiltros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkBoxFechas;
        private System.Windows.Forms.CheckBox chkBoxTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}