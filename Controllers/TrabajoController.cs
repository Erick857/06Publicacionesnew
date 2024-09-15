using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Controllers
{
    internal class TrabajoController
    {
        public Trabajo InsertarTrabajo(Trabajo trabajo)
        {
            return Trabajo.InsertarTrabajo(trabajo);
        }

        public string ActualizarTrabajo(Trabajo trabajo)
        {
            return Trabajo.ActualizarTrabajo(trabajo);
        }

        public string EliminarTrabajo(string idTrabajo)
        {
            return Trabajo.EliminarTrabajo(idTrabajo);
        }

        public Trabajo ObtenerTrabajoPorId(string idTrabajo)
        {
            return Trabajo.ObtenerTrabajoPorId(idTrabajo);
        }

        public List<Trabajo> ListTrabajos()
        {
            return Trabajo.ListTrabajos();
        }
    }
}
