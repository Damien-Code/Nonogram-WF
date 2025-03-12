using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Models;
namespace Nonogram_WF.Controllers
{
    public class UserController
    {
        // check if values are correct
        public static void CheckEmail(string email)
        {
            if(email.Length < 6)
            {
                return;
            }
            Users.SetUser(email);
        }

        // correct email/password
    }
}
