using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CapaModelo;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class ClienteDA:Conexion
    {
        public int InsertarCliente(Cliente cliente)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_insertar_cliente", connection);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("p_id", cliente.Id);
            command.Parameters.AddWithValue("p_nombre", cliente.Nombres);
            command.Parameters.AddWithValue("p_apellido", cliente.Apellidos);
            command.Parameters.AddWithValue("p_direccion", cliente.Direccion);
            command.Parameters.AddWithValue("p_telefono", cliente.Telefono);
            command.Parameters.AddWithValue("p_dni", cliente.Dni);
            command.Parameters.AddWithValue("p_email", cliente.Email);
            command.Parameters.AddWithValue("p_usuario", cliente.Usuario);
            command.Parameters.AddWithValue("p_clave", cliente.Clave);
            command.ExecuteNonQuery();
            connection.Close();

            return 1;
        }
        public int ActualizarCliente(Cliente cliente)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_actualizar_cliente", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_id", cliente.Id);
            command.Parameters.AddWithValue("p_nombre", cliente.Nombres);
            command.Parameters.AddWithValue("p_apellido", cliente.Apellidos);
            command.Parameters.AddWithValue("p_direccion", cliente.Direccion);
            command.Parameters.AddWithValue("p_telefono", cliente.Telefono);
            command.Parameters.AddWithValue("p_dni", cliente.Dni);
            command.Parameters.AddWithValue("p_email", cliente.Email);
            command.Parameters.AddWithValue("p_usuario", cliente.Usuario);
            command.Parameters.AddWithValue("p_clave", cliente.Clave);
            command.ExecuteNonQuery();
            connection.Close();

            return 1;
        }
        //public List<Cliente> ListarCliente()
        //{
        //    List<Cliente> lstCliente = new List<Cliente>();
        
        //   return lstCliente;
        //}

        public DataTable ListarCliente()
        {
            DataTable dt = new DataTable();
            connection.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("sp_listar_cliente",connection);
            sda.Fill(dt);
            connection.Close();
            return dt;
        } 
        public Cliente BuscarClienteCodigo(int cod)
        {
            Cliente cliente = new Cliente();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("sp_buscar_cliente_codigo",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id",cod);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    cliente.Id = Convert.ToInt32(dataReader["id_cliente"].ToString());
                    cliente.Nombres = dataReader["nombre"].ToString();
                    cliente.Apellidos = dataReader["apellido"].ToString();
                    cliente.Direccion = dataReader["direccion"].ToString();
                    cliente.Telefono = dataReader["telefono"].ToString();
                    cliente.Dni = dataReader["dni"].ToString();
                    cliente.Email = dataReader["email"].ToString();
                    cliente.Clave = dataReader["clave"].ToString();
                    cliente.Usuario = dataReader["usuario"].ToString();
                }
                
            }
            connection.Close();
          return cliente;
        }
        public Cliente AutenticarCliente(Cliente cli)
        {
            Cliente cliente = new Cliente();
            connection.Open();

            MySqlCommand command = new MySqlCommand("sp_autenticar_clientes", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_usuario", cliente.Usuario);
            command.Parameters.AddWithValue("p_clave", cliente.Clave);
            command.ExecuteNonQuery();

            MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    cliente.Id = Convert.ToInt32(dataReader["id_cliente"].ToString());
                    cliente.Nombres = dataReader["nombre"].ToString();
                    cliente.Apellidos = dataReader["apellido"].ToString();
                    cliente.Direccion = dataReader["direccion"].ToString();
                    cliente.Telefono = dataReader["telefono"].ToString();
                    cliente.Dni = dataReader["dni"].ToString();
                    cliente.Email = dataReader["email"].ToString();
                    cliente.Clave = dataReader["clave"].ToString();
                    cliente.Usuario = dataReader["usuario"].ToString();


                }
            }
            connection.Close();
            return cliente;
        }
        public int EliminarCliente(int cod)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_autenticar_clientes", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_id", cod);
            command.ExecuteNonQuery();
            connection.Close();
            return 1;
        }
        public int GenerarCodigoCliente()
        {
            int cod = 0;           
            return cod;
        }
    }
}
