using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
   public class UsuariosDA:Conexion
    {
        Usuario dm = new Usuario();

        public Usuario AutenticarUsuario(string login, string password)
        {
            Usuario usu = new Usuario();
            connection.Open();

            MySqlCommand command = new MySqlCommand("sp_autenticar_usuarios", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_login", login);
            command.Parameters.AddWithValue("p_password", password);
            command.ExecuteNonQuery();

            MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    //usu.Id = Convert.ToInt32(dataReader["id_usuario"].ToString());
                    usu.Login = dataReader["login"].ToString();
                    usu.Passwd = dataReader["passwd"].ToString();
                    usu.Empleado = new Empleado { Nombre = dataReader["nombre"].ToString(), Apellido = dataReader["apellidos"].ToString()};
                 }
            }
            connection.Close();
            return usu;

        }
    }
}
