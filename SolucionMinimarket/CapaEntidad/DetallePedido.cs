using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class DetallePedido
    {
     public int Id { get; set; }
	 public Pedido Pedido { get; set; }
     public Producto Producto { get; set; }
     public int Cantidad { get; set; }
     public int Puntos { get; set; }
     public int TotalCanje { get; set; }
    }
}
