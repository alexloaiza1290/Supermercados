using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class PedidoDA : Conexion
    {
        Pedido dm = new Pedido();
        public int InsertarPedido(Pedido ped)
        {
            Pedido x = new Pedido();

            return 1;
        }
        public int ActualizarPedido(Pedido ped)
        {

            return 1;
        }

        public List<Pedido> ListarPedido()
        {
            List<Pedido> lstPedido = new List<Pedido>();


            return lstPedido;
        }
        public Pedido BuscarPedidoCodigo(int cod)
        {
            Pedido ped = new Pedido();
            return ped;
        }
        public int GenerarCodPedido()
        {
            int cod = 0;

            return cod;


        }
    }
}