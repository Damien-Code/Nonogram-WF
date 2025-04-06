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
        /// <summary>
        /// sets the user in session.json
        /// </summary>
        /// <param name="email"></param>
        /// <param name="settings"></param>
        /// <param name="history"></param>
        public static void SetSession(string email, Settings settings, UserHistory history)
        {
            JSON_RW.SetSession(email, settings, history);
        }

        /// <summary>
        /// gets the current user from session.json
        /// </summary>
        /// <returns></returns>
        public static Users GetSession()
        {
            return JSON_RW.GetSession();
        }
        /// <summary>
        /// removes the users session
        /// </summary>
        public static void RemoveSession()
        {
            JSON_RW.RemoveSession();
            return;
        }
        /// <summary>
        /// sets the current theme of the user in the session
        /// </summary>
        /// <param name="theme"></param>
        public static void SetTheme(string theme)
        {
            Users currentUser = JSON_RW.GetSession();
            currentUser.Settings.Theme = theme;
            JSON_RW.UpdateSessionSettings(currentUser);
        }
    }
}
