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
    public class CicloEscolarDAO
    {
        MySqlConnection conexion;

        public CicloEscolarDAO()
        {
            String conexStr = "server=localhost;user=root;database=siiap_prueba;port=3306;password=123456";
            conexion = new MySqlConnection(conexStr);
            conexion.Open();
        }

        ~CicloEscolarDAO()
        {
            conexion.Close();
        }

        public void agregar(String nombre, String inicio, String fin)
        {
            String sentencia = "INSERT INTO ciclo_escolar(nombre, inicio, fin) VALUES('" + nombre + "','" + inicio + "','" + fin + "');";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            query.ExecuteNonQuery();
        }

        public bool actualizar(int id, String nombre, String inicio, String fin)
        {
            String sentencia = "UPDATE ciclo_escolar SET nombre='" + nombre + "', inicio='" + inicio + "', fin='" + fin + "' WHERE id=" + id + ";";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            query.ExecuteNonQuery();
            return true;
        }

        public bool borrar(int id)
        {
            String sentencia = "DELETE FROM ciclo_escolar WHERE id=" + id + ";";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            query.ExecuteNonQuery();
            return true;
        }

        public CicloEscolar obtener(int id)
        {
            CicloEscolar ciclo = null;
            String sentencia = "SELECT id, nombre, inicio, fin FROM ciclo_escolar WHERE id=" + id + ";";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            MySqlDataReader rdr = query.ExecuteReader();
            if (rdr.HasRows)
            {
                ciclo = new CicloEscolar(Convert.ToInt32(rdr[0]), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }
            rdr.Close();
            return ciclo;
        }

        public List<CicloEscolar> listar()
        {
            List<CicloEscolar> ciclos = new List<CicloEscolar>();
            String sentencia = "SELECT id, nombre, inicio, fin FROM ciclo_escolar;";
            MySqlCommand query = new MySqlCommand(sentencia, conexion);
            MySqlDataReader rdr = query.ExecuteReader();
            while (rdr.Read())
            {
                ciclos.Add(new CicloEscolar(Convert.ToInt32(rdr[0]), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString()));
            }
            rdr.Close();
            return ciclos;
        }
    }
}
