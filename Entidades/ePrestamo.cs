using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePrestamo
    {
        public int id { get; set; }
        public DateTime fecha_retiro { get; set; }
        public DateTime fecha_devolucion { get; set; }
        public DateTime fecha_solicitado { get; set; }
        public int duracion { get; set; }
        public eUsuario responsable { get; set; }
        public eAsisTec asisTec { get; set; }
        public String estadoP { get; set; }
    }

    public enum estadoP {Pendiente, EnCurso, Finalizado}
}
