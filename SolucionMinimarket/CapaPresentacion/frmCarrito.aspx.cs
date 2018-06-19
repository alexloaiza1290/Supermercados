using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Data;
using System.Data.SqlClient;


namespace CapaPresentacion
{
    public partial class frmCarrito : System.Web.UI.Page
    {
        Pedido ped = new Pedido();
        PedidoBL objNeg = new PedidoBL();
        int cant = 2;

        List<DetallePedido> lstDetalle = new List<DetallePedido>();
        DetallePedido detPed = new DetallePedido();
        DetallePedidoBL objNeg_Det = new DetallePedidoBL();

     
        int idcliente = 1;
        int idEmpleado = 1;
        int numPedido;

        private double totalCarrito(DataTable dt)
        {
            double tot = 0;
            foreach (DataRow item in dt.Rows)
            {
                tot += Convert.ToDouble(item[4]);
            }
            return tot;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                grvPedido.DataSource = Session["pedido"];
                grvPedido.DataBind();
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int i;
            double total = 0, prec, subtotal;
            string cod, des, p;
           
            var items = (DataTable)Session["pedido"];
            for (i = 0; i < grvPedido.Rows.Count; i++)
            {
                cod = (grvPedido.Rows[i].Cells[0].Text);
                des = grvPedido.Rows[i].Cells[1].Text;
                p = grvPedido.Rows[i].Cells[2].Text;
                if (((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text == "" || Convert.ToInt32(((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text) <= 0)
                {
                    cant = 0;
                    lblLetras.Text = "Existen productos con cantidades negativas o vacios";
                }
                else
                {
                    cant = System.Convert.ToInt32(((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text);
                    int resul;
                    ProductosBL objProd = new ProductosBL();
                    int codProd = Convert.ToInt32(grvPedido.Rows[i].Cells[0].Text);
                    //int CantProd = Convert.ToInt32(detalle.Cantidad);
                    resul = objProd.ConsultarStockProducto(codProd);
                    if (resul<cant)
                    {
                        lblLetras.Text += "\n**Stock Insuficiente en el Producto " + grvPedido.Rows[i].Cells[1].Text;
                    }
                    else
                    {
                        prec = System.Convert.ToDouble(p);
                        subtotal = cant * prec;
                        grvPedido.Rows[i].Cells[4].Text = subtotal.ToString();
                        foreach (DataRow dr in items.Rows)
                        {
                            if (dr["Codigo"].ToString() == cod.ToString())
                            {
                                dr["Cantidad"] = cant;
                                dr["Total"] = subtotal;
                                break;
                            }
                        }
                        total = total + subtotal;
                    }
                   
                }
                float igv, totPedido;
                igv = float.Parse((total * 0.18).ToString());
                totPedido = float.Parse((igv + total).ToString());
                lblTotal.Text = total.ToString("0.00");
            }

               
            //if (lblTotal.Text!= "0.00")
            //    lblLetras.Text = "";
            //else
            //    lblLetras.Text = "Ingresar Cantidad";


        }
        public void guardarPedido()
        {
            ped.Id = objNeg.GenerarCodPedido();
            numPedido = objNeg.GenerarCodPedido();
            ped.Cliente.Id = idcliente;
            ped.Empleado.Id = idEmpleado;
            ped.FechaPedido = DateTime.Now;
            ped.TotalPuntos = float.Parse(lblTotal.Text);
            int rpta = objNeg.InsertarPedido(ped);
            int codDetalle = objNeg_Det.GenerarCodDetallePedido();
            for (int i = 0; i < grvPedido.Rows.Count; i++)
            {
                DetallePedido detalle = new DetallePedido();
                
                if (((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text == "" || Convert.ToInt32(((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text) <= 0)                 
                 {
                   // detalle.Cantidad = 0;
                }
                else
                {

                    int stock;
                    ProductosBL objProd = new ProductosBL();
                    int codProd = Convert.ToInt32(grvPedido.Rows[i].Cells[0].Text);
                    int CantProd = Convert.ToInt32(((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text);
                    stock = objProd.ConsultarStockProducto(codProd);
                    if (stock < CantProd)
                    {
                       
                    }
                    else
                    {
                        detalle.Id = codDetalle;
                        detalle.Pedido.Id = numPedido;
                        detalle.Producto.Id = Convert.ToInt32(grvPedido.Rows[i].Cells[0].Text);
                        detalle.Cantidad = System.Convert.ToInt32(((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text);
                        detalle.Puntos = Convert.ToInt32(grvPedido.Rows[i].Cells[2].Text);
                        detalle.TotalCanje = detalle.Cantidad * detalle.Puntos;
                        //*****Actualizar Stock
                        int resul;                       
                       // int codProd = Convert.ToInt32(detalle.Id);
                       //int CantProd = Convert.ToInt32(detalle.Cantidad);
                        resul = objProd.ActualizarStock(codProd, CantProd);
                        lstDetalle.Add(detalle);
                        codDetalle++;
                    }
                   
                }
                    
                //detalle.Cantidad = System.Convert.ToInt32(((TextBox)this.grvPedido.Rows[i].Cells[3].FindControl("txtCantidad")).Text);
               
            }
            int rptadp;// = objNeg_Det.InsertarDetallePedido(lstDetalle);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            if (lblTotal.Text != "0.00")
            {
                lblLetras.Text = "";
                guardarPedido();
                grvPrueba.DataSource = lstDetalle;
                grvPrueba.DataBind();
                lblcompraSatisfactoria.Text = "COMPRA REALIZADA CORRECTAMENTE";
                Session.Remove("pedido");
            }               
            else
                lblLetras.Text = "Verificar la Cantidad Solicitada";

       
        }

        protected void grvPedido_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int n = e.RowIndex;
            DataTable ocar = new DataTable();
            ocar = (DataTable)Session["pedido"];
            ocar.Rows[n].Delete();
            lblTotal.Text = totalCarrito(ocar).ToString();

            grvPedido.DataSource = ocar;
            grvPedido.DataBind();
        }
    }
}