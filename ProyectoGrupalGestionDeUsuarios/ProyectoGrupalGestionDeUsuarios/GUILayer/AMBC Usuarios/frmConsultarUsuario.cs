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
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Usuarios
{
    public partial class frmConsultarUsuario : Form
    {
        Usuario usuarioEntities = new Usuario();
        DataManager DataMan = new DataManager();
        UsuarioDao UsuarioDao = new UsuarioDao();

        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            cargarGrilla(UsuarioDao.consultaUsuarios());

        }
        private int cargarGrilla(string SQLconsulta)
        {
            DataTable usuarios = UsuarioDao.Consultar(SQLconsulta);
            dgvConsultaUsuarios.Rows.Clear();
            int cantFilas = usuarios.Rows.Count;
            
            for (int i = 0; i < usuarios.Rows.Count; i++)
            {
                dgvConsultaUsuarios.Rows.Add(usuarios.Rows[i]["usuario"],
                                             usuarios.Rows[i]["password"],
                                             usuarios.Rows[i]["email"],
                                             usuarios.Rows[i]["nombre"],
                                             usuarios.Rows[i]["estado"],
                                             usuarios.Rows[i]["id_usuario"]);
            }
            return cantFilas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            DialogResult dialogoResultante = MessageBox.Show("Seguro que desea eliminar " + usuarioEntities.NombreUsuario + "", "Aviso", MessageBoxButtons.YesNo);


            if (dialogoResultante == DialogResult.Yes)
            {
                //agregado de recargado de grilla
                UsuarioDao.EliminarPorId(usuarioEntities.IdUsuario);
                cargarGrilla(UsuarioDao.consultaUsuarios());


            }
            else if (dialogoResultante == DialogResult.No)
            {
                //nothing
            }
        }

        private void dgvConsultaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            usuarioEntities.IdUsuario = Convert.ToInt32(dgvConsultaUsuarios.CurrentRow.Cells[5].Value);
            usuarioEntities.NombreUsuario = Convert.ToString(dgvConsultaUsuarios.CurrentRow.Cells[0].Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            frmModificarUsuario modificarUsuario = new frmModificarUsuario(usuarioEntities.IdUsuario);
            modificarUsuario.ShowDialog();
            cargarGrilla(UsuarioDao.consultaUsuarios());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                cargarGrilla(UsuarioDao.consultaUsuarios());
            }
            else
            {


                if (cargarGrilla(UsuarioDao.buscarPorNombreUsuario(txtBuscar.Text)) >= 1)
                    cargarGrilla(UsuarioDao.buscarPorNombreUsuario(txtBuscar.Text));
                else
                    MessageBox.Show("Usuario " + txtBuscar.Text + " No fue encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
