using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Database;
using Nonogram_WF.Interfaces;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Nonogram_WF.Controllers;
using System.Text.Json.Serialization;

namespace Nonogram_WF.Models
{
    public class Users : IUser
    {
        // private properties 

        //private string _name;
        private string _email;
        private string _password;
        private string _salt;

        // Get and Set to be able to use the properties
        public string Email
        {
            get => _email; set => _email = value;
        }

        public string Password
        {
            get => _password; set => _password = value;
        }

        public string Salt
        {
            get => _salt; set => _salt = value;
        }

        public Settings Settings { get; set; }

        // Construct if the Users class is initialized with arguments
        [JsonConstructor]
        public Users(string email, string password, string salt, Settings settings)
        {
            Email = email;
            Password = password;
            Salt = salt;
            Settings = settings;
            
        }

        //Construct for session
        public Users(string email, Settings settings)
        {
            Email = email;
            Settings = settings;
        }

        /// <summary>
        /// Reads all users from the GetUsers() method
        /// Create new user object with email and Hash and Salt from DPassword class
        /// Add new user object to the allUsers List
        /// Write the list to JSON
        /// </summary>
        /// <param name="email"></param>
        /// <param name="dPassword"></param>
        public static void SetUser(string email, DPassword dPassword, Settings settings)
        {
            AllUsers allUsers = JSON_RW.GetUsers();
            Users user = new Users(email, dPassword.Hash, dPassword.Salt, settings);
            allUsers.Users.Add(user);
            JSON_RW.WriteFile(allUsers);
        }

        /// <summary>
        /// Creates salt by using a random value generator and stores it in an array
        /// Then it creates an hashed password by taking the set password from the user together with the created salt
        /// Uses the SHA-256 algorithm to derive a secret key from the password "key"
        /// and does a number of iterations to apply to the process and set a length of the derived key
        /// Returns the hash en the converted base64 string of the salt
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DPassword CreatePassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8
                ));

            // Chose to return a new DPassword object instead of an string array
            // Using a string array as its return type would result in less readable code
            return new DPassword(hashed, Convert.ToBase64String(salt));
        }
    }
}
