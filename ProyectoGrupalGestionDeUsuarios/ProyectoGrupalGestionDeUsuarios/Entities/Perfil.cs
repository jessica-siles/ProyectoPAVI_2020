using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProyectoGrupalGestionDeUsuarios.Entities;
using System.Windows.Forms;

namespace ProyectoGrupalGestionDeUsuarios.Entities
{
    public class Perfil        
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }

        public int Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

        public void cambiarEstado()
        {
            if (Estado is "False")
            {
                Estado = "Activo";
            }
            else
            {
                Estado = "No Activo";
            }
        }
        public void mostrarEstado(bool m)
        {
            MessageBox.Show(Convert.ToString(m), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
