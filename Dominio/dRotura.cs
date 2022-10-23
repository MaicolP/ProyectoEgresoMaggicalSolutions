using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dRotura
    {
        public void altaRotura(eRotura rotura)
        {
            pRotura unPR = new pRotura();
            unPR.altaRotura(rotura);
        }

        public void bajaRotura(eRotura rotura)
        {
            pRotura unPR = new pRotura();
            unPR.bajaRotura(rotura);
        }

        public void modificarRotura(eRotura rotura)
        {
            pRotura unPR = new pRotura();
            unPR.modificarRotura(rotura);
        }

        public List<eRotura> listarRotura()
        {
            pRotura unPR = new pRotura();
            return unPR.listarRotura();
        }

        public List<eRotura> listarRoturaPorEq()
        {
            pRotura unPR = new pRotura();
            return unPR.listarRoturaPorEq();
        }

        public eRotura buscarRotura(int id)
        {
            pRotura unPR = new pRotura();
            return unPR.buscarRotura(id);
        }
    }
}
