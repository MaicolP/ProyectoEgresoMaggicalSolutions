using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public class pReserva : clsPersistencia
    {
        public void altaReserva(ePrestamoCR prestamoActual)
        {
            String consultaSQL = "INSERT INTO reserva (id_prestamo, nro_mesa) VALUES('" + prestamoActual.id + "' , '0' );";
            ejecutarSQL(consultaSQL);
        }

        public void bajaReserva(int idPrestamoCR)
        {
            String consultaSQL = "DELETE FROM reserva WHERE reserva.id_prestamo='" + idPrestamoCR + "';";
            ejecutarSQL(consultaSQL);
        }
    }
}
