namespace _06Publicaciones.Views.Tiendas
{
    partial class frm_tiendas
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
            this.txt_cpostal_tienda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Tiendas = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_guardar_tienda = new System.Windows.Forms.Button();
            this.btn_limpiar_tienda = new System.Windows.Forms.Button();
            this.txt_direccion_tienda = new System.Windows.Forms.TextBox();
            this.txt_nombre_tienda = new System.Windows.Forms.TextBox();
            this.txt_id_tienda = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelIdAutor = new System.Windows.Forms.Label();
            this.txt_ciudad_tienda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_estado_tienda = new System.Windows.Forms.TextBox();
            this.btn_eliminar_tienda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cpostal_tienda
            // 
            this.txt_cpostal_tienda.Location = new System.Drawing.Point(184, 335);
            this.txt_cpostal_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_cpostal_tienda.Name = "txt_cpostal_tienda";
            this.txt_cpostal_tienda.Size = new System.Drawing.Size(381, 22);
            this.txt_cpostal_tienda.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Codigo Postal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Lista de Tiendas";
            // 
            // lst_Tiendas
            // 
            this.lst_Tiendas.FormattingEnabled = true;
            this.lst_Tiendas.ItemHeight = 16;
            this.lst_Tiendas.Location = new System.Drawing.Point(657, 77);
            this.lst_Tiendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_Tiendas.Name = "lst_Tiendas";
            this.lst_Tiendas.Size = new System.Drawing.Size(567, 484);
            this.lst_Tiendas.TabIndex = 88;
            this.lst_Tiendas.SelectedIndexChanged += new System.EventHandler(this.lst_Tiendas_SelectedIndexChanged);
            this.lst_Tiendas.DoubleClick += new System.EventHandler(this.lst_Tiendas_DoubleClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(265, 28);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(125, 16);
            this.lbl_Titulo.TabIndex = 75;
            this.lbl_Titulo.Text = "Gestión de Tiendas";
            // 
            // btn_guardar_tienda
            // 
            this.btn_guardar_tienda.Location = new System.Drawing.Point(216, 379);
            this.btn_guardar_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_guardar_tienda.Name = "btn_guardar_tienda";
            this.btn_guardar_tienda.Size = new System.Drawing.Size(150, 61);
            this.btn_guardar_tienda.TabIndex = 86;
            this.btn_guardar_tienda.Text = "Guardar";
            this.btn_guardar_tienda.UseVisualStyleBackColor = true;
            this.btn_guardar_tienda.Click += new System.EventHandler(this.btn_guardar_tienda_Click);
            // 
            // btn_limpiar_tienda
            // 
            this.btn_limpiar_tienda.Location = new System.Drawing.Point(391, 379);
            this.btn_limpiar_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_limpiar_tienda.Name = "btn_limpiar_tienda";
            this.btn_limpiar_tienda.Size = new System.Drawing.Size(150, 61);
            this.btn_limpiar_tienda.TabIndex = 87;
            this.btn_limpiar_tienda.Text = "Limpiar";
            this.btn_limpiar_tienda.UseVisualStyleBackColor = true;
            this.btn_limpiar_tienda.Click += new System.EventHandler(this.btn_limpiar_tienda_Click);
            // 
            // txt_direccion_tienda
            // 
            this.txt_direccion_tienda.Location = new System.Drawing.Point(184, 202);
            this.txt_direccion_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_direccion_tienda.Name = "txt_direccion_tienda";
            this.txt_direccion_tienda.Size = new System.Drawing.Size(381, 22);
            this.txt_direccion_tienda.TabIndex = 85;
            // 
            // txt_nombre_tienda
            // 
            this.txt_nombre_tienda.Location = new System.Drawing.Point(184, 151);
            this.txt_nombre_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_nombre_tienda.Name = "txt_nombre_tienda";
            this.txt_nombre_tienda.Size = new System.Drawing.Size(381, 22);
            this.txt_nombre_tienda.TabIndex = 84;
            // 
            // txt_id_tienda
            // 
            this.txt_id_tienda.Location = new System.Drawing.Point(184, 100);
            this.txt_id_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_id_tienda.Name = "txt_id_tienda";
            this.txt_id_tienda.Size = new System.Drawing.Size(381, 22);
            this.txt_id_tienda.TabIndex = 83;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(52, 253);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(53, 16);
            this.labelTelefono.TabIndex = 78;
            this.labelTelefono.Text = "Ciudad:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(52, 205);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(67, 16);
            this.labelNombre.TabIndex = 77;
            this.labelNombre.Text = "Direccion:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(51, 154);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 16);
            this.labelApellido.TabIndex = 76;
            this.labelApellido.Text = "Nombre:";
            // 
            // labelIdAutor
            // 
            this.labelIdAutor.AutoSize = true;
            this.labelIdAutor.Location = new System.Drawing.Point(51, 103);
            this.labelIdAutor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIdAutor.Name = "labelIdAutor";
            this.labelIdAutor.Size = new System.Drawing.Size(69, 16);
            this.labelIdAutor.TabIndex = 74;
            this.labelIdAutor.Text = "ID Tienda:";
            // 
            // txt_ciudad_tienda
            // 
            this.txt_ciudad_tienda.Location = new System.Drawing.Point(184, 247);
            this.txt_ciudad_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_ciudad_tienda.Name = "txt_ciudad_tienda";
            this.txt_ciudad_tienda.Size = new System.Drawing.Size(381, 22);
            this.txt_ciudad_tienda.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Estado:";
            // 
            // txt_estado_tienda
            // 
            this.txt_estado_tienda.Location = new System.Drawing.Point(184, 292);
            this.txt_estado_tienda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_estado_tienda.Name = "txt_estado_tienda";
            this.txt_estado_tienda.Size = new System.Drawing.Size(381, 22);
            this.txt_estado_tienda.TabIndex = 101;
            // 
            // btn_eliminar_tienda
            // 
            this.btn_eliminar_tienda.Location = new System.Drawing.Point(1120, 569);
            this.btn_eliminar_tienda.Name = "btn_eliminar_tienda";
            this.btn_eliminar_tienda.Size = new System.Drawing.Size(104, 45);
            this.btn_eliminar_tienda.TabIndex = 102;
            this.btn_eliminar_tienda.Text = "Eliminar";
            this.btn_eliminar_tienda.UseVisualStyleBackColor = true;
            this.btn_eliminar_tienda.Click += new System.EventHandler(this.btn_eliminar_tienda_Click);
            // 
            // frm_tiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 626);
            this.Controls.Add(this.btn_eliminar_tienda);
            this.Controls.Add(this.txt_estado_tienda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ciudad_tienda);
            this.Controls.Add(this.txt_cpostal_tienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Tiendas);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_guardar_tienda);
            this.Controls.Add(this.btn_limpiar_tienda);
            this.Controls.Add(this.txt_direccion_tienda);
            this.Controls.Add(this.txt_nombre_tienda);
            this.Controls.Add(this.txt_id_tienda);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelIdAutor);
            this.Name = "frm_tiendas";
            this.Text = "frm_tiendas";
            this.Load += new System.EventHandler(this.frm_tiendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_cpostal_tienda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Tiendas;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_guardar_tienda;
        private System.Windows.Forms.Button btn_limpiar_tienda;
        private System.Windows.Forms.TextBox txt_direccion_tienda;
        private System.Windows.Forms.TextBox txt_nombre_tienda;
        private System.Windows.Forms.TextBox txt_id_tienda;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelIdAutor;
        private System.Windows.Forms.TextBox txt_ciudad_tienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_estado_tienda;
        private System.Windows.Forms.Button btn_eliminar_tienda;
    }
}