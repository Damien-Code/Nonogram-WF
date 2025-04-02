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
        public static void SetSession(string email,Models.Settings settings, UserHistory history) {
            Models.Session.SetSession(email,settings,history);
        }
        public static void SetLoginSession(Users currentUser) {
            Models.Session.SetSession(currentUser.Email, currentUser.Settings, currentUser.History);
        }
        public static Users GetSession()
        {
            return Models.Session.GetSession();
        }
        public static void RemoveSession() {
            Models.Session.RemoveSession();
            return;
        }
    }
}
