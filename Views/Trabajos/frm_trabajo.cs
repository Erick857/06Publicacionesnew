using _06Publicaciones.config;
using _06Publicaciones.Models;
using System;
using System.Windows.Forms;

namespace _06Publicaciones.Views.Trabajos
{
    public partial class frm_trabajo : Form
    {
        public frm_trabajo()
        {
            InitializeComponent();
        }

        private void frm_trabajo_Load(object sender, EventArgs e)
        {
            CargaTrabajos();
        }

        public void CargaTrabajos()
        {
            var listaTrabajos = Trabajo.ListTrabajos();
            lst_Trabajos.DataSource = null;
            lst_Trabajos.DataSource = listaTrabajos;
            lst_Trabajos.DisplayMember = "Descripcion";
            lst_Trabajos.ValueMember = "IdTrabajo";
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
        private void btn_guardar_trabajo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarTextBox(txt_descripcion_trabajo) && !ValidarNumericBox(num_max_nivel, num_min_nivel))
                {
                    return;
                }

                var trabajo = new Trabajo
                {
                    Descripcion = txt_descripcion_trabajo.Text,
                    MinLevel = Convert.ToInt32(num_min_nivel.Value),
                    MaxLevel = Convert.ToInt32(num_max_nivel.Value),
                };

                var trabajo_guardado = Trabajo.InsertarTrabajo(trabajo);
                if (trabajo_guardado != null)
                {
                    ErrorHandler.ManejarInsertar();
                }
                else
                {
                    CargaTrabajos();
                    MessageBox.Show("Se guardo el trabajo con exito");
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "");
            }

        }

        private void btn_limpiar_trabajo_Click(object sender, EventArgs e)
        {
            txt_descripcion_trabajo.Clear();
            num_max_nivel.Value = num_max_nivel.Minimum;
            num_min_nivel.Value = num_min_nivel.Minimum;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar el trabajo?", "Formulario de trabajos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var trabajo = Trabajo.EliminarTrabajo(lst_Trabajos.SelectedValue.ToString());
                if (lst_Trabajos.SelectedItem == null)
                {
                    ErrorHandler.ManejarEliminar();
                }
                else
                {
                    MessageBox.Show("El trabajo se elimino con exito");
                    CargaTrabajos();
                }
            }
            else {
                MessageBox.Show("El usuario cancelo la operacion");
            }
        }

        private void lst_Trabajos_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Trabajos.SelectedValue != null)
            {
                var trabajo = Trabajo.ObtenerTrabajoPorId(lst_Trabajos.SelectedValue.ToString());
                txt_descripcion_trabajo.Text = trabajo.Descripcion;
                num_max_nivel.Value = trabajo.MaxLevel;
                num_min_nivel.Value = trabajo.MinLevel;
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un item de la lista");
            }

        }
    }
}
