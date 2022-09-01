using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dAsisTec
    {
        public void altaAsisTec(eAsisTec asisTec)
        {
            pAsisTec unP = new pAsisTec();
            unP.altaAsisTec(asisTec);
        }

        public void bajaAsisTec(eAsisTec asisTec)
        {
            pAsisTec unP = new pAsisTec();
            unP.bajaAsisTec(asisTec);
        }

        public List<eAsisTec> listarAsisTec()
        {
            pAsisTec unP = new pAsisTec();
            return unP.listarAsisTec();
        }
    }
}
