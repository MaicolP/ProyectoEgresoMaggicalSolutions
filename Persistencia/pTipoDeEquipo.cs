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
            string consultaSQL = "INSERT INTO `tipo`(`id_tipo`, `nombre`, `subtipo`) VALUES " + 
                "('0','" + tipo.nombre + "','" + tipo.subtipo + "')";
            ejecutarSQL(consultaSQL);
        }

        public void bajaTipoDeEquipo(eTipoDeEquipo tipo)
        {
            string consultaSQL = "DELETE FROM tipo WHERE id_tipo='"+ tipo.id +"';";
            ejecutarSQL(consultaSQL);
        }

        public void modificarTipoDeEquipo(eTipoDeEquipo tipo)
        {
            string consultaSQL = "UPDATE `tipo` SET `nombre`='" + tipo.nombre + "',`subtipo`='" + tipo.subtipo + "' WHERE id_tipo='" + tipo.id + "';";
            ejecutarSQL(consultaSQL);
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

        public eTipoDeEquipo buscarTipoDeEquipo(int id)
        {
            eTipoDeEquipo tipo = new eTipoDeEquipo();
            string consultaSQL = "SELECT * FROM tipo WHERE id_tipo='" + id + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);

            while (resultado.Read())
            {
                tipo = recrearT(resultado);
            }

            return tipo;
        }
    }
}
