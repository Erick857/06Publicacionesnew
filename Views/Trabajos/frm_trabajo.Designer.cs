
namespace _06Publicaciones.Views.Trabajos
{
    partial class frm_trabajo
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
            this.lst_Trabajos = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_guardar_trabajo = new System.Windows.Forms.Button();
            this.btn_limpiar_trabajo = new System.Windows.Forms.Button();
            this.txt_descripcion_trabajo = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelIdAutor = new System.Windows.Forms.Label();
            this.num_max_nivel = new System.Windows.Forms.NumericUpDown();
            this.num_min_nivel = new System.Windows.Forms.NumericUpDown();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_max_nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Lista de Trabajos";
            // 
            // lst_Trabajos
            // 
            this.lst_Trabajos.FormattingEnabled = true;
            this.lst_Trabajos.ItemHeight = 20;
            this.lst_Trabajos.Location = new System.Drawing.Point(711, 58);
            this.lst_Trabajos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Trabajos.Name = "lst_Trabajos";
            this.lst_Trabajos.Size = new System.Drawing.Size(452, 444);
            this.lst_Trabajos.TabIndex = 60;
            this.lst_Trabajos.DoubleClick += new System.EventHandler(this.lst_Trabajos_DoubleClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(295, 24);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(160, 20);
            this.lbl_Titulo.TabIndex = 45;
            this.lbl_Titulo.Text = "Gestión de Trabajos";
            // 
            // btn_guardar_trabajo
            // 
            this.btn_guardar_trabajo.Location = new System.Drawing.Point(230, 301);
            this.btn_guardar_trabajo.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_guardar_trabajo.Name = "btn_guardar_trabajo";
            this.btn_guardar_trabajo.Size = new System.Drawing.Size(156, 37);
            this.btn_guardar_trabajo.TabIndex = 58;
            this.btn_guardar_trabajo.Text = "Guardar";
            this.btn_guardar_trabajo.UseVisualStyleBackColor = true;
            this.btn_guardar_trabajo.Click += new System.EventHandler(this.btn_guardar_trabajo_Click);
            // 
            // btn_limpiar_trabajo
            // 
            this.btn_limpiar_trabajo.Location = new System.Drawing.Point(449, 301);
            this.btn_limpiar_trabajo.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_limpiar_trabajo.Name = "btn_limpiar_trabajo";
            this.btn_limpiar_trabajo.Size = new System.Drawing.Size(156, 37);
            this.btn_limpiar_trabajo.TabIndex = 59;
            this.btn_limpiar_trabajo.Text = "Limpiar";
            this.btn_limpiar_trabajo.UseVisualStyleBackColor = true;
            this.btn_limpiar_trabajo.Click += new System.EventHandler(this.btn_limpiar_trabajo_Click);
            // 
            // txt_descripcion_trabajo
            // 
            this.txt_descripcion_trabajo.Location = new System.Drawing.Point(194, 114);
            this.txt_descripcion_trabajo.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_descripcion_trabajo.Name = "txt_descripcion_trabajo";
            this.txt_descripcion_trabajo.Size = new System.Drawing.Size(444, 27);
            this.txt_descripcion_trabajo.TabIndex = 53;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(28, 245);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(110, 20);
            this.labelNombre.TabIndex = 47;
            this.labelNombre.Text = "Nivel Minimo:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(29, 181);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(114, 20);
            this.labelApellido.TabIndex = 46;
            this.labelApellido.Text = "Nivel Maximo:";
            // 
            // labelIdAutor
            // 
            this.labelIdAutor.AutoSize = true;
            this.labelIdAutor.Location = new System.Drawing.Point(28, 117);
            this.labelIdAutor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIdAutor.Name = "labelIdAutor";
            this.labelIdAutor.Size = new System.Drawing.Size(104, 20);
            this.labelIdAutor.TabIndex = 44;
            this.labelIdAutor.Text = "Descripcion:";
            // 
            // num_max_nivel
            // 
            this.num_max_nivel.Location = new System.Drawing.Point(194, 174);
            this.num_max_nivel.Name = "num_max_nivel";
            this.num_max_nivel.Size = new System.Drawing.Size(444, 27);
            this.num_max_nivel.TabIndex = 62;
            // 
            // num_min_nivel
            // 
            this.num_min_nivel.Location = new System.Drawing.Point(194, 238);
            this.num_min_nivel.Name = "num_min_nivel";
            this.num_min_nivel.Size = new System.Drawing.Size(444, 27);
            this.num_min_nivel.TabIndex = 63;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(1054, 510);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(109, 46);
            this.btn_eliminar.TabIndex = 64;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // frm_trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 585);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.num_min_nivel);
            this.Controls.Add(this.num_max_nivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Trabajos);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_guardar_trabajo);
            this.Controls.Add(this.btn_limpiar_trabajo);
            this.Controls.Add(this.txt_descripcion_trabajo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelIdAutor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_trabajo";
            this.Text = "frm_trabajo";
            this.Load += new System.EventHandler(this.frm_trabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_max_nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Trabajos;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_guardar_trabajo;
        private System.Windows.Forms.Button btn_limpiar_trabajo;
        private System.Windows.Forms.TextBox txt_descripcion_trabajo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelIdAutor;
        private System.Windows.Forms.NumericUpDown num_max_nivel;
        private System.Windows.Forms.NumericUpDown num_min_nivel;
        private System.Windows.Forms.Button btn_eliminar;
    }
}