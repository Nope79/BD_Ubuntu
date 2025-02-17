namespace Proyecto_1.FrontEnd.Area
{
    partial class f_crear_actualizar_area
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_area_nombre = new System.Windows.Forms.Label();
            this.lbl_area_ubicacion = new System.Windows.Forms.Label();
            this.tbx_area_nombre = new System.Windows.Forms.TextBox();
            this.tbx_area_ubicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 279);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(93, 23);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(207, 229);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 35);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_area_nombre
            // 
            this.lbl_area_nombre.AutoSize = true;
            this.lbl_area_nombre.Location = new System.Drawing.Point(50, 66);
            this.lbl_area_nombre.Name = "lbl_area_nombre";
            this.lbl_area_nombre.Size = new System.Drawing.Size(66, 16);
            this.lbl_area_nombre.TabIndex = 7;
            this.lbl_area_nombre.Text = "NOMBRE";
            // 
            // lbl_area_ubicacion
            // 
            this.lbl_area_ubicacion.AutoSize = true;
            this.lbl_area_ubicacion.Location = new System.Drawing.Point(49, 157);
            this.lbl_area_ubicacion.Name = "lbl_area_ubicacion";
            this.lbl_area_ubicacion.Size = new System.Drawing.Size(79, 16);
            this.lbl_area_ubicacion.TabIndex = 8;
            this.lbl_area_ubicacion.Text = "UBICACIÓN";
            // 
            // tbx_area_nombre
            // 
            this.tbx_area_nombre.Location = new System.Drawing.Point(150, 60);
            this.tbx_area_nombre.MaxLength = 45;
            this.tbx_area_nombre.Name = "tbx_area_nombre";
            this.tbx_area_nombre.Size = new System.Drawing.Size(147, 22);
            this.tbx_area_nombre.TabIndex = 2;
            // 
            // tbx_area_ubicacion
            // 
            this.tbx_area_ubicacion.Location = new System.Drawing.Point(150, 151);
            this.tbx_area_ubicacion.MaxLength = 45;
            this.tbx_area_ubicacion.Name = "tbx_area_ubicacion";
            this.tbx_area_ubicacion.Size = new System.Drawing.Size(147, 22);
            this.tbx_area_ubicacion.TabIndex = 3;
            // 
            // f_crear_actualizar_area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 311);
            this.Controls.Add(this.tbx_area_ubicacion);
            this.Controls.Add(this.tbx_area_nombre);
            this.Controls.Add(this.lbl_area_ubicacion);
            this.Controls.Add(this.lbl_area_nombre);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_regresar);
            this.Name = "f_crear_actualizar_area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área en proceso";
            this.Load += new System.EventHandler(this.f_crear_actualizar_area_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_area_nombre;
        private System.Windows.Forms.Label lbl_area_ubicacion;
        private System.Windows.Forms.TextBox tbx_area_nombre;
        private System.Windows.Forms.TextBox tbx_area_ubicacion;
    }
}