using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nonogram_WF.Database;
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
            // If the email does not match the correct specifications, give error message
            if (!CheckEmail(email)) 
            {
                MessageBox.Show("Please enter a valid email. \n It should be as following: johndoe@example.com ");
                return false;
            }

			// If the password does not match the correct specifications, give error message
			if (!CheckPassword(password))
			{
				MessageBox.Show("Please enter a valid password. \n It should contain at least 6 characters");
				return false;
			}

			// If the the confirm password does not match the input of password, give error message
			if (!CheckConfirmPassword(password, confirmPassword))
			{
				MessageBox.Show("Please make sure that you confirm the correct password");
				return false;
			}

			// If the email already exists give error message
			if (CheckEmailExists(email))
			{
				MessageBox.Show("This email already exists");
				return false;
			}

			// check to see if settings work
			//TODO: change default settings and history
			Models.Settings settings = new Models.Settings("Light", "9");
			
			//test history
			UserHistory history = new UserHistory();
			history.AllHistory.Add(new History());


            // If all the methods return true, then store the email and password(hash and salt)
            Users.SetUser(email, Users.CreatePassword(password), settings, history);
			Models.Session.SetSession(email, settings, history);
			return true;
		}

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
        /// <returns type="bool"></returns>
        public static bool CheckEmail(string email)
        {
            return CreateValidEmailRegex().IsMatch(email);
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

		/// <summary>
		/// Goes through the users of the GetUsers method
		/// Checks if the input email matches one of the already stored emails
		/// Returns true if so
		/// Else returns false
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		public static bool CheckEmailExists(string email)
		{
			AllUsers allUsers = Users.GetUsers();
			
			Users? currentUser = allUsers.Users.Find(x => x.Email == email);
			if (currentUser != null) { return true; }
			
			return false;
		}


	}
}