using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eReserva
    {
        public int id { get; set; }
        public int numMesa { get; set; }
        ePrestamoCR prestamoCR { get; set; }
    }
}
