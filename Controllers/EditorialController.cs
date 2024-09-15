using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Controllers
{
    internal class EditorialController
    {
        public Editorial InsertarEditorial(Editorial editorial)
        {
            return Editorial.InsertarEditorial(editorial);
        }

        public string ActualizarEditorial(Editorial editorial)
        {
            return Editorial.ActualizarEditorial(editorial);
        }

        public string EliminarEditorial(string idEditorial)
        {
            return Editorial.EliminarEditorial(idEditorial);
        }

        public Editorial ObtenerEditorialPorId(string idEditorial)
        {
            return Editorial.ObtenerEditorialPorId(idEditorial);
        }

        public List<Editorial> ListEditoriales()
        {
            return Editorial.ListEditoriales();
        }
    }
}
