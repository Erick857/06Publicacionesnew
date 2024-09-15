
namespace _06Publicaciones.Views.Empleados
{
    partial class frm_empleados
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
            this.lst_Empleados = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_guardar_empleado = new System.Windows.Forms.Button();
            this.btn_limpiar_empleado = new System.Windows.Forms.Button();
            this.txt_apellido_empleado = new System.Windows.Forms.TextBox();
            this.txt_inicial_empleado = new System.Windows.Forms.TextBox();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelIdAutor = new System.Windows.Forms.Label();
            this.cb_trabajo_empleado = new System.Windows.Forms.ComboBox();
            this.cb_editorial_empleado = new System.Windows.Forms.ComboBox();
            this.dtp_fecha_inicio_empleado = new System.Windows.Forms.DateTimePicker();
            this.num_lvl_trabajo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl_trabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lista de Empleados";
            // 
            // lst_Empleados
            // 
            this.lst_Empleados.FormattingEnabled = true;
            this.lst_Empleados.ItemHeight = 22;
            this.lst_Empleados.Location = new System.Drawing.Point(624, 83);
            this.lst_Empleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_Empleados.Name = "lst_Empleados";
            this.lst_Empleados.Size = new System.Drawing.Size(567, 488);
            this.lst_Empleados.TabIndex = 39;
            this.lst_Empleados.SelectedIndexChanged += new System.EventHandler(this.lst_Autores_SelectedIndexChanged);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(232, 34);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(191, 22);
            this.lbl_Titulo.TabIndex = 21;
            this.lbl_Titulo.Text = "Gestión de Empleados";
            // 
            // btn_guardar_empleado
            // 
            this.btn_guardar_empleado.Location = new System.Drawing.Point(182, 559);
            this.btn_guardar_empleado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_guardar_empleado.Name = "btn_guardar_empleado";
            this.btn_guardar_empleado.Size = new System.Drawing.Size(150, 61);
            this.btn_guardar_empleado.TabIndex = 37;
            this.btn_guardar_empleado.Text = "Guardar";
            this.btn_guardar_empleado.UseVisualStyleBackColor = true;
            this.btn_guardar_empleado.Click += new System.EventHandler(this.btn_guardar_empleado_Click);
            // 
            // btn_limpiar_empleado
            // 
            this.btn_limpiar_empleado.Location = new System.Drawing.Point(357, 559);
            this.btn_limpiar_empleado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_limpiar_empleado.Name = "btn_limpiar_empleado";
            this.btn_limpiar_empleado.Size = new System.Drawing.Size(150, 61);
            this.btn_limpiar_empleado.TabIndex = 38;
            this.btn_limpiar_empleado.Text = "Limpiar";
            this.btn_limpiar_empleado.UseVisualStyleBackColor = true;
            // 
            // txt_apellido_empleado
            // 
            this.txt_apellido_empleado.Location = new System.Drawing.Point(151, 262);
            this.txt_apellido_empleado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_apellido_empleado.Name = "txt_apellido_empleado";
            this.txt_apellido_empleado.Size = new System.Drawing.Size(381, 28);
            this.txt_apellido_empleado.TabIndex = 32;
            // 
            // txt_inicial_empleado
            // 
            this.txt_inicial_empleado.Location = new System.Drawing.Point(151, 208);
            this.txt_inicial_empleado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_inicial_empleado.Name = "txt_inicial_empleado";
            this.txt_inicial_empleado.Size = new System.Drawing.Size(381, 28);
            this.txt_inicial_empleado.TabIndex = 31;
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Location = new System.Drawing.Point(151, 157);
            this.txt_nombre_empleado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(381, 28);
            this.txt_nombre_empleado.TabIndex = 30;
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Location = new System.Drawing.Point(151, 106);
            this.txt_id_empleado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(381, 28);
            this.txt_id_empleado.TabIndex = 29;
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(14, 479);
            this.labelCodigoPostal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(164, 22);
            this.labelCodigoPostal.TabIndex = 28;
            this.labelCodigoPostal.Text = "Fecha de Contrato:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(18, 420);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(80, 22);
            this.labelEstado.TabIndex = 27;
            this.labelEstado.Text = "Editorial:";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(19, 372);
            this.labelCiudad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(147, 22);
            this.labelCiudad.TabIndex = 26;
            this.labelCiudad.Text = "Nivel de Trabajo:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(19, 318);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(77, 22);
            this.labelDireccion.TabIndex = 25;
            this.labelDireccion.Text = "Trabajo:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(19, 268);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(79, 22);
            this.labelTelefono.TabIndex = 24;
            this.labelTelefono.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(18, 211);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(60, 22);
            this.labelNombre.TabIndex = 23;
            this.labelNombre.Text = "Inicial:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(19, 160);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(78, 22);
            this.labelApellido.TabIndex = 22;
            this.labelApellido.Text = "Nombre:";
            // 
            // labelIdAutor
            // 
            this.labelIdAutor.AutoSize = true;
            this.labelIdAutor.Location = new System.Drawing.Point(18, 109);
            this.labelIdAutor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIdAutor.Name = "labelIdAutor";
            this.labelIdAutor.Size = new System.Drawing.Size(117, 22);
            this.labelIdAutor.TabIndex = 20;
            this.labelIdAutor.Text = "ID Empleado:";
            // 
            // cb_trabajo_empleado
            // 
            this.cb_trabajo_empleado.FormattingEnabled = true;
            this.cb_trabajo_empleado.Location = new System.Drawing.Point(151, 315);
            this.cb_trabajo_empleado.Name = "cb_trabajo_empleado";
            this.cb_trabajo_empleado.Size = new System.Drawing.Size(381, 30);
            this.cb_trabajo_empleado.TabIndex = 41;
            // 
            // cb_editorial_empleado
            // 
            this.cb_editorial_empleado.FormattingEnabled = true;
            this.cb_editorial_empleado.Location = new System.Drawing.Point(151, 420);
            this.cb_editorial_empleado.Name = "cb_editorial_empleado";
            this.cb_editorial_empleado.Size = new System.Drawing.Size(381, 30);
            this.cb_editorial_empleado.TabIndex = 42;
            // 
            // dtp_fecha_inicio_empleado
            // 
            this.dtp_fecha_inicio_empleado.Location = new System.Drawing.Point(151, 479);
            this.dtp_fecha_inicio_empleado.Name = "dtp_fecha_inicio_empleado";
            this.dtp_fecha_inicio_empleado.Size = new System.Drawing.Size(381, 28);
            this.dtp_fecha_inicio_empleado.TabIndex = 43;
            // 
            // num_lvl_trabajo
            // 
            this.num_lvl_trabajo.Location = new System.Drawing.Point(151, 372);
            this.num_lvl_trabajo.Name = "num_lvl_trabajo";
            this.num_lvl_trabajo.Size = new System.Drawing.Size(381, 28);
            this.num_lvl_trabajo.TabIndex = 44;
            // 
            // frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 676);
            this.Controls.Add(this.num_lvl_trabajo);
            this.Controls.Add(this.dtp_fecha_inicio_empleado);
            this.Controls.Add(this.cb_editorial_empleado);
            this.Controls.Add(this.cb_trabajo_empleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Empleados);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_guardar_empleado);
            this.Controls.Add(this.btn_limpiar_empleado);
            this.Controls.Add(this.txt_apellido_empleado);
            this.Controls.Add(this.txt_inicial_empleado);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.labelCodigoPostal);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelIdAutor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frm_empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl_trabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Empleados;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_guardar_empleado;
        private System.Windows.Forms.Button btn_limpiar_empleado;
        private System.Windows.Forms.TextBox txt_apellido_empleado;
        private System.Windows.Forms.TextBox txt_inicial_empleado;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelIdAutor;
        private System.Windows.Forms.ComboBox cb_trabajo_empleado;
        private System.Windows.Forms.ComboBox cb_editorial_empleado;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio_empleado;
        private System.Windows.Forms.NumericUpDown num_lvl_trabajo;
    }
}