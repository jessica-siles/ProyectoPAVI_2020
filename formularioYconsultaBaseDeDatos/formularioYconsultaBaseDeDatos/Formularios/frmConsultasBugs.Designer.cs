namespace formularioYconsultaBaseDeDatos.Formularios
{
    partial class frmConsultasBugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasBugs));
            this.grupoCombos = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.cboAsignado = new System.Windows.Forms.ComboBox();
            this.cboCriticidad = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblnCriticidad = new System.Windows.Forms.Label();
            this.lblnAsignadoA = new System.Windows.Forms.Label();
            this.lblnFechaHasta = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.idBugs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiganadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnPrioridad = new System.Windows.Forms.Label();
            this.lblnEstado = new System.Windows.Forms.Label();
            this.lblnProducto = new System.Windows.Forms.Label();
            this.lblnFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grupoCombos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoCombos
            // 
            this.grupoCombos.BackColor = System.Drawing.Color.Moccasin;
            this.grupoCombos.Controls.Add(this.dtpFechaHasta);
            this.grupoCombos.Controls.Add(this.cboAsignado);
            this.grupoCombos.Controls.Add(this.cboCriticidad);
            this.grupoCombos.Controls.Add(this.btnConsultar);
            this.grupoCombos.Controls.Add(this.cboProducto);
            this.grupoCombos.Controls.Add(this.cboPrioridad);
            this.grupoCombos.Controls.Add(this.cboEstado);
            this.grupoCombos.Controls.Add(this.lblnCriticidad);
            this.grupoCombos.Controls.Add(this.lblnAsignadoA);
            this.grupoCombos.Controls.Add(this.lblnFechaHasta);
            this.grupoCombos.Controls.Add(this.dgvConsulta);
            this.grupoCombos.Controls.Add(this.lblnPrioridad);
            this.grupoCombos.Controls.Add(this.lblnEstado);
            this.grupoCombos.Controls.Add(this.lblnProducto);
            this.grupoCombos.Controls.Add(this.lblnFechaDesde);
            this.grupoCombos.Controls.Add(this.dtpFechaDesde);
            this.grupoCombos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoCombos.Location = new System.Drawing.Point(1, 12);
            this.grupoCombos.Name = "grupoCombos";
            this.grupoCombos.Size = new System.Drawing.Size(855, 388);
            this.grupoCombos.TabIndex = 0;
            this.grupoCombos.TabStop = false;
            this.grupoCombos.Text = "Filtros";
            this.grupoCombos.Enter += new System.EventHandler(this.grupoCombos_Enter);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(527, 21);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(169, 25);
            this.dtpFechaHasta.TabIndex = 15;
            // 
            // cboAsignado
            // 
            this.cboAsignado.FormattingEnabled = true;
            this.cboAsignado.Location = new System.Drawing.Point(527, 54);
            this.cboAsignado.Name = "cboAsignado";
            this.cboAsignado.Size = new System.Drawing.Size(169, 25);
            this.cboAsignado.TabIndex = 14;
            // 
            // cboCriticidad
            // 
            this.cboCriticidad.FormattingEnabled = true;
            this.cboCriticidad.Location = new System.Drawing.Point(527, 88);
            this.cboCriticidad.Name = "cboCriticidad";
            this.cboCriticidad.Size = new System.Drawing.Size(169, 25);
            this.cboCriticidad.TabIndex = 13;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(527, 118);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(169, 31);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(118, 121);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(169, 25);
            this.cboProducto.TabIndex = 11;
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(118, 88);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(169, 25);
            this.cboPrioridad.TabIndex = 10;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(118, 54);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(169, 25);
            this.cboEstado.TabIndex = 9;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.txtEstado_SelectedIndexChanged);
            // 
            // lblnCriticidad
            // 
            this.lblnCriticidad.AutoSize = true;
            this.lblnCriticidad.Location = new System.Drawing.Point(443, 91);
            this.lblnCriticidad.Name = "lblnCriticidad";
            this.lblnCriticidad.Size = new System.Drawing.Size(71, 17);
            this.lblnCriticidad.TabIndex = 8;
            this.lblnCriticidad.Text = "Criticidad:";
            // 
            // lblnAsignadoA
            // 
            this.lblnAsignadoA.AutoSize = true;
            this.lblnAsignadoA.Location = new System.Drawing.Point(433, 57);
            this.lblnAsignadoA.Name = "lblnAsignadoA";
            this.lblnAsignadoA.Size = new System.Drawing.Size(81, 17);
            this.lblnAsignadoA.TabIndex = 7;
            this.lblnAsignadoA.Text = "Asignado a:";
            // 
            // lblnFechaHasta
            // 
            this.lblnFechaHasta.AutoSize = true;
            this.lblnFechaHasta.Location = new System.Drawing.Point(428, 27);
            this.lblnFechaHasta.Name = "lblnFechaHasta";
            this.lblnFechaHasta.Size = new System.Drawing.Size(86, 17);
            this.lblnFechaHasta.TabIndex = 6;
            this.lblnFechaHasta.Text = "Fecha Hasta:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBugs,
            this.titulo,
            this.producto,
            this.fechaCreacion,
            this.estado,
            this.asiganadoA,
            this.criticidad,
            this.prioridad});
            this.dgvConsulta.Location = new System.Drawing.Point(6, 161);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(839, 221);
            this.dgvConsulta.TabIndex = 5;
            // 
            // idBugs
            // 
            this.idBugs.HeaderText = "# Bugs";
            this.idBugs.Name = "idBugs";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Tìtulo";
            this.titulo.Name = "titulo";
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha Creacion";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.Width = 200;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // asiganadoA
            // 
            this.asiganadoA.HeaderText = "Asignado a";
            this.asiganadoA.Name = "asiganadoA";
            // 
            // criticidad
            // 
            this.criticidad.HeaderText = "Criticidad";
            this.criticidad.Name = "criticidad";
            // 
            // prioridad
            // 
            this.prioridad.HeaderText = "Prioridad";
            this.prioridad.Name = "prioridad";
            // 
            // lblnPrioridad
            // 
            this.lblnPrioridad.AutoSize = true;
            this.lblnPrioridad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnPrioridad.Location = new System.Drawing.Point(36, 88);
            this.lblnPrioridad.Name = "lblnPrioridad";
            this.lblnPrioridad.Size = new System.Drawing.Size(69, 17);
            this.lblnPrioridad.TabIndex = 4;
            this.lblnPrioridad.Text = "Prioridad:";
            // 
            // lblnEstado
            // 
            this.lblnEstado.AutoSize = true;
            this.lblnEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnEstado.Location = new System.Drawing.Point(52, 57);
            this.lblnEstado.Name = "lblnEstado";
            this.lblnEstado.Size = new System.Drawing.Size(53, 17);
            this.lblnEstado.TabIndex = 3;
            this.lblnEstado.Text = "Estado:";
            // 
            // lblnProducto
            // 
            this.lblnProducto.AutoSize = true;
            this.lblnProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnProducto.Location = new System.Drawing.Point(37, 123);
            this.lblnProducto.Name = "lblnProducto";
            this.lblnProducto.Size = new System.Drawing.Size(68, 17);
            this.lblnProducto.TabIndex = 2;
            this.lblnProducto.Text = "Producto:";
            // 
            // lblnFechaDesde
            // 
            this.lblnFechaDesde.AutoSize = true;
            this.lblnFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnFechaDesde.Location = new System.Drawing.Point(23, 27);
            this.lblnFechaDesde.Name = "lblnFechaDesde";
            this.lblnFechaDesde.Size = new System.Drawing.Size(89, 17);
            this.lblnFechaDesde.TabIndex = 1;
            this.lblnFechaDesde.Text = "Fecha Desde:";
            this.lblnFechaDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(118, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(169, 25);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(774, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(432, 409);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(188, 408);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(47, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar1.Image")));
            this.btnBuscar1.Location = new System.Drawing.Point(109, 406);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(54, 38);
            this.btnBuscar1.TabIndex = 2;
            this.btnBuscar1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(27, 406);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(54, 38);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmConsultasBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grupoCombos);
            this.Name = "frmConsultasBugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta General De Bugs";
            this.Load += new System.EventHandler(this.frmConsultasBugs_Load);
            this.grupoCombos.ResumeLayout(false);
            this.grupoCombos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoCombos;
        private System.Windows.Forms.Label lblnFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblnPrioridad;
        private System.Windows.Forms.Label lblnEstado;
        private System.Windows.Forms.Label lblnProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.ComboBox cboAsignado;
        private System.Windows.Forms.ComboBox cboCriticidad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblnCriticidad;
        private System.Windows.Forms.Label lblnAsignadoA;
        private System.Windows.Forms.Label lblnFechaHasta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiganadoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridad;
    }
}