using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace formularioYconsultaBaseDeDatos.Clases
{
    class Bugs
    {
        Datos datosBugs = new Datos();

        private int id_bug;
        private string titulo;
        private string descripcion;
        private DateTime fecha_alta;
        private int id_usuario_responsable;
        private int id_usuario_asignado;
        private int id_producto;
        private int id_prioridad;
        private int id_criticidad;
        private int id_estado;
        private bool borrado;

        public int Id_bug { get => id_bug; set => id_bug = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public int Id_usuario_responsable { get => id_usuario_responsable; set => id_usuario_responsable = value; }
        public int Id_usuario_asignado { get => id_usuario_asignado; set => id_usuario_asignado = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_prioridad { get => id_prioridad; set => id_prioridad = value; }
        public int Id_criticidad { get => id_criticidad; set => id_criticidad = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public bool Borrado { get => borrado; set => borrado = value; }


        public DataTable recuperarBugs()
        {
            string consultaSQL = "SELECT id_bug,titulo,Criticidades.nombre CRITI,Prioridades.nombre PRIORI,fecha_alta,Productos.nombre PRODU,Estados.nombre ESTADO,usuario"
                              + " FROM Bugs INNER JOIN Criticidades ON Bugs.id_criticidad = Criticidades.id_criticidad"                      
                              + " INNER JOIN Estados ON Bugs.id_estado = Estados.id_estado"
                              + " INNER JOIN Prioridades ON Bugs.id_prioridad = Prioridades.id_prioridad"
                              + " INNER JOIN Productos ON Bugs.id_producto = Productos.id_producto"
                              + " INNER JOIN Usuarios ON Bugs.id_usuario_asignado = Usuarios.id_usuario"
                              + " ORDER BY fecha_alta";

            return datosBugs.consultar(consultaSQL);
        }

        public DataTable recuperarBugsFiltados(string desde,string hasta,string criticidad,string prioridad,string productos,string estados,string usuarios)
        {


            string consultaSQL = "SELECT id_bug,titulo,Criticidades.nombre as CRITI,Prioridades.nombre as PRIORI,fecha_alta,Productos.nombre as PRODU,Estados.nombre as ESTADO,usuario"
                              + " FROM Bugs INNER JOIN Criticidades ON Bugs.id_criticidad = Criticidades.id_criticidad"
                              + " INNER JOIN Estados ON Bugs.id_estado = Estados.id_estado"
                              + " INNER JOIN Prioridades ON Bugs.id_prioridad = Prioridades.id_prioridad"
                              + " INNER JOIN Productos ON Bugs.id_producto = Productos.id_producto"
                              + " INNER JOIN Usuarios ON Bugs.id_usuario_asignado = Usuarios.id_usuario";


            //consultaSQL += " AND fecha_alta BETWEEN '"+ desde +"' AND '"+hasta+"'";

            if (productos != "")
                consultaSQL += " AND Bugs.id_producto=" + productos;
            if (estados != "")
                consultaSQL += " AND Bugs.id_estado=" + estados;
            if (criticidad != "")
                consultaSQL += " AND Bugs.id_criticidad=" + criticidad;
            if (usuarios != "")
                consultaSQL += " AND Bugs.id_usuario_asignado=" + usuarios;
            if (prioridad != "")
                consultaSQL += " AND Bugs.id_prioridad=" + prioridad;

            consultaSQL += " ORDER BY fecha_alta";

            return datosBugs.consultar(consultaSQL);
        }
    }
}
