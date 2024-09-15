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

namespace _06Publicaciones.Views.Empleados
{
    public partial class frm_empleados : Form
    {
        public frm_empleados()
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

        public void CargaEmpleados()
        {
            var listaEmpleados = Empleado.ListEmpleados();
            lst_Empleados.DataSource = null;
            lst_Empleados.DataSource = listaEmpleados;
            lst_Empleados.DisplayMember = "NombreCompleto";
            lst_Empleados.ValueMember = "IdEmpleado";
        }

        private void CargarJobsBox()
        {
            var jobs = Trabajo.ListTrabajos();
            cb_trabajo_empleado.DataSource = jobs;
            cb_trabajo_empleado.DisplayMember = "Descripcion";
            cb_trabajo_empleado.ValueMember = "IdTrabajo";
        }

        public void CargaEditoriales()
        {
            var listaEditoriales = Editorial.ListEditoriales();
            cb_editorial_empleado.DataSource = null;
            cb_editorial_empleado.DataSource = listaEditoriales;
            cb_editorial_empleado.DisplayMember = "Nombre";
            cb_editorial_empleado.ValueMember = "IdEditorial";
        }

        private void lst_Autores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_empleados_Load(object sender, EventArgs e)
        {
            CargaEmpleados();
            CargarJobsBox();
            CargaEditoriales();
        }

        private void btn_guardar_empleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarTextBox(txt_id_empleado, txt_nombre_empleado, txt_inicial_empleado, txt_apellido_empleado) && !ValidarNumericBox(num_lvl_trabajo))
                {
                    return;
                }

                var empleado = new Empleado
                {
                    IdEmpleado = txt_id_empleado.Text,
                    Nombre = txt_nombre_empleado.Text,
                    Inicial = txt_inicial_empleado.Text,
                    Apellido = txt_apellido_empleado.Text,
                    JobId = Convert.ToInt32(cb_trabajo_empleado.SelectedValue),
                    JobLevel = Convert.ToInt32(num_lvl_trabajo.Value),
                    EditorialId = Convert.ToInt32(cb_editorial_empleado.SelectedValue),
                    FechaContratacion = dtp_fecha_inicio_empleado.Value,
                };

                var empleado_guardado = Empleado.InsertarEmpleado(empleado);
                if (empleado_guardado != null)
                {
                    ErrorHandler.ManejarInsertar();
                }
                else
                {
                    CargaEmpleados();
                    MessageBox.Show("Se guardo el empleado con exito");
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
