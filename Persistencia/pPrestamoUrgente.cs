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
    public class pPrestamoUrgente : clsPersistencia
    {
        public void altaPrestamoUrgente(ePrestamoUrgente p)
        {
            string consultaSQL = "";
            ejecutarSQL(consultaSQL);
        }

        public void bajaPrestamoUrgente(ePrestamoUrgente p)
        {
            string consultaSQL = "";
            ejecutarSQL(consultaSQL);
        }

        public void modificarPrestamoUrgente(ePrestamoUrgente p)
        {
            string consultaSQL = "";
            ejecutarSQL(consultaSQL);
        }

        public List<ePrestamoUrgente> listarPrestamoUrgente()
        {
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_urgente ON prestamo.id_prestamo = prestamo_urgente.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario ORDER BY prestamo_urgente.id_prestamo;";
            List<ePrestamoUrgente> _prestamos = new List<ePrestamoUrgente>();
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while(resultado.Read())
            {
                _prestamos.Add(recrearP(resultado));
            }
            return _prestamos;
        }

        public List<ePrestamoUrgente> listarPrestamoUrgente(estadoP estado)
        {
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_urgente ON prestamo.id_prestamo = prestamo_urgente.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.estado = '" + estado.ToString() + "' ORDER BY prestamo_urgente.id_prestamo;";
            List<ePrestamoUrgente> _prestamos = new List<ePrestamoUrgente>();
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamos.Add(recrearP(resultado));
            }
            return _prestamos;
        }

        public List<ePrestamoUrgente> listarPUSinDevolver()
        {
            List<ePrestamoUrgente> _prestamos = new List<ePrestamoUrgente>();
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_urgente ON prestamo.id_prestamo = prestamo_urgente.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.fecha_devolucion < now() AND prestamo.estado='EnCurso' ORDER BY prestamo_urgente.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamos.Add(recrearP(resultado));
            }
            return _prestamos;
        }

        private ePrestamoUrgente recrearP(MySqlDataReader resultado)
        {
            pUsuario unPU = new pUsuario();
            ePrestamoUrgente prestamo = new ePrestamoUrgente();

            prestamo.id = resultado.GetInt32("id_prestamo");
            MySqlDateTime fechaRetiro = resultado.GetMySqlDateTime("fecha_retiro");
            prestamo.fecha_retiro = new DateTime(fechaRetiro.Year, fechaRetiro.Month, fechaRetiro.Day, fechaRetiro.Hour, fechaRetiro.Minute, fechaRetiro.Second);
            MySqlDateTime fechaDevolucion = resultado.GetMySqlDateTime("fecha_devolucion");
            prestamo.fecha_devolucion = new DateTime(fechaDevolucion.Year, fechaDevolucion.Month, fechaDevolucion.Day, fechaDevolucion.Hour, fechaDevolucion.Minute, fechaDevolucion.Second);
            MySqlDateTime fechaSolicitado = resultado.GetMySqlDateTime("fecha_solicitada");
            prestamo.fecha_solicitado = new DateTime(fechaSolicitado.Year, fechaSolicitado.Month, fechaSolicitado.Day, fechaSolicitado.Hour, fechaSolicitado.Minute, fechaSolicitado.Second);
            prestamo.responsable.ci = resultado.GetString("ci");
            prestamo.responsable = unPU.buscarUsuario(prestamo.responsable);
            prestamo.estadoP = resultado.GetString("estado");

            string consultaSQL = "SELECT * FROM pu_eq INNER JOIN equipo ON pu_eq.id_equipo = equipo.id_equipo WHERE pu_eq.id_prestamo = '" + prestamo.id + "'";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            pEquipo unPE = new pEquipo();
            eEquipo auxEq = new eEquipo();
            while (fila.Read())
            {
                auxEq.id = fila.GetInt32("id_equipo");
                prestamo._equipos.Add(unPE.buscarEquipo(auxEq));
            }

            return prestamo;
        }


    }
}
