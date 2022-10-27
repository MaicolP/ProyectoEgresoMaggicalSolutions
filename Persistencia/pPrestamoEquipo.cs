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
    public class pPrestamoEquipo : clsPersistencia
    {
        public void altaPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            string consultaSQL1 = "INSERT INTO prestamo(fecha_retiro, fecha_devolucion, fecha_solicitada, id_usuario, estado) VALUES('" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.responsable.id + "', '" + prestamo.estadoP +"');";
            ejecutarSQL(consultaSQL1);
            string consultaSQL2 = "INSERT INTO prestamo_con_reserva(id_prestamo, curso, ejercicio, prioridad) VALUES((SELECT MAX(id_prestamo) FROM prestamo),'" + prestamo.curso + "','" + prestamo.ejercicio + "','"+ prestamo.prioridad +"')";
            ejecutarSQL(consultaSQL2);
            string consultaSQL3 = "INSERT INTO prestamo_equipos VALUES((SELECT MAX(id_prestamo) FROM prestamo_con_reserva),'" + prestamo.nomDocente + "','" + prestamo.apeDocente +"','" + prestamo.locaciones +"','" + prestamo.transporte +"','" + prestamo.equipoRodaje +"');";
            ejecutarSQL(consultaSQL3);

            pEquipo unE = new pEquipo();

            foreach(eEquipo eq in prestamo._equipos)
            {
                consultaSQL1 = "INSERT INTO peq_eq VALUES((SELECT MAX(id_prestamo) FROM prestamo), '" + eq.id +"');";
                ejecutarSQL(consultaSQL1);
                eq.estado = estadoEq.Reservado.ToString();
                unE.modificarEquipo(eq);
            }
        }

        public void bajaPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            String consultaSQL = "DELETE FROM prestamo_equipos WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL);
            String consultaSQL2 = "DELETE FROM prestamo_con_reserva WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL2);
            String consultaSQL3 = "DELETE FROM prestamo WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL3);

            String consultaSQL4 = "DELETE FROM peq_eq WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL4);
        }

        public void modificarPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            string consultaSQL1 = "UPDATE prestamo SET fecha_retiro = '" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_devolucion = '" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_solicitada = '" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', id_usuario = '" + prestamo.responsable.id + "', estado = '" + prestamo.estadoP + "' WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL1);
            String consultaSQL2 = "UPDATE prestamo_con_reserva SET curso = '" + prestamo.curso + "', ejercicio = '" + prestamo.ejercicio + "' WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL2);
            string consultaSQL3 = "UPDATE prestamo_equipos SET nombre_docente = '" + prestamo.nomDocente + "', apellido_docente = '" + prestamo.apeDocente + "', locaciones = '" + prestamo.locaciones + "', transporte = '" + prestamo.transporte + "', equipo_rodaje ='" + prestamo.equipoRodaje + "' WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL3);

            String consultaSQL4 = "DELETE FROM peq_eq WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL4);
            foreach (eEquipo eq in prestamo._equipos)
            {
                consultaSQL1 = "INSERT INTO peq_eq VALUES('" + prestamo.id + "', '" + eq.id + "');";
                ejecutarSQL(consultaSQL1);
            }
        }

        public List<ePrestamoEquipo> listarPrestamoEquipoPendiente()
        {
            List<ePrestamoEquipo> _prestamoEquipo = new List<ePrestamoEquipo>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_equipos ON prestamo.id_prestamo = prestamo_equipos.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.estado = '" + estadoP.Pendiente + "'ORDER BY prestamo_con_reserva.prioridad DESC;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEquipo.Add(recrearPE(resultado));
            }
            return _prestamoEquipo;
        }

        public List<ePrestamoEquipo> listarPrestamoEquipo(estadoP estado)
        {
            List<ePrestamoEquipo> _prestamoEquipo = new List<ePrestamoEquipo>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_equipos ON prestamo.id_prestamo = prestamo_equipos.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.estado = '" + estado.ToString() + "' ORDER BY prestamo_equipos.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEquipo.Add(recrearPE(resultado));
            }
            return _prestamoEquipo;
        }

        public List<ePrestamoEquipo> listarPrestamoEquipoxId(int idPrestamo)
        {
            List<ePrestamoEquipo> _prestamoEquipo = new List<ePrestamoEquipo>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_equipos ON prestamo.id_prestamo = prestamo_equipos.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo_equipos.id_prestamo = " + idPrestamo + ";";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEquipo.Add(recrearPE(resultado));
            }
            return _prestamoEquipo;
        }

        public List<ePrestamoEquipo> listarPrestamoEquipoNoPendiente()
        {
            List<ePrestamoEquipo> _prestamoEquipo = new List<ePrestamoEquipo>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_equipos ON prestamo.id_prestamo = prestamo_equipos.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.estado !='" + estadoP.Pendiente + "'ORDER  BY prestamo_equipos.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEquipo.Add(recrearPE(resultado));
            }
            return _prestamoEquipo;
        }

        private ePrestamoEquipo recrearPE(MySqlDataReader resultado)
        {
            pUsuario unPU = new pUsuario();
            ePrestamoEquipo prestamo = new ePrestamoEquipo();

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
            prestamo.curso = resultado.GetString("curso");
            prestamo.estadoP = resultado.GetString("estado");
            prestamo.ejercicio = resultado.GetString("ejercicio");
            prestamo.prioridad = resultado.GetInt32("prioridad");
            prestamo.locaciones = resultado.GetString("locaciones");
            prestamo.transporte = resultado.GetString("transporte");
            prestamo.nomDocente = resultado.GetString("nombre_docente");
            prestamo.apeDocente = resultado.GetString("apellido_docente");
            prestamo.equipoRodaje = resultado.GetString("equipo_rodaje");

            string consultaSQL = "SELECT * FROM peq_eq INNER JOIN equipo ON peq_eq.id_equipo = equipo.id_equipo WHERE peq_eq.id_prestamo = '" + prestamo.id + "'";
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

        public List<ePrestamoEquipo> listarPESinDevolver()
        {
            List<ePrestamoEquipo> _prestamoEquipo = new List<ePrestamoEquipo>();
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_equipos ON prestamo.id_prestamo = prestamo_equipos.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.fecha_devolucion < now() AND prestamo.estado='EnCurso' ORDER BY prestamo_equipos.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEquipo.Add(recrearPE(resultado));
            }
            return _prestamoEquipo;
        }

        public List<ePrestamoEquipo> listarPrestamoEquipoXMes(int ano, int mes)
        {
            List<ePrestamoEquipo> _prestamoEquipo = new List<ePrestamoEquipo>();
            string consultaSQL = "SELECT * FROM prestamo " +
                                 "INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo " +
                                 "INNER JOIN prestamo_equipos ON prestamo.id_prestamo = prestamo_equipos.id_prestamo " +
                                 "INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario " +
                                 "WHERE((prestamo.fecha_retiro BETWEEN '" + ano + "-" + mes + "-01' AND '" + ano + "-" + mes + "-31') OR(prestamo.fecha_devolucion BETWEEN '" + ano + "-" + mes + "-01' AND '" + ano + "-" + mes + "-31')) AND(prestamo.estado = 'EnCurso') ORDER BY prestamo_equipos.id_prestamo; ";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEquipo.Add(recrearPE(resultado));
            }
            CerrarConexion();
            return _prestamoEquipo;
        }
    }
}
