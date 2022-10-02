using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Persistencia
{
    public class pPrestamoEspacio : clsPersistencia
    {
        public void altaPrestamoEspacio(ePrestamoEspacio prestamo)
        {
            String consultaSQL = "INSERT INTO prestamo (fecha_retiro, fecha_devolucion, fecha_solicitada, id_usuario, estado) VALUES('" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "','" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "','" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "','" + prestamo.responsable.id + "','" + prestamo.estadoP + "');";
            ejecutarSQL(consultaSQL);
            String consultaSQL2 = "INSERT INTO prestamo_con_reserva (id_prestamo, curso, ejercicio) VALUES ((SELECT MAX(id_prestamo) FROM prestamo), '" + prestamo.curso + "', '" + prestamo.ejercicio + "');";
            ejecutarSQL(consultaSQL2);
            String consultaSQL3 = "INSERT INTO prestamo_espacios (id_prestamo, id_espacio) VALUES ((SELECT MAX(id_prestamo) FROM prestamo_con_reserva), '" + prestamo.espacio.id + "');";
            ejecutarSQL(consultaSQL3);

        }
    }
}