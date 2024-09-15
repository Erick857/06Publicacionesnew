
namespace _06Publicaciones.Views.Ventas
{
    partial class frm_ventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Ventas = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_guardar_venta = new System.Windows.Forms.Button();
            this.btn_limpiar_venta = new System.Windows.Forms.Button();
            this.txt_numero_orden = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelIdAutor = new System.Windows.Forms.Label();
            this.cb_tienda_venta = new System.Windows.Forms.ComboBox();
            this.dtp_fecha_orden = new System.Windows.Forms.DateTimePicker();
            this.num_cantidad_venta = new System.Windows.Forms.NumericUpDown();
            this.txt_metodo_pago = new System.Windows.Forms.TextBox();
            this.cb_libro_venta = new System.Windows.Forms.ComboBox();
            this.btn_eliminar_venta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Lista de Ventas";
            // 
            // lst_Ventas
            // 
            this.lst_Ventas.FormattingEnabled = true;
            this.lst_Ventas.ItemHeight = 16;
            this.lst_Ventas.Location = new System.Drawing.Point(660, 71);
            this.lst_Ventas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_Ventas.Name = "lst_Ventas";
            this.lst_Ventas.Size = new System.Drawing.Size(567, 484);
            this.lst_Ventas.TabIndex = 88;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(303, 19);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(67, 20);
            this.lbl_Titulo.TabIndex = 75;
            this.lbl_Titulo.Text = "Ventas";
            // 
            // btn_guardar_venta
            // 
            this.btn_guardar_venta.Location = new System.Drawing.Point(214, 386);
            this.btn_guardar_venta.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_guardar_venta.Name = "btn_guardar_venta";
            this.btn_guardar_venta.Size = new System.Drawing.Size(150, 61);
            this.btn_guardar_venta.TabIndex = 86;
            this.btn_guardar_venta.Text = "Guardar";
            this.btn_guardar_venta.UseVisualStyleBackColor = true;
            this.btn_guardar_venta.Click += new System.EventHandler(this.btn_guardar_venta_Click);
            // 
            // btn_limpiar_venta
            // 
            this.btn_limpiar_venta.Location = new System.Drawing.Point(389, 386);
            this.btn_limpiar_venta.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_limpiar_venta.Name = "btn_limpiar_venta";
            this.btn_limpiar_venta.Size = new System.Drawing.Size(150, 61);
            this.btn_limpiar_venta.TabIndex = 87;
            this.btn_limpiar_venta.Text = "Limpiar";
            this.btn_limpiar_venta.UseVisualStyleBackColor = true;
            this.btn_limpiar_venta.Click += new System.EventHandler(this.btn_limpiar_venta_Click);
            // 
            // txt_numero_orden
            // 
            this.txt_numero_orden.Location = new System.Drawing.Point(187, 142);
            this.txt_numero_orden.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_numero_orden.Name = "txt_numero_orden";
            this.txt_numero_orden.Size = new System.Drawing.Size(381, 22);
            this.txt_numero_orden.TabIndex = 84;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(55, 339);
            this.labelCiudad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 16);
            this.labelCiudad.TabIndex = 80;
            this.labelCiudad.Text = "Libro:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(55, 290);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(110, 16);
            this.labelDireccion.TabIndex = 79;
            this.labelDireccion.Text = "Metodo de pago:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(55, 243);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(64, 16);
            this.labelTelefono.TabIndex = 78;
            this.labelTelefono.Text = "Cantidad:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(55, 199);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(107, 16);
            this.labelNombre.TabIndex = 77;
            this.labelNombre.Text = "Fecha de Orden:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(54, 148);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(117, 16);
            this.labelApellido.TabIndex = 76;
            this.labelApellido.Text = "Numero de Orden:";
            // 
            // labelIdAutor
            // 
            this.labelIdAutor.AutoSize = true;
            this.labelIdAutor.Location = new System.Drawing.Point(54, 97);
            this.labelIdAutor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIdAutor.Name = "labelIdAutor";
            this.labelIdAutor.Size = new System.Drawing.Size(50, 16);
            this.labelIdAutor.TabIndex = 74;
            this.labelIdAutor.Text = "Tienda";
            // 
            // cb_tienda_venta
            // 
            this.cb_tienda_venta.FormattingEnabled = true;
            this.cb_tienda_venta.Location = new System.Drawing.Point(187, 88);
            this.cb_tienda_venta.Name = "cb_tienda_venta";
            this.cb_tienda_venta.Size = new System.Drawing.Size(381, 24);
            this.cb_tienda_venta.TabIndex = 93;
            // 
            // dtp_fecha_orden
            // 
            this.dtp_fecha_orden.Location = new System.Drawing.Point(187, 192);
            this.dtp_fecha_orden.Name = "dtp_fecha_orden";
            this.dtp_fecha_orden.Size = new System.Drawing.Size(381, 22);
            this.dtp_fecha_orden.TabIndex = 94;
            // 
            // num_cantidad_venta
            // 
            this.num_cantidad_venta.Location = new System.Drawing.Point(187, 241);
            this.num_cantidad_venta.Name = "num_cantidad_venta";
            this.num_cantidad_venta.Size = new System.Drawing.Size(381, 22);
            this.num_cantidad_venta.TabIndex = 95;
            // 
            // txt_metodo_pago
            // 
            this.txt_metodo_pago.Location = new System.Drawing.Point(187, 287);
            this.txt_metodo_pago.Name = "txt_metodo_pago";
            this.txt_metodo_pago.Size = new System.Drawing.Size(381, 22);
            this.txt_metodo_pago.TabIndex = 96;
            // 
            // cb_libro_venta
            // 
            this.cb_libro_venta.FormattingEnabled = true;
            this.cb_libro_venta.Location = new System.Drawing.Point(187, 336);
            this.cb_libro_venta.Name = "cb_libro_venta";
            this.cb_libro_venta.Size = new System.Drawing.Size(381, 24);
            this.cb_libro_venta.TabIndex = 97;
            // 
            // btn_eliminar_venta
            // 
            this.btn_eliminar_venta.Location = new System.Drawing.Point(1113, 562);
            this.btn_eliminar_venta.Name = "btn_eliminar_venta";
            this.btn_eliminar_venta.Size = new System.Drawing.Size(114, 45);
            this.btn_eliminar_venta.TabIndex = 98;
            this.btn_eliminar_venta.Text = "Eliminar";
            this.btn_eliminar_venta.UseVisualStyleBackColor = true;
            this.btn_eliminar_venta.Click += new System.EventHandler(this.btn_eliminar_venta_Click);
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 637);
            this.Controls.Add(this.btn_eliminar_venta);
            this.Controls.Add(this.cb_libro_venta);
            this.Controls.Add(this.txt_metodo_pago);
            this.Controls.Add(this.num_cantidad_venta);
            this.Controls.Add(this.dtp_fecha_orden);
            this.Controls.Add(this.cb_tienda_venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Ventas);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_guardar_venta);
            this.Controls.Add(this.btn_limpiar_venta);
            this.Controls.Add(this.txt_numero_orden);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelIdAutor);
            this.Name = "frm_ventas";
            this.Text = "frm_ventas";
            this.Load += new System.EventHandler(this.frm_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Ventas;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_guardar_venta;
        private System.Windows.Forms.Button btn_limpiar_venta;
        private System.Windows.Forms.TextBox txt_numero_orden;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelIdAutor;
        private System.Windows.Forms.ComboBox cb_tienda_venta;
        private System.Windows.Forms.DateTimePicker dtp_fecha_orden;
        private System.Windows.Forms.NumericUpDown num_cantidad_venta;
        private System.Windows.Forms.TextBox txt_metodo_pago;
        private System.Windows.Forms.ComboBox cb_libro_venta;
        private System.Windows.Forms.Button btn_eliminar_venta;
    }
}