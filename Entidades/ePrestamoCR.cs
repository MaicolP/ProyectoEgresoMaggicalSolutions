using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePrestamoCR : ePrestamo
    {
        public int prioridad { get; set; }
        public string ejercicio { get; set; }
        public string curso { get; set; }
    }
}
