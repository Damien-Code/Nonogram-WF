using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Database;
using Nonogram_WF.Models;
using Nonogram_WF.Views;

namespace Nonogram_WF.Controllers
{
    public class LoginController
    {
        /// <summary>
        /// Takes users login data and checks it to see if its valid data, else returns message boxes
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool CheckUserData(string email, string password)
        {
            var usercheck = CheckEmailExists(email);
            if (usercheck.boolean)
            {
                if (!PasswordCheck(usercheck.user, password))
                {
                    Session.SetLoginSession(usercheck.user);
                    return false;
                }

                MessageBox.Show("Password is incorrect");
                return true;
            }

            MessageBox.Show("Email does not exist");
            return true;
        }
        /// <summary>
        /// Checks if email already exists, if so returns the user and true, else false and empty user
        /// </summary>
        /// <param name="email"></param>
        /// <returns>(bool. Users)</returns>
        public static (bool boolean, Users user) CheckEmailExists(string email)
        {
            AllUsers allUsers = Users.GetUsers();
            Users LoggedInUser = allUsers.Users.Find(x => x.Email == email);
            if (LoggedInUser == null)
            {
                Users emptyUser = new();
                return (false, emptyUser);
            }
            return (true, LoggedInUser);

        }
        /// <summary>
        /// Checks if password is correct
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool PasswordCheck(Users user, string password)
        {
            string hashedPassword = Users.hashLoginPassword(password, user.Salt);
            if (hashedPassword != user.Password)
            {
                return true;
            }
            return false;
        }
    }
}
