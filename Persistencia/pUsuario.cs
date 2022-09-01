using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pUsuario : clsPersistencia
    {
        public eUsuario login(string nombre, string clave)
        {
            eUsuario usuario = null;
            string consultaSQL = "SELECT * FROM usuario WHERE ci='" + nombre + "' AND clave='" + clave + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            if (resultado.Read())
            {
                usuario = recrearU(resultado);
            }
            return usuario;
        }

        public void altaUsuario(eUsuario usuario)
        {
            string consultaSQL = "INSERT INTO usuario (nombre, apellido, ci, clave) VALUES ('" + usuario.nombre + "', '" + usuario.apellido +
                                 "', '" + usuario.ci + "', '" + usuario.clave + "');";
            ejecutarSQL(consultaSQL);
        }

        public void bajaUsuario(eUsuario usuario)
        {
            string consultaSQL = "DELETE FROM usuario WHERE ci='" + usuario.ci + "';";
            ejecutarSQL(consultaSQL);
        }

        public void modificarUsuario(eUsuario usuario)
        {
            string consultaSQL = "UPDATE usuario SET nombre='" + usuario.nombre + "', apellido='" + usuario.apellido + "', clave='" + usuario.clave + "' WHERE ci='" + usuario.ci +"';";
            ejecutarSQL(consultaSQL);
        }

        public List<eUsuario> listarUsuario()
        {
            List<eUsuario> _usuarios = new List<eUsuario>();
            string consultaSQL = "SELECT * FROM usuario ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _usuarios.Add(recrearU(resultado));
            }
            return _usuarios;
        }

        private eUsuario recrearU(MySqlDataReader resultado)
        {
            eUsuario usuario = new eUsuario();
            usuario.id = resultado.GetInt32("id_usuario");
            usuario.ci = resultado.GetString("ci");
            usuario.nombre = resultado.GetString("nombre");
            usuario.apellido = resultado.GetString("apellido");
            usuario.clave = resultado.GetString("clave");

            return usuario;
        }

        public eUsuario buscarUsuario(eUsuario usuario)
        {
            string consultaSQL = "SELECT * FROM usuario WHERE ci='" + usuario.ci + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            usuario = null;
            while (resultado.Read())
            {
                usuario = recrearU(resultado);
            }
            return usuario;
        }
    }
}
