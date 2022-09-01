using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pResponsable : clsPersistencia
    {
        public void altaResponsable(eResponsable responsable)
        {
            string consultaSQL = "INSERT INTO responsable (id_responsable) SELECT id_usuario FROM usuario WHERE ci = '" + responsable.ci + "';" +
                                 "UPDATE responsable SET docente=" + responsable.docente.ToString() + " WHERE id_responsable =" +
                                 "(SELECT id_usuario FROM usuario WHERE ci='" + responsable.ci + "');";
            ejecutarSQL(consultaSQL);
        }

        public void bajaResponsable(eResponsable responsable)
        {
            string consultaSQL = "DELETE responsable, usuario FROM responsable INNER JOIN usuario ON usuario.id_usuario=responsable.id_responsable WHERE usuario.ci='" + responsable.ci + "';";
            ejecutarSQL(consultaSQL);
        }

        public List<eResponsable> listarResponsable()
        {
            List<eResponsable> _responsables = new List<eResponsable>();
            string consultaSQL = "SELECT id_usuario, ci, nombre, apellido, clave FROM usuario INNER JOIN responsable ON usuario.id_usuario=responsable.id_responsable;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _responsables.Add(recrearR(resultado));
            }
            return _responsables;
        }

        public List<eResponsable> listarResponsableSegunTipo(bool docente) //True son docentes y false alumnos
        {
            List<eResponsable> _responsables = new List<eResponsable>();
            string consultaSQL = "SELECT id_usuario, ci, nombre, apellido, clave FROM usuario INNER JOIN responsable ON usuario.id_usuario=responsable.id_responsable WHERE docente=" + docente + ";";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _responsables.Add(recrearR(resultado));
            }
            return _responsables;
        }

        private eResponsable recrearR(MySqlDataReader resultado)
        {
            eResponsable responsable = new eResponsable();
            responsable.id = resultado.GetInt32("id_usuario");
            responsable.ci = resultado.GetString("ci");
            responsable.nombre = resultado.GetString("nombre");
            responsable.apellido = resultado.GetString("apellido");
            responsable.clave = resultado.GetString("clave");

            return responsable;
        }

        public eResponsable buscarResponsable(eResponsable responsable)
        {
            string consultaSQL = "SELECT * FROM responsable INNER JOIN usuario ON usuario.id_usuario=responsable.id_responsable WHERE usuario.ci='" + responsable.ci + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            responsable = null;
            while (resultado.Read())
            {
                responsable = recrearR(resultado);
            }
            return responsable;
        }
    }
}
