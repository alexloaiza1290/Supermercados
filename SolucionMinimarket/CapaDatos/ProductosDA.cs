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
   public class ProductosDA : Conexion
    {
        Producto dm = new Producto();
        public int InsertarProducto(Producto prod)
        {
            Producto pr = new Producto();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("sp_insertar_producto",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_nombre",prod.Nombre);
            cmd.Parameters.AddWithValue("p_descripcion",prod.Descripcion);
            cmd.Parameters.AddWithValue("p_puntos",prod.Puntos);
            cmd.Parameters.AddWithValue("p_stock",prod.Stock);
            cmd.Parameters.AddWithValue("p_foto",prod.Foto);
            cmd.Parameters.AddWithValue("p_id_categoria",prod.Categoria.Id);
            cmd.ExecuteNonQuery();
            connection.Close();
            return 1;
        }
        public int ActualizarProducto(Producto prod)
        {
            
            return 1;
        }
        public List<Producto> ListarProductos()
        {
            List<Producto> lstProductos = new List<Producto>();
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_listar_productos", connection);
            command.CommandType = CommandType.StoredProcedure;
            MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Producto producto = new Producto ();
                    producto.Id = Convert.ToInt32(dataReader["id_producto"].ToString());
                    producto.Nombre = dataReader["nombre"].ToString();
                    producto.Descripcion = dataReader["descripcion"].ToString();
                    producto.Puntos = Convert.ToInt32(dataReader["puntos"].ToString());
                    producto.Stock = Convert.ToInt32(dataReader["stock"].ToString());
                    lstProductos.Add(producto);
                }
            }

            return lstProductos;
        }

        //public DataTable ListarCatalogoProductos()
        //{
            
        //    connection.Open();
        //    DataTable dtDatos = new DataTable();

        //    // Se crea un MySqlAdapter para obtener los datos de la base
        //    MySqlDataAdapter mdaDatos = new MySqlDataAdapter("sp_listar_catalogo_productos", connection);

        //    // Con la información del adaptador se rellena el DataTable
        //    mdaDatos.Fill(dtDatos);
        //    connection.Close();

        //    return dtDatos;
        //}
        public List<Producto> ListarCatalogoProductos()
        {
            List<Producto> lstProductos = new List<Producto>();
            connection.Open();
            MySqlCommand command = new MySqlCommand("sp_listar_catalogo_productos", connection);
            command.CommandType = CommandType.StoredProcedure;
            MySqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(dataReader["id_producto"].ToString());
                    producto.Nombre = dataReader["nombre"].ToString();
                    producto.Descripcion = dataReader["descripcion"].ToString();
                    producto.Puntos = Convert.ToInt32(dataReader["puntos"].ToString());
                    producto.Stock = Convert.ToInt32(dataReader["stock"].ToString());
                    lstProductos.Add(producto);
                }
            }

            return lstProductos;
        }
        public Producto BuscarProductosCodigo(int cod)
        {
            Producto prod = new Producto();
            
            return prod;

        }
        public int GenerarCodProducto()
        {
            int cod = 0;
            
            return cod;
        }
        public int ActualizarStock(int cod,int cant)
        {
            
            return 1;          
           
        }
        public int ConsultarStockProducto(int cod)
        {
            int stock = 0;
            
            return stock;
        }
    }
}
