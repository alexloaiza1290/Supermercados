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
    public partial class frmLoginAdministrador : System.Web.UI.Page
    {
        Usuario u1 = new Usuario();
        Usuario u2 = new Usuario();

        UsuariosBL objNeg = new UsuariosBL();

        private void autenticarUsuarios()
        {
            u1.Login = this.txtUsuario.Text;
            u1.Passwd  = this.txtPassword.Text;
            u2 = objNeg.AutenticarUsuario(u1.Login, u1.Passwd);
           
            u2 = objNeg.AutenticarUsuario(u2.Login,u2.Passwd);

            if (u1.Login == u2.Login && u1.Passwd == u2.Passwd)
            {
                Session["Usuarios"] = u2.Empleado.Nombre + " " + u2.Empleado.Apellido;
                Response.Redirect("/frmMantenimientoCategoria.aspx");
            }
            else
            {
                Response.Redirect("/frmLoginAdministrador.aspx");

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            autenticarUsuarios();
        }
    }
}