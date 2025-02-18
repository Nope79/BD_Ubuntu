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
            this.lbl_area_nombre = new System.Windows.Forms.Label();
            this.lbl_area_ubicacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_area_ubicacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbx_area_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 276);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(93, 23);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_area_nombre
            // 
            this.lbl_area_nombre.AutoSize = true;
            this.lbl_area_nombre.Location = new System.Drawing.Point(19, 31);
            this.lbl_area_nombre.Name = "lbl_area_nombre";
            this.lbl_area_nombre.Size = new System.Drawing.Size(66, 16);
            this.lbl_area_nombre.TabIndex = 7;
            this.lbl_area_nombre.Text = "NOMBRE";
            // 
            // lbl_area_ubicacion
            // 
            this.lbl_area_ubicacion.AutoSize = true;
            this.lbl_area_ubicacion.Location = new System.Drawing.Point(6, 110);
            this.lbl_area_ubicacion.Name = "lbl_area_ubicacion";
            this.lbl_area_ubicacion.Size = new System.Drawing.Size(79, 16);
            this.lbl_area_ubicacion.TabIndex = 8;
            this.lbl_area_ubicacion.Text = "UBICACIÓN";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbx_area_ubicacion);
            this.panel1.Controls.Add(this.tbx_area_nombre);
            this.panel1.Controls.Add(this.lbl_area_ubicacion);
            this.panel1.Controls.Add(this.lbl_area_nombre);
            this.panel1.Location = new System.Drawing.Point(28, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 149);
            this.panel1.TabIndex = 9;
            // 
            // tbx_area_ubicacion
            // 
            this.tbx_area_ubicacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbx_area_ubicacion.Depth = 0;
            this.tbx_area_ubicacion.Hint = "";
            this.tbx_area_ubicacion.Location = new System.Drawing.Point(91, 102);
            this.tbx_area_ubicacion.MaxLength = 32767;
            this.tbx_area_ubicacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbx_area_ubicacion.Name = "tbx_area_ubicacion";
            this.tbx_area_ubicacion.PasswordChar = '\0';
            this.tbx_area_ubicacion.SelectedText = "";
            this.tbx_area_ubicacion.SelectionLength = 0;
            this.tbx_area_ubicacion.SelectionStart = 0;
            this.tbx_area_ubicacion.Size = new System.Drawing.Size(176, 28);
            this.tbx_area_ubicacion.TabIndex = 11;
            this.tbx_area_ubicacion.TabStop = false;
            this.tbx_area_ubicacion.UseSystemPasswordChar = false;
            // 
            // tbx_area_nombre
            // 
            this.tbx_area_nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbx_area_nombre.Depth = 0;
            this.tbx_area_nombre.Hint = "";
            this.tbx_area_nombre.Location = new System.Drawing.Point(91, 19);
            this.tbx_area_nombre.MaxLength = 32767;
            this.tbx_area_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbx_area_nombre.Name = "tbx_area_nombre";
            this.tbx_area_nombre.PasswordChar = '\0';
            this.tbx_area_nombre.SelectedText = "";
            this.tbx_area_nombre.SelectionLength = 0;
            this.tbx_area_nombre.SelectionStart = 0;
            this.tbx_area_nombre.Size = new System.Drawing.Size(176, 28);
            this.tbx_area_nombre.TabIndex = 10;
            this.tbx_area_nombre.TabStop = false;
            this.tbx_area_nombre.UseSystemPasswordChar = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(198, 256);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Primary = true;
            this.btn_guardar.Size = new System.Drawing.Size(100, 36);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // f_crear_actualizar_area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 311);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel1);
            this.Name = "f_crear_actualizar_area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área en proceso";
            this.Load += new System.EventHandler(this.f_crear_actualizar_area_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_area_nombre;
        private System.Windows.Forms.Label lbl_area_ubicacion;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbx_area_ubicacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbx_area_nombre;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
    }
}