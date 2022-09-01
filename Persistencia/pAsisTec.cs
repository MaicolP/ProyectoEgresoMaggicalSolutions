using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pAsisTec : clsPersistencia
    {
        public void altaAsisTec(eAsisTec asisTec)
        {
            string consultaSQL = "INSERT INTO asistente_tecnico (id_asistente) SELECT id_usuario FROM usuario WHERE ci = '" + asisTec.ci + "';";
            ejecutarSQL(consultaSQL);
        }

        public void bajaAsisTec(eAsisTec asisTec)
        {
            string consultaSQL = "DELETE asistente_tecnico, usuario FROM asistente_tecnico INNER JOIN usuario ON usuario.id_usuario=asistente_tecnico.id_asistente WHERE usuario.ci='" + asisTec.ci + "';";
            ejecutarSQL(consultaSQL);
        }

        public List<eAsisTec> listarAsisTec()
        {
            List<eAsisTec> _asisTec = new List<eAsisTec>();
            string consultaSQL = "SELECT * FROM usuario INNER JOIN asistente_tecnico ON usuario.id_usuario=asistente_tecnico.id_asistente;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _asisTec.Add(recrearAT(resultado));
            }

            return _asisTec;
        }

        private eAsisTec recrearAT(MySqlDataReader resultado)
        {
            eAsisTec asisTec = new eAsisTec();
            asisTec.id = resultado.GetInt32("id_usuario");
            asisTec.ci = resultado.GetString("ci");
            asisTec.nombre = resultado.GetString("nombre");
            asisTec.apellido = resultado.GetString("apellido");
            asisTec.clave = resultado.GetString("clave");

            return asisTec;
        }
    }
}
