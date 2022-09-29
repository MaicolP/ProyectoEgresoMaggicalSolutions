using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePrestamoEquipo : ePrestamoCR
    {
        public string nomDocente { get; set; }
        public string apeDocente { get; set; }
        public string locaciones { get; set; }
        public string transporte { get; set; }
        public string equipoRodaje { get; set; }
        public List<eEquipo> _equipos = new List<eEquipo>();
    }
}
