using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGrupalGestionDeUsuarios.Entities;
using System.Data;

namespace ProyectoGrupalGestionDeUsuarios.DataAccessLayer
{
    public class FormularioDao
    {
        //Datos oDatos = new Datos();  
        public DataTable RecuperarFormularios()
        {           
            return DBHelper.GetDBHelper().ConsultaSQL("SELECT * FROM Formularios");            
        }
        
        public Formulario recuperarFormularioPorID(int id)
        {
            string consultaSQL = "SELECT * FROM Formularios WHERE id_formulario =" + id;

            //var resultado = oDatos.Consultar(consultaSQL);
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSQL);
            return MapearFormulario(resultado.Rows[0]);
            
        }

        public Formulario MapearFormulario(DataRow row)
        {
            Formulario oFormulario = new Formulario();
            oFormulario.IdFormulario = Convert.ToInt32(row["id_formulario"].ToString());
            oFormulario.Nombre = row["nombre"].ToString();            
            oFormulario.Borrado = Convert.ToInt32(row["borrado"]);
            oFormulario.Descripcion = row["descripcion"].ToString();
            oFormulario.NombreBoton = row["boton_name"].ToString();
            return oFormulario;
        }

        public bool existeFormulario(string nombre)
        {            
            DataTable tabla = new DataTable();            
            //tabla = oDatos.Consultar("SELECT * FROM Formularios WHERE nombre ='" + nombre + "'");
            tabla = DBHelper.GetDBHelper().ConsultaSQL("SELECT * FROM Formularios WHERE nombre ='" + nombre + "'");
            if (tabla.Rows.Count == 0)
                return false;
            else
                return true;
        }

        public void InsertarFormulario(Formulario oFormulario)
        {
            string insertSQL = "INSERT INTO Formularios (nombre, borrado, descripcion, boton_name) "
                                + "VALUES ('" +
                                oFormulario.Nombre + "','" +
                                oFormulario.Borrado + "','" +
                                oFormulario.Descripcion + "','" +
                                oFormulario.NombreBoton + "')";

            //oDatos.Actualizar(insertSQL);
            DBHelper.GetDBHelper().EjecutarSQL(insertSQL);
        }

        public void UpdateFormulario(Formulario oFormulario)
        {
            string UpdateSQL = "UPDATE Formularios SET nombre='" + oFormulario.Nombre + "'," +
                                                                  "borrado=" + oFormulario.Borrado + "," +
                                                                  "descripcion='" + oFormulario.Descripcion + "'," +
                                                                  "boton_name ='" + oFormulario.NombreBoton + "'" +
                                                                  "WHERE id_formulario=" + oFormulario.IdFormulario;
            //oDatos.Actualizar(UpdateSQL);  
            DBHelper.GetDBHelper().EjecutarSQL(UpdateSQL);
        }

        public void DeleteFormulario(int id)
        {
            string DeleteSQL = "DELETE FROM Formularios WHERE id_formulario=" + id;
            //oDatos.Actualizar(DeleteSQL);
            DBHelper.GetDBHelper().EjecutarSQL(DeleteSQL);
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            string consulta = "SELECT * FROM "+nombreTabla+" WHERE borrado=0";
            DataTable tabla = DBHelper.GetDBHelper().ConsultaSQL(consulta);       
            return tabla;
        }

    }
}
