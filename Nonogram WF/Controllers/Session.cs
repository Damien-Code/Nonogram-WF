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
        public static void SetSession(string email) {
            Models.Session.SetSession(email);
        }
        public static string GetSession()
        {
            return Models.Session.GetSession();
        }
    }
}
