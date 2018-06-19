using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class frmRegistroCliente : System.Web.UI.Page
    {
        Cliente c = new Cliente();
        List<Cliente> lstCliente = new List<Cliente>();
        ClienteBL NegCliente = new ClienteBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                txtIdCliente.Text = NegCliente.GenerarCodigoCliente().ToString();
            }
        }
        private void AsignarClientes()
        {
            c.Id = int.Parse(txtIdCliente.Text);
            c.Nombres = txtNombre.Text;
            c.Apellidos = txtApellido.Text;
            c.Direccion = txtDireccion.Text;
            c.Telefono = txtTelefono.Text;
            c.Dni = txtDNI.Text;
            c.Email = txtEmail.Text;
            c.Usuario = txtUsuario.Text;
            c.Clave = txtClave.Text;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int rpta = 0;
            AsignarClientes();
            rpta = NegCliente.InsertarCliente(c);
            if (rpta == 1)
            {
                Response.Redirect("/frmAccesoCliente.aspx");
                LimpiarCliente();
            }

        }
        private void LimpiarCliente()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
    }
}