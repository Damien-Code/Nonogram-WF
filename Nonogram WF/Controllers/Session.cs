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
        public static void SetSession(string email,Settings settings) {
            Models.Session.SetSession(email,settings);
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
