using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupalGestionDeUsuarios.Entities
{
    public class Formulario
    {
        int idFormulario;
        string nombre;
        int borrado;
        string descripcion;
        string nombreBoton;

        public int IdFormulario { get => idFormulario; set => idFormulario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string NombreBoton { get => nombreBoton; set => nombreBoton = value; }

        public override string ToString()
        {
            return Nombre;
        }

        //public void BorradoToActivoInactivo()
        //{
        //    if (Borrado is "False")
        //        Borrado = "Activo";
        //    else
        //        Borrado = "Inactivo";
        //}

        public bool ValidarFormulario()
        {
            if (nombre == string.Empty)
            {
                MessageBox.Show("El nombre esta vacio!!!");
                return false;
            }
            if (descripcion == "")
            {
                MessageBox.Show("La descripción esta vacio!!!");
                return false;
            }
            return true;
        }
    }
}
