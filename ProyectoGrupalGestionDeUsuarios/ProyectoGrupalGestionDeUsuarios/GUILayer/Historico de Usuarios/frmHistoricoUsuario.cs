using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;

namespace ProyectoGrupalGestionDeUsuarios.GUILayer.Historico_de_Usuarios
{
    public partial class frmHistoricoUsuario : Form
    {
        usuariosHistorialDao historial = new usuariosHistorialDao();
        public frmHistoricoUsuario()
        {
            InitializeComponent();
        }

        private void frmHistoricoUsuario_Load(object sender, EventArgs e)
        {
            mostrarDatos(historial.cargarGrilla());
        }
        private int mostrarDatos(string consulta)
        {
            DataTable historialUsuarios = historial.grilla(consulta);
            dgvConsultaHistorial.Rows.Clear();
            int cantFilas = historialUsuarios.Rows.Count;
            string estado = "";

            for (int i = 0; i < historialUsuarios.Rows.Count; i++)
            {
                if (historialUsuarios.Rows[i]["estado"] is "S")
                    estado = "Activo";
                else
                    estado = "Inactivo";

                dgvConsultaHistorial.Rows.Add(
                                             historialUsuarios.Rows[i]["fecha_historico"],
                                             historialUsuarios.Rows[i]["titulo"],
                                             historialUsuarios.Rows[i]["descripcion"],
                                             historialUsuarios.Rows[i]["usuario"],
                                             historialUsuarios.Rows[i]["nombre"],
                                             historialUsuarios.Rows[i]["email"],
                                             estado
                                             );
            }
            return cantFilas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                mostrarDatos(historial.cargarGrilla());
            }
            else
            {
                if (mostrarDatos(historial.buscarNombre(txtBuscar.Text)) >= 1)
                    mostrarDatos(historial.buscarNombre(txtBuscar.Text));
                else
                    MessageBox.Show("Usuario " + txtBuscar.Text + " No fue encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }
    }
}
