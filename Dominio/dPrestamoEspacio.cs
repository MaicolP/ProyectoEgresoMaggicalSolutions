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

        public List<ePrestamoEspacio> listarPrestamoEspacioPendiente()
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            return unP.listarPrestamoEspacioPendiente();
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

        public List<ePrestamoEspacio> listarPrestamoEspacioNoPendiente()
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            return unP.listarPrestamoEspacioNoPendiente();
        }

        public List<ePrestamoEspacio> listarPrestamoEspacioxId(int idPrestamo)
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            return unP.listarPrestamoEspacioxId(idPrestamo);
        }

        public List<ePrestamoEspacio> listarPESinDevolver()
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            return unP.listarPESinDevolver();
        }

        public List<ePrestamoEspacio> listarPrestamoEquipoXMes(int ano, int mes)
        {
            pPrestamoEspacio unP = new pPrestamoEspacio();
            return unP.listarPrestamoEquipoXMes(ano, mes);
        }
    }
}
