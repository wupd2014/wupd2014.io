using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Skin
    {
        public static void SetSkin(object obj)
        {
            string type = obj.GetType().FullName;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage((MaterialForm)obj);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightBlue900, Accent.Amber700, TextShade.WHITE);
            materialSkinManager.ColorScheme =
              //  new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            //new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightBlue900, Accent.Cyan100, TextShade.WHITE);
        }
    }
}
