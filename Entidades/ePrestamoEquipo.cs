using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ePrestamoEquipo : ePrestamoCR
    {
        string nomDocente { get; set; }
        string apeDocente { get; set; }
        string locaciones { get; set; }
        string transporte { get; set; }
        string equipoRodaje { get; set; }
        List<eEquipo> _equipos = new List<eEquipo>();
    }
}
