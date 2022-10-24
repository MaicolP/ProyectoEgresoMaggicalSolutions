using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Entidades;

namespace Dominio
{
    public class dPrestamoUrgente
    {
        public List<ePrestamoUrgente> listarPUSinDevolver()
        {
            pPrestamoUrgente unPU = new pPrestamoUrgente();
            return unPU.listarPUSinDevolver();
        }

        public List<ePrestamoUrgente> listarPrestamoUrgente()
        {
            pPrestamoUrgente unPU = new pPrestamoUrgente();
            return unPU.listarPrestamoUrgente();
        }

        public List<ePrestamoUrgente> listarPrestamoUrgente(estadoP estado)
        {
            pPrestamoUrgente unPU = new pPrestamoUrgente();
            return unPU.listarPrestamoUrgente(estado);
        }

        public void altaPrestamoUrgente(ePrestamoUrgente prestamo)
        {
            pPrestamoUrgente unPU = new pPrestamoUrgente();
            unPU.altaPrestamoUrgente(prestamo);
        }

        public void bajaPrestamoUrgente(ePrestamoUrgente prestamo)
        {
            pPrestamoUrgente unPU = new pPrestamoUrgente();
            unPU.bajaPrestamoUrgente(prestamo);
        }

        public void modificarPrestamoUrgente(ePrestamoUrgente prestamo)
        {
            pPrestamoUrgente unPU = new pPrestamoUrgente();
            unPU.modificarPrestamoUrgente(prestamo);
        }
    }
}
