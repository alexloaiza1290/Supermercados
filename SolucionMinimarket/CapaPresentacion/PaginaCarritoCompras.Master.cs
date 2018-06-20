using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace CapaPresentacion
{
    public partial class PaginaCarritoCompras : System.Web.UI.MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cli"].ToString() == "")
            {
                lblNombreCliente.Visible = false;
            }
            else
            {
                lblNombreCliente.Text =  Session["cli"].ToString();
            }

        }
       


    }
}