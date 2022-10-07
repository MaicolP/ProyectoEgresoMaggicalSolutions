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
    public class pLibro : clsPersistencia
        {
            public void altaLibro(eLibro libro)
            {

                String consultaSQL = "INSERT INTO libro (titulo, autor, disponible) VALUES('" + libro.titulo + "','" + libro.autor + "'," + libro.disponible + ");";

                ejecutarSQL(consultaSQL);

            }

            public List<eLibro> listarLibro()

            {
                List<eLibro> _libros = new List<eLibro>();
                String consultaSQL = "SELECT * FROM libro ;";
                MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
                while (resultado.Read())
                {
                    _libros.Add(recrearL(resultado));
                }
                return _libros;
            }

            public List<eLibro> listarLibroDisp(bool disp)

            {
                List<eLibro> _libros = new List<eLibro>();
                String consultaSQL = "SELECT * FROM libro WHERE libro.disponible = " + disp + ";";
                MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
                while (resultado.Read())
                {
                    _libros.Add(recrearL(resultado));
                }
                return _libros;
            }

            public void bajaLibro(eLibro libro)
            {
                String consultaSQL = "DELETE FROM libro WHERE id_libro = '" + libro.id + "';";
                ejecutarSQL(consultaSQL);
            }

            public void modificarLibro(eLibro libro)
            {
                String consultaSQL = "UPDATE libro SET titulo='" + libro.titulo + "', autor='" + libro.autor + "', disponible=" + libro.disponible + " WHERE id_libro = '" + libro.id + "';";
                ejecutarSQL(consultaSQL);
            }

            public eLibro buscarLibro(eLibro libro)
            {
                String consultaSQL = "SELECT * FROM libro WHERE id_libro = '" + libro.id + "';";
                MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
                libro = null;
                while (resultado.Read())
                {
                    libro = recrearL(resultado);
                }
                return libro;
            }

            public eLibro recrearL(MySqlDataReader resultado)
            {
                eLibro libro = new eLibro();
                libro.id = resultado.GetInt32("id_libro");
                libro.titulo = resultado.GetString("titulo");
                libro.autor = resultado.GetString("autor");
                libro.disponible = resultado.GetBoolean("disponible");

                return libro;
            }
        }
}
