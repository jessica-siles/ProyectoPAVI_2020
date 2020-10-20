using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ProyectoGrupalGestionDeUsuarios.DataAccessLayer;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;
using ProyectoGrupalGestionDeUsuarios.Reportes.ReporteUsuarios;

namespace ProyectoGrupalGestionDeUsuarios.Reportes
{
    public partial class frmDatosUsuarios : Form
    {
        PermisoService permisoService = new PermisoService();
        public frmDatosUsuarios()
        {
            InitializeComponent();
        }
        public DataTable DosOpciones(string NombUser, string titulo, string fechaDesde, string fechaHasta)
        {
            string dos = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,usuario,email FROM UsuariosHistorico INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil WHERE usuario = '" + NombUser + "' AND titulo = '"+ titulo + "' AND fecha_historico BETWEEN '"+ fechaDesde + "' AND '"+ fechaHasta + "'";
            DataTable r = DataManager.GetInstance().ConsultaSQL(dos);
            return r;
        }
        public DataTable UnaSeleccionBusqueda(string NombUser, string titulo, string fechaDesde, string fechaHasta)
        {
            string una = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,usuario,email FROM UsuariosHistorico INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil WHERE usuario = '" + NombUser + "' OR titulo = '" + titulo + "' AND fecha_historico BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";
            DataTable r = DataManager.GetInstance().ConsultaSQL(una);
            return r;
        }

        public DataTable report(string fechaDesde, string fechaHasta)
        {
            string rep = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,usuario,email FROM UsuariosHistorico INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil WHERE fecha_historico BETWEEN '" + fechaDesde+"' AND '"+fechaHasta+"'";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;

        }

        public DataTable mostrartodo()
        {
            string rep = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,usuario,email FROM UsuariosHistorico INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }

        public DataTable usuarios(int id_usuario)
        {
            string rep = "SELECT fecha_historico,titulo FROM UsuariosHistorico";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }
        
        private void frmDatosUsuarios_Load(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.SetParameters(new ReportParameter[]{ new
            ReportParameter("fecha", Convert.ToString(DateTime.Today)), new ReportParameter("fechaDesde", dtpDesde.Text) , new ReportParameter("fechaHasta", dtpHasta.Text)});
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("UsuariosDatos", mostrartodo()));
            reportViewer2.RefreshReport();

            
            cboTitulo.Items.Add("Registro de Usuario");
            cboTitulo.Items.Add("Modificacion de Usuario");
            cboTitulo.Items.Add("Eliminacion de Usuario");
            cboTitulo.Items.Add("");
            cboTitulo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DateTime des = Convert.ToDateTime(dtpDesde.Text);
            DateTime has = Convert.ToDateTime(dtpHasta.Text);
            string desde = "";
            string hasta = "";

            int perfil = Convert.ToInt32(cboTitulo.SelectedValue);

            if (des > has)
            {
                MessageBox.Show("Debe ingresar fechas validas");
            }

            if(des < has)
            {
                 desde = des.ToString("yyyy-MM-dd");

                 hasta = has.ToString("yyyy-MM-dd");
            }


            DataTable agregar = new DataTable();

            if (txtUsuario.Text == "" && cboTitulo.Text == "")
            {
                agregar = report(desde, hasta);
            }
            if (txtUsuario.Text == "" && cboTitulo.Text != "")
            {
                agregar = UnaSeleccionBusqueda(txtUsuario.Text, cboTitulo.Text, desde, hasta);
            }
            if (txtUsuario.Text != "" && cboTitulo.Text == "")
            {
                agregar = UnaSeleccionBusqueda(txtUsuario.Text,cboTitulo.Text,desde,hasta);
            }
            if (txtUsuario.Text != "" && cboTitulo.Text != "")
            {
                agregar = DosOpciones(txtUsuario.Text,cboTitulo.Text,desde,hasta);
            }

            reportViewer2.LocalReport.SetParameters(new ReportParameter[]{ new
            ReportParameter("fechaDesde", dtpDesde.Text),new ReportParameter("fechaHasta", dtpHasta.Text)});
            reportViewer2.LocalReport.DataSources.Clear();
            
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("UsuariosDatos", agregar));
            
            reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}