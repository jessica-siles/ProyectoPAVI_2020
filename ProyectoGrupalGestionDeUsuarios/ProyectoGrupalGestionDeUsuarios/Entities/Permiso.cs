using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupalGestionDeUsuarios.Entities
{
    public class Permiso
    {
        public int Id_perfil { set; get; }
        public int Id_Formulario { get; set; }
        public int Borrado { get; set; }

    }
}
