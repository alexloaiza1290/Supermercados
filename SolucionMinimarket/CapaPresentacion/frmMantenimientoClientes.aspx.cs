using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmMantenimientoClientes : System.Web.UI.Page
    {
        Cliente c = new Cliente();
        List<Cliente> lstCliente = new List<Cliente>();
        ClienteBL negCliente = new ClienteBL();
        DataTable dt = new DataTable();

        private void CargarClientes()
        {
            lstCliente = negCliente.ListarCliente();
            grvDatos.DataSource = lstCliente;
            grvDatos.DataBind();
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
        public int NuevoCliente()
        {
            int rpta = 0;
            AsignarClientes();
            rpta = negCliente.InsertarCliente(c);
            return rpta;
        }
        public int ActualizarCliente()
        {
            int rpta = 0;
            AsignarClientes();
            rpta = negCliente.ActualizarCliente(c);
            btnGuardar.Text = "Guardar";
            LimpiarCliente();
            return rpta;
        }
        private void BuscarCliente()
        {
            Cliente cli = new Cliente();
            cli = negCliente.BuscarClienteCodigo(Convert.ToInt32(txtIdCliente.Text));
            txtIdCliente.Text = cli.Id.ToString();
            txtNombre.Text = cli.Nombres;
            txtApellido.Text = cli.Apellidos;
            txtDireccion.Text = cli.Direccion;
            txtTelefono.Text = cli.Telefono;
            txtDNI.Text = cli.Dni;
            txtEmail.Text = cli.Email;
            txtUsuario.Text = cli.Usuario;
            txtClave.Text = cli.Clave;
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
        private void HabilitarEntradas(bool estado)
        {
            txtIdCliente.Enabled = estado;
            txtNombre.Enabled = estado;
            txtApellido.Enabled = estado;
            txtDireccion.Enabled = estado;
            txtTelefono.Enabled = estado;
            txtDNI.Enabled = estado;
            txtEmail.Enabled = estado;
            txtUsuario.Enabled = estado;
            txtClave.Enabled = estado;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                CargarClientes();
                txtIdCliente.Text = negCliente.GenerarCodigoCliente().ToString();
            }

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
            txtIdCliente.Text = negCliente.GenerarCodigoCliente().ToString();
            btnGuardar.Text = "Guardar";

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Guardar")
            {
                NuevoCliente();
                LimpiarCliente();
            }

            else
            { 
                ActualizarCliente();
                btnGuardar.Text = "Guardar";
                LimpiarCliente();
            }
            CargarClientes();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
            btnGuardar.Text = "Actualizar";
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int rpta = 0;
            rpta = negCliente.EliminarCliente(Convert.ToInt32(txtIdCliente.Text));
            LimpiarCliente();
            CargarClientes();

        }

    }
}