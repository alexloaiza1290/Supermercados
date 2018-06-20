using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Usuario
    { 
        public int Id { get; set; }
        public string Login { get; set; }
        public string Passwd { get; set; }
        public Empleado Empleado { get; set; }
    }
}
