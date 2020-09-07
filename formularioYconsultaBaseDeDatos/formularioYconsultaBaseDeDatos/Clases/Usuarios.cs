using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace formularioYconsultaBaseDeDatos.Clases
{
    class Usuarios
    {
        private int id_usuario;
        private string nom_usuario;
        private string password;
        private string email;
        private int id_perfil;

        public int Id_usuario
        {
            get { return id_usuario;}
            set { id_usuario = value;}
        }

        public string Nom_usuario
        {
            get { return nom_usuario; }
            set { nom_usuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email { get => email; set => email = value; }

        public int Id_perfil { get => id_perfil; set => id_perfil = value; }

        public int validarUsuario(string nombre, string clave)
        {
            string consultaSQL = "SELECT * FROM dbo.Usuarios WHERE usuario='" + nombre + "'AND password='" + clave + "'";
            DataTable tabla = new DataTable();

            Datos oDato = new Datos();
            tabla = oDato.consultar(consultaSQL);

            if (tabla.Rows.Count > 0)
                return Convert.ToInt32(tabla.Rows[0][0]);
            else
                return 0;
        }
    }

}
