﻿using System;
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
        Permiso Permiso = new Permiso();
        Permiso InsertarPermiso = new Permiso();
        PermisosDao PermisoDao = new PermisosDao();
        List<int> Modificar = new List<int>();
        List<int> list = new List<int>();
        List<int> Quitar = new List<int>();
        bool flagADD = false;
        bool flagDEL = false;        

        public frmAltaPermisos()
        {
            InitializeComponent();            
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
                Permiso.Id_perfil = int.Parse(cboPerfil.SelectedValue.ToString());
                cargarTablasDeForms(dgvFormAsignados, PermisoDao.buscarPorPerfilForms(Permiso.Id_perfil));
                cargarTablasDeForms(dgvFormSinAsignar, PermisoDao.MostrarNoRepetidos(Permiso.Id_perfil));
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flagADD = true;

            if (dgvFormSinAsignar.Rows.Count != 0)
            {
                dgvFormAsignados.Rows.Add(dgvFormSinAsignar.CurrentRow.Cells[0].Value, 
                                          dgvFormSinAsignar.CurrentRow.Cells[1].Value, 
                                          dgvFormSinAsignar.CurrentRow.Cells[2].Value);
                dgvFormSinAsignar.Rows.Remove(dgvFormSinAsignar.CurrentRow);
            }
            else
                return;
            
        }

        private void recorrerGrilla()
        {
            list.Clear();
            Modificar.Clear();
            Quitar.Clear();

            foreach (DataGridViewRow row in dgvFormAsignados.Rows)
            {

                InsertarPermiso.Id_Formulario = Convert.ToInt32(row.Cells["numForm"].Value);
                DataTable FormulariosAsignados = PermisoDao.buscarFormAsignado(Permiso.Id_perfil, InsertarPermiso.Id_Formulario);

                if (FormulariosAsignados.Rows.Count == 0 && dgvFormAsignados.Rows.Count > 0)
                {
                    list.Add(InsertarPermiso.Id_Formulario);
                }

                if (FormulariosAsignados.Rows.Count > 0 && dgvFormAsignados.Rows.Count > 0)
                {                    
                    Modificar.Add(InsertarPermiso.Id_Formulario);
                }

                //if (flag) //Si boton quitar fue presionado
                //{
                //    foreach (DataGridViewRow renglon in dgvFormSinAsignar.Rows)
                //    {
                //        InsertarPermiso.Id_Formulario = Convert.ToInt32(renglon.Cells["numF"].Value);
                //        DataTable FormNoAsignados = PermisoDao.buscarFormAsignado(Permiso.Id_perfil, InsertarPermiso.Id_Formulario);

                //        if (FormNoAsignados.Rows.Count == 1 && dgvFormSinAsignar.Rows.Count > 0)
                //        {
                //            Quitar.Add(InsertarPermiso.Id_Formulario);                           
                //        }                        
                //    }                    
                //}
            }

            if (flagDEL) //Si boton quitar fue presionado
            {
                foreach (DataGridViewRow renglon in dgvFormSinAsignar.Rows)
                {
                    InsertarPermiso.Id_Formulario = Convert.ToInt32(renglon.Cells["numF"].Value);
                    DataTable FormNoAsignados = PermisoDao.buscarFormAsignado(Permiso.Id_perfil, InsertarPermiso.Id_Formulario);

                    if (FormNoAsignados.Rows.Count == 1 && dgvFormSinAsignar.Rows.Count > 0)
                    {
                        Quitar.Add(InsertarPermiso.Id_Formulario);
                    }
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
            PermisoDao.agregarInsertDeForms(list, Permiso.Id_perfil);
            //llamada a transaccion update (hacer!!)  
            if (flagADD)
                PermisoDao.modificarFormsUpdate(Modificar, Permiso.Id_perfil, 0);  
            if (flagDEL)
                PermisoDao.quitarPermisos(Quitar, Permiso.Id_perfil, 1);

            flagADD = flagADD = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            flagDEL = true;
            if (dgvFormAsignados.Rows.Count != 0)
            {
                dgvFormSinAsignar.Rows.Add(dgvFormAsignados.CurrentRow.Cells[0].Value, 
                dgvFormAsignados.CurrentRow.Cells[1].Value,
                dgvFormAsignados.CurrentRow.Cells[2].Value);

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