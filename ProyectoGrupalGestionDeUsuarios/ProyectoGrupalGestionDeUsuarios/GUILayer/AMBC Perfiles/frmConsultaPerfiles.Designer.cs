namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles
{
    partial class frmConsultaPerfiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPerfiles));
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idperfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.groupBoxConsulta.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.estado,
            this.descripcion,
            this.idperfil});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsulta.Location = new System.Drawing.Point(14, 30);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsulta.MultiSelect = false;
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvConsulta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(826, 312);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            this.dgvConsulta.SelectionChanged += new System.EventHandler(this.dgvConsulta_SelectionChanged);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 260;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 260;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 260;
            // 
            // idperfil
            // 
            this.idperfil.HeaderText = "id";
            this.idperfil.Name = "idperfil";
            this.idperfil.ReadOnly = true;
            this.idperfil.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(257, 18);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 53);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(14, 18);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(194, 53);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(632, 18);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(194, 53);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxConsulta.Controls.Add(this.dgvConsulta);
            this.groupBoxConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxConsulta.Location = new System.Drawing.Point(26, 12);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(859, 346);
            this.groupBoxConsulta.TabIndex = 4;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Listado De Perfiles";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.btnModificar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Location = new System.Drawing.Point(40, 364);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(837, 80);
            this.panelBotones.TabIndex = 1;
            // 
            // frmConsultaPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 473);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.groupBoxConsulta);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(926, 512);
            this.MinimumSize = new System.Drawing.Size(926, 512);
            this.Name = "frmConsultaPerfiles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Perfiles";
            this.Load += new System.EventHandler(this.frmConsultaPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.groupBoxConsulta.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idperfil;
    }
}