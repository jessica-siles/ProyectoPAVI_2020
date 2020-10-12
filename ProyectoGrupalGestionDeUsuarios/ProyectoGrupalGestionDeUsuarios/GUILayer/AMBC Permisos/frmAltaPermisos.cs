using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;
using ProyectoGrupalGestionDeUsuarios.Entities;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Permisos
{
    public partial class frmAltaPermisos : Form
    {
        
        string mensaje = "";
        PermisoService permisoService = new PermisoService();
        Permiso permiso = new Permiso();
        Permiso insertarPermiso = new Permiso();
        PermisosDao permisoDao = new PermisosDao();
        
        public frmAltaPermisos()
        {
            
            InitializeComponent();
           

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void frmAltaPermisos_Load(object sender, EventArgs e)
        {
            
            permisoService.cargarComb(cboPerfil);

        }

        private void cargarTablasDeForms(DataGridView tabla, DataTable consulta)
        {
            DataTable cargarTabla = consulta;
            tabla.Rows.Clear();

            for (int i = 0; i < cargarTabla.Rows.Count; i++)
            {
                tabla.Rows.Add(cargarTabla.Rows[i]["id_formulario"],
                               cargarTabla.Rows[i]["nombre"],
                               cargarTabla.Rows[i]["descripcion"]);
            }


            
        }

        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cboPerfil.SelectedValue) == "System.Data.DataRowView" || Convert.ToString(cboPerfil.SelectedValue) == "")
            {
                return;
            }
            else
            { 
                permiso.Id_perfil = int.Parse(cboPerfil.SelectedValue.ToString());
                cargarTablasDeForms(dgvFormAsignados , permisoDao.buscarPorPerfilForms(permiso.Id_perfil));
                cargarTablasDeForms(dgvFormSinAsignar, permisoDao.MostrarNoRepetidos(permiso.Id_perfil));
                return;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvFormSinAsignar.Rows.Count.ToString());
            if (dgvFormSinAsignar.Rows.Count != 0)
            {
                dgvFormAsignados.Rows.Add(dgvFormSinAsignar.CurrentRow.Cells[0].Value, dgvFormSinAsignar.CurrentRow.Cells[1].Value, dgvFormSinAsignar.CurrentRow.Cells[2].Value);
                dgvFormSinAsignar.Rows.Remove(dgvFormSinAsignar.CurrentRow);
            }

            else
                return;

        }

        private void recorrerGrilla()
        {
            foreach (DataGridViewRow row in dgvFormAsignados.Rows)
            {
                
                insertarPermiso.Id_Formulario = Convert.ToInt32(row.Cells["numForm"].Value);
                MessageBox.Show(insertarPermiso.Id_Formulario.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            recorrerGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvFormAsignados.Rows.Count != 0)
            {
                dgvFormSinAsignar.Rows.Add(dgvFormAsignados.CurrentRow.Cells[0].Value, dgvFormAsignados.CurrentRow.Cells[1].Value, dgvFormAsignados.CurrentRow.Cells[2].Value);
                dgvFormAsignados.Rows.Remove(dgvFormAsignados.CurrentRow);
            }

            else
                return;
        }















        //private void buscarRepetidos(DataTable asig, DataTable SINasig) 
        //{
        //    DataTable asignados = asig;
        //    DataTable SINasignar = SINasig;
        //    bool aviso = false;

        //    if (asignados.Rows.Count > 0 && SINasignar.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < SINasignar.Rows.Count; i++)
        //        {
        //            int a = Convert.ToInt32(SINasignar.Rows[i]["id_formulario"]);
        //            MessageBox.Show(Convert.ToString(a));
        //            for (int y = 0; y < asignados.Rows.Count; y++)
        //            {
        //                int b = Convert.ToInt32(asignados.Rows[i]["id_formulario"]);
        //                MessageBox.Show(Convert.ToString(b));

        //                if (SINasignar.Rows[i]["id_formulario"] == asignados.Rows[y]["id_formulario"])
        //                {
        //                    MessageBox.Show(Convert.ToString(a));
        //                    aviso = true;
        //                }
        //            }
        //        }
        //    }

        //}



    }
}
