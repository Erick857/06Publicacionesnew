using _06Publicaciones.config;
using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Publicaciones.Views.Editoriales
{
    public partial class frm_editoriales : Form
    {
        public frm_editoriales()
        {
            InitializeComponent();
        }

        public void CargaEditoriales()
        {
            var listaEditoriales = Editorial.ListEditoriales();
            lst_Editoriales.DataSource = null;
            lst_Editoriales.DataSource = listaEditoriales;
            lst_Editoriales.DisplayMember = "Nombre";
            lst_Editoriales.ValueMember = "IdEditorial";
        }

        private bool ValidarTextBox(params TextBox[] cajadetexto)
        {
            foreach (var caja in cajadetexto)
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete la informacion");
                    return false;
                }
            }
            return true;
        }

        private void frm_editoriales_Load(object sender, EventArgs e)
        {
            CargaEditoriales();
        }

        private void lst_Trabajos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_editorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarTextBox(txt_id_editorial, txt_nombre_editorial, txt_ciudad_editorial, txt_estado_editorial, txt_pais_editorial))
                {
                    return;
                }

                var editorial = new Editorial
                {
                    IdEditorial = txt_id_editorial.Text,
                    Nombre = txt_nombre_editorial.Text,
                    Ciudad = txt_ciudad_editorial.Text,
                    Estado = txt_estado_editorial.Text,
                    Pais = txt_pais_editorial.Text,
                };

                var editorial_guardada = Editorial.InsertarEditorial(editorial);
                if (editorial_guardada != null)
                {
                    ErrorHandler.ManejarInsertar();
                }
                else
                {
                    CargaEditoriales();
                    MessageBox.Show("Se guardo la editorial con exito");
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "");
            }

        }
    }
}
