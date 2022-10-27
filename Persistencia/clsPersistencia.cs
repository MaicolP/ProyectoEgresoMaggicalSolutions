using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Persistencia
{
   public class clsPersistencia
    {
        public MySqlConnection con; 
        public string miConexion;

        public void AbrirConexion()
        {
            try
            {
                miConexion = "server=localhost; uid=root ; password= ; database=bd_audiovisual;";

                con = new MySqlConnection(miConexion);
                con.Open();
            }
            catch
            {
                MessageBox.Show("No se ha podido conectar con la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void CerrarConexion() 
        {
            con.Close();
        }

        public void ejecutarSQL(string consultaSQL) 
        {
            AbrirConexion();
            MySqlCommand comando = new MySqlCommand(consultaSQL, con);
                                                                       
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public MySqlDataReader ejecutarYdevolver(string consultaSQL)
        {
            MySqlDataReader resultado;

            AbrirConexion();

            MySqlCommand comando = new MySqlCommand(consultaSQL, con);

            resultado = comando.ExecuteReader();

            return resultado;
        }

    }
}
