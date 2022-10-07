using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dLibro
    {
        public void altaLibro(eLibro libro)
        {
            pLibro unL = new pLibro();
            unL.altaLibro(libro);
        }

        public List<eLibro> listarLibro()
        {
            pLibro unL = new pLibro();
            return unL.listarLibro();
        }

        public List<eLibro> listarLibroDisp(bool disp)
        {
            pLibro unL = new pLibro();
            return unL.listarLibroDisp(disp);
        }

        public eLibro buscarLibro(eLibro libro)
        {
            pLibro unL = new pLibro();
            return unL.buscarLibro(libro);
        }

        public void bajaLibro(eLibro libro)
        {
            pLibro unL = new pLibro();
            unL.bajaLibro(libro);
        }

        public void modificarLibro(eLibro libro)
        {
            pLibro unL = new pLibro();
            unL.modificarLibro(libro);
        }
    }
}
