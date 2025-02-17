using Proyecto_1.BackEnd;
using Proyecto_1.FrontEnd.Area;
using Proyecto_1.FrontEnd.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1.FrontEnd
{
    public partial class f_inventario : Form
    {
        Inventarios i = new Inventarios();
        public f_inventario()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            f_menu m = new f_menu();
            m.Show(this);
            this.Hide();
        }

        private void f_inventario_Load(object sender, EventArgs e)
        {
            Inventarios i = new Inventarios();
            dgv_inventario.DataSource = i.seleccionar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (i.eliminar(i)) MessageBox.Show("Elemento borrado exitosamente.");
            else MessageBox.Show("No se ha podido eliminar el elemento.");
            f_inventario_Load(null, null);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            f_crear_actualizar_inventario ac = new f_crear_actualizar_inventario(i);
            ac.Show();
            this.Hide();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            f_crear_actualizar_inventario ac = new f_crear_actualizar_inventario();
            ac.Show();
            this.Hide();
        }

        private void dgv_inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_inventario.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgv_inventario.Rows[e.RowIndex];

                    this.i.inventario_id = Convert.ToInt32(selectedRow.Cells["inventario_id"].Value);
                    this.i.inventario_nombre = selectedRow.Cells["inventario_nombre_corto"].Value.ToString();
                    this.i.inventario_descripcion = selectedRow.Cells["inventario_descripcion"].Value.ToString();
                    this.i.inventario_serie = selectedRow.Cells["inventario_serie"].Value.ToString();
                    this.i.inventario_color = selectedRow.Cells["inventario_color"].Value.ToString();
                    this.i.inventario_fecha = selectedRow.Cells["inventario_fecha_adquisicion"].Value.ToString();
                    this.i.inventario_tipo = selectedRow.Cells["inventario_tipo_adquisicion"].Value.ToString();
                    this.i.inventario_observaciones = selectedRow.Cells["inventario_observaciones"].Value.ToString();
                    this.i.area_id = (selectedRow.Cells["area_id"].Value.ToString().Length != 0 ? Convert.ToInt32(selectedRow.Cells["area_id"].Value.ToString()) : 0);

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
                btn_eliminar.Enabled = false;
                btn_actualizar.Enabled = false;
            }
        }

        private void dgv_inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
