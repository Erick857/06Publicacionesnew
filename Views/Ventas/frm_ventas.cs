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

namespace _06Publicaciones.Views.Ventas
{
    public partial class frm_ventas : Form
    {
        public frm_ventas()
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

        private void LimpiarForm()
        {
            txt_numero_orden.Clear();
            txt_metodo_pago.Clear();
            num_cantidad_venta.Value = num_cantidad_venta.Minimum;
            cb_tienda_venta.SelectedIndex = -1;
            cb_libro_venta.SelectedIndex = -1;
        }

        public void CargaVentas()
        {
            var listaVentas = Venta.ListVentas();
            lst_Ventas.DataSource = null;
            lst_Ventas.DataSource = listaVentas;
            lst_Ventas.DisplayMember = "NombreListar";
            lst_Ventas.ValueMember = "NumeroOrden";
        }

        public void CargaPublicaciones()
        {
            var listaPublicaciones = Publicacion.ListPublicaciones();
            cb_libro_venta.DataSource = null;
            cb_libro_venta.DataSource = listaPublicaciones;
            cb_libro_venta.DisplayMember = "Titulo";
            cb_libro_venta.ValueMember = "IdPublicacion";
        }

        public void CargaTiendas()
        {
            var listaTiendas = Tienda.ListTiendas();
            cb_tienda_venta.DataSource = null;
            cb_tienda_venta.DataSource = listaTiendas;
            cb_tienda_venta.DisplayMember = "NombreTienda";
            cb_tienda_venta.ValueMember = "IdTienda";
        }

        private void frm_ventas_Load(object sender, EventArgs e)
        {
            CargaVentas();
            CargaPublicaciones();
            CargaTiendas();
        }

        private void btn_limpiar_venta_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btn_guardar_venta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarTextBox(txt_numero_orden, txt_metodo_pago) && !ValidarNumericBox(num_cantidad_venta))
                {
                    return;
                }

                var venta = new Venta
                {
                    IdTienda = cb_tienda_venta.SelectedValue.ToString(),
                    NumeroOrden = txt_numero_orden.Text,
                    FechaOrden = Convert.ToDateTime(dtp_fecha_orden.Value),
                    Cantidad = Convert.ToInt32(num_cantidad_venta.Value),
                    MetodoPago = txt_metodo_pago.Text,
                    IdPublicacion = cb_libro_venta.SelectedValue.ToString(),
                };

                var venta_guardada = Venta.InsertarVenta(venta);
                if (venta_guardada != null)
                {
                    ErrorHandler.ManejarInsertar();
                }
                else
                {
                    CargaVentas();
                    LimpiarForm();
                    MessageBox.Show("Se guardo el trabajo con exito");
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "");
            }

        }

        private void btn_eliminar_venta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar la venta?", "Formulario de ventas", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var venta = Venta.EliminarVenta(lst_Ventas.SelectedValue.ToString());
                if (lst_Ventas.SelectedItem == null)
                {
                    ErrorHandler.ManejarEliminar();
                }
                else
                {
                    MessageBox.Show("El trabajo se elimino con exito");
                    CargaVentas();
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la operacion");
            }
        }
    }
}
