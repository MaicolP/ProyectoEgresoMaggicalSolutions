using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pRotura : clsPersistencia
    {
        public void altaRotura(eRotura rotura)
        {
            string consultaSQL = "INSERT INTO `rotura`(`id_rotura`, `id_prestamo_origen_rotura`, `detalle_desperfecto`, `detalle_solucion`, `id_equipo`) " + 
                "VALUES('0','" + rotura.idPrestamoOrigenRotura + "','" + rotura.detalleDesperfecto + "','" + rotura.detalleSolucion + "','" + rotura.equipo.id + "');";
            ejecutarSQL(consultaSQL);
        }

        public void bajaRotura(eRotura rotura)
        {
            string consultaSQL = "DELETE FROM rotura WHERE id_rotura='" + rotura.idRotura + "';";
            ejecutarSQL(consultaSQL);
        }

        public void modificarRotura(eRotura rotura)
        {
            string consultaSQL = "UPDATE `rotura` SET `id_prestamo_origen_rotura`='" + rotura.idPrestamoOrigenRotura + "',`detalle_desperfecto`='" + rotura.detalleDesperfecto + "',`detalle_solucion`='" + rotura.detalleSolucion + "',`id_equipo`='" + rotura.equipo.id + "' WHERE id_rotura='" + rotura.idRotura + "';";
            ejecutarSQL(consultaSQL);
        }

        public List<eRotura> listarRoturaPorEq()
        {
            List<eRotura> _roturas = new List<eRotura>();
            string consultaSQL = "SELECT * FROM `rotura` INNER JOIN equipo ON rotura.id_equipo=equipo.id_equipo ORDER BY rotura.id_equipo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);

            while (resultado.Read())
            {
                _roturas.Add(recrearRotura(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _roturas;
        }

        public List<eRotura> listarRotura()
        {
            List<eRotura> _roturas = new List<eRotura>();
            string consultaSQL = "SELECT * FROM `rotura` INNER JOIN equipo ON rotura.id_equipo=equipo.id_equipo;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);

            while(resultado.Read())
            {
                _roturas.Add(recrearRotura(resultado));
            }
            resultado.Close();
            CerrarConexion();
            return _roturas;
        }

        public eRotura buscarRotura(int id)
        {
            eRotura rotura = new eRotura();
            string consultaSQL = "SELECT * FROM `rotura` INNER JOIN equipo ON rotura.id_equipo=equipo.id_equipo WHERE rotura.id_rotura='" + id + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);

            while (resultado.Read())
            {
                rotura = recrearRotura(resultado);
            }
            resultado.Close();
            CerrarConexion();
            return rotura;
        }

        private eRotura recrearRotura(MySqlDataReader resultado)
        {
            eRotura rotura = new eRotura();

            rotura.idRotura = resultado.GetInt32("id_rotura");
            rotura.idPrestamoOrigenRotura = resultado.GetInt32("id_prestamo_origen_rotura");
            rotura.detalleDesperfecto = resultado.GetString("detalle_desperfecto");
            rotura.detalleSolucion = resultado.GetString("detalle_solucion");
            rotura.equipo.id = resultado.GetInt32("id_equipo");
            rotura.equipo.nroSerie = resultado.GetString("nro_serie");
            rotura.equipo.nombre = resultado.GetString("nombre");
            rotura.equipo.precio = resultado.GetString("precio");

            return rotura;
        }
    }
}
