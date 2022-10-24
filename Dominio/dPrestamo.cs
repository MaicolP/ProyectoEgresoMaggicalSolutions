using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dPrestamo
    {
       public void finalizarPrestamo(ePrestamo prestamo)
        {
            pPrestamo pP = new pPrestamo();
            pP.finalizarPrestamo(prestamo);
        }
    }
}
