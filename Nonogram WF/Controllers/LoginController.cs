using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Database;
using Nonogram_WF.Models;

namespace Nonogram_WF.Controllers
{
    public class LoginController
    {
        public static bool CheckUserData(string email, string password)
        {
            var usercheck = CheckEmailExists(email);
            if (usercheck.Item1) 
            {
                return PasswordCheck(usercheck.Item2, password);
            }
            return true;
        }

        public static Tuple<bool,Users> CheckEmailExists(string email)
        {
            AllUsers allUsers = Users.GetUsers();
            Users LoggedInUser = allUsers.Users.Find(x => x.Email == email);
            if (LoggedInUser == null)
            {
                Users emptyUser = new();
                return Tuple.Create(false, emptyUser);
            }
            return Tuple.Create(true, LoggedInUser);
       
        }

        public static bool PasswordCheck(Users user, string password)
        {
            string hashedPassword = Users.hashLoginPassword(password,user.Salt);
            if (hashedPassword != user.Password) { return true; }
            return false;
        }
    }
}
