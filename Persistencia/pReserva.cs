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
        public void altaReserva(eReserva reserva)
        {
            String consultaSQL = "INSERT INTO reserva (id_prestamo, nro_mesa) VALUES('" + reserva.prestamoCR.id + "' , '" + reserva.numMesa + "' );";
            ejecutarSQL(consultaSQL);
        }

        public void bajaReserva(int idPrestamoCR)
        {
            String consultaSQL = "DELETE FROM reserva WHERE reserva.id_prestamo='" + idPrestamoCR + "';";
            ejecutarSQL(consultaSQL);
        }
    }
}
