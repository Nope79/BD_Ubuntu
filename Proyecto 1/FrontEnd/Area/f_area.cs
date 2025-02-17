﻿using System;
using System.Windows.Forms;
using Proyecto_1.BackEnd;

namespace Proyecto_1.FrontEnd.Area
{
    public partial class f_area : Form
    {
        Areas a = new Areas();
        
        public f_area()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            f_menu m = new f_menu();
            m.Show(this);
            this.Hide();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            f_crear_actualizar_area c = new f_crear_actualizar_area();
            c.Show();
            this.Hide();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (a.eliminar(a)) MessageBox.Show("Elemento borrado exitosamente.");
            else MessageBox.Show("No se ha podido eliminar el elemento.");
            f_area_Load(null, null);
        }

        private void f_area_Load(object sender, EventArgs e)
        {
            dgv_area.DataSource = a.seleccionar();
        }
        
        private void dgv_area_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_area.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgv_area.Rows[e.RowIndex];

                    this.a.area_id = Convert.ToInt32(selectedRow.Cells["area_id"].Value);
                    this.a.area_nombre = selectedRow.Cells["area_nombre"].Value.ToString();
                    this.a.area_ubicacion = selectedRow.Cells["area_ubicacion"].Value.ToString();
                    
                    btn_eliminar.Enabled = true;
                    btn_actualizar.Enabled = true;
                }
                else
                {
                    btn_eliminar.Enabled = false;
                    btn_actualizar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            f_crear_actualizar_area ac = new f_crear_actualizar_area(a);
            ac.Show();
            this.Hide();
        }
    }
}
