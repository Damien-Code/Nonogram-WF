using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Models;
namespace Nonogram_WF.Controllers
{
    
    public class UserController
    {
        /// <summary>
        /// Validates the user input of email and password
        /// Checks the email, via the CheckEmail method
        /// Checks the password via the CheckPassword method
        /// If everything is correct, then it sets that user to JSON via the SetUser method in the model
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidateUserData(string email, string password)
        {
            if (!CheckEmail(email)) return false;//return email error
            if (!CheckPassword(password)) return false ;//return email error
            Users.SetUser(email, Users.CreatePassword(password));
            Session.SetSession(email);
            return true;
        }

        // check if input values are correct
        public static bool CheckEmail(string email)
        {
            if(email.Length < 6)
            {
                return false;
            }
            return true;
        }

        // Check if input values are correct
        public static bool CheckPassword(string password)
        {
            //if (password.Length < 6) { return false; }
            //return true;
            return (password.Length < 6) ? false : true;
        }
    }
}
