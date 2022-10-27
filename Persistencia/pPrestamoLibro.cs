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
    public class pPrestamoLibro : clsPersistencia
    {
        public void altaPrestamoLibro(ePrestamoLibro prestamo)
        {
            string consultaSQL1 = "INSERT INTO prestamo(fecha_retiro, fecha_devolucion, fecha_solicitada, id_usuario, estado) VALUES('" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.responsable.id + "', '" + prestamo.estadoP + "');";
            ejecutarSQL(consultaSQL1);
            string consultaSQL2 = "INSERT INTO prestamo_directo(id_prestamo) VALUES((SELECT MAX(id_prestamo) FROM prestamo))";
            ejecutarSQL(consultaSQL2);
            string consultaSQL3 = "INSERT INTO prestamo_libros(id_prestamo) VALUES((SELECT MAX(id_prestamo) FROM prestamo))";
            ejecutarSQL(consultaSQL3);

            //pLibro unL = new pLibro();

            //foreach (eLibro l in prestamo._libros)
            //{
            //    consultaSQL1 = "INSERT INTO pl_l VALUES((SELECT MAX(id_prestamo) FROM prestamo), '" + l.id + "');";
            //    ejecutarSQL(consultaSQL1);
            //    l.disponible = false;
            //    unL.modificarLibro(l);
            //}
        }

        public ePrestamoLibro buscarPrestamoLibro(ePrestamoLibro prestamo)
        {
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_libros ON prestamo.id_prestamo = prestamo_libros.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.id_prestamo = '" + prestamo.id + "';";
            ePrestamoLibro prestamoUr = new ePrestamoLibro();
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                prestamo = recrearP(resultado);
            }
            return prestamo;
        }

        public void bajaPrestamoLibro(ePrestamoLibro prestamo)
        {
            string consultaSQL1 = "DELETE FROM prestamo_libros WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL1);
            string consultaSQL2 = "DELETE FROM prestamo_con_reserva WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL2);
            string consultaSQL3 = "DELETE FROM prestamo WHERE id_prestamo = '" + prestamo.id+ "';";
            ejecutarSQL(consultaSQL3);
        }

        public void modificarPrestamoLibro(ePrestamoLibro prestamo)
        {
            string consultaSQL1 = "UPDATE prestamo SET fecha_retiro = '" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_devolucion = '" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', fecha_solicitada = '" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', duracion = '" + prestamo.duracion + "', id_usuario = '" + prestamo.responsable.id + "', estado = '" + prestamo.estadoP + "' WHERE id_prestamo = '" + prestamo.id + "';";
            ejecutarSQL(consultaSQL1);
        }

        public List<ePrestamoLibro> listarPrestamoLibro()
        {
            List<ePrestamoLibro> _prestamos = new List<ePrestamoLibro>();
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_libros ON prestamo.id_prestamo = prestamo_libros.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario ORDER BY prestamo_libros.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamos.Add(recrearP(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _prestamos;
        }

        public List<ePrestamoLibro> listarPrestamoLibro(estadoP estado)
        {
            List<ePrestamoLibro> _prestamos = new List<ePrestamoLibro>();
            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_libros ON prestamo.id_prestamo = prestamo_libros.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.estado='" + estado.ToString() + "' ORDER BY prestamo_libros.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamos.Add(recrearP(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _prestamos;
        }

        public List<ePrestamoLibro> listarPLSinDevolver()
        {
            List<ePrestamoLibro> _prestamos = new List<ePrestamoLibro>();

            string consultaSQL = "SELECT * FROM prestamo INNER JOIN prestamo_directo ON prestamo.id_prestamo = prestamo_directo.id_prestamo INNER JOIN prestamo_libros ON prestamo.id_prestamo = prestamo_libros.id_prestamo INNER JOIN usuario ON prestamo.id_usuario = usuario.id_usuario WHERE prestamo.fecha_devolucion < now() AND prestamo.estado='EnCurso' ORDER BY prestamo_libros.id_prestamo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _prestamos.Add(recrearP(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _prestamos;
        }

        private ePrestamoLibro recrearP(MySqlDataReader resultado)
        {
            pUsuario unPU = new pUsuario();
            ePrestamoLibro prestamo = new ePrestamoLibro();

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

            string consultaSQL = "SELECT * FROM pl_l INNER JOIN libro ON pl_l.id_libro = libro.id_libro WHERE pl_l.id_prestamo = '" + prestamo.id + "'";
            MySqlDataReader fila = ejecutarYdevolver(consultaSQL);
            pLibro unPE = new pLibro();
            eLibro auxLibro = new eLibro();
            while (fila.Read())
            {
                auxLibro.id = fila.GetInt32("id_libro");
                prestamo._libros.Add(unPE.buscarLibro(auxLibro));
            }
            resultado.Close();
            CerrarConexion();
            return prestamo;
        }
    }
}
