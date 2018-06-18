using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public  class UsuariosBL
    {
        UsuariosDA da = new UsuariosDA();
        public Usuario AutenticarUsuario(string login, string password)
        {
            return da.AutenticarUsuario(login, password);
        }
    }
}
