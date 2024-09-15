using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Controllers
{
    internal class TiendaController
    {
        public Tienda InsertarTienda(Tienda tienda)
        {
            return Tienda.InsertarTienda(tienda);
        }

        public string ActualizarTienda(Tienda tienda)
        {
            return Tienda.ActualizarTienda(tienda);
        }

        public string EliminarTienda(string idTienda)
        {
            return Tienda.EliminarTienda(idTienda);
        }

        public Tienda ObtenerTiendaPorId(string idTienda)
        {
            return Tienda.ObtenerTiendaPorId(idTienda);
        }

        public List<Tienda> ListTiendas()
        {
            return Tienda.ListTiendas();
        }
    }
}
