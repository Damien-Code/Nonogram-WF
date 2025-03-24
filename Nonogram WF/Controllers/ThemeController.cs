using Nonogram_WF.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Controllers
{
    class ThemeController
    {
        public static Theme GetTheme() {
            string themeName = Session.GetSession().Settings.Theme;
            //var x = (Theme)Activator.CreateInstance(Type.GetType(themeName))!;
            string currentTheme = "Nonogram_WF.Themes." + themeName;
            Type t = Type.GetType(currentTheme)!;
            //MessageBox.Show(Type.GetType(objType.AssemblyQualifiedName).ToString());
            return (Theme)Activator.CreateInstance(t)!;
            //return y;
        }
    }
}
