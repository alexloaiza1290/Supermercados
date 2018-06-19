using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMantenimientoCategoria : System.Web.UI.Page
    {
        CategoriaBL negCat = new CategoriaBL();
        Categoria c = new Categoria();
        private void CargarCategoria()
        {
            List<Categoria> lstCategoria = new List<Categoria>();
            lstCategoria = negCat.ListarCategorias();
            grvDatos.DataSource = lstCategoria;
            grvDatos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                CargarCategoria();
            }
        }
        public void AsignarEntradas()
        {
            c.Id = Convert.ToInt32(txtCodigo.Text);
            c.Nombre = txtNombre.Text;
            c.Descripcion = txtDescripcion.Text;
        }

        public int nuevoCat()
        {
            int rpta = 0;
            AsignarEntradas();
           rpta = negCat.InsertarCategoria(c);
            return rpta;
        }
        public int ActualizarCat()
        {
            int rpta = 0;
            AsignarEntradas();
            rpta = negCat.ActualizarCategoria(c);
            return rpta;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCategoria();
            btnGuardar.Text = "Actualizar";
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Text = "Guardar";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Guardar")
            {
                nuevoCat();
                Limpiar();
            }
            else
            {
                ActualizarCat();
                btnGuardar.Text = "Guardar";
                Limpiar();
            }
            CargarCategoria();
        }
        private void BuscarCategoria()
        {
            Categoria cat = new Categoria();
            cat = negCat.BuscarCategoriaCodigo(Convert.ToInt32(txtCodigo.Text));
            txtCodigo.Text = cat.Id.ToString();
            txtNombre.Text = cat.Nombre;
            txtDescripcion.Text = cat.Descripcion;
        }

       private void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }
        public void EliminarCategoria()
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            negCat.EliminarCategoria(codigo);
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
            Limpiar();
            CargarCategoria();
        }
    }
}