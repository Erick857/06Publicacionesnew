using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Controllers
{
    internal class VentaControllers
    {
        public Venta InsertarTrabajo(Venta venta)
        {
            return Venta.InsertarVenta(venta);
        }

        public string ActualizarTrabajo(Venta venta)
        {
            return Venta.ActualizarVenta(venta);
        }

        public string EliminarTrabajo(string numeroOrden)
        {
            return Venta.EliminarVenta(numeroOrden);
        }

        public Venta ObtenerTrabajoPorId(string numeroOrden)
        {
            return Venta.ObtenerVentaPorId(numeroOrden);
        }

        public List<Venta> ListVentas()
        {
            return Venta.ListVentas();
        }
    }
}
