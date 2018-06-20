using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Cargo Cargo { get; set; }
    }
}
