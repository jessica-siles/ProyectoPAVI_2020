using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupalGestionDeUsuarios.Entities
{
    public class HistorialUsuario
    {
        public int Id_historico { get; set; }
        public string Fecha { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public int borrado { get; set; }
    }
}
