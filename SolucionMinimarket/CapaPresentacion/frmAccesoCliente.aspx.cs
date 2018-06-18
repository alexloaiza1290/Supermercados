using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAccesoCliente : System.Web.UI.Page
    {
        ClienteBL negCli = new ClienteBL();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Cliente ent = new Cliente();
            ent.Usuario = txtUsuario.Text;
            ent.Clave = txtPassword.Text;

            ent = negCli.AutenticarCliente(ent);


            if (ent.Nombres != "")
            {
                Session["cli"] = ent.Nombres + " " + ent.Apellidos;
                Response.Redirect("/frmCatalogo.aspx");
            }
            else
                Response.Redirect("/frmAccesoCliente.aspx");

        }

        protected void btnRegistar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/frmRegistroCliente.aspx");

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/frmRegistroCliente.aspx");
        }
    }
}