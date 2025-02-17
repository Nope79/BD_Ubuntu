namespace Proyecto_1
{
    partial class f_menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_area = new System.Windows.Forms.Button();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(174, 204);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(141, 54);
            this.btn_inventario.TabIndex = 1;
            this.btn_inventario.Text = "INVENTARIO";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_area
            // 
            this.btn_area.Location = new System.Drawing.Point(471, 205);
            this.btn_area.Name = "btn_area";
            this.btn_area.Size = new System.Drawing.Size(141, 53);
            this.btn_area.TabIndex = 2;
            this.btn_area.Text = "ÁREA";
            this.btn_area.UseVisualStyleBackColor = true;
            this.btn_area.Click += new System.EventHandler(this.btn_area_Click);
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.Location = new System.Drawing.Point(326, 79);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(142, 16);
            this.lbl_presentacion.TabIndex = 2;
            this.lbl_presentacion.Text = "Bienvenido al sistema!";
            this.lbl_presentacion.Click += new System.EventHandler(this.lbl_presentacion_Click);
            // 
            // f_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.btn_area);
            this.Controls.Add(this.btn_inventario);
            this.Name = "f_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Label lbl_presentacion;
    }
}

