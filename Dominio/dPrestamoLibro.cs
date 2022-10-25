using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dPrestamoLibro
    {
        public void altaPrestamoLibro(ePrestamoLibro prestamo)
        {
            pPrestamoLibro unPE = new pPrestamoLibro();
            unPE.altaPrestamoLibro(prestamo);
        }

        public void bajaPrestamoLibro(ePrestamoLibro prestamo)
        {
            pPrestamoLibro unPE = new pPrestamoLibro();
            unPE.bajaPrestamoLibro(prestamo);
        }

        public void modificarPrestamoLibro(ePrestamoLibro prestamo)
        {
            pPrestamoLibro unPE = new pPrestamoLibro();
            unPE.modificarPrestamoLibro(prestamo);
        }

        public List<ePrestamoLibro> listarPrestamoLibro()
        {
            pPrestamoLibro unPE = new pPrestamoLibro();
            return unPE.listarPrestamoLibro();
        }

        public List<ePrestamoLibro> listarPLSinDevolver()
        {
            pPrestamoLibro unPE = new pPrestamoLibro();
            return unPE.listarPLSinDevolver();
        }

        public List<ePrestamoLibro> listarPrestamoLibro(estadoP estado)
        {
            pPrestamoLibro unPE = new pPrestamoLibro();
            return unPE.listarPrestamoLibro(estado);
        }
    }
}
