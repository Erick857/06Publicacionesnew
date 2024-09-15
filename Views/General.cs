using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.Views.Empleados;
using _06Publicaciones.Views.Autores;
using _06Publicaciones.Views.Trabajos;
using _06Publicaciones.Views.Publicaciones;
using _06Publicaciones.Views.Ventas;
using _06Publicaciones.Views.Editoriales;
using _06Publicaciones.Views.Tiendas;


namespace _06Publicaciones.Views
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empleados _Empleados = new frm_empleados();
            _Empleados.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Autores _Autores = new frm_Autores();
            _Autores.ShowDialog();

        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_trabajo _Trabajo = new frm_trabajo();
            _Trabajo.ShowDialog();

        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_editoriales _Editoriales = new frm_editoriales();
            _Editoriales.ShowDialog();
        }

        private void publicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_publicaciones _Publicaciones = new frm_publicaciones();
            _Publicaciones.ShowDialog();
        }

        private void tiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tiendas _Tiendas = new frm_tiendas();
            _Tiendas.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ventas _Ventas = new frm_ventas();
            _Ventas.ShowDialog();
        }
    }
}
