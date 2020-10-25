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
        public DataTable DosOpciones(string NombUser, string titulo, string fechaDesde, string fechaHasta)
        {
            string dos = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,usuario,email FROM UsuariosHistorico INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil WHERE usuario = '" + NombUser + "' AND titulo = '" + titulo + "' AND fecha_historico BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";
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
            string rep = "SELECT fecha_historico,titulo,UsuariosHistorico.descripcion,Perfiles.nombre,usuario,email FROM UsuariosHistorico INNER JOIN Perfiles ON UsuariosHistorico.id_perfil = Perfiles.id_perfil WHERE fecha_historico BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";
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
        public DataTable cantidadPorPerfil(string desde, string hasta)
        {
            string rep = "SELECT Perfiles.nombre AS perfil, count(usuarios.id_perfil) AS cantidad FROM Usuarios "
                        + "INNER JOIN Perfiles ON Perfiles.id_perfil = Usuarios.id_perfil "
                        + "INNER JOIN UsuariosHistorico ON UsuariosHistorico.id_usuario = Usuarios.id_usuario "
                        + "WHERE UsuariosHistorico.titulo = 'Registro de Usuario' AND UsuariosHistorico.fecha_historico BETWEEN '" + desde +"' AND '"+ hasta +"' "
                        + " GROUP BY Perfiles.nombre";
            DataTable r = DataManager.GetInstance().ConsultaSQL(rep);
            return r;
        }
        public DataTable loadEstadisticaPerfil()
        {
            string rep = "SELECT Perfiles.nombre AS perfil, count(usuarios.id_perfil) AS cantidad FROM Usuarios "
                        + " INNER JOIN Perfiles ON Perfiles.id_perfil = Usuarios.id_perfil"
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
    }
}
