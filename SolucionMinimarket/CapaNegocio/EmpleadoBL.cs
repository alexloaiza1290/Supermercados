using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class EmpleadoBL
    {
        EmpleadoDA da = new EmpleadoDA();
        public int InsertarEmpleado(Empleado emp)
        {
            return InsertarEmpleado(emp);
        }
        public int ActualizarEmpleado(Empleado emp)
        {
            return da.ActualizarEmpleado(emp);
        }
        public List<Empleado> ListarEmpleado()
        {
            return da.ListarEmpleado();
        }
        public Empleado BuscarEmpleadoCodigo(int cod)
        {
            return da.BuscarEmpleadoCodigo(cod);
        }
        public int GenerarCodigo()
        {

            return da.GenerarCodigo();
        }
    }
}
