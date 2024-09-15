using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Controllers
{
    internal class PublicacionController
    {
        public Publicacion InsertarPublicacion(Publicacion publicacion)
        {
            return Publicacion.InsertarPublicacion(publicacion);
        }

        public string ActualizarPublicacion(Publicacion publicacion)
        {
            return Publicacion.ActualizarPublicacion(publicacion);
        }

        public string EliminarPublicacion(string idPublicacion)
        {
            return Publicacion.EliminarPublicacion(idPublicacion);
        }

        public Publicacion ObtenerPublicacionPorId(string idPublicacion)
        {
            return Publicacion.ObtenerPublicacionPorId(idPublicacion);
        }

        public List<Publicacion> ListPublicaciones()
        {
            return Publicacion.ListPublicaciones();
        }
    }
}
