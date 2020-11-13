using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoGrupalGestionDeUsuarios.BusinessLayer;

namespace ProyectoGrupalGestionDeUsuarios.DataAccessLayer
{
    public class Reporte
    {
        public DataTable reporteHistoricoUsuarios(int NombUser, string titulo, string fechaDesde, string fechaHasta)
        {
            string reporte = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,UsuariosHistorico.usuario,UsuariosHistorico.email FROM UsuariosHistorico "
                            + "INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil "
                            + "INNER JOIN Usuarios ON Usuarios.id_usuario = UsuariosHistorico.id_usuario "
                            + "WHERE fecha_historico BETWEEN '"+ fechaDesde +"' AND '"+ fechaHasta +"' ";
            if (NombUser != 0)
                reporte += "AND usuarios.id_usuario = "+ NombUser;
            if (titulo != "")
                reporte += "AND UsuariosHistorico.titulo = '"+ titulo +"'";

            DataTable r = DataManager.GetInstance().ConsultaSQL(reporte);
            return r;
        }

        public DataTable mostrartodo()
        {
            string rep = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,usuario,email FROM UsuariosHistorico INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }

        public DataTable cantidadPorPerfil(string desde, string hasta)
        {
            string rep = "SELECT Perfiles.nombre AS perfil, count(usuarios.id_perfil) AS cantidad FROM Usuarios "
                        + "INNER JOIN Perfiles ON Perfiles.id_perfil = Usuarios.id_perfil "
                        + "INNER JOIN UsuariosHistorico ON UsuariosHistorico.id_usuario = Usuarios.id_usuario "
                        + "WHERE usuarios.borrado = 0 AND UsuariosHistorico.titulo = 'Registro de Usuario' AND UsuariosHistorico.fecha_historico BETWEEN '" + desde +"' AND '"+ hasta +"' "
                        + " GROUP BY Perfiles.nombre";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }
        
        public DataTable CboTodosUsuarios()
        {
            string rep = "SELECT id_usuario,usuario FROM usuarios";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }
        public DataTable cboUsers()
        {
            string rep = "SELECT id_usuario,usuario FROM usuarios WHERE borrado = 0";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }
        public DataTable loadEstadisticaPerfil()
        {
            string rep = "SELECT Perfiles.nombre AS perfil, count(usuarios.id_perfil) AS cantidad FROM Usuarios "
                        + " INNER JOIN Perfiles ON Perfiles.id_perfil = Usuarios.id_perfil WHERE Usuarios.borrado = 0 "
                        + " GROUP BY Perfiles.nombre ";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }
        public DataTable estadisticaHistUsuarios(string desde, string hasta)
        {
            string cantidad= "SELECT UsuariosHistorico.titulo AS Estado, count(UsuariosHistorico.titulo) AS Cantidad "
                            + "FROM UsuariosHistorico "
                            + "WHERE fecha_historico BETWEEN '"+ desde +"' AND '"+ hasta +"' "
                            + "GROUP BY UsuariosHistorico.titulo";
            DataTable r = DataManager.GetInstance().ConsultaSQL(cantidad);
            return r;

        }
        public DataTable TodoHistUsuarios()
        {
            string cantidad = "SELECT UsuariosHistorico.titulo AS Estado, count(UsuariosHistorico.titulo) AS Cantidad "
                            + "FROM UsuariosHistorico "
                            + "GROUP BY UsuariosHistorico.titulo";
            DataTable r = DataManager.GetInstance().ConsultaSQL(cantidad);
            return r;

        }
        public DataTable PerfilesYusuarios(string desde, string hasta, int id_perfil, int id_usuario, string estado)
        {
            string consulta = "SELECT UsuariosHistorico.fecha_historico,Perfiles.nombre,Usuarios.usuario,Usuarios.email,Usuarios.estado FROM Perfiles "
                            + "INNER JOIN Usuarios ON Usuarios.id_perfil = Perfiles.id_perfil "
                            + "INNER JOIN UsuariosHistorico ON UsuariosHistorico.id_usuario = Usuarios.id_usuario "
                            + "WHERE UsuariosHistorico.titulo = 'Registro de Usuario' AND Usuarios.borrado = 0 "
                            + "AND UsuariosHistorico.fecha_historico BETWEEN '" + desde + "' AND '" + hasta + "'";
                            if (id_perfil != 0)
                            consulta += " AND Perfiles.id_perfil = " + id_perfil;
                            if (id_usuario != 0)
                            consulta += " AND Usuarios.id_usuario = " + id_usuario;
                            if (estado != "")
                            consulta += " AND Usuarios.estado = '" + estado + "'";

            DataTable r = DataManager.GetInstance().ConsultaSQL(consulta);
            return r;
        }
        
        public DataTable TodosPerfilesYusuarios()
        {
            string cantidad = "SELECT UsuariosHistorico.fecha_historico,Perfiles.nombre,Usuarios.usuario,Usuarios.email,Usuarios.estado FROM Perfiles "
                            + "INNER JOIN Usuarios ON Usuarios.id_perfil = Perfiles.id_perfil "
                            + "INNER JOIN UsuariosHistorico ON UsuariosHistorico.id_usuario = Usuarios.id_usuario "
                            + "WHERE UsuariosHistorico.titulo = 'Registro de Usuario' AND Usuarios.borrado = 0";
            DataTable r = DataManager.GetInstance().ConsultaSQL(cantidad);
            return r;
        }

    }
}
