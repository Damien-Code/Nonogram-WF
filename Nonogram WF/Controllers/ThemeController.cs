using Nonogram_WF.Models;
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
        /// <summary>
        /// gets current theme
        /// </summary>
        /// <returns>Theme</returns>
        public static Theme GetTheme()
        {
            Users session = Session.GetSession();
            string? themeName = null;
            dynamic t;
            if (session.Settings == null)
            {
                t = Type.GetType("Nonogram_WF.Themes.Light");
            }
            else if (session.Settings.Theme == "" || session.Settings.Theme == null)
            {
                t = Type.GetType("Nonogram_WF.Themes.Light");
            }
            else
            {
                themeName = session.Settings.Theme;
                string currentTheme = "Nonogram_WF.Themes." + themeName;
                t = Type.GetType(currentTheme)!;
            }
            return (Theme)Activator.CreateInstance(t)!;
        }
    }
}
