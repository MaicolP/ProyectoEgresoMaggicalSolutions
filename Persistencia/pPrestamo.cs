using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public class pPrestamo : clsPersistencia
    {
        public void finalizarPrestamo(ePrestamo prestamo)
        {
            string consultaSQL = "UPDATE prestamo SET estado='" + prestamo.estadoP + "' WHERE id_prestamo='" + prestamo.id + "'";
            ejecutarSQL(consultaSQL);
        }
    }
}
