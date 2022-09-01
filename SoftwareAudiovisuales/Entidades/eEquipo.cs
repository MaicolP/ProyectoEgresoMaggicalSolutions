using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class eEquipo
    {
        int id { get; set; }
        string nom { get; set; }
        string numSerie { get; set; }
        bool asegurado { get; set; }
        estado estado { get; set; }
        string observaciones { get; set; }
        DateTime fechaIngreso { get; set; }

        //Tipo y subtipo????????????

    }

    enum estado {Disponible,Reservado,Mantenimiento,Roto}
}
