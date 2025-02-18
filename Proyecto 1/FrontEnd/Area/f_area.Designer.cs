using System.Windows.Forms;

namespace Proyecto_1.FrontEnd.Area
{
    partial class f_area
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.dgv_area = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_crear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_area)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 425);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(94, 23);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // dgv_area
            // 
            this.dgv_area.AllowUserToAddRows = false;
            this.dgv_area.AllowUserToDeleteRows = false;
            this.dgv_area.AllowUserToResizeColumns = false;
            this.dgv_area.AllowUserToResizeRows = false;
            this.dgv_area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_area.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_area.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_area.Location = new System.Drawing.Point(144, 82);
            this.dgv_area.Name = "dgv_area";
            this.dgv_area.ReadOnly = true;
            this.dgv_area.RowHeadersVisible = false;
            this.dgv_area.RowHeadersWidth = 51;
            this.dgv_area.RowTemplate.Height = 24;
            this.dgv_area.Size = new System.Drawing.Size(451, 288);
            this.dgv_area.TabIndex = 5;
            this.dgv_area.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_area_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(131, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 320);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_crear);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Location = new System.Drawing.Point(131, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 51);
            this.panel2.TabIndex = 7;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Depth = 0;
            this.btn_eliminar.Icon = null;
            this.btn_eliminar.Location = new System.Drawing.Point(335, 5);
            this.btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Primary = true;
            this.btn_eliminar.Size = new System.Drawing.Size(124, 39);
            this.btn_eliminar.TabIndex = 0;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_crear
            // 
            this.btn_crear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_crear.Depth = 0;
            this.btn_crear.Icon = null;
            this.btn_crear.Location = new System.Drawing.Point(8, 5);
            this.btn_crear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Primary = true;
            this.btn_crear.Size = new System.Drawing.Size(124, 39);
            this.btn_crear.TabIndex = 8;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click_1);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(177, 5);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Primary = true;
            this.btn_actualizar.Size = new System.Drawing.Size(124, 39);
            this.btn_actualizar.TabIndex = 0;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // f_area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 459);
            this.Controls.Add(this.dgv_area);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f_area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área";
            this.Load += new System.EventHandler(this.f_area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_area)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DataGridView dgv_area;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_eliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_crear;
        private MaterialSkin.Controls.MaterialRaisedButton btn_actualizar;
    }
}