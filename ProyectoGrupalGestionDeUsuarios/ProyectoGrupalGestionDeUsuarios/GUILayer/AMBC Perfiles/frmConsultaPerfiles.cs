﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Perfiles
{
    public partial class frmConsultaPerfiles : Form
    {
        private readonly PerfilService perfilService;

        public frmConsultaPerfiles()
        {
            InitializeComponent();
            InitializeDataGridView();
            perfilService = new PerfilService();            
            
            dgvConsulta.DataSource = perfilService.obtenerPerfiles();           
        }               

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoPerfil ModificarPerfil;
            ModificarPerfil = new frmAgregarNuevoPerfil();
            ModificarPerfil.ShowDialog();
        }

        private void frmConsultaPerfiles_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvConsulta.ColumnCount = 3;
            dgvConsulta.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvConsulta.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvConsulta.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            dgvConsulta.Columns[0].Name = "Nombre";
            dgvConsulta.Columns[0].DataPropertyName = "Nombre";
            // Definimos el ancho de la columna.

            dgvConsulta.Columns[1].Name = "Estado";
            dgvConsulta.Columns[1].DataPropertyName = "Estado";            

            dgvConsulta.Columns[2].Name = "descripcion";
            dgvConsulta.Columns[2].DataPropertyName = "Descripcion";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvConsulta.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvConsulta.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
