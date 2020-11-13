namespace ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_Permisos
{
    partial class frmPermisosHistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdHistorialPermisos = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxHistorioPermisos = new System.Windows.Forms.GroupBox();
            this.grpBoxFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkBoxFechas = new System.Windows.Forms.CheckBox();
            this.chkBoxTodos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.cboFormulario = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPermisos)).BeginInit();
            this.grpBoxHistorioPermisos.SuspendLayout();
            this.grpBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdHistorialPermisos
            // 
            this.grdHistorialPermisos.AllowUserToAddRows = false;
            this.grdHistorialPermisos.AllowUserToDeleteRows = false;
            this.grdHistorialPermisos.BackgroundColor = System.Drawing.Color.Purple;
            this.grdHistorialPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorialPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.fecha,
            this.Formulario,
            this.Perfil,
            this.Descripción});
            this.grdHistorialPermisos.Location = new System.Drawing.Point(6, 19);
            this.grdHistorialPermisos.Name = "grdHistorialPermisos";
            this.grdHistorialPermisos.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grdHistorialPermisos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdHistorialPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHistorialPermisos.Size = new System.Drawing.Size(798, 268);
            this.grdHistorialPermisos.TabIndex = 0;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 50;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 120;
            // 
            // Formulario
            // 
            this.Formulario.HeaderText = "Formulario";
            this.Formulario.Name = "Formulario";
            this.Formulario.ReadOnly = true;
            this.Formulario.Width = 250;
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            this.Perfil.Width = 120;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 200;
            // 
            // grpBoxHistorioPermisos
            // 
            this.grpBoxHistorioPermisos.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxHistorioPermisos.Controls.Add(this.grdHistorialPermisos);
            this.grpBoxHistorioPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxHistorioPermisos.ForeColor = System.Drawing.Color.White;
            this.grpBoxHistorioPermisos.Location = new System.Drawing.Point(36, 198);
            this.grpBoxHistorioPermisos.Name = "grpBoxHistorioPermisos";
            this.grpBoxHistorioPermisos.Size = new System.Drawing.Size(810, 293);
            this.grpBoxHistorioPermisos.TabIndex = 1;
            this.grpBoxHistorioPermisos.TabStop = false;
            this.grpBoxHistorioPermisos.Text = "Historial De Permisos";
            // 
            // grpBoxFiltros
            // 
            this.grpBoxFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxFiltros.Controls.Add(this.btnLimpiar);
            this.grpBoxFiltros.Controls.Add(this.chkBoxFechas);
            this.grpBoxFiltros.Controls.Add(this.chkBoxTodos);
            this.grpBoxFiltros.Controls.Add(this.btnConsultar);
            this.grpBoxFiltros.Controls.Add(this.lblFechaHasta);
            this.grpBoxFiltros.Controls.Add(this.dtpFechaHasta);
            this.grpBoxFiltros.Controls.Add(this.dtpFechaDesde);
            this.grpBoxFiltros.Controls.Add(this.lblFechaDesde);
            this.grpBoxFiltros.Controls.Add(this.lblPerfil);
            this.grpBoxFiltros.Controls.Add(this.lblFormulario);
            this.grpBoxFiltros.Controls.Add(this.cboPerfil);
            this.grpBoxFiltros.Controls.Add(this.cboFormulario);
            this.grpBoxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFiltros.ForeColor = System.Drawing.Color.White;
            this.grpBoxFiltros.Location = new System.Drawing.Point(36, 3);
            this.grpBoxFiltros.Name = "grpBoxFiltros";
            this.grpBoxFiltros.Size = new System.Drawing.Size(810, 189);
            this.grpBoxFiltros.TabIndex = 2;
            this.grpBoxFiltros.TabStop = false;
            this.grpBoxFiltros.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(186, 144);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(221, 30);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkBoxFechas
            // 
            this.chkBoxFechas.AutoSize = true;
            this.chkBoxFechas.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxFechas.Enabled = false;
            this.chkBoxFechas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkBoxFechas.Location = new System.Drawing.Point(316, 65);
            this.chkBoxFechas.Name = "chkBoxFechas";
            this.chkBoxFechas.Size = new System.Drawing.Size(144, 22);
            this.chkBoxFechas.TabIndex = 11;
            this.chkBoxFechas.Text = "Habilitar fechas";
            this.chkBoxFechas.UseVisualStyleBackColor = false;
            this.chkBoxFechas.CheckedChanged += new System.EventHandler(this.chkBoxFecha_CheckedChanged);
            // 
            // chkBoxTodos
            // 
            this.chkBoxTodos.AutoSize = true;
            this.chkBoxTodos.Checked = true;
            this.chkBoxTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxTodos.Location = new System.Drawing.Point(517, 65);
            this.chkBoxTodos.Name = "chkBoxTodos";
            this.chkBoxTodos.Size = new System.Drawing.Size(149, 22);
            this.chkBoxTodos.TabIndex = 10;
            this.chkBoxTodos.Text = "Todo el historial";
            this.chkBoxTodos.UseVisualStyleBackColor = true;
            this.chkBoxTodos.CheckedChanged += new System.EventHandler(this.chkBoxTodos_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(517, 112);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(221, 30);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(67, 112);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(105, 18);
            this.lblFechaHasta.TabIndex = 8;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(186, 106);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(110, 24);
            this.dtpFechaHasta.TabIndex = 7;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(186, 65);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(110, 24);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(67, 70);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(109, 18);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(444, 26);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(52, 18);
            this.lblPerfil.TabIndex = 4;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblFormulario
            // 
            this.lblFormulario.AutoSize = true;
            this.lblFormulario.Location = new System.Drawing.Point(67, 26);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(95, 18);
            this.lblFormulario.TabIndex = 3;
            this.lblFormulario.Text = "Formulario:";
            // 
            // cboPerfil
            // 
            this.cboPerfil.Enabled = false;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(517, 23);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(221, 26);
            this.cboPerfil.TabIndex = 1;
            // 
            // cboFormulario
            // 
            this.cboFormulario.Enabled = false;
            this.cboFormulario.FormattingEnabled = true;
            this.cboFormulario.Location = new System.Drawing.Point(186, 23);
            this.cboFormulario.Name = "cboFormulario";
            this.cboFormulario.Size = new System.Drawing.Size(221, 26);
            this.cboFormulario.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(352, 505);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 44);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPermisosHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoGrupalGestionDeUsuarios.Properties.Resources.FondoPerf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpBoxFiltros);
            this.Controls.Add(this.grpBoxHistorioPermisos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmPermisosHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial De Permisos";
            this.Load += new System.EventHandler(this.frmPermisosHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorialPermisos)).EndInit();
            this.grpBoxHistorioPermisos.ResumeLayout(false);
            this.grpBoxFiltros.ResumeLayout(false);
            this.grpBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistorialPermisos;
        private System.Windows.Forms.GroupBox grpBoxHistorioPermisos;
        private System.Windows.Forms.GroupBox grpBoxFiltros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblFormulario;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.ComboBox cboFormulario;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox chkBoxTodos;
        private System.Windows.Forms.CheckBox chkBoxFechas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
    }
}