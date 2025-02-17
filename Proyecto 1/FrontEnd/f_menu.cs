using Proyecto_1.FrontEnd;
using Proyecto_1.FrontEnd.Area;
using System;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class f_menu : Form
    {
        public f_menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            f_inventario i = new f_inventario();
            i.Show();
            this.Hide();
        }

        private void btn_area_Click(object sender, EventArgs e)
        {
            f_area a = new f_area();
            a.Show();
            this.Hide();
        }

        private void lbl_presentacion_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            string[] valores = {"Bienvenido al Sistema!", "Este es el Menú Principal!", "Bienvenido :D!!!", "Hola y Bienvenido!"};
            lbl_presentacion.Text = valores[rand.Next() % 4];
        }
    }
}
