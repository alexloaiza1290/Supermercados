using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
  public  class DetallePedidoBL
    {
        DetallePedidoDA da = new DetallePedidoDA();
        public int InsertarDetallePedido(List<DetallePedido> LstDetPed)
        {
            return da.InsertarDetallePedido(LstDetPed);

        }
        public int GenerarCodDetallePedido()
        {
            return da.GenerarCodDetallePedido();
        }

    }
}
