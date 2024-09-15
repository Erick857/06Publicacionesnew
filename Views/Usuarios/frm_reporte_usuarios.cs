using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06Publicaciones.Controllers;
using _06Publicaciones.Models;
using Microsoft.Reporting.WinForms;


namespace _06Publicaciones.Views.Usuarios
{
    public partial class frm_reporte_usuarios : Form
    {
        UsuariosController usuariosController = new UsuariosController();
        public frm_reporte_usuarios()
        {
            InitializeComponent();
        }

        private void frm_reporte_usuarios_Load(object sender, EventArgs e)
        {
            /*List <UsuariosModel> usuarios = new List<UsuariosModel>();
            ReportDataSource fuentedatos = new ReportDataSource();
            reportViewer1.LocalReport.DataSources.Clear(f);
            reportViewer1.LocalReport.DataSources.Add(fuentedatos);*/           
            this.usuarioTableAdapter.Fill(this.ds1.usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
