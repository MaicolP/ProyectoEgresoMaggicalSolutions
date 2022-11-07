using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pLibroVirtual : clsPersistencia
    {
        public void altaLibroVirtual(eLibroVirtual libroVirtual)
        {
            String consultaSQL = "INSERT INTO libro_v (nombre, url) VALUES('" + libroVirtual.nombre + "','" + libroVirtual.url + "');";
            ejecutarSQL(consultaSQL);
        }

        public List<eLibroVirtual> listarLibroVirtual()
        {
            List<eLibroVirtual> _librosVirtual = new List<eLibroVirtual>();
            String consultaSQL = "SELECT * FROM libro_v ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _librosVirtual.Add(recrearLV(resultado));
            }
            CerrarConexion();
            return _librosVirtual;
        }

        public void bajaLibroVirtual(eLibroVirtual libroVirtual)
        {
            String consultaSQL = "DELETE FROM libro_v WHERE id_libro_v = '" + libroVirtual.id + "';";
            ejecutarSQL(consultaSQL);
        }

        public void modificarLibroVirtual(eLibroVirtual libroVirtual)
        {
            String consultaSQL = "UPDATE libro_v SET nombre='" + libroVirtual.nombre + "', url='" + libroVirtual.url + "' WHERE id_libro_v = '" + libroVirtual.id + "';";
            ejecutarSQL(consultaSQL);
        }

        public eLibroVirtual buscarLibroVirtual(eLibroVirtual libroVirtual)
        {
            String consultaSQL = "SELECT * FROM libro_v WHERE id_libro_v = '" + libroVirtual.id + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            libroVirtual = null;
            while (resultado.Read())
            {
                libroVirtual = recrearLV(resultado);
            }
            CerrarConexion();
            return libroVirtual;
        }

        public eLibroVirtual recrearLV(MySqlDataReader resultado)
        {
            eLibroVirtual libroVirtual = new eLibroVirtual();
            libroVirtual.id = resultado.GetInt32("id_libro_v");
            libroVirtual.nombre = resultado.GetString("nombre");
            libroVirtual.url = resultado.GetString("url");
            return libroVirtual;
        }
    }
}
