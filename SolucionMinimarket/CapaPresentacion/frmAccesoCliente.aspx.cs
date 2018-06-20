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
            Cliente cliente1 = new Cliente();
            Cliente cliente2 = new Cliente();
            cliente1.Usuario = txtUsuario.Text;
            cliente1.Clave = txtPassword.Text;
            cliente2 = negCli.AutenticarCliente(txtUsuario.Text,txtPassword.Text);
            if (cliente1.Usuario == cliente2.Usuario && cliente1.Clave == cliente2.Clave)
            {
                Session["cli"] = cliente1.Nombres + " " + cliente1.Apellidos;
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