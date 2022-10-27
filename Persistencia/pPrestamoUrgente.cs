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
        public void altaPrestamoUrgente(ePrestamoUrgente prestamo)
        {
            string consultaSQL1 = "INSERT INTO prestamo(fecha_retiro, fecha_devolucion, fecha_solicitada, id_usuario, estado) VALUES('" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.responsable.id + "', '" + prestamo.estadoP + "');";
            ejecutarSQL(consultaSQL1);
            string consultaSQL2 = "INSERT INTO prestamo_directo(id_prestamo) VALUES((SELECT MAX(id_prestamo) FROM prestamo))";
            ejecutarSQL(consultaSQL2);
            string consultaSQL3 = "INSERT INTO prestamo_urgente(id_prestamo) VALUES((SELECT MAX(id_prestamo) FROM prestamo))";
            ejecutarSQL(consultaSQL3);

            pEquipo unE = new pEquipo();

            foreach (eEquipo eq in prestamo._equipos)
            {
                consultaSQL1 = "INSERT INTO pu_eq VALUES((SELECT MAX(id_prestamo) FROM prestamo), '" + eq.id + "');";
                ejecutarSQL(consultaSQL1);
                eq.estado = estadoEq.Reservado.ToString();
                unE.modificarEquipo(eq);
            }
        }

        public void bajaPrestamoUrgente(ePrestamoUrgente prestamo)
        {
            String consultaSQL = "DELETE FROM prestamo_urgente WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL);
            String consultaSQL2 = "DELETE FROM prestamo_directo WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL2);
            String consultaSQL3 = "DELETE FROM prestamo WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL3);

            String consultaSQL4 = "DELETE FROM pu_eq WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL4);
        }

        public ePrestamoUrgente buscarPrestamoUrgente(ePrestamoUrgente prestamo)
        {
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_urgente ON prestamo.id_prestamo = prestamo_urgente.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.id_prestamo = '" + prestamo.id + "';";
            ePrestamoUrgente prestamoUr = new ePrestamoUrgente();
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while(resultado.Read())
            {
                prestamo = recrearP(resultado);
            }
            return prestamo;
        }

        public void modificarPrestamoUrgente(ePrestamoUrgente prestamo)
        {
            string consultaSQL1 = "UPDATE prestamo SET fecha_retiro = '" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_devolucion = '" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_solicitada = '" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', duracion = '" + prestamo.duracion + "',id_usuario = '" + prestamo.responsable.id + "', estado = '" + prestamo.estadoP + "' WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL1);

            String consultaSQL4 = "DELETE FROM pu_eq WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL4);
            foreach (eEquipo eq in prestamo._equipos)
            {
                consultaSQL1 = "INSERT INTO pu_eq VALUES('" + prestamo.id + "', '" + eq.id + "');";
                ejecutarSQL(consultaSQL1);
            }
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
            prestamo.duracion = resultado.GetInt32("duracion");
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
