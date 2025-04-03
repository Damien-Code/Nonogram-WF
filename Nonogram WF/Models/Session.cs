using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Database;
using Nonogram_WF.Themes;

namespace Nonogram_WF.Models
{
    public class Session
    {
		public static void SetSession(string email,Settings settings, UserHistory history)
		{
			JSON_RW.SetSession(email, settings, history);
		}
		
        public static Users GetSession() {
			return JSON_RW.GetSession();
		}
		public static void RemoveSession() { 
			JSON_RW.RemoveSession();
			return;
		}
		public static void SetTheme(string theme) {
			Users currentUser = JSON_RW.GetSession();
			currentUser.Settings.Theme = theme;
			JSON_RW.UpdateSessionSettings(currentUser);
		}
		public static void SetFontSize(string fontSize) {
			Users currentUser = JSON_RW.GetSession();
			currentUser.Settings.FontSize = fontSize;
			JSON_RW.UpdateSessionSettings(currentUser);
		}
	}
}
