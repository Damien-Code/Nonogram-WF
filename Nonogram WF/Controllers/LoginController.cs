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

        public static (bool boolean,Users user) CheckEmailExists(string email)
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

        public static bool PasswordCheck(Users user, string password)
        {
            string hashedPassword = Users.hashLoginPassword(password,user.Salt);
            if (hashedPassword != user.Password) 
            { 
                return true; 
            }
            return false;
        }
    }
}
