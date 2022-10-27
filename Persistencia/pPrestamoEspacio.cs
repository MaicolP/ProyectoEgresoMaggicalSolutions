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
    public class pPrestamoEspacio : clsPersistencia
    {
        public void altaPrestamoEspacio(ePrestamoEspacio prestamo)
        {
            String consultaSQL = "INSERT INTO prestamo (fecha_retiro, fecha_devolucion, fecha_solicitada, id_usuario, estado) VALUES('" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "','" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "','" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "','" + prestamo.responsable.id + "','" + prestamo.estadoP + "');";
            ejecutarSQL(consultaSQL);
            String consultaSQL2 = "INSERT INTO prestamo_con_reserva (id_prestamo, curso, ejercicio, prioridad) VALUES ((SELECT MAX(id_prestamo) FROM prestamo), '" + prestamo.curso + "', '" + prestamo.ejercicio + "','" + prestamo.prioridad + "');";
            ejecutarSQL(consultaSQL2);
            String consultaSQL3 = "INSERT INTO prestamo_espacios (id_prestamo, id_espacio) VALUES ((SELECT MAX(id_prestamo) FROM prestamo_con_reserva), '" + prestamo.espacio.id + "');";
            ejecutarSQL(consultaSQL3);

        }

        public void bajaPrestamoEspacio(ePrestamoEspacio prestamo)
        {
            String consultaSQL = "DELETE FROM prestamo_espacios WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL);
            String consultaSQL2 = "DELETE FROM prestamo_con_reserva WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL2);
            String consultaSQL3 = "DELETE FROM prestamo WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL3);
        }

        public List<ePrestamoEspacio> listarPESinDevolver()
        {
            List<ePrestamoEspacio> _prestamoEspacios = new List<ePrestamoEspacio>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_espacios ON prestamo.id_prestamo = prestamo_espacios.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.fecha_devolucion < now() AND prestamo.estado='EnCurso' ORDER BY prestamo_espacios.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEspacios.Add(recrearPE(resultado));
            }
            return _prestamoEspacios;
        }

        public List<ePrestamoEspacio> listarPrestamoEquipoXMes(int ano, int mes)
        {
            List<ePrestamoEspacio> _prestamoEspacios = new List<ePrestamoEspacio>();
            String consultaSQL = "SELECT * FROM prestamo " +
                                 "INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo " +
                                 "INNER JOIN prestamo_espacios ON prestamo.id_prestamo = prestamo_espacios.id_prestamo " +
                                 "INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario " +
                                 "WHERE((prestamo.fecha_retiro BETWEEN '" + ano + "-" + mes + "-01' AND '" + ano + "-" + mes + "-31') OR(prestamo.fecha_devolucion BETWEEN '" + ano + "-" + mes + "-01' AND '" + ano + "-" + mes +"-31')) AND(prestamo.estado = 'EnCurso') ORDER BY prestamo_espacios.id_prestamo; ";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEspacios.Add(recrearPE(resultado));
            }
            CerrarConexion();
            return _prestamoEspacios;
        }

        public void modificarPrestamoEspacio(ePrestamoEspacio prestamoActual)
        {
            String consultaSQL = "UPDATE prestamo SET fecha_retiro = '" + prestamoActual.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_devolucion = '" + prestamoActual.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_solicitada = '" + prestamoActual.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', estado = '" + prestamoActual.estadoP + "' WHERE id_prestamo = '" + prestamoActual.id + "';";
            ejecutarSQL(consultaSQL);
            String consultaSQL2 = "UPDATE prestamo_con_reserva SET curso = '" + prestamoActual.curso + "', ejercicio = '" + prestamoActual.ejercicio + "' WHERE id_prestamo = '" + prestamoActual.id + "';";
            ejecutarSQL(consultaSQL2);
            String consultaSQL3 = "UPDATE prestamo_espacios SET id_espacio = '" + prestamoActual.espacio.id + "'  WHERE id_prestamo = '" + prestamoActual.id + "';";
            ejecutarSQL(consultaSQL3);
        }

        public List<ePrestamoEspacio> listarPrestamoEspacioPendiente()
        {
            List<ePrestamoEspacio> _prestamoEspacios = new List<ePrestamoEspacio>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_espacios ON prestamo.id_prestamo = prestamo_espacios.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario INNER JOIN espacio ON prestamo_espacios.id_espacio = espacio.id_espacio WHERE prestamo.estado = '"+ estadoP.Pendiente + "'ORDER BY prestamo_con_reserva.prioridad DESC;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEspacios.Add(recrearPE(resultado));
            }
            return _prestamoEspacios;
        }

        public List<ePrestamoEspacio> listarPrestamoEspacio(estadoP estado)
        {
            List<ePrestamoEspacio> _prestamoEspacios = new List<ePrestamoEspacio>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_espacios ON prestamo.id_prestamo = prestamo_espacios.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario INNER JOIN espacio ON prestamo_espacios.id_espacio = espacio.id_espacio WHERE prestamo.estado='" + estado.ToString() + "' ORDER BY prestamo_espacios.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEspacios.Add(recrearPE(resultado));
            }
            return _prestamoEspacios;
        }

        public List<ePrestamoEspacio> listarPrestamoEspacioxId(int iDPrestamo)
        {
            List<ePrestamoEspacio> _prestamoEspacios = new List<ePrestamoEspacio>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_espacios ON prestamo.id_prestamo = prestamo_espacios.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario INNER JOIN espacio ON prestamo_espacios.id_espacio = espacio.id_espacio WHERE prestamo_espacios.id_prestamo = " + iDPrestamo + ";";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEspacios.Add(recrearPE(resultado));
            }
            return _prestamoEspacios;
        }

        public List<ePrestamoEspacio> listarPrestamoEspacioNoPendiente()
        {
            List<ePrestamoEspacio> _prestamoEspacios = new List<ePrestamoEspacio>();
            String consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_con_reserva ON prestamo.id_prestamo = prestamo_con_reserva.id_prestamo INNER JOIN prestamo_espacios ON prestamo.id_prestamo = prestamo_espacios.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario INNER JOIN espacio ON prestamo_espacios.id_espacio = espacio.id_espacio WHERE prestamo.estado !='" + estadoP.Pendiente + "' ORDER BY prestamo_espacios.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamoEspacios.Add(recrearPE(resultado));
            }
            return _prestamoEspacios;
        }

        private ePrestamoEspacio recrearPE(MySqlDataReader resultado)
        {
            pUsuario unPU = new pUsuario();
            pEspacio unPE = new pEspacio();

            ePrestamoEspacio prestamoEspacio = new ePrestamoEspacio();
            prestamoEspacio.id = resultado.GetInt32("id_prestamo");
            MySqlDateTime fechaRetiro = resultado.GetMySqlDateTime("fecha_retiro");
            prestamoEspacio.fecha_retiro = new DateTime(fechaRetiro.Year, fechaRetiro.Month, fechaRetiro.Day, fechaRetiro.Hour, fechaRetiro.Minute, fechaRetiro.Second);
            MySqlDateTime fechaDevolucion = resultado.GetMySqlDateTime("fecha_devolucion");
            prestamoEspacio.fecha_devolucion = new DateTime(fechaDevolucion.Year, fechaDevolucion.Month, fechaDevolucion.Day, fechaDevolucion.Hour, fechaDevolucion.Minute, fechaDevolucion.Second);
            MySqlDateTime fechaSolicitado = resultado.GetMySqlDateTime("fecha_solicitada");
            prestamoEspacio.fecha_solicitado = new DateTime(fechaSolicitado.Year, fechaSolicitado.Month, fechaSolicitado.Day, fechaSolicitado.Hour, fechaSolicitado.Minute, fechaSolicitado.Second);
            prestamoEspacio.responsable.ci = resultado.GetString("ci");
            prestamoEspacio.estadoP = resultado.GetString("estado");
            prestamoEspacio.responsable = unPU.buscarUsuario(prestamoEspacio.responsable);
            prestamoEspacio.estadoP = resultado.GetString("estado");
            prestamoEspacio.curso = resultado.GetString("curso");
            prestamoEspacio.prioridad = resultado.GetInt32("prioridad");
            prestamoEspacio.ejercicio = resultado.GetString("ejercicio");
            prestamoEspacio.espacio.id = resultado.GetInt32("id_espacio");
            prestamoEspacio.espacio = unPE.buscarEspacio(prestamoEspacio.espacio);
               
            return prestamoEspacio;

        }
    }
}