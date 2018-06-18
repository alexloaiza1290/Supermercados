using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMantenimientoProductos : System.Web.UI.Page
    {
        List<Producto> lstProducto = new List<Producto>();
        ProductosBL NegProd = new ProductosBL();
        Producto p = new Producto();
        List<Categoria> lstCategoria = new List<Categoria>();
        CategoriaBL NegCat = new CategoriaBL();
        DataTable dt = new DataTable();

        public void CargarProductos()
        {
            //lstProducto = NegProd.ListarProducto();
            ////dt = NegProd.ListarProductos();
            //grvDatos.DataSource = lstProducto;
            //grvDatos.DataBind();
            //txtFoto.Text = FileUpload1.FileName;
        }
        public void CargarCategoria()
        {
            dt = NegCat.ListarCategoria();
            //lstCategoria = NegCat.ListarCategorias();
            ddlCategoria.DataSource = dt;
            ddlCategoria.DataTextField = "nombre";
            ddlCategoria.DataValueField = "id_categoria";
            ddlCategoria.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                CargarProductos();
                CargarCategoria();
                txtIdProducto.Text = NegProd.GenerarCodProducto().ToString();
            }

        }
        public void AsignarEntradas()
        {
            //txtFoto.Text = FileUploadFoto.FileName;
            p.Id = Convert.ToInt32(txtIdProducto.Text);
            p.Nombre = txtNombre.Text;
            p.Descripcion = txtDescripcion.Text;
            p.Puntos = Convert.ToDouble(txtPrecio.Text);
            p.Stock = Convert.ToInt32(txtStock.Text);
            p.Foto = txtFoto.Text;
            //Categoria cat=new Categoria();
            //cat.Id = Convert.ToInt32(ddlCategoria.SelectedValue.ToString());
            //p.Categoria = cat;
            p.Categoria = new Categoria() {Id = Convert.ToInt32(ddlCategoria.SelectedValue.ToString()) };
           // p.Categoria  = Convert.ToInt32(ddlCategoria.SelectedValue.ToString());
        }

        public int nuevoProd()
        {
            int rpta = 0;
            AsignarEntradas();
            rpta = NegProd.insertarProducto(p);
            return rpta;
        }
        public int ActualizarProd()
        {
            int rpta = 0;
            AsignarEntradas();
            rpta = NegProd.ActualizarProducto(p);
            return rpta;
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            if (btnGrabar.Text=="Grabar")
            {
                nuevoProd();
            }
            else
            {
                ActualizarProd();
                btnGrabar.Text = "Grabar";
            }
            CargarProductos();
        }
        public void BuscarProductoCodigo()
        {
            Producto pr = new Producto();
            pr = NegProd.BuscarProductosCodigo(Convert.ToInt32(txtIdProducto.Text));
            txtIdProducto.Text = pr.Id.ToString();
            txtNombre.Text = pr.Nombre;
            txtDescripcion.Text = pr.Descripcion;
            txtPrecio.Text = pr.Puntos.ToString();
            txtStock.Text = pr.Stock.ToString();
            txtFoto.Text = pr.Foto;
            imgProducto.ImageUrl = "/imagenes/" + txtFoto.Text;
            ddlCategoria.SelectedValue = pr.Categoria.Id.ToString();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductoCodigo();
            btnGrabar.Text = "Actualizar";
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtIdProducto.Text = NegProd.GenerarCodProducto().ToString();
        }

        protected void btnMostrarFoto_Click(object sender, EventArgs e)
        {
            txtFoto.Text = FileUpload1.FileName;
            imgProducto.ImageUrl = "/imagenes/" + FileUpload1.FileName;         

        }
        private void limpiar()
        {
            txtIdProducto.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text ="";
            txtFoto.Text = "";
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblPrueba.Text = ddlCategoria.SelectedValue.ToString();
        }
    }
}