using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Proyecto_1.BackEnd;

namespace Proyecto_1.FrontEnd.Area
{
    public partial class f_crear_actualizar_area : Form
    {
        bool modo = false; // modo crear es false, modo actualizar es true.
        public f_crear_actualizar_area()
        {
            InitializeComponent();
        }

        public f_crear_actualizar_area(Areas a)
        {
            InitializeComponent();  
            tbx_area_nombre.Text = a.area_nombre.ToString();
            tbx_area_ubicacion.Text = a.area_ubicacion.ToString();
            modo = true;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            // Volvemos a la pagina de areas
            f_area a = new f_area();
            a.Show();
            this.Hide();
        }

        private void f_crear_actualizar_area_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string validacion = validar();

            if (validacion == "Válido")
            {
                if (!modo)
                {
                    // Intentamos realizar la insersion
                    Areas a = new Areas(tbx_area_nombre.Text, tbx_area_ubicacion.Text);
                    if (a.insertar(a)) MessageBox.Show("Insersión Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la insersión.");
                }
                else
                {
                    // Intentamos realizar la actualización
                    Areas a = new Areas(tbx_area_nombre.Text, tbx_area_ubicacion.Text);
                    if (a.actualizar(a)) MessageBox.Show("Actualización Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la actualización.");
                }

                // Volvemos a la pagina de areas
                f_area f_Area = new f_area();
                f_Area.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validacion);
            }
        }

        private string validar()
        {
            // Validaciones de llenado de datos
            if (tbx_area_nombre.Text.Length == 0 && tbx_area_ubicacion.Text.Length == 0) return "Debe llenar todos los campos.";
            if (tbx_area_nombre.Text.Length == 0) return "Debe llenar el campo 'Nombre'.";
            if (tbx_area_ubicacion.Text.Length == 0) return "Debe llenar el campo 'Ubicación'.";

            // Validaciones de formato
            if (!Regex.Match(tbx_area_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "El nombre solo debe contener letras, espacios, tildes y ñ.";
            if (!Regex.Match(tbx_area_ubicacion.Text, @"^[0-9a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "La ubicación solo debe contener letras, números, espacios, tildes y ñ.";

            return "Válido";
        }
    }
}
