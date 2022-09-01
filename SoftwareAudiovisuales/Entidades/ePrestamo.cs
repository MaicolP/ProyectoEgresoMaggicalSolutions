using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class ePrestamo
    {
        int id { get; set; }
        DateTime retiro { get; set; }
        DateTime devolucion { get; set; }     
    }
}
