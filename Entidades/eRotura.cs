using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eRotura
    {

        public int idRotura { get; set; }
        public int idPrestamoOrigenRotura { get; set; }
        public string detalleDesperfecto { get; set; }
        public string detalleSolucion { get; set; }
        public eEquipo equipo = new eEquipo();

        public eRotura()
        {

        }

    }
}
