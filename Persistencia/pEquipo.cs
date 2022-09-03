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
                                 equipo.nroSerie + "','" + equipo.nombre + "','" + equipo.estado.ToString() + "','" + equipo.observaciones + "','" +
                                 equipo.asegurado + "','" + equipo.fechaIngreso.ToString("yyyy-MM-dd") + "','" + equipo.tipo.id + "','" + equipo.precio + "');";
            ejecutarSQL(consultaSQL);
        }

        public void bajaEquipo(eEquipo equipo)
        {
            string consultaSQL = "DELETE FROM equipo WHERE id_equipo=" + equipo.id + " ;";
            ejecutarSQL(consultaSQL);
        }

        public void modificarEquipo(eEquipo equipo)
        {
            
        }

        public eEquipo buscarEquipo(eEquipo equipo)
        {
            string consultaSQL = "SELECT e.id_equipo, e.nombre, e.fecha_ingreso, e.nro_serie, e.precio, e.estado, e.asegurado, e.observaciones, e.id_tipo, t.nombre AS tipo, t.subtipo FROM equipo AS e INNER JOIN tipo AS t ON t.id_tipo=e.id_tipo WHERE e.id_equipo=" + equipo.id + " ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                equipo = recrearE(resultado);
            }
            return equipo;
        }

        public List<eEquipo> listarEquipo()
        {
            List<eEquipo> _equipos = new List<eEquipo>();
            string consultaSQL = "SELECT e.id_equipo, e.nombre, e.fecha_ingreso, e.nro_serie, e.precio, e.estado, e.asegurado, e.observaciones, e.id_tipo, t.nombre AS tipo, t.subtipo FROM equipo AS e INNER JOIN tipo AS t ON t.id_tipo=e.id_tipo";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _equipos.Add(recrearE(resultado));
            }
            return _equipos;
        }

        private eEquipo recrearE(MySqlDataReader resultado)
        {
            eEquipo equipo = new eEquipo();

            equipo.id = resultado.GetInt32("id_equipo");
            equipo.nroSerie = resultado.GetString("nro_serie");
            equipo.nombre = resultado.GetString("nombre");
            equipo.estado = (estado)Enum.Parse(typeof(estado), resultado.GetString("estado"));
            equipo.asegurado = resultado.GetBoolean("asegurado");
            equipo.precio = resultado.GetString("precio");
            MySqlDateTime fechaIngreso = resultado.GetMySqlDateTime("fecha_ingreso");
            equipo.fechaIngreso = new DateTime(fechaIngreso.Year, fechaIngreso.Month, fechaIngreso.Day);
            equipo.observaciones = resultado.GetString("observaciones");
            eTipoDeEquipo tipo = new eTipoDeEquipo();
            tipo.id = resultado.GetInt32("id_tipo");
            tipo.nombre = resultado.GetString("tipo");
            tipo.subtipo = resultado.GetString("subtipo");
            equipo.tipo = tipo;
            return equipo;
        }
    }
}
