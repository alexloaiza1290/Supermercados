using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public DateTime FechaPedido { get; set; }
        public double TotalPuntos { get; set; }
    }
}
