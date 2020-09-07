namespace formularioYconsultaBaseDeDatos.Formularios
{
    partial class frmDetalleBugs
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
            this.lblnBugs = new System.Windows.Forms.Label();
            this.lblnTitulo = new System.Windows.Forms.Label();
            this.lblnProducto = new System.Windows.Forms.Label();
            this.lblnDescripcion = new System.Windows.Forms.Label();
            this.lblnFechaCrea = new System.Windows.Forms.Label();
            this.lblnPrioridad = new System.Windows.Forms.Label();
            this.lblnCriticidad = new System.Windows.Forms.Label();
            this.txtBug = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtFechaCrea = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.txtCriticidad = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignadoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnBugs
            // 
            this.lblnBugs.AutoSize = true;
            this.lblnBugs.Location = new System.Drawing.Point(198, 9);
            this.lblnBugs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnBugs.Name = "lblnBugs";
            this.lblnBugs.Size = new System.Drawing.Size(53, 21);
            this.lblnBugs.TabIndex = 0;
            this.lblnBugs.Text = "#Bugs";
            // 
            // lblnTitulo
            // 
            this.lblnTitulo.AutoSize = true;
            this.lblnTitulo.Location = new System.Drawing.Point(198, 43);
            this.lblnTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnTitulo.Name = "lblnTitulo";
            this.lblnTitulo.Size = new System.Drawing.Size(49, 21);
            this.lblnTitulo.TabIndex = 1;
            this.lblnTitulo.Text = "Titulo";
            // 
            // lblnProducto
            // 
            this.lblnProducto.AutoSize = true;
            this.lblnProducto.Location = new System.Drawing.Point(181, 83);
            this.lblnProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnProducto.Name = "lblnProducto";
            this.lblnProducto.Size = new System.Drawing.Size(76, 21);
            this.lblnProducto.TabIndex = 2;
            this.lblnProducto.Text = "Producto:";
            // 
            // lblnDescripcion
            // 
            this.lblnDescripcion.AutoSize = true;
            this.lblnDescripcion.Location = new System.Drawing.Point(157, 193);
            this.lblnDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnDescripcion.Name = "lblnDescripcion";
            this.lblnDescripcion.Size = new System.Drawing.Size(94, 21);
            this.lblnDescripcion.TabIndex = 3;
            this.lblnDescripcion.Text = "Descripcion:";
            // 
            // lblnFechaCrea
            // 
            this.lblnFechaCrea.AutoSize = true;
            this.lblnFechaCrea.Location = new System.Drawing.Point(139, 120);
            this.lblnFechaCrea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnFechaCrea.Name = "lblnFechaCrea";
            this.lblnFechaCrea.Size = new System.Drawing.Size(118, 21);
            this.lblnFechaCrea.TabIndex = 4;
            this.lblnFechaCrea.Text = "Fecha Creacion:";
            // 
            // lblnPrioridad
            // 
            this.lblnPrioridad.AutoSize = true;
            this.lblnPrioridad.Location = new System.Drawing.Point(184, 257);
            this.lblnPrioridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnPrioridad.Name = "lblnPrioridad";
            this.lblnPrioridad.Size = new System.Drawing.Size(77, 21);
            this.lblnPrioridad.TabIndex = 5;
            this.lblnPrioridad.Text = "Prioridad:";
            // 
            // lblnCriticidad
            // 
            this.lblnCriticidad.AutoSize = true;
            this.lblnCriticidad.Location = new System.Drawing.Point(184, 294);
            this.lblnCriticidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnCriticidad.Name = "lblnCriticidad";
            this.lblnCriticidad.Size = new System.Drawing.Size(79, 21);
            this.lblnCriticidad.TabIndex = 6;
            this.lblnCriticidad.Text = "Criticidad:";
            // 
            // txtBug
            // 
            this.txtBug.Enabled = false;
            this.txtBug.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBug.Location = new System.Drawing.Point(265, 6);
            this.txtBug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBug.Name = "txtBug";
            this.txtBug.Size = new System.Drawing.Size(93, 29);
            this.txtBug.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(265, 43);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(277, 29);
            this.txtTitulo.TabIndex = 9;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(265, 80);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(277, 29);
            this.txtProducto.TabIndex = 10;
            // 
            // txtFechaCrea
            // 
            this.txtFechaCrea.Enabled = false;
            this.txtFechaCrea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCrea.Location = new System.Drawing.Point(265, 117);
            this.txtFechaCrea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaCrea.Name = "txtFechaCrea";
            this.txtFechaCrea.Size = new System.Drawing.Size(176, 29);
            this.txtFechaCrea.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(265, 154);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(277, 92);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Enabled = false;
            this.txtPrioridad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioridad.Location = new System.Drawing.Point(265, 254);
            this.txtPrioridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Size = new System.Drawing.Size(277, 29);
            this.txtPrioridad.TabIndex = 13;
            // 
            // txtCriticidad
            // 
            this.txtCriticidad.Enabled = false;
            this.txtCriticidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriticidad.Location = new System.Drawing.Point(265, 291);
            this.txtCriticidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCriticidad.Name = "txtCriticidad";
            this.txtCriticidad.Size = new System.Drawing.Size(277, 29);
            this.txtCriticidad.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(299, 562);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 38);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 335);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(671, 229);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de Bugs";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.responsable,
            this.estado,
            this.asignadoA});
            this.dgvHistorial.Location = new System.Drawing.Point(8, 30);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(647, 188);
            this.dgvHistorial.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 150;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Width = 150;
            // 
            // asignadoA
            // 
            this.asignadoA.HeaderText = "Asignado a";
            this.asignadoA.Name = "asignadoA";
            this.asignadoA.Width = 150;
            // 
            // frmDetalleBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(696, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCriticidad);
            this.Controls.Add(this.txtPrioridad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtFechaCrea);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtBug);
            this.Controls.Add(this.lblnCriticidad);
            this.Controls.Add(this.lblnPrioridad);
            this.Controls.Add(this.lblnFechaCrea);
            this.Controls.Add(this.lblnDescripcion);
            this.Controls.Add(this.lblnProducto);
            this.Controls.Add(this.lblnTitulo);
            this.Controls.Add(this.lblnBugs);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleBugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Bugs";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnBugs;
        private System.Windows.Forms.Label lblnTitulo;
        private System.Windows.Forms.Label lblnProducto;
        private System.Windows.Forms.Label lblnDescripcion;
        private System.Windows.Forms.Label lblnFechaCrea;
        private System.Windows.Forms.Label lblnPrioridad;
        private System.Windows.Forms.Label lblnCriticidad;
        private System.Windows.Forms.TextBox txtBug;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtFechaCrea;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrioridad;
        private System.Windows.Forms.TextBox txtCriticidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignadoA;
    }
}