using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
   public class DetallePedidoDA
    {
        DetallePedido dm = new DetallePedido();
        public int InsertarDetallePedido(List< DetallePedido> LstDetPed)
        {
            DetallePedido dtp = new DetallePedido();
        
           
            return 1;
        }
        public void ActualizarDetallePedido(DetallePedido detPed)
        {
        }

        public int GenerarCodDetallePedido()
        {                      

            int cod = 0;
            
            return cod;


        }
    }
}
