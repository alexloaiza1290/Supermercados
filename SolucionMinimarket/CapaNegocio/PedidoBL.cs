using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class PedidoBL
    {
        PedidoDA da = new PedidoDA();
        public int InsertarPedido(Pedido ped)
        {
            return da.InsertarPedido(ped);
        }
        public int ActualizarPedido(Pedido ped)
        {
            return da.ActualizarPedido(ped);
        }
        public List<Pedido> ListarPedido()
        {
            return da.ListarPedido();
        }
        public Pedido BuscarPedidoCodigo(int cod)
        {
            return da.BuscarPedidoCodigo(cod);
        }
        public int GenerarCodPedido()
        {
            return da.GenerarCodPedido();
        }


    }
}
