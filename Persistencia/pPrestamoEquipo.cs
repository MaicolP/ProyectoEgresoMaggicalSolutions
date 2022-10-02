using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public class pPrestamoEquipo : clsPersistencia
    {

        public void altaPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            string consultaSQL1 = "INSERT INTO prestamo(fecha_retiro, fecha_devolucion, fecha_solicitada, id_usuario, estado) VALUES('" + prestamo.fecha_retiro.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_devolucion.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.fecha_solicitado.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + prestamo.responsable.id + "', '" + prestamo.estadoP +"');";
            ejecutarSQL(consultaSQL1);
            string consultaSQL2 = "INSERT INTO prestamo_con_reserva(id_prestamo, curso, ejercicio) VALUES((SELECT MAX(id_prestamo) FROM prestamo),'" + prestamo.curso + "','" + prestamo.ejercicio + "')";
            ejecutarSQL(consultaSQL2);
            string consultaSQL3 = "INSERT INTO prestamo_equipos VALUES((SELECT MAX(id_prestamo) FROM prestamo_con_reserva),'" + prestamo.nomDocente + "','" + prestamo.apeDocente +"','" + prestamo.locaciones +"','" + prestamo.transporte +"','" + prestamo.equipoRodaje +"');";
            ejecutarSQL(consultaSQL3);

            pEquipo unE = new pEquipo();

            foreach(eEquipo eq in prestamo._equipos)
            {
                consultaSQL1 = "INSERT INTO peq_eq VALUES((SELECT MAX(id_prestamo) FROM prestamo), '" + eq.id +"');";
                ejecutarSQL(consultaSQL1);
                eq.estado = estado.Reservado.ToString();
                unE.modificarEquipo(eq);
            }
        }

        public void bajaPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            
        }

        public void modificarPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            
        }

        public List<ePrestamoEquipo> listarPrestamoEquipo()
        {
            List<ePrestamoEquipo> _prestamoEquipo = new List<ePrestamoEquipo>();


            return _prestamoEquipo;
        }

    }
}
