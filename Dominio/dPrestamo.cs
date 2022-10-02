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
        public void altaPrestamoEspacio(ePrestamoEspacio prestamo)
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            unP.altaPrestamoEspacio(prestamo);
        }
    }
}
