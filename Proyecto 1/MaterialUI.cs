using MaterialSkin;
using MaterialSkin.Controls;

namespace Proyecto_1
{
    internal class MaterialUI
    {
        public static void LoadMaterial(MaterialForm actualForm)
        {
            // crear material theme manager y añadir el form a gestionar
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(actualForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // configurar el esquema de colores
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
             );
        }
    }
}
