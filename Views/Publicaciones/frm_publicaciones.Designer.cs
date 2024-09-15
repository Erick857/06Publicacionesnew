
namespace _06Publicaciones.Views.Publicaciones
{
    partial class frm_publicaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num_avance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Publicaciones = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_guardar_publicacion = new System.Windows.Forms.Button();
            this.btn_limpiar_publicacion = new System.Windows.Forms.Button();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_id_publicacion = new System.Windows.Forms.TextBox();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelIdAutor = new System.Windows.Forms.Label();
            this.cb_editorial_publicacion = new System.Windows.Forms.ComboBox();
            this.num_precio = new System.Windows.Forms.NumericUpDown();
            this.num_regalias = new System.Windows.Forms.NumericUpDown();
            this.num_ventas_anuales = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_notas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha_publicacion = new System.Windows.Forms.DateTimePicker();
            this.btn_eliminar_publicaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_avance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_regalias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ventas_anuales)).BeginInit();
            this.SuspendLayout();
            // 
            // num_avance
            // 
            this.num_avance.Location = new System.Drawing.Point(163, 346);
            this.num_avance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_avance.Name = "num_avance";
            this.num_avance.Size = new System.Drawing.Size(381, 22);
            this.num_avance.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Lista de Publicaciones";
            // 
            // lst_Publicaciones
            // 
            this.lst_Publicaciones.FormattingEnabled = true;
            this.lst_Publicaciones.ItemHeight = 16;
            this.lst_Publicaciones.Location = new System.Drawing.Point(636, 72);
            this.lst_Publicaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_Publicaciones.Name = "lst_Publicaciones";
            this.lst_Publicaciones.Size = new System.Drawing.Size(567, 484);
            this.lst_Publicaciones.TabIndex = 60;
            this.lst_Publicaciones.DoubleClick += new System.EventHandler(this.lst_Publicaciones_DoubleClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(244, 23);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(160, 16);
            this.lbl_Titulo.TabIndex = 46;
            this.lbl_Titulo.Text = "Gestión de Publicaciones";
            // 
            // btn_guardar_publicacion
            // 
            this.btn_guardar_publicacion.Location = new System.Drawing.Point(195, 591);
            this.btn_guardar_publicacion.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_guardar_publicacion.Name = "btn_guardar_publicacion";
            this.btn_guardar_publicacion.Size = new System.Drawing.Size(150, 61);
            this.btn_guardar_publicacion.TabIndex = 58;
            this.btn_guardar_publicacion.Text = "Guardar";
            this.btn_guardar_publicacion.UseVisualStyleBackColor = true;
            this.btn_guardar_publicacion.Click += new System.EventHandler(this.btn_guardar_publicacion_Click);
            // 
            // btn_limpiar_publicacion
            // 
            this.btn_limpiar_publicacion.Location = new System.Drawing.Point(370, 591);
            this.btn_limpiar_publicacion.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_limpiar_publicacion.Name = "btn_limpiar_publicacion";
            this.btn_limpiar_publicacion.Size = new System.Drawing.Size(150, 61);
            this.btn_limpiar_publicacion.TabIndex = 59;
            this.btn_limpiar_publicacion.Text = "Limpiar";
            this.btn_limpiar_publicacion.UseVisualStyleBackColor = true;
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(163, 197);
            this.txt_genero.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(381, 22);
            this.txt_genero.TabIndex = 56;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(163, 146);
            this.txt_titulo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(381, 22);
            this.txt_titulo.TabIndex = 55;
            // 
            // txt_id_publicacion
            // 
            this.txt_id_publicacion.Location = new System.Drawing.Point(163, 95);
            this.txt_id_publicacion.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_id_publicacion.Name = "txt_id_publicacion";
            this.txt_id_publicacion.Size = new System.Drawing.Size(381, 22);
            this.txt_id_publicacion.TabIndex = 54;
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(30, 442);
            this.labelCodigoPostal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(104, 16);
            this.labelCodigoPostal.TabIndex = 53;
            this.labelCodigoPostal.Text = "Ventas Anuales:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(30, 396);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(65, 16);
            this.labelEstado.TabIndex = 52;
            this.labelEstado.Text = "Regalias:";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(30, 352);
            this.labelCiudad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(56, 16);
            this.labelCiudad.TabIndex = 51;
            this.labelCiudad.Text = "Avance:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(31, 307);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(49, 16);
            this.labelDireccion.TabIndex = 50;
            this.labelDireccion.Text = "Precio:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(31, 257);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(59, 16);
            this.labelTelefono.TabIndex = 49;
            this.labelTelefono.Text = "Editorial:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(31, 200);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(55, 16);
            this.labelNombre.TabIndex = 48;
            this.labelNombre.Text = "Genero:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(30, 149);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(43, 16);
            this.labelApellido.TabIndex = 47;
            this.labelApellido.Text = "Titulo:";
            // 
            // labelIdAutor
            // 
            this.labelIdAutor.AutoSize = true;
            this.labelIdAutor.Location = new System.Drawing.Point(30, 98);
            this.labelIdAutor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIdAutor.Name = "labelIdAutor";
            this.labelIdAutor.Size = new System.Drawing.Size(96, 16);
            this.labelIdAutor.TabIndex = 45;
            this.labelIdAutor.Text = "ID Publicacion:";
            // 
            // cb_editorial_publicacion
            // 
            this.cb_editorial_publicacion.FormattingEnabled = true;
            this.cb_editorial_publicacion.Location = new System.Drawing.Point(163, 248);
            this.cb_editorial_publicacion.Name = "cb_editorial_publicacion";
            this.cb_editorial_publicacion.Size = new System.Drawing.Size(381, 24);
            this.cb_editorial_publicacion.TabIndex = 66;
            // 
            // num_precio
            // 
            this.num_precio.Location = new System.Drawing.Point(163, 300);
            this.num_precio.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_precio.Name = "num_precio";
            this.num_precio.Size = new System.Drawing.Size(381, 22);
            this.num_precio.TabIndex = 67;
            // 
            // num_regalias
            // 
            this.num_regalias.Location = new System.Drawing.Point(163, 390);
            this.num_regalias.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_regalias.Name = "num_regalias";
            this.num_regalias.Size = new System.Drawing.Size(381, 22);
            this.num_regalias.TabIndex = 68;
            // 
            // num_ventas_anuales
            // 
            this.num_ventas_anuales.Location = new System.Drawing.Point(163, 436);
            this.num_ventas_anuales.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_ventas_anuales.Name = "num_ventas_anuales";
            this.num_ventas_anuales.Size = new System.Drawing.Size(381, 22);
            this.num_ventas_anuales.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 491);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Notas:";
            // 
            // txt_notas
            // 
            this.txt_notas.Location = new System.Drawing.Point(160, 485);
            this.txt_notas.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_notas.Name = "txt_notas";
            this.txt_notas.Size = new System.Drawing.Size(381, 22);
            this.txt_notas.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 535);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Fecha publicacion:";
            // 
            // dtp_fecha_publicacion
            // 
            this.dtp_fecha_publicacion.Location = new System.Drawing.Point(160, 530);
            this.dtp_fecha_publicacion.Name = "dtp_fecha_publicacion";
            this.dtp_fecha_publicacion.Size = new System.Drawing.Size(384, 22);
            this.dtp_fecha_publicacion.TabIndex = 73;
            // 
            // btn_eliminar_publicaciones
            // 
            this.btn_eliminar_publicaciones.Location = new System.Drawing.Point(1088, 563);
            this.btn_eliminar_publicaciones.Name = "btn_eliminar_publicaciones";
            this.btn_eliminar_publicaciones.Size = new System.Drawing.Size(115, 51);
            this.btn_eliminar_publicaciones.TabIndex = 74;
            this.btn_eliminar_publicaciones.Text = "Eliminar";
            this.btn_eliminar_publicaciones.UseVisualStyleBackColor = true;
            this.btn_eliminar_publicaciones.Click += new System.EventHandler(this.btn_eliminar_publicaciones_Click);
            // 
            // frm_publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 668);
            this.Controls.Add(this.btn_eliminar_publicaciones);
            this.Controls.Add(this.dtp_fecha_publicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_notas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_ventas_anuales);
            this.Controls.Add(this.num_regalias);
            this.Controls.Add(this.num_precio);
            this.Controls.Add(this.cb_editorial_publicacion);
            this.Controls.Add(this.num_avance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Publicaciones);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_guardar_publicacion);
            this.Controls.Add(this.btn_limpiar_publicacion);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_id_publicacion);
            this.Controls.Add(this.labelCodigoPostal);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelIdAutor);
            this.Name = "frm_publicaciones";
            this.Text = "frm_publicaciones";
            this.Load += new System.EventHandler(this.frm_publicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_avance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_regalias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ventas_anuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_avance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Publicaciones;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_guardar_publicacion;
        private System.Windows.Forms.Button btn_limpiar_publicacion;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_id_publicacion;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelIdAutor;
        private System.Windows.Forms.ComboBox cb_editorial_publicacion;
        private System.Windows.Forms.NumericUpDown num_precio;
        private System.Windows.Forms.NumericUpDown num_regalias;
        private System.Windows.Forms.NumericUpDown num_ventas_anuales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_notas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha_publicacion;
        private System.Windows.Forms.Button btn_eliminar_publicaciones;
    }
}