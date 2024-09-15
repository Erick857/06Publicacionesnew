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

namespace _06Publicaciones.Views.Publicaciones
{
    public partial class frm_publicaciones : Form
    {
        public frm_publicaciones()
        {
            InitializeComponent();
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

        private bool ValidarNumericBox(params NumericUpDown[] numericUpDowns)
        {
            foreach (var elemento in numericUpDowns)
            {
                if (string.IsNullOrWhiteSpace(elemento.Text))
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Ingrese los valores maximos y minimos");
                    return false;
                }
            }
            return true;
        }
        public void CargaPublicaciones()
        {
            var listaPublicaciones = Publicacion.ListPublicaciones();
            lst_Publicaciones.DataSource = null;
            lst_Publicaciones.DataSource = listaPublicaciones;
            lst_Publicaciones.DisplayMember = "Titulo";
            lst_Publicaciones.ValueMember = "IdPublicacion";
        }
        public void CargaEditoriales()
        {
            var listaEditoriales = Editorial.ListEditoriales();
            cb_editorial_publicacion.DataSource = null;
            cb_editorial_publicacion.DataSource = listaEditoriales;
            cb_editorial_publicacion.DisplayMember = "Nombre";
            cb_editorial_publicacion.ValueMember = "IdEditorial";
        }

        private void frm_publicaciones_Load(object sender, EventArgs e)
        {
            CargaPublicaciones();
            CargaEditoriales();
        }

        private void btn_guardar_publicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarTextBox(txt_id_publicacion, txt_titulo, txt_genero, txt_notas) && !ValidarNumericBox(num_avance, num_precio, num_ventas_anuales, num_regalias))
                {
                    return;
                }

                var publicacion = new Publicacion
                {
                    IdPublicacion = txt_id_publicacion.Text,
                    Titulo = txt_titulo.Text,
                    Genero = txt_genero.Text,
                    IdEditorial = Convert.ToInt32(cb_editorial_publicacion.SelectedValue),
                    Precio = Convert.ToDecimal(num_precio.Value),
                    Avance = Convert.ToDecimal(num_avance.Value),
                    Regalias = Convert.ToInt32(num_regalias.Value),
                    VentasAnuales = Convert.ToInt32(num_ventas_anuales.Value),
                    Notas = txt_notas.Text,
                    FechaPublicacion = Convert.ToDateTime(dtp_fecha_publicacion.Value),
                };

                var publicacion_guardada = Publicacion.InsertarPublicacion(publicacion);
                if (publicacion_guardada != null)
                {
                    ErrorHandler.ManejarInsertar();
                }
                else
                {
                    CargaPublicaciones();
                    MessageBox.Show("Se guardo la publicacion con exito");
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "");
            }

        }

        private void btn_eliminar_publicaciones_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar la publicacion?", "Formulario de publicaciones", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var publicacion = Publicacion.EliminarPublicacion(lst_Publicaciones.SelectedValue.ToString());
                if (lst_Publicaciones.SelectedItem == null)
                {
                    ErrorHandler.ManejarEliminar();
                }
                else
                {
                    MessageBox.Show("La tienda se elimino con exito");
                    CargaPublicaciones();
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la operacion");
            }
        }

        private void lst_Publicaciones_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Publicaciones.SelectedValue != null)
            {
                var publicacion = Publicacion.ObtenerPublicacionPorId(lst_Publicaciones.SelectedValue.ToString());
                txt_id_publicacion.Text = publicacion.IdPublicacion;
                txt_titulo.Text = publicacion.Titulo;
                txt_genero.Text = publicacion.Genero;
                cb_editorial_publicacion.SelectedValue = publicacion.IdEditorial;
                num_precio.Value = Convert.ToDecimal(publicacion.Precio);
                num_avance.Value = Convert.ToDecimal(publicacion.Avance);
                num_regalias.Value = Convert.ToInt32(publicacion.Regalias);
                num_ventas_anuales.Value = Convert.ToInt32(publicacion.VentasAnuales);
                txt_notas.Text = publicacion.Notas;
                dtp_fecha_publicacion.Value = Convert.ToDateTime(publicacion.FechaPublicacion);
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un item de la lista");
            }
        }
    }
}
