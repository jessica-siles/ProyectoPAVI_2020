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


        PermisoService permisoService = new PermisoService();
        Permiso permiso = new Permiso();
        Permiso insertarPermiso = new Permiso();
        PermisosDao permisoDao = new PermisosDao();
        List<int> Modificar = new List<int>();
        List<int> list = new List<int>();

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
                cargarTablasDeForms(dgvFormAsignados, permisoDao.buscarPorPerfilForms(permiso.Id_perfil));
                cargarTablasDeForms(dgvFormSinAsignar, permisoDao.MostrarNoRepetidos(permiso.Id_perfil));
                return;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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

            list.Clear();
            Modificar.Clear();


            foreach (DataGridViewRow row in dgvFormAsignados.Rows)
            {

                insertarPermiso.Id_Formulario = Convert.ToInt32(row.Cells["numForm"].Value);
                DataTable insertar = permisoDao.buscarFormAsignado(permiso.Id_perfil, insertarPermiso.Id_Formulario);
                if (insertar.Rows.Count == 0 && dgvFormAsignados.Rows.Count > 0)
                {
                    list.Add(insertarPermiso.Id_Formulario);
                }
                if (insertar.Rows.Count == 1 && dgvFormAsignados.Rows.Count > 0)
                {
                    Modificar.Add(insertarPermiso.Id_Formulario);
                }
                else
                {

                }
            }



        }
        private void buscarUpdate(List<int> Numforms)
        {

            for (int i = 0; i < Numforms.Count(); i++)
            {
                MessageBox.Show(Convert.ToString(Numforms[i]));
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            recorrerGrilla();
            //llamada a la transaccion de insertar forms (hacer!!)
            permisoDao.agregarInsertDeForms(list, permiso.Id_perfil);
            //llamada a transaccion update (hacer!!)
            permisoDao.modificarFormsUpdate(Modificar, permiso.Id_perfil);

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