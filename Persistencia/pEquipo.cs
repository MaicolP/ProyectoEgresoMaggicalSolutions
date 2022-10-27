using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Persistencia
{
    public class pEquipo : clsPersistencia
    {
        public void altaEquipo(eEquipo equipo)
        {
            string consultaSQL = "INSERT INTO equipo (nro_serie, nombre, estado, observaciones, asegurado, fecha_ingreso, id_tipo, precio) VALUES('" +
                                 equipo.nroSerie + "','" + equipo.nombre + "','" + equipo.estado.ToString() + "','" + equipo.observaciones + "'," +
                                 equipo.asegurado.ToString() + ",'" + equipo.fechaIngreso.ToString("yyyy-MM-dd") + "','" + equipo.tipo.id + "','" + equipo.precio + "');";
            ejecutarSQL(consultaSQL);
        }

        public void bajaEquipo(eEquipo equipo)
        {
            string consultaSQL = "DELETE FROM equipo WHERE id_equipo=" + equipo.id + " ;";
            ejecutarSQL(consultaSQL);
        }

        public void modificarEquipo(eEquipo equipo)
        {
            string consultaSQL = "UPDATE equipo SET nro_serie='" + equipo.nroSerie + "', nombre='" + equipo.nombre + "', estado='" + equipo.estado.ToString() + "', observaciones='" + equipo.observaciones +
                "', asegurado=" + equipo.asegurado.ToString() + ", fecha_ingreso='" + equipo.fechaIngreso.ToString("yyyy-MM-dd") + "', id_tipo='" + equipo.tipo.id + "', precio='" + equipo.precio +
                "' WHERE id_equipo='" + equipo.id + "' ;";
            ejecutarSQL(consultaSQL);
        }

        public eEquipo buscarEquipo(eEquipo equipo)
        {
            string consultaSQL = "SELECT e.id_equipo, e.nombre, e.fecha_ingreso, e.nro_serie, e.precio, e.estado, e.asegurado, e.observaciones, e.id_tipo, t.nombre AS nombre_tipo, t.subtipo FROM equipo AS e INNER JOIN tipo AS t ON t.id_tipo=e.id_tipo WHERE e.id_equipo=" + equipo.id + " ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                equipo = recrearE(resultado);
            }
            resultado.Close();
            CerrarConexion();
            return equipo;
        }

        public List<eEquipo> listarEquipo()
        {
            List<eEquipo> _equipos = new List<eEquipo>();
            string consultaSQL = "SELECT e.id_equipo, e.nombre, e.fecha_ingreso, e.nro_serie, e.precio, e.estado, e.asegurado, e.observaciones, e.id_tipo, t.nombre AS nombre_tipo, t.subtipo FROM equipo AS e INNER JOIN tipo AS t ON t.id_tipo=e.id_tipo ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _equipos.Add(recrearE(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _equipos;
        }


        public List<eEquipo> listarEquipo(string tipo, string subtipo)
        {
            List<eEquipo> _equipos = new List<eEquipo>();
            string consultaSQL = "SELECT e.id_equipo, e.nombre, e.fecha_ingreso, e.nro_serie, e.precio, e.estado, e.asegurado, e.observaciones, e.id_tipo, t.nombre AS nombre_tipo, t.subtipo FROM equipo AS e INNER JOIN tipo AS t ON t.id_tipo=e.id_tipo" +
                                " WHERE t.nombre='" + tipo + "' AND t.subtipo='" + subtipo + "' ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _equipos.Add(recrearE(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _equipos;
        }

        public List<eEquipo> listarEquipo(string tipo)
        {
            List<eEquipo> _equipos = new List<eEquipo>();
            string consultaSQL = "SELECT e.id_equipo, e.nombre, e.fecha_ingreso, e.nro_serie, e.precio, e.estado, e.asegurado, e.observaciones, e.id_tipo, t.nombre AS nombre_tipo, t.subtipo FROM equipo AS e INNER JOIN tipo AS t ON t.id_tipo=e.id_tipo" +
                                " WHERE t.nombre='" + tipo + "' ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _equipos.Add(recrearE(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _equipos;
        }

        private eEquipo recrearE(MySqlDataReader resultado)
        {
            eEquipo equipo = new eEquipo();

            equipo.id = resultado.GetInt32("id_equipo");
            equipo.nroSerie = resultado.GetString("nro_serie");
            equipo.nombre = resultado.GetString("nombre");
            equipo.estado = resultado.GetString("estado");
            equipo.asegurado = resultado.GetBoolean("asegurado");
            equipo.precio = resultado.GetString("precio");
            MySqlDateTime fechaIngreso = resultado.GetMySqlDateTime("fecha_ingreso");
            equipo.fechaIngreso = new DateTime(fechaIngreso.Year, fechaIngreso.Month, fechaIngreso.Day);
            equipo.observaciones = resultado.GetString("observaciones");
            eTipoDeEquipo tipo = new eTipoDeEquipo();
            tipo.id = resultado.GetInt32("id_tipo");
            tipo.nombre = resultado.GetString("nombre_tipo");
            tipo.subtipo = resultado.GetString("subtipo");
            equipo.tipo = tipo;
            return equipo;
        }
    }
}
