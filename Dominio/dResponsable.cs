using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dResponsable
    {
        public void altaResponsable(eResponsable responsable)
        {
            pResponsable unR = new pResponsable();
            unR.altaResponsable(responsable);
        }

        public void bajaResponsable(eResponsable responsable)
        {
            pResponsable unR = new pResponsable();
            unR.bajaResponsable(responsable);
        }

        public List<eResponsable> listarResponsable()
        {
            pResponsable unR = new pResponsable();
            return unR.listarResponsable();
        }

        public List<eResponsable> listarResponsableSegunTipo(bool docente)
        {
            pResponsable unR = new pResponsable();
            return unR.listarResponsableSegunTipo(docente);
        }
    }
}
