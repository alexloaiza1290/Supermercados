using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using MySql.Data.MySqlClient;



namespace CapaDatos
{
   public class CategoriaDA: Conexion
    {
        public int InsertarCategoria(Categoria cat)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_insertar_categoria", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_nombre", cat.Nombre);
            command.Parameters.AddWithValue("p_descripcion", cat.Descripcion);
            command.ExecuteNonQuery();

            connection.Close();

            return 1;
        }
        public int ActualizarCategoria(Categoria cat)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_actualizar_categoria", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_id_categoria", cat.Id);
            command.Parameters.AddWithValue("p_nombre", cat.Nombre);
            command.Parameters.AddWithValue("p_descripcion", cat.Descripcion);
            command.ExecuteNonQuery();

            connection.Close();
            return 1;
        }
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> lstCategoria = new List<Categoria>();
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_listar_categoria", connection);
            command.CommandType = CommandType.StoredProcedure;
            MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(dataReader["id_categoria"]);
                    categoria.Nombre = dataReader["nombre"].ToString();
                    categoria.Descripcion = dataReader["descripcion"].ToString();
                    lstCategoria.Add(categoria);
                }
            }
            connection.Close();
            return lstCategoria;
        }
        public Categoria BuscarCategoriaCodigo(int cod)
        {
            Categoria cat = new Categoria();
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_listar_categoria_codigo", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_id_categoria", cod);
            MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    cat.Id = Convert.ToInt32(dataReader["id_categoria"].ToString());
                    cat.Nombre = dataReader["nombre"].ToString();
                    cat.Descripcion = dataReader["descripcion"].ToString();
                }
            }

            connection.Close();

            return cat;

        }
        //Elimnina un registro de la tabla categoria mediante el parametro ingresado
        public int EliminarCategoria(int codigo)
        {  
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_eliminar_categoria", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("p_id_categoria", codigo);
            command.ExecuteNonQuery();
            connection.Close();
            return 1;
        }
    }
}
