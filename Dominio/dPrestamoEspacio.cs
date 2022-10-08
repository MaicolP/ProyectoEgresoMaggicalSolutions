using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dPrestamoEspacio
    {
        public void altaPrestamoEspacio(ePrestamoEspacio prestamo)
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            unP.altaPrestamoEspacio(prestamo);
        }

        public List<ePrestamoEspacio> listarPrestamoEspacio()
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            return unP.listarPrestamoEspacio();
        }

        public void modificarPrestamoEspacio(ePrestamoEspacio prestamoActual)
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            unP.modificarPrestamoEspacio(prestamoActual);
        }

        public void bajaPrestamoEspacio(ePrestamoEspacio prestamo)
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            unP.bajaPrestamoEspacio(prestamo);
        }

        public List<ePrestamoEspacio> listarPrestamoEspacio(estadoP estado)
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            return unP.listarPrestamoEspacio(estado);
        }
    }
}
