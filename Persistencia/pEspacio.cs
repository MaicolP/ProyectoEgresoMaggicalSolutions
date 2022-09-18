using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace Persistencia
{
    public class pEspacio : clsPersistencia
    {
        public void altaEspacio(eEspacio espacio)
        {

            String consultaSQL= "INSERT INTO espacio (nombre, estado) VALUES('" + espacio.nom + "','" + espacio.disponible + "');";

            ejecutarSQL(consultaSQL);

        }

        public List<eEspacio> listarEspacios()

        {
            List<eEspacio> _espacios = new List<eEspacio>();
            String consultaSQL = "SELECT * FROM espacio ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _espacios.Add(recrearE(resultado));
            }
            return _espacios;
        }

        public void bajaEspacio(eEspacio espacio)
        {
            String consultaSQL = "DELETE FROM espacio WHERE id_espacio = '" + espacio.id + "';";
            ejecutarSQL(consultaSQL);
        }

        public void modificarEspacio(eEspacio espacio)
        {
            String consultaSQL = "UPDATE espacio SET nombre='" + espacio.nom + "', estado='" + espacio.disponible + "' WHERE id_espacio = '" + espacio.id + "';";
            ejecutarSQL(consultaSQL);
        }

        public eEspacio buscarEspacio(eEspacio espacio)
        {
            String consultaSQL = "SELECT * FROM espacio WHERE id_espacio = '" + espacio.id + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            espacio = null;
            while (resultado.Read())
            {
                espacio = recrearE(resultado);
            }
            return espacio;
        }

        public eEspacio recrearE(MySqlDataReader resultado)
        {
            eEspacio espacio = new eEspacio();
            espacio.id = resultado.GetInt32("id_espacio");
            espacio.nom = resultado.GetString("nombre");
            espacio.disponible = resultado.GetBoolean("estado");

            return espacio;
        }
    }
}
