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
        public void altaReserva(eReserva reserva)
        {
            pReserva unPR = new pReserva();
            unPR.altaReserva(reserva);
        }

        public void bajaReserva(int idPrestamoCR)
        {
            pReserva reserva = new pReserva();
            reserva.bajaReserva(idPrestamoCR);
        }
    }
}
