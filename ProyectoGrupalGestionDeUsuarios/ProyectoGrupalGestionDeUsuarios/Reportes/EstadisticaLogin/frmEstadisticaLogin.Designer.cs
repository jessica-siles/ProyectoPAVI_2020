namespace ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaLogins
{
    partial class frmEstadisticaLogin
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grpBoxEstLogins = new System.Windows.Forms.GroupBox();
            this.bntSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.grpBoxEstLogins.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoGrupalGestionDeUsuarios.Reportes.EstadisticaLogin.EstadisticaLoginInforme" +
    ".rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 132);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(859, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // grpBoxEstLogins
            // 
            this.grpBoxEstLogins.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxEstLogins.Controls.Add(this.bntSalir);
            this.grpBoxEstLogins.Controls.Add(this.btnConsultar);
            this.grpBoxEstLogins.Controls.Add(this.dtpFechaHasta);
            this.grpBoxEstLogins.Controls.Add(this.dtpFechaDesde);
            this.grpBoxEstLogins.Controls.Add(this.lblHasta);
            this.grpBoxEstLogins.Controls.Add(this.lblDesde);
            this.grpBoxEstLogins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEstLogins.ForeColor = System.Drawing.Color.White;
            this.grpBoxEstLogins.Location = new System.Drawing.Point(13, 2);
            this.grpBoxEstLogins.Name = "grpBoxEstLogins";
            this.grpBoxEstLogins.Size = new System.Drawing.Size(859, 124);
            this.grpBoxEstLogins.TabIndex = 1;
            this.grpBoxEstLogins.TabStop = false;
            this.grpBoxEstLogins.Text = "Filtros";
            // 
            // bntSalir
            // 
            this.bntSalir.BackColor = System.Drawing.Color.White;
            this.bntSalir.ForeColor = System.Drawing.Color.Black;
            this.bntSalir.Location = new System.Drawing.Point(571, 73);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(200, 33);
            this.bntSalir.TabIndex = 5;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = false;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(170, 73);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(200, 33);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(571, 24);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaHasta.TabIndex = 3;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(170, 24);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(485, 29);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(57, 18);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(79, 28);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(61, 18);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // frmEstadisticaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoGrupalGestionDeUsuarios.Properties.Resources.FondoPerf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.grpBoxEstLogins);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmEstadisticaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica Ingresos al Sistema";
            this.Load += new System.EventHandler(this.frmEstadisticaLogin_Load);
            this.grpBoxEstLogins.ResumeLayout(false);
            this.grpBoxEstLogins.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox grpBoxEstLogins;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button bntSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}