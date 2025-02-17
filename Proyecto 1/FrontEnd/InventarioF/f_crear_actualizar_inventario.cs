using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Proyecto_1.BackEnd;
using Proyecto_1.FrontEnd.Area;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Proyecto_1.FrontEnd.Inventario
{
    public partial class f_crear_actualizar_inventario : Form
    {
        bool modo = false; // modo crear es false, modo actualizar es true.
        public f_crear_actualizar_inventario()
        {
            InitializeComponent();
        }
        public f_crear_actualizar_inventario(Inventarios i)
        {
            InitializeComponent();

            txb_inventario_nombre.Text = i.inventario_nombre.ToString();
            txb_inventario_descripcion.Text = i.inventario_descripcion.ToString();
            txb_inventario_serie.Text = i.inventario_serie.ToString();
            lbl_inventario_color.Text = i.inventario_color.ToString();
            dtp_inventario_fecha.Text = i.inventario_fecha.ToString();
            lbl_inventario_tipo.Text = i.inventario_tipo.ToString();
            txb_inventario_observaciones.Text = i.inventario_observaciones.ToString();
            txb_area_id.Text = i.area_id.ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string aux = dtp_inventario_fecha.Value.ToString();
            string fecha = aux.Substring(6, 4) + "-" + aux.Substring(3, 2) + "-" + aux.Substring(0, 2);

            string validacion = validar(fecha);

            if (validacion == "Válido")
            {
                if (!modo)
                {
                    // Intentamos realizar la insersion
                    Inventarios i = new Inventarios(txb_inventario_nombre.Text, txb_inventario_descripcion.Text, txb_inventario_serie.Text, lbx_inventario_color.Text, fecha, lbx_inventario_tipo.Text, txb_inventario_observaciones.Text, int.Parse(txb_area_id.Text));
                    if (i.insertar(i)) MessageBox.Show("Insersión Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la insersión.");
                }
                else
                {
                    // Intentamos realizar la actualización
                    Inventarios i = new Inventarios(txb_inventario_nombre.Text, txb_inventario_descripcion.Text, txb_inventario_serie.Text, lbx_inventario_color.Text, fecha, lbx_inventario_tipo.Text, txb_inventario_observaciones.Text, int.Parse(txb_area_id.Text));
                    if (i.actualizar(i)) MessageBox.Show("Actualización Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la actualización.");
                }

                // Volvemos a la pagina de inventario

                f_inventario fi = new f_inventario();
                fi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validacion);
            }
        }

        private string validar(string fecha)
        {
            try
            {
                // Validar llenado de campos
                if (txb_inventario_nombre.Text.Length == 0) return "Debe llenar el campo 'Nombre'.";
                if (txb_inventario_descripcion.Text.Length == 0) return "Debe llenar el campo 'Descripcion'.";
                if (txb_inventario_serie.Text.Length == 0) return "Debe llenar el campo 'Serie'.";
                if (lbx_inventario_color.Text.Length == 0) return "Debe elegir un valor en el campo 'Color'.";
                if (lbx_inventario_tipo.Text.Length == 0) return "Debe elegir un valor en el campo 'Tipo de adquisicion'.";
                if (txb_inventario_observaciones.Text.Length == 0) return "Debe llenar el campo 'Observaciones'.";
                if (txb_area_id.Text.Length == 0) return "Debe llenar el campo 'Id del area'.";

                // Validaciones de formato
                if (!Regex.Match(txb_inventario_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "El nombre solo debe contener letras, espacios, tildes y ñ.";
                if (!Regex.Match(txb_inventario_descripcion.Text, @"^[0-9a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "La descripcion solo debe contener letras, números, espacios, tildes y ñ.";
                if (!Regex.Match(txb_inventario_serie.Text, @"^[0-9a-zA-]+$").Success) return "La serie solo puede contener numeros y letras.";
                if (!Regex.Match(txb_inventario_observaciones.Text, @"^[0-9a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "Las observaciones solo debe contener letras, números, espacios, tildes y ñ.";
                if (!Regex.Match(txb_area_id.Text, @"^[0-9]+$").Success) return "La serie solo puede contener numeros.";

                // Validar existencia de area
                Areas a = new Areas();
                if (!a.buscar_id(int.Parse(txb_area_id.Text.ToString()))) return "Ingrese un id existente.";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "Válido";
        }

        private void f_crear_actualizar_inventario_Load(object sender, EventArgs e)
        {
            Inventarios i = new Inventarios();
        }

        private void txb_area_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            f_inventario f = new f_inventario();
            f.Show();
            this.Hide();
        }

        private void lbx_area_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
