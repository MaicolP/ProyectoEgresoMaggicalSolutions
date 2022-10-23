using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dReserva
    {
        public void altaReserva(ePrestamoCR prestamoActual)
        {
            pReserva reserva = new pReserva();
            reserva.altaReserva(prestamoActual);
        }

        public void bajaReserva(int idPrestamoCR)
        {
            pReserva reserva = new pReserva();
            reserva.bajaReserva(idPrestamoCR);
        }
    }
}
