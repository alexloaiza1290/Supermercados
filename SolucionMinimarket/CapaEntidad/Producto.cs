using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Puntos { get; set; }
        public int Stock { get; set; }
        public string Foto { get; set; }
        public Categoria Categoria { get; set; }
    }
}
