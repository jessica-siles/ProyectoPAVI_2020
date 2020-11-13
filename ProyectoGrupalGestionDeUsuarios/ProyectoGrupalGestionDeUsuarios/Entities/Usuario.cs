using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupalGestionDeUsuarios.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public int perfil { get; set; }
        public string Password { get; set; }


        public Perfil Perfil { get; set; }


        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
