using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dLibroVirtual
    {
        public void altaLibroVirtual(eLibroVirtual libroVirtual)
        {
            pLibroVirtual unLV = new pLibroVirtual();
            unLV.altaLibroVirtual(libroVirtual);
        }
        public List<eLibroVirtual> listarLibroVirtual()
        {
            pLibroVirtual unLV = new pLibroVirtual();
            return unLV.listarLibroVirtual();
        }
        public eLibroVirtual buscarLibroVirtual(eLibroVirtual libroVirtual)
        {
            pLibroVirtual unLV = new pLibroVirtual();
            return unLV.buscarLibroVirtual(libroVirtual);
        }
        public void bajaLibroVirtual(eLibroVirtual libroVirtual)
        {
            pLibroVirtual unLV = new pLibroVirtual();
            unLV.bajaLibroVirtual(libroVirtual);
        }
        public void modificarLibroVirtual(eLibroVirtual libroVirtual)
        {
            pLibroVirtual unLV = new pLibroVirtual();
            unLV.modificarLibroVirtual(libroVirtual);
        }
    }
}
