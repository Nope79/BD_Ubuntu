using System;
using System.Windows.Forms;
using Proyecto_1.FrontEnd;
using Proyecto_1.FrontEnd.Area;
using Proyecto_1.FrontEnd.Inventario;

namespace Proyecto_1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f_menu());
        }
    }
}
