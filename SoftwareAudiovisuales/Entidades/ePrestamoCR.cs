using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class ePrestamoCR : ePrestamo
    {
        int prioridad { get; set; }
        string ejercicio { get; set; }
        string curso { get; set; }
    }
}
