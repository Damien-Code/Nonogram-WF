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
                t = Type.GetType("Nonogram_WF.Themes.Light");
            }
            else { 
                string currentTheme = "Nonogram_WF.Themes." + themeName;
            t = Type.GetType(currentTheme)!;
            }
            return (Theme)Activator.CreateInstance(t)!;
        }
    }
}
