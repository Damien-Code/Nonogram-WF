using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Models;

namespace Nonogram_WF.Controllers
{
    class Session
    {
        /// <summary>
        /// sets session
        /// </summary>
        /// <param name="email"></param>
        /// <param name="settings"></param>
        /// <param name="history"></param>
        public static void SetSession(string email, Models.Settings settings, UserHistory history)
        {
            Models.Session.SetSession(email, settings, history);
        }
        /// <summary>
        /// sets session after user logs in
        /// </summary>
        /// <param name="currentUser"></param>
        public static void SetLoginSession(Users currentUser)
        {
            Models.Session.SetSession(currentUser.Email, currentUser.Settings, currentUser.History);
        }
        /// <summary>
        /// Gets current session and returns it as type Users
        /// </summary>
        /// <returns>Users</returns>
        public static Users GetSession()
        {
            return Models.Session.GetSession();
        }
        /// <summary>
        /// Removes session
        /// </summary>
        public static void RemoveSession()
        {
            Models.Session.RemoveSession();
            return;
        }
    }
}
