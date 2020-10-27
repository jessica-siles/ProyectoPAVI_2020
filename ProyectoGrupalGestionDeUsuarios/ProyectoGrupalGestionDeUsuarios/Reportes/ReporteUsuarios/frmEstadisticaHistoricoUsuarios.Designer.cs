namespace ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios
{
    partial class frmEstadisticaHistoricoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaHistoricoUsuarios));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios.EstadisticaHistoricoUsua" +
    "rios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(469, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hasta:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(85, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "Desde:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(532, 54);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(283, 40);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Consultar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(541, 675);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 40);
            this.button1.TabIndex = 35;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpDesde.Location = new System.Drawing.Point(147, 18);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(274, 27);
            this.dtpDesde.TabIndex = 36;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpHasta.Location = new System.Drawing.Point(532, 18);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(283, 27);
            this.dtpHasta.TabIndex = 37;
            // 
            // frmEstadisticaHistoricoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 729);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEstadisticaHistoricoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstadisticaHistoricoUsuarios";
            this.Load += new System.EventHandler(this.frmEstadisticaHistoricoUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}