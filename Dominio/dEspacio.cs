using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dEspacio
    {
        public void altaEspacio(eEspacio espacio)
        {
            pEspacio unE = new pEspacio();
            unE.altaEspacio(espacio);
        }

        public List<eEspacio> listarEspacios()
        {
            pEspacio unE = new pEspacio();
            return unE.listarEspacios();
        }

        public eEspacio buscarEspacio(eEspacio espacio)
        {
            pEspacio unE = new pEspacio();
            return unE.buscarEspacio(espacio);
        }

        public void bajaEspacio(eEspacio espacio)
        {
            pEspacio unE = new pEspacio();
            unE.bajaEspacio(espacio);
        }

        public void modificarEspacio(eEspacio espacio)
        {
            pEspacio unE = new pEspacio();
            unE.modificarEspacio(espacio);
        }

        public List<eEspacio> listarEspaciosDisponibles()
        {
            pEspacio unE = new pEspacio();
            return unE.listarEspaciosDisponibles();
        }
    }
}
