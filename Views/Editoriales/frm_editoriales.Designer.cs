namespace _06Publicaciones.Views.Editoriales
{
    partial class frm_editoriales
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
            this.btn_eliminar_editorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Editoriales = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_guardar_editorial = new System.Windows.Forms.Button();
            this.btn_limpiar_editorial = new System.Windows.Forms.Button();
            this.txt_id_editorial = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelIdAutor = new System.Windows.Forms.Label();
            this.txt_nombre_editorial = new System.Windows.Forms.TextBox();
            this.txt_ciudad_editorial = new System.Windows.Forms.TextBox();
            this.txt_estado_editorial = new System.Windows.Forms.TextBox();
            this.txt_pais_editorial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_eliminar_editorial
            // 
            this.btn_eliminar_editorial.Location = new System.Drawing.Point(1024, 513);
            this.btn_eliminar_editorial.Name = "btn_eliminar_editorial";
            this.btn_eliminar_editorial.Size = new System.Drawing.Size(109, 46);
            this.btn_eliminar_editorial.TabIndex = 76;
            this.btn_eliminar_editorial.Text = "Eliminar";
            this.btn_eliminar_editorial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Lista de Editoriales";
            // 
            // lst_Editoriales
            // 
            this.lst_Editoriales.FormattingEnabled = true;
            this.lst_Editoriales.ItemHeight = 16;
            this.lst_Editoriales.Location = new System.Drawing.Point(681, 69);
            this.lst_Editoriales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Editoriales.Name = "lst_Editoriales";
            this.lst_Editoriales.Size = new System.Drawing.Size(452, 436);
            this.lst_Editoriales.TabIndex = 72;
            this.lst_Editoriales.SelectedIndexChanged += new System.EventHandler(this.lst_Trabajos_SelectedIndexChanged);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(278, 26);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(196, 20);
            this.lbl_Titulo.TabIndex = 66;
            this.lbl_Titulo.Text = "Gestión de Editoriales";
            // 
            // btn_guardar_editorial
            // 
            this.btn_guardar_editorial.Location = new System.Drawing.Point(225, 446);
            this.btn_guardar_editorial.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_guardar_editorial.Name = "btn_guardar_editorial";
            this.btn_guardar_editorial.Size = new System.Drawing.Size(156, 37);
            this.btn_guardar_editorial.TabIndex = 70;
            this.btn_guardar_editorial.Text = "Guardar";
            this.btn_guardar_editorial.UseVisualStyleBackColor = true;
            this.btn_guardar_editorial.Click += new System.EventHandler(this.btn_guardar_editorial_Click);
            // 
            // btn_limpiar_editorial
            // 
            this.btn_limpiar_editorial.Location = new System.Drawing.Point(444, 446);
            this.btn_limpiar_editorial.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_limpiar_editorial.Name = "btn_limpiar_editorial";
            this.btn_limpiar_editorial.Size = new System.Drawing.Size(156, 37);
            this.btn_limpiar_editorial.TabIndex = 71;
            this.btn_limpiar_editorial.Text = "Limpiar";
            this.btn_limpiar_editorial.UseVisualStyleBackColor = true;
            // 
            // txt_id_editorial
            // 
            this.txt_id_editorial.Location = new System.Drawing.Point(188, 105);
            this.txt_id_editorial.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_id_editorial.Name = "txt_id_editorial";
            this.txt_id_editorial.Size = new System.Drawing.Size(444, 22);
            this.txt_id_editorial.TabIndex = 69;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(22, 236);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(53, 16);
            this.labelNombre.TabIndex = 68;
            this.labelNombre.Text = "Ciudad:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(23, 172);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 16);
            this.labelApellido.TabIndex = 67;
            this.labelApellido.Text = "Nombre:";
            // 
            // labelIdAutor
            // 
            this.labelIdAutor.AutoSize = true;
            this.labelIdAutor.Location = new System.Drawing.Point(22, 108);
            this.labelIdAutor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIdAutor.Name = "labelIdAutor";
            this.labelIdAutor.Size = new System.Drawing.Size(73, 16);
            this.labelIdAutor.TabIndex = 65;
            this.labelIdAutor.Text = "Id Editorial:";
            // 
            // txt_nombre_editorial
            // 
            this.txt_nombre_editorial.Location = new System.Drawing.Point(188, 165);
            this.txt_nombre_editorial.Name = "txt_nombre_editorial";
            this.txt_nombre_editorial.Size = new System.Drawing.Size(444, 22);
            this.txt_nombre_editorial.TabIndex = 77;
            // 
            // txt_ciudad_editorial
            // 
            this.txt_ciudad_editorial.Location = new System.Drawing.Point(188, 230);
            this.txt_ciudad_editorial.Name = "txt_ciudad_editorial";
            this.txt_ciudad_editorial.Size = new System.Drawing.Size(444, 22);
            this.txt_ciudad_editorial.TabIndex = 78;
            // 
            // txt_estado_editorial
            // 
            this.txt_estado_editorial.Location = new System.Drawing.Point(188, 290);
            this.txt_estado_editorial.Name = "txt_estado_editorial";
            this.txt_estado_editorial.Size = new System.Drawing.Size(444, 22);
            this.txt_estado_editorial.TabIndex = 79;
            // 
            // txt_pais_editorial
            // 
            this.txt_pais_editorial.Location = new System.Drawing.Point(188, 356);
            this.txt_pais_editorial.Name = "txt_pais_editorial";
            this.txt_pais_editorial.Size = new System.Drawing.Size(444, 22);
            this.txt_pais_editorial.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Pais:";
            // 
            // frm_editoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pais_editorial);
            this.Controls.Add(this.txt_estado_editorial);
            this.Controls.Add(this.txt_ciudad_editorial);
            this.Controls.Add(this.txt_nombre_editorial);
            this.Controls.Add(this.btn_eliminar_editorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Editoriales);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_guardar_editorial);
            this.Controls.Add(this.btn_limpiar_editorial);
            this.Controls.Add(this.txt_id_editorial);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelIdAutor);
            this.Name = "frm_editoriales";
            this.Text = "frm_editoriales";
            this.Load += new System.EventHandler(this.frm_editoriales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar_editorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Editoriales;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_guardar_editorial;
        private System.Windows.Forms.Button btn_limpiar_editorial;
        private System.Windows.Forms.TextBox txt_id_editorial;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelIdAutor;
        private System.Windows.Forms.TextBox txt_nombre_editorial;
        private System.Windows.Forms.TextBox txt_ciudad_editorial;
        private System.Windows.Forms.TextBox txt_estado_editorial;
        private System.Windows.Forms.TextBox txt_pais_editorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}