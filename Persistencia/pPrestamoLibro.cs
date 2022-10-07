using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

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

            pLibro unL = new pLibro();

            foreach (eLibro l in prestamo._libros)
            {
                consultaSQL1 = "INSERT INTO pl_l VALUES((SELECT MAX(id_prestamo) FROM prestamo), '" + l.id + "');";
                ejecutarSQL(consultaSQL1);
                l.disponible = false;
                unL.modificarLibro(l);
            }
        }

        public void bajaPrestamoLibro(ePrestamoLibro prestamo)
        {

        }

        public void modificarPrestamoLibro(ePrestamoLibro prestamo)
        {

        }

        public List<ePrestamoLibro> listarPrestamoLibro()
        {
            List<ePrestamoLibro> _prestamoLibro = new List<ePrestamoLibro>();


            return _prestamoLibro;
        }
    }
}
