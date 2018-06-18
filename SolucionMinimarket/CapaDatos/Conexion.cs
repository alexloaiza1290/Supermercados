using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDatos
{
    public abstract class Conexion
    {
        protected MySqlConnection connection;

        public Conexion()
        {
            connection = GetConnection();
        }

        private static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; " +
                "User id = root; " +
                "Database = canje; " +
                "password = mysql;";
            return conn;
        }
    }
}
