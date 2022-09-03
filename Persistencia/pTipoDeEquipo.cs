using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pTipoDeEquipo : clsPersistencia
    {
        public void altaTipoDeEquipo(eTipoDeEquipo tipo)
        {
            
        }

        public void bajaTipoDeEquipo(eTipoDeEquipo tipo)
        {
            
        }

        public void modificarTipoDeEquipo(eTipoDeEquipo tipo)
        {
            
        }

        public List<eTipoDeEquipo> listarTipoDeEquipo()
        {
            List<eTipoDeEquipo> _tipos = new List<eTipoDeEquipo>();
            string consultaSQL = "SELECT * FROM tipo ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            
            while (resultado.Read())
            {
                _tipos.Add(recrearT(resultado));
            }

            return _tipos;
        }

        private eTipoDeEquipo recrearT(MySqlDataReader resultado)
        {
            eTipoDeEquipo tipo = new eTipoDeEquipo();
            tipo.id = resultado.GetInt32("id_tipo");
            tipo.nombre = resultado.GetString("nombre");
            tipo.subtipo = resultado.GetString("subtipo");

            return tipo;
        }
    }
}
