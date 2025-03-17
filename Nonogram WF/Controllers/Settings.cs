using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Models;

namespace Nonogram_WF.Controllers
{
    class Settings
    {
        public static string GetTheme() {
            Models.Settings settings = Models.Session.GetSession().Settings;
            return settings != null ? settings.Theme : "";
            
        }
        public static void SetTheme(string theme) {
            //to be added
            Thread AddToDB = new Thread(new ThreadStart(()=> {
                //add method call to put set theme into db
                Models.Users.SetTheme(theme);
            }));
            Thread AddToSession = new Thread(new ThreadStart(()=> { 
                
                //add method call to put set theme into sessionstore
                Models.Session.SetTheme(theme);
            }));
            AddToDB.Start();
            AddToSession.Start();
        }

        public static string GetFontSize(string fontSize) {
            Models.Settings settings = Models.Session.GetSession().Settings;

			return settings != null ? settings.FontSize : "";
            //Users x = Controllers.Session.GetSession();
            
            //if (x == null) { return ""; }
            //return x.Settings.FontSize;
			//return Models.Session.GetSession().Settings.FontSize;
        }
        public static void SetFontSize() { 
            //to be added
        }
    }
}
