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
   public class DetallePedidoDA:Conexion
    {
        public int InsertarDetallePedido(List< DetallePedido> LstDetPed)
        {
            DetallePedido dtp = new DetallePedido();
            connection.Open();
            foreach (DetallePedido item in LstDetPed)
            {
                dtp.Id = item.Id;
                dtp.Producto.Id = item.Producto.Id;
                dtp.Pedido.Id = item.Pedido.Id;
                dtp.Cantidad = item.Cantidad;
                dtp.Puntos = item.Puntos;
                dtp.TotalCanje = item.TotalCanje;
                MySqlCommand cmd = new MySqlCommand("sp_insertar_detalle_pedido", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id_producto",dtp.Producto.Id);
                cmd.Parameters.AddWithValue("p_id_pedido", dtp.Pedido.Id);
                cmd.Parameters.AddWithValue("p_cantidad", dtp.Cantidad);
                cmd.Parameters.AddWithValue("p_puntos", dtp.Puntos);
                cmd.Parameters.AddWithValue("p_total_canje", dtp.TotalCanje);
            }
            connection.Close();
           
            return 1;
        }
        public int GenerarCodDetallePedido()
        {                      

            int cod = 0;
            
            return cod;


        }
    }
}
