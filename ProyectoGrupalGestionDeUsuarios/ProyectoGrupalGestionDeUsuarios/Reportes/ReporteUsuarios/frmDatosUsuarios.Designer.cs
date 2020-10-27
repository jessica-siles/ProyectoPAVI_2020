using ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios;

namespace ProyectoGrupalGestionDeUsuarios.Reportes
{
    partial class frmDatosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosUsuarios));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prueba = new ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios.prueba();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios.ReporteDatosUsuario.rdlc" +
    "";
            this.reportViewer2.Location = new System.Drawing.Point(12, 185);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(882, 351);
            this.reportViewer2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 56);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre de \r\n      usuario:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(602, 132);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(274, 40);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Consultar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(454, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 56);
            this.label4.TabIndex = 26;
            this.label4.Text = "Modificaciones \r\n      del Usuario:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(54, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Desde:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(530, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hasta:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(590, 550);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 51);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTitulo
            // 
            this.cboTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Location = new System.Drawing.Point(602, 83);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(274, 28);
            this.cboTitulo.TabIndex = 32;
            // 
            // prueba
            // 
            this.prueba.DataSetName = "prueba";
            this.prueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboUsuario
            // 
            this.cboUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(127, 83);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(274, 28);
            this.cboUsuario.TabIndex = 33;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpDesde.Location = new System.Drawing.Point(127, 31);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(274, 27);
            this.dtpDesde.TabIndex = 34;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpHasta.Location = new System.Drawing.Point(602, 27);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(274, 27);
            this.dtpHasta.TabIndex = 35;
            // 
            // frmDatosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 615);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.cboTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmDatosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.frmDatosUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private prueba prueba;
        private System.Windows.Forms.ComboBox cboTitulo;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}