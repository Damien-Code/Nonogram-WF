using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Models;
using Nonogram_WF.Themes;

namespace Nonogram_WF.Controllers
{
    class Settings
    {

        public Settings() { }
        public static string GetTheme() {


            Models.Settings settings = Models.Session.GetSession().Settings;
            return settings != null ? settings.Theme : "";

        }
        public static void SetTheme(string theme)
        {
            //to be added
            Thread AddToDB = new Thread(new ThreadStart(() => {
                //add method call to put set theme into db
                Models.Users.SetTheme(theme);
            }));
            Thread AddToSession = new Thread(new ThreadStart(() => {

                //add method call to put set theme into sessionstore
                Models.Session.SetTheme(theme);
            }));
            AddToDB.Start();
            AddToSession.Start();
        }

        public static string GetFontSize()
        {
            Models.Settings settings = Models.Session.GetSession().Settings;

            return settings != null ? settings.FontSize : "9";
        }
        public static void SetFontSize(string fontSize)
        {
            Thread AddToDB = new Thread(new ThreadStart(() => {
                //add method call to put set theme into db
                Models.Users.SetFontSize(fontSize);
            }));
            Thread AddToSession = new Thread(new ThreadStart(() => {

                //add method call to put set theme into sessionstore
                Models.Session.SetFontSize(fontSize);
            }));
            AddToDB.Start();
            AddToSession.Start();
        }
    }
}
