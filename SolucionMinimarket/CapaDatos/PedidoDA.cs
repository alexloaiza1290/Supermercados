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
    public class PedidoDA : Conexion
    {
        public int InsertarPedido(Pedido ped)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("sp_insertar_pedido",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_fecha_pedido", ped.FechaPedido);
            cmd.Parameters.AddWithValue("p_total_puntos", ped.TotalPuntos);
            cmd.Parameters.AddWithValue("p_id_cliente", ped.Cliente.Id);
            cmd.Parameters.AddWithValue("p_id_empleado", ped.Empleado.Id);
            cmd.ExecuteNonQuery();
            connection.Close();
            return 1;
        }
        public int ActualizarPedido(Pedido ped)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("sp_actualizar_pedido", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id", ped.Id);
            cmd.Parameters.AddWithValue("p_fecha_pedido", ped.FechaPedido);
            cmd.Parameters.AddWithValue("p_total_puntos", ped.TotalPuntos);
            cmd.Parameters.AddWithValue("p_id_cliente", ped.Cliente.Id);
            cmd.Parameters.AddWithValue("p_id_empleado", ped.Empleado.Id);
            cmd.ExecuteNonQuery();
            connection.Close();
            return 1;
        }

        public List<Pedido> ListarPedido()
        {
            List<Pedido> lstPedido = new List<Pedido>();
            MySqlCommand cmd = new MySqlCommand("sp_listar_pedido",connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Pedido pedido = new Pedido();
                    pedido.Id = Convert.ToInt32(dataReader["id_pedido"].ToString());
                    pedido.FechaPedido = Convert.ToDateTime(dataReader["fecha_pedido"].ToString());
                    pedido.TotalPuntos = Convert.ToDouble(dataReader["total_puntos"].ToString());
                    pedido.Cliente.Id = Convert.ToInt32(dataReader["id_cliente"].ToString());
                    pedido.Empleado.Id = Convert.ToInt32(dataReader["id_empleado"].ToString());
                }
            }
            return lstPedido;
        }
        public Pedido BuscarPedidoCodigo(int cod)
        {
            Pedido ped = new Pedido();
            MySqlCommand cmd = new MySqlCommand("sp_listar_pedido_codigo", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id",cod);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Pedido pedido = new Pedido();
                    pedido.Id = Convert.ToInt32(dataReader["id"].ToString());
                    pedido.FechaPedido = Convert.ToDateTime(dataReader["fecha_pedido"].ToString());
                    pedido.TotalPuntos = Convert.ToDouble(dataReader["total_puntos"].ToString());
                    pedido.Cliente.Id = Convert.ToInt32(dataReader["id_cliente"].ToString());
                    pedido.Empleado.Id = Convert.ToInt32(dataReader["id_empleado"].ToString());
                }
            }
            return ped;
        }
        public int GenerarCodPedido()
        {
            int cod = 0;

            return cod;
        }
    }
}