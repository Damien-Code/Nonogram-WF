using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
        public static bool ValidateUserData(string email, string password, string confirmPassword)
        {
            if (!CheckEmail(email)) 
            {
                MessageBox.Show("Please enter a valid email. \n It should be as following: johndoe@example.com ");
                return false;//return email error
            }

            if (!CheckPassword(password))
            {
                MessageBox.Show("Please enter a valid password. \n It should contain at least 6 characters");
                return false;//return email error
            }
            if(!CheckConfirmPassword(password, confirmPassword))
            {
                MessageBox.Show("Please make sure that you confirm the correct password");
                return false;
            }

            Settings settings = new Settings("Dark", "16");
            

            Users.SetUser(email, Users.CreatePassword(password), settings);
            return true;
        }


        static Regex ValidEmailRegex = CreateValidEmailRegex();

        /// <summary>
        /// A regex method that creates a valid regex for email
        /// </summary>
        /// <returns></returns>
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }


        /// <summary>
        /// Check if the input of email matches the correct specifications of the regex method
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool CheckEmail(string email)
        {
            bool isValid = ValidEmailRegex.IsMatch(email);
            return isValid;
        }


        /// <summary>
        /// Check if the input password matches the correct specifications
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CheckPassword(string password)
        {
            return (password.Length < 6) ? false : true;
        }

        /// <summary>
        /// Checks if the input of password is equal to the input of confirm password 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns></returns>
        public static bool CheckConfirmPassword(string password, string confirmPassword)
        {
            return (password != confirmPassword) ? false : true;
        }


    }
}
