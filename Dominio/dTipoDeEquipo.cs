using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dTipoDeEquipo
    {
        public void altaTipoDeEquipo(eTipoDeEquipo tipo)
        {
            pTipoDeEquipo unT = new pTipoDeEquipo();
            unT.altaTipoDeEquipo(tipo);
        }

        public void bajaTipoDeEquipo(eTipoDeEquipo tipo)
        {
            pTipoDeEquipo unT = new pTipoDeEquipo();
            unT.bajaTipoDeEquipo(tipo);
        }

        public void modificarTipoDeEquipo(eTipoDeEquipo tipo)
        {
            pTipoDeEquipo unT = new pTipoDeEquipo();
            unT.modificarTipoDeEquipo(tipo);
        }

        public List<eTipoDeEquipo> listarTipoDeEquipo()
        {
            pTipoDeEquipo unT = new pTipoDeEquipo();
            return unT.listarTipoDeEquipo();
        }
    }
}
