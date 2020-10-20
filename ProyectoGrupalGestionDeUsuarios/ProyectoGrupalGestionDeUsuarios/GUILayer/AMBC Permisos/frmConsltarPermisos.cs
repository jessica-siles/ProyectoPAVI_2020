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

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.AMBC_Permisos
{
    public partial class frmConsltarPermisos : Form
    {
        private readonly PermisoService permisoService;
        Perfil oPerfil = new Perfil();
        int nro;

        public frmConsltarPermisos()
        {
            InitializeComponent();
            permisoService = new PermisoService();           
        }

        private void frmConsltarPermisos_Load(object sender, EventArgs e)
        {
            permisoService.cargarComb(cboPerfil);
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
                return;
            }
            else
            {
                oPerfil.IdPerfil = int.Parse(cboPerfil.SelectedValue.ToString());
                CargarGrilla(dgvConsultaPermisos, permisoService.obtenerFormulariosPorPerfil(oPerfil.IdPerfil));
                return;
            }
            
        }
    }
}
