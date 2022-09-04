using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dEquipo
    {
        public void altaEquipo(eEquipo equipo)
        {
            pEquipo unE = new pEquipo();
            unE.altaEquipo(equipo);
        }

        public void bajaEquipo(eEquipo equipo)
        {
            pEquipo unE = new pEquipo();
            unE.bajaEquipo(equipo);
        }

        public void modificarEquipo(eEquipo equipo)
        {
            pEquipo unE = new pEquipo();
            unE.modificarEquipo(equipo);
        }

        public List<eEquipo> listarEquipo()
        {
            pEquipo unE = new pEquipo();
            return unE.listarEquipo();
        }

        public eEquipo buscarEquipo(eEquipo equipo)
        {
            pEquipo unE = new pEquipo();
            return unE.buscarEquipo(equipo);
        }

        public List<eEquipo> listarEequipo(string tipo)
        {
            pEquipo unE = new pEquipo();
            return unE.listarEquipo(tipo);
        }

        public List<eEquipo> listarEequipo(string tipo, string subtipo)
        {
            pEquipo unE = new pEquipo();
            return unE.listarEquipo(tipo, subtipo);
        }
    }
}
