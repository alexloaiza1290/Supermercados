using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
   public class ClienteBL
    {
        ClienteDA da = new ClienteDA();
        public int InsertarCliente(Cliente cli)
        {
            return da.InsertarCliente(cli);
        }
        public int ActualizarCliente(Cliente cli)
        {
            return da.ActualizarCliente(cli);
        }
        public List<Cliente> ListarCliente()
        {
            return da.ListarCliente();
        }

        public Cliente BuscarClienteCodigo(int cod)
        {
            return da.BuscarClienteCodigo(cod);
        }
        public Cliente AutenticarCliente(string usuario, string clave)
        {
            return da.AutenticarCliente(usuario, clave);
        }
        public int EliminarCliente(int cl)
        {
            return da.EliminarCliente(cl);
        }
        public int GenerarCodigoCliente()
        {
            return da.GenerarCodigoCliente();
        }
    }
}
