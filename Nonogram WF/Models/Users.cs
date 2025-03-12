using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Database;
using Nonogram_WF.Interfaces;

namespace Nonogram_WF.Models
{
    public class Users : IUser
    {
        // interface to check if everyting is correct
        // set values to json
        public string name;
        public string email;
        public string password;

        public string Email
        {
            get => email; set => email = value;
        }
        public Users(string email) {
            Email = email;
        }
        public static void SetUser(string email)
        {
            Users user = new Users(email);
            JSON_RW.WriteFile(user);
        }
    }
}
