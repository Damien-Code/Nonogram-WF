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
        /// <summary>
        /// Gets current session, checks if its not empty, then returns the sessions theme, else returns empty string
        /// </summary>
        /// <returns>string</returns>
        public static string GetTheme() {


            Models.Settings settings = Models.Session.GetSession().Settings;
            return settings != null ? settings.Theme : "";

        }
        /// <summary>
        /// sets the theme in data and session using multithreading
        /// </summary>
        /// <param name="theme"></param>
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
    }
}
