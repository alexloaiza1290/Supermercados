using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
  public  class ProductosBL
    {
        ProductosDA da = new ProductosDA();
        public int insertarProducto(Producto prod)
        {
            return da.InsertarProducto(prod);
        }
        public int ActualizarProducto(Producto prod)
        {
            return da.ActualizarProducto(prod);
        }
        //public DataTable ListarProductos()
        //{
        //    return da.ListarProductos();
        //}
        public List<Producto> ListarProducto()
        {
            List<Producto> lstProducto = new List<Producto>();
            lstProducto = da.ListarProductos();
            return lstProducto;
        }
        public List<Producto> ListarCatalogoProductos()
        {
            return da.ListarCatalogoProductos();
        }
        public Producto BuscarProductosCodigo(int cod)
        {
            return da.BuscarProductosCodigo(cod);
        }
        public int GenerarCodProducto()
        {
            return da.GenerarCodProducto();
        }
        public int ActualizarStock(int cod, int cant)
        {
          return da.ActualizarStock(cod, cant);
        }
        public int ConsultarStockProducto(int cod)
        {
            return da.ConsultarStockProducto(cod);           
        }
    }
}
