using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formularioYconsultaBaseDeDatos.Clases;

namespace formularioYconsultaBaseDeDatos.Formularios
    
{
    public partial class frmConsultasBugs : Form
    {
        Datos combosDatos = new Datos();
        Bugs consBugs = new Bugs();

        public frmConsultasBugs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grupoCombos_Enter(object sender, EventArgs e)
        {

        }

        private void txtEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultasBugs_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            this.cargarCombo(cboEstado,"estados",1);
            this.cargarCombo(cboProducto, "productos", 1);
            this.cargarCombo(cboPrioridad, "prioridades", 1);
            this.cargarCombo(cboCriticidad, "criticidades", 1);
            this.cargarCombo(cboAsignado, "usuarios", 2);

            //dgvConsulta.DataSource = consBugs.recuperarBugs();
            this.cargarGrilla(dgvConsulta,consBugs.recuperarBugs());

        }
        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_bug"],
                                tabla.Rows[i]["titulo"],
                                tabla.Rows[i]["PRODU"],
                                tabla.Rows[i]["fecha_alta"],
                                tabla.Rows[i]["ESTADO"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["CRITI"],
                                tabla.Rows[i]["PRIORI"]);
            }
        }
        private void cargarCombo(ComboBox combo, string nombre, int numeroColumna)
        {
            DataTable tabla = new DataTable();
            tabla = combosDatos.consultarTabla(nombre);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[numeroColumna].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmDetalleBugs formularioDetalle = new frmDetalleBugs();
            formularioDetalle.ShowDialog();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _estado, _producto, _asignado, _criticidad, _prioridad;
            _estado = _producto = _asignado = _criticidad = _prioridad = "";

            

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fecha Desde mayor que Hasta");
                    return;
            }
            if (cboEstado.SelectedIndex != -1)
                _estado = cboEstado.SelectedValue.ToString();

            if (cboCriticidad.SelectedIndex != -1)
                _criticidad = cboCriticidad.SelectedValue.ToString();

            if (cboAsignado.SelectedIndex != -1)
                _asignado = cboAsignado.SelectedValue.ToString();
            
            if (cboPrioridad.SelectedIndex != -1)
            {
                _prioridad = cboPrioridad.SelectedValue.ToString();
                MessageBox.Show(_prioridad);
            }

            if (cboProducto.SelectedIndex != -1)
                _producto = cboProducto.SelectedValue.ToString();


            this.cargarGrilla(dgvConsulta, consBugs.recuperarBugsFiltados(dtpFechaDesde.Value.ToString(),
                                                                          dtpFechaHasta.Value.ToString(),
                                                                          _criticidad,
                                                                          _asignado,
                                                                          _producto,
                                                                          _estado,
                                                                          _prioridad));

        }
    }
}
