using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
   public class EmpleadoDA
    {
        Empleado dm = new Empleado();
        public int InsertarEmpleado(Empleado emp)
        {
            Empleado x = new Empleado();
            return 1;
        }
        public int ActualizarEmpleado(Empleado emp)
        {
           
            return 1;
        }
        public List<Empleado> ListarEmpleado()
        {
            List<Empleado> lstEmpleado = new List<Empleado>();
           
            return lstEmpleado;
        }
        public Empleado BuscarEmpleadoCodigo(int cod)
        {
            Empleado emp = new Empleado();
           
            return emp;
        }
        public int GenerarCodigo()
        {
          
            int cod = 0;
           
            return cod;
        }

    }
}
