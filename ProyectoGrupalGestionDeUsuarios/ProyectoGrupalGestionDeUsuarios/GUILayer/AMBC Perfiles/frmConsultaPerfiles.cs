using System;
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
        Perfil objetoPerfil = new Perfil();

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
            frmModificarPerfil modificarPerfil = new frmModificarPerfil();
            var perfil = (Perfil)dgvConsulta.CurrentRow.DataBoundItem;
            modificarPerfil.SeleccionarPerfil(frmModificarPerfil.FormMode.update, perfil);
            modificarPerfil.ShowDialog();
            dgvConsulta.DataSource = perfilService.obtenerPerfiles();


        }

        private void frmConsultaPerfiles_Load(object sender, EventArgs e)
        {
            
        }

        public void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvConsulta.ColumnCount = 4;
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

            dgvConsulta.Columns[2].Name = "Descripcion";
            dgvConsulta.Columns[2].DataPropertyName = "Descripcion";

            dgvConsulta.Columns[3].Name = "id";
            dgvConsulta.Columns[3].DataPropertyName = "IdPerfil";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvConsulta.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvConsulta.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsulta_SelectionChanged(object sender, EventArgs e)
        {
            objetoPerfil.IdPerfil = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[3].Value);
            objetoPerfil.Nombre = Convert.ToString(dgvConsulta.CurrentRow.Cells[0].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar " + objetoPerfil.Nombre + "", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            {
                //agregado de recargado de grilla
                perfilService.eliminarPerfil(objetoPerfil.IdPerfil);
                dgvConsulta.DataSource = perfilService.obtenerPerfiles();

            }
        }
    }
}
