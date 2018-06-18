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
   public class CategoriaBL
    {
        CategoriaDA da = new CategoriaDA();
        public int InsertarCategoria(Categoria cat)
        {
            return da.InsertarCategoria(cat);
        }
        public int ActualizarCategoria(Categoria cat)
        {
            return da.ActualizarCategoria(cat);
        }
        public List<Categoria> ListarCategorias()
        {
            return da.ListarCategorias();
        }
        public DataTable ListarCategoria()
        {
            return da.ListarCategoria();
        }
        public Categoria BuscarCategoriaCodigo(int cod)
        {
            return da.BuscarCategoriaCodigo(cod);
        }
        public int EliminarCategoria(int cod)
        {
            return da.EliminarCategoria(cod);
        }


    }
}
