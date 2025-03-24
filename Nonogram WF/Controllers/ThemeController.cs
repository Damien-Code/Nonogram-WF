using Nonogram_WF.Themes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Controllers
{
    class ThemeController
    {
        public static Theme GetTheme() {
            string themeName = Session.GetSession().Settings.Theme;
            dynamic t;
            if (themeName == "")
            {
                //MessageBox.Show("test");
                t = Type.GetType("Nonogram_WF.Themes.Light");

            }
            //var x = (Theme)Activator.CreateInstance(Type.GetType(themeName))!;
            else { 
                string currentTheme = "Nonogram_WF.Themes." + themeName;
            t = Type.GetType(currentTheme)!;
            }
            //if (t == null) { Convert.ChangeType(t, typeof(Light)); }
            //MessageBox.Show(Type.GetType(objType.AssemblyQualifiedName).ToString());
            return (Theme)Activator.CreateInstance(t)!;
            //return y;
        }
    }
}
