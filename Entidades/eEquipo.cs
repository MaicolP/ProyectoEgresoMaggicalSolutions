using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eEquipo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string nroSerie { get; set; }
        public string precio { get; set; }
        public bool asegurado { get; set; }
        public string estado { get; set; }
        public string observaciones { get; set; }
        public DateTime fechaIngreso { get; set; }
        public eTipoDeEquipo tipo { get; set; }
    }
    public enum estadoEq {Disponible,Reservado,Mantenimiento,Roto}
}
