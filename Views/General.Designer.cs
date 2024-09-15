
namespace _06Publicaciones.Views
{
    partial class General
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.trabajosToolStripMenuItem,
            this.publicacionesToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.editorialesToolStripMenuItem,
            this.tiendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // trabajosToolStripMenuItem
            // 
            this.trabajosToolStripMenuItem.Name = "trabajosToolStripMenuItem";
            this.trabajosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trabajosToolStripMenuItem.Text = "Trabajos";
            this.trabajosToolStripMenuItem.Click += new System.EventHandler(this.trabajosToolStripMenuItem_Click);
            // 
            // publicacionesToolStripMenuItem
            // 
            this.publicacionesToolStripMenuItem.Name = "publicacionesToolStripMenuItem";
            this.publicacionesToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.publicacionesToolStripMenuItem.Text = "Publicaciones";
            this.publicacionesToolStripMenuItem.Click += new System.EventHandler(this.publicacionesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // editorialesToolStripMenuItem
            // 
            this.editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            this.editorialesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.editorialesToolStripMenuItem.Text = "Editoriales";
            this.editorialesToolStripMenuItem.Click += new System.EventHandler(this.editorialesToolStripMenuItem_Click);
            // 
            // tiendasToolStripMenuItem
            // 
            this.tiendasToolStripMenuItem.Name = "tiendasToolStripMenuItem";
            this.tiendasToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.tiendasToolStripMenuItem.Text = "Tiendas";
            this.tiendasToolStripMenuItem.Click += new System.EventHandler(this.tiendasToolStripMenuItem_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 690);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "General";
            this.Text = "General";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendasToolStripMenuItem;
    }
}