using System.Windows.Forms;

namespace Proyecto_1.FrontEnd.Inventario
{
    partial class f_crear_actualizar_inventario
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
            this.lbl_inventario_nombre = new System.Windows.Forms.Label();
            this.lbl_inventario_descripcion = new System.Windows.Forms.Label();
            this.lbl_inventario_serie = new System.Windows.Forms.Label();
            this.lbl_inventario_color = new System.Windows.Forms.Label();
            this.lbl_inventario_fecha = new System.Windows.Forms.Label();
            this.lbl_inventario_tipo = new System.Windows.Forms.Label();
            this.lbl_inventario_observaciones = new System.Windows.Forms.Label();
            this.lbl_area_id = new System.Windows.Forms.Label();
            this.txb_inventario_nombre = new System.Windows.Forms.TextBox();
            this.txb_inventario_descripcion = new System.Windows.Forms.TextBox();
            this.txb_inventario_serie = new System.Windows.Forms.TextBox();
            this.lbx_inventario_color = new System.Windows.Forms.ListBox();
            this.dtp_inventario_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbx_inventario_tipo = new System.Windows.Forms.ListBox();
            this.txb_inventario_observaciones = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txb_area_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_inventario_nombre
            // 
            this.lbl_inventario_nombre.AutoSize = true;
            this.lbl_inventario_nombre.Location = new System.Drawing.Point(35, 94);
            this.lbl_inventario_nombre.Name = "lbl_inventario_nombre";
            this.lbl_inventario_nombre.Size = new System.Drawing.Size(117, 16);
            this.lbl_inventario_nombre.TabIndex = 13;
            this.lbl_inventario_nombre.Text = "NOMBRE CORTO";
            // 
            // lbl_inventario_descripcion
            // 
            this.lbl_inventario_descripcion.AutoSize = true;
            this.lbl_inventario_descripcion.Location = new System.Drawing.Point(35, 162);
            this.lbl_inventario_descripcion.Name = "lbl_inventario_descripcion";
            this.lbl_inventario_descripcion.Size = new System.Drawing.Size(98, 16);
            this.lbl_inventario_descripcion.TabIndex = 14;
            this.lbl_inventario_descripcion.Text = "DESCRIPCIÓN";
            // 
            // lbl_inventario_serie
            // 
            this.lbl_inventario_serie.AutoSize = true;
            this.lbl_inventario_serie.Location = new System.Drawing.Point(35, 236);
            this.lbl_inventario_serie.Name = "lbl_inventario_serie";
            this.lbl_inventario_serie.Size = new System.Drawing.Size(47, 16);
            this.lbl_inventario_serie.TabIndex = 15;
            this.lbl_inventario_serie.Text = "SERIE";
            // 
            // lbl_inventario_color
            // 
            this.lbl_inventario_color.AutoSize = true;
            this.lbl_inventario_color.Location = new System.Drawing.Point(35, 318);
            this.lbl_inventario_color.Name = "lbl_inventario_color";
            this.lbl_inventario_color.Size = new System.Drawing.Size(53, 16);
            this.lbl_inventario_color.TabIndex = 16;
            this.lbl_inventario_color.Text = "COLOR";
            // 
            // lbl_inventario_fecha
            // 
            this.lbl_inventario_fecha.AutoSize = true;
            this.lbl_inventario_fecha.Location = new System.Drawing.Point(364, 94);
            this.lbl_inventario_fecha.Name = "lbl_inventario_fecha";
            this.lbl_inventario_fecha.Size = new System.Drawing.Size(163, 16);
            this.lbl_inventario_fecha.TabIndex = 17;
            this.lbl_inventario_fecha.Text = "FECHA DE ADQUISICIÓN";
            // 
            // lbl_inventario_tipo
            // 
            this.lbl_inventario_tipo.AutoSize = true;
            this.lbl_inventario_tipo.Location = new System.Drawing.Point(364, 162);
            this.lbl_inventario_tipo.Name = "lbl_inventario_tipo";
            this.lbl_inventario_tipo.Size = new System.Drawing.Size(149, 16);
            this.lbl_inventario_tipo.TabIndex = 18;
            this.lbl_inventario_tipo.Text = "TIPO DE ADQUISICIÓN";
            // 
            // lbl_inventario_observaciones
            // 
            this.lbl_inventario_observaciones.AutoSize = true;
            this.lbl_inventario_observaciones.Location = new System.Drawing.Point(364, 236);
            this.lbl_inventario_observaciones.Name = "lbl_inventario_observaciones";
            this.lbl_inventario_observaciones.Size = new System.Drawing.Size(122, 16);
            this.lbl_inventario_observaciones.TabIndex = 19;
            this.lbl_inventario_observaciones.Text = "OBSERVACIONES";
            // 
            // lbl_area_id
            // 
            this.lbl_area_id.AutoSize = true;
            this.lbl_area_id.Location = new System.Drawing.Point(364, 318);
            this.lbl_area_id.Name = "lbl_area_id";
            this.lbl_area_id.Size = new System.Drawing.Size(89, 16);
            this.lbl_area_id.TabIndex = 20;
            this.lbl_area_id.Text = "ID DEL ÁREA";
            // 
            // txb_inventario_nombre
            // 
            this.txb_inventario_nombre.Location = new System.Drawing.Point(167, 94);
            this.txb_inventario_nombre.MaxLength = 45;
            this.txb_inventario_nombre.Name = "txb_inventario_nombre";
            this.txb_inventario_nombre.Size = new System.Drawing.Size(130, 22);
            this.txb_inventario_nombre.TabIndex = 2;
            // 
            // txb_inventario_descripcion
            // 
            this.txb_inventario_descripcion.Location = new System.Drawing.Point(167, 162);
            this.txb_inventario_descripcion.MaxLength = 45;
            this.txb_inventario_descripcion.Name = "txb_inventario_descripcion";
            this.txb_inventario_descripcion.Size = new System.Drawing.Size(130, 22);
            this.txb_inventario_descripcion.TabIndex = 3;
            // 
            // txb_inventario_serie
            // 
            this.txb_inventario_serie.Location = new System.Drawing.Point(167, 224);
            this.txb_inventario_serie.MaxLength = 45;
            this.txb_inventario_serie.Name = "txb_inventario_serie";
            this.txb_inventario_serie.Size = new System.Drawing.Size(130, 22);
            this.txb_inventario_serie.TabIndex = 4;
            // 
            // lbx_inventario_color
            // 
            this.lbx_inventario_color.FormattingEnabled = true;
            this.lbx_inventario_color.ItemHeight = 16;
            this.lbx_inventario_color.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Morado",
            "Verde",
            "Amarillo",
            "Rosa",
            "Naranja",
            "Cyan",
            "Negro",
            "Blanco"});
            this.lbx_inventario_color.Location = new System.Drawing.Point(167, 297);
            this.lbx_inventario_color.Name = "lbx_inventario_color";
            this.lbx_inventario_color.Size = new System.Drawing.Size(130, 52);
            this.lbx_inventario_color.TabIndex = 5;
            // 
            // dtp_inventario_fecha
            // 
            this.dtp_inventario_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_inventario_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inventario_fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_inventario_fecha.Location = new System.Drawing.Point(542, 94);
            this.dtp_inventario_fecha.Name = "dtp_inventario_fecha";
            this.dtp_inventario_fecha.Size = new System.Drawing.Size(254, 22);
            this.dtp_inventario_fecha.TabIndex = 6;
            // 
            // lbx_inventario_tipo
            // 
            this.lbx_inventario_tipo.FormattingEnabled = true;
            this.lbx_inventario_tipo.ItemHeight = 16;
            this.lbx_inventario_tipo.Items.AddRange(new object[] {
            "Directa",
            "Indirecta",
            "De bienes"});
            this.lbx_inventario_tipo.Location = new System.Drawing.Point(542, 146);
            this.lbx_inventario_tipo.Name = "lbx_inventario_tipo";
            this.lbx_inventario_tipo.Size = new System.Drawing.Size(156, 52);
            this.lbx_inventario_tipo.TabIndex = 7;
            // 
            // txb_inventario_observaciones
            // 
            this.txb_inventario_observaciones.Location = new System.Drawing.Point(542, 224);
            this.txb_inventario_observaciones.MaxLength = 45;
            this.txb_inventario_observaciones.Name = "txb_inventario_observaciones";
            this.txb_inventario_observaciones.Size = new System.Drawing.Size(156, 22);
            this.txb_inventario_observaciones.TabIndex = 8;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 415);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(105, 23);
            this.btn_regresar.TabIndex = 11;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(702, 392);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 46);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txb_area_id
            // 
            this.txb_area_id.Location = new System.Drawing.Point(533, 315);
            this.txb_area_id.MaxLength = 9;
            this.txb_area_id.Name = "txb_area_id";
            this.txb_area_id.Size = new System.Drawing.Size(100, 22);
            this.txb_area_id.TabIndex = 21;
            // 
            // f_crear_actualizar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.txb_area_id);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txb_inventario_observaciones);
            this.Controls.Add(this.lbx_inventario_tipo);
            this.Controls.Add(this.dtp_inventario_fecha);
            this.Controls.Add(this.lbx_inventario_color);
            this.Controls.Add(this.txb_inventario_serie);
            this.Controls.Add(this.txb_inventario_descripcion);
            this.Controls.Add(this.txb_inventario_nombre);
            this.Controls.Add(this.lbl_area_id);
            this.Controls.Add(this.lbl_inventario_observaciones);
            this.Controls.Add(this.lbl_inventario_tipo);
            this.Controls.Add(this.lbl_inventario_fecha);
            this.Controls.Add(this.lbl_inventario_color);
            this.Controls.Add(this.lbl_inventario_serie);
            this.Controls.Add(this.lbl_inventario_descripcion);
            this.Controls.Add(this.lbl_inventario_nombre);
            this.Name = "f_crear_actualizar_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario en proceso";
            this.Load += new System.EventHandler(this.f_crear_actualizar_inventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_inventario_nombre;
        private System.Windows.Forms.Label lbl_inventario_descripcion;
        private System.Windows.Forms.Label lbl_inventario_serie;
        private System.Windows.Forms.Label lbl_inventario_color;
        private System.Windows.Forms.Label lbl_inventario_fecha;
        private System.Windows.Forms.Label lbl_inventario_tipo;
        private System.Windows.Forms.Label lbl_inventario_observaciones;
        private System.Windows.Forms.Label lbl_area_id;
        private System.Windows.Forms.TextBox txb_inventario_nombre;
        private System.Windows.Forms.TextBox txb_inventario_descripcion;
        private System.Windows.Forms.TextBox txb_inventario_serie;
        private System.Windows.Forms.ListBox lbx_inventario_color;
        private System.Windows.Forms.DateTimePicker dtp_inventario_fecha;
        private System.Windows.Forms.ListBox lbx_inventario_tipo;
        private System.Windows.Forms.TextBox txb_inventario_observaciones;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txb_area_id;
    }
}