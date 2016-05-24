using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoBasesDeDatos
{    
    public class CentroUnivDAO
    {
        MySqlConnection conexion;

        public CentroUnivDAO()
        {
            String conectStrs = "server=localhost;user=root;database=siiap_prueba;port=3306;password=123456";
            conexion = new MySqlConnection(conectStrs);
            conexion.Open();
        }    
        
        ~CentroUnivDAO()
        {
            conexion.Close();
        } 

        public void agregar(String nombre)
        {
            String sentencia = "INSERT INTO centro_universitario(nombre) VALUES ('" + nombre + "');";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            query.ExecuteNonQuery();
        }

        public bool actualizar(int id, String nombre)
        {
            String sentencia = "UPDATE centro_universitario SET nombre='" + nombre + "' WHERE id=" + id + ";";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            query.ExecuteNonQuery();
            return true;
        }

        public bool borrar(int id)
        {
            String sentencia = "DELETE FROM centro_universitario WHERE id=" + id + ";";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            query.ExecuteNonQuery();
            return true;
        }

        public CentroUniv obtener(int id)
        {
            CentroUniv centro = null;
            String sentencia = "SELECT id, nombre FROM centro_universitario WHERE id=" + id + ";";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            MySqlDataReader rdr = query.ExecuteReader();
            if (rdr.HasRows)
            {
                centro = new CentroUniv(Convert.ToInt32(rdr[0]), rdr[1].ToString());
            }
            rdr.Close();
            return null;
        }

        public List<CentroUniv> listar()
        {
            List<CentroUniv> centros = new List<CentroUniv>();
            String sentencia = "SELECT id, nombre FROM centro_universitario;";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            MySqlDataReader rdr = query.ExecuteReader();
            while (rdr.Read())
            {
                centros.Add(new CentroUniv(Convert.ToInt32(rdr[0]), rdr[1].ToString()));
            }
            rdr.Close();
            return centros;
        }

    }
}
