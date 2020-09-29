namespace ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_de_Usuarios
{
    partial class frmHistoricoUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricoUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.dgvConsultaUsuarios = new System.Windows.Forms.DataGridView();
            this.id_historico_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(312, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Nombre de Usuario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(473, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(194, 40);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(35, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(402, 29);
            this.txtBuscar.TabIndex = 7;
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxConsulta.Controls.Add(this.dgvConsultaUsuarios);
            this.groupBoxConsulta.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxConsulta.Location = new System.Drawing.Point(22, 106);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(1212, 370);
            this.groupBoxConsulta.TabIndex = 12;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Lista De Historicos";
            // 
            // dgvConsultaUsuarios
            // 
            this.dgvConsultaUsuarios.AllowUserToAddRows = false;
            this.dgvConsultaUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaUsuarios.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.dgvConsultaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_historico_usuario,
            this.fecha,
            this.titulo,
            this.descripcion,
            this.id_usuario,
            this.id_perfil,
            this.usuario,
            this.pass,
            this.estado,
            this.borrado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultaUsuarios.GridColor = System.Drawing.Color.Thistle;
            this.dgvConsultaUsuarios.Location = new System.Drawing.Point(7, 30);
            this.dgvConsultaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsultaUsuarios.MultiSelect = false;
            this.dgvConsultaUsuarios.Name = "dgvConsultaUsuarios";
            this.dgvConsultaUsuarios.ReadOnly = true;
            this.dgvConsultaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsultaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaUsuarios.Size = new System.Drawing.Size(1198, 329);
            this.dgvConsultaUsuarios.TabIndex = 0;
            // 
            // id_historico_usuario
            // 
            this.id_historico_usuario.HeaderText = "id_historico_usuario";
            this.id_historico_usuario.Name = "id_historico_usuario";
            this.id_historico_usuario.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // id_perfil
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.id_perfil.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_perfil.HeaderText = "id_Perfil";
            this.id_perfil.Name = "id_perfil";
            this.id_perfil.ReadOnly = true;
            this.id_perfil.Width = 150;
            // 
            // usuario
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.usuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.usuario.Width = 195;
            // 
            // pass
            // 
            this.pass.HeaderText = "password";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // estado
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.estado.DefaultCellStyle = dataGridViewCellStyle4;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            // 
            // frmHistoricoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 488);
            this.Controls.Add(this.groupBoxConsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHistoricoUsuario";
            this.Text = "HistoricoUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.DataGridView dgvConsultaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_historico_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
    }
}