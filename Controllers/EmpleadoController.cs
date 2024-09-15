using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Controllers
{
    internal class EmpleadoController
    {
        public Empleado InsertarEmpleado(Empleado empleado)
        {
            return Empleado.InsertarEmpleado(empleado);
        }

        public string ActualizarEmpleado(Empleado empleado)
        {
            return Empleado.ActualizarEmpleado(empleado);
        }

        public string EliminarEmpleado(string idEmpleado)
        {
            return Empleado.EliminarEmpleado(idEmpleado);
        }

        public Empleado ObtenerEmpleadoPorId(string idEmpleado)
        {
            return Empleado.ObtenerEmpleadoPorId(idEmpleado);
        }

        public List<Empleado> ListEmpleados()
        {
            return Empleado.ListEmpleados();
        }
    }
}
