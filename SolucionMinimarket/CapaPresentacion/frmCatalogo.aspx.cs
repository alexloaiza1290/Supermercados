using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;

using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmCatalogo : System.Web.UI.Page
    {
        DataTable dt;
        ProductosBL negProd = new ProductosBL();
        List<Producto> lstProd = new List<Producto>();
        DataTable carrito = new DataTable();

        private void CargarCatalogo()
        {
            //lstProd = negProd.ListarCatalogoProductos();
            dt = negProd.ListarCatalogoProductos();
            var lista = from item in lstProd
                        select new
                        {
                           item.Id ,
                            item.Nombre,
                            item.Descripcion,
                            item.Puntos,
                            item.Stock,
                            item.Foto,
                           Categorias= item.Categoria.Nombre  
                        };
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
        private void CargarDetalle()
        {
            dt = new DataTable();
            dt.Columns.Add("codigo", System.Type.GetType("System.Int32"));
            dt.Columns.Add("descripcion", System.Type.GetType("System.String"));
            dt.Columns.Add("puntos", System.Type.GetType("System.Double"));
            dt.Columns.Add("total", System.Type.GetType("System.Double"));
            Session["pedido"] = dt;

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                CargarCatalogo();              
                CargarDetalle();
                
            }

        }
        private void AgregarItem(int cod, string des, double puntos)
        {
            double total;
            int cantidad = 1;
            total = puntos * cantidad;
            carrito = (DataTable)Session["pedido"];
            DataRow fila = carrito.NewRow();
            fila[0] = cod;
            fila[1] = des;
            fila[2] = puntos;
            fila[3] = (int)cantidad;
            fila[4] = total;
            carrito.Rows.Add(fila);
            Session["pedido"] = carrito;
        }

       
        protected void DataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int cod;
            string des = null, nom = null;
            double puntos = 0;
            if (e.CommandName == "Agregar")
            {
                DataList1.SelectedIndex = e.Item.ItemIndex;
                cod = System.Convert.ToInt32(((Label)this.DataList1.SelectedItem.FindControl("lblIdProducto")).Text);
                nom = ((Label)this.DataList1.SelectedItem.FindControl("lblNombre")).Text;
                des = ((Label)this.DataList1.SelectedItem.FindControl("lblDescripcion")).Text;
                puntos = System.Convert.ToInt32(((Label)this.DataList1.SelectedItem.FindControl("lblPuntos")).Text);
                AgregarItem(cod, nom + " " + des, puntos);

                lblProductoAgregado.Text = "Producto Agregado: " + nom;
              
            }
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            if (Session["cli"].ToString() == "")
            {
                Response.Redirect("/frmAccesoCliente.aspx");

            }
            else
            {
              Response.Redirect("/frmCarrito.aspx");           

            }
        }
    }
}