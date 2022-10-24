using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dPrestamoEquipo
    {
        public void altaPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            pPrestamoEquipo unPE = new pPrestamoEquipo();
            unPE.altaPrestamoEquipo(prestamo);
        }

        public void bajaPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            pPrestamoEquipo unPE = new pPrestamoEquipo();
            unPE.bajaPrestamoEquipo(prestamo);
        }

        public void modificarPrestamoEquipo(ePrestamoEquipo prestamo)
        {
            pPrestamoEquipo unPE = new pPrestamoEquipo();
            unPE.modificarPrestamoEquipo(prestamo);
        }

        public List<ePrestamoEquipo> listarPrestamoEquipo()
        {
            pPrestamoEquipo unPE = new pPrestamoEquipo();
            return unPE.listarPrestamoEquipo();
        }

        public List<ePrestamoEquipo> listarPrestamoEquipo(estadoP estado)
        {
            pPrestamoEquipo unPE = new pPrestamoEquipo();
            return unPE.listarPrestamoEquipo(estado);
        }

        public List<ePrestamoEquipo> listarPESinDevolver()
        {
            pPrestamoEquipo unPE = new pPrestamoEquipo();
            return unPE.listarPESinDevolver();
        }
    }
}
