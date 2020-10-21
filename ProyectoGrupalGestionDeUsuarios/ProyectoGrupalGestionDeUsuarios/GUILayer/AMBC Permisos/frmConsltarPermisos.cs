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
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Permisos
{
    public partial class frmConsltarPermisos : Form
    {
        private readonly PermisoService permisoService;
        PermisosDao permisoDao = new PermisosDao();
        Perfil oPerfil = new Perfil();
        int nro;

        public frmConsltarPermisos()
        {
            InitializeComponent();
            permisoService = new PermisoService();
            dgvConsultaPermisos.ClearSelection();
        }

        private void frmConsltarPermisos_Load(object sender, EventArgs e)
        {
            permisoService.cargarComb(cboPerfil, -1);
            
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_formulario"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["descripcion"]);
            }
        }
        
        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cboPerfil.SelectedValue) == "System.Data.DataRowView" || Convert.ToString(cboPerfil.SelectedValue) == "")
            {
                btnModificar.Enabled = false;
                button1.Enabled = false;
                return;
            }
            else
            {
                oPerfil.IdPerfil = int.Parse(cboPerfil.SelectedValue.ToString());
                CargarGrilla(dgvConsultaPermisos, permisoService.obtenerFormulariosPorPerfil(oPerfil.IdPerfil));
                if (dgvConsultaPermisos.Rows.Count == 0)
                {
                    btnModificar.Enabled = false;
                    button1.Enabled = false;
                    return;
                }
                else
                {
                    btnModificar.Enabled = true;
                    button1.Enabled = true;
                    return;
                }
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogoResultante = MessageBox.Show("Seguro que desea eliminar todos los formularios asociados? ", "Aviso", MessageBoxButtons.YesNo);

            if (dialogoResultante == DialogResult.Yes)
            {
                permisoDao.eliminartodos(oPerfil.IdPerfil);
                CargarGrilla(dgvConsultaPermisos, permisoService.obtenerFormulariosPorPerfil(oPerfil.IdPerfil));
                
            }
            else if (dialogoResultante == DialogResult.No)
            {
                    //nothing
            }
        
        }

        private void dgvConsultaPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvConsultaPermisos.ClearSelection();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAltaPermisos alta = new frmAltaPermisos(oPerfil.IdPerfil);
            alta.ShowDialog();
            CargarGrilla(dgvConsultaPermisos, permisoService.obtenerFormulariosPorPerfil(oPerfil.IdPerfil));


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
