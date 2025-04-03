using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Database;
using Nonogram_WF.Interfaces;
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

        public UserHistory History { get; set; } = new();


        // Construct if the Users class is initialized with arguments
        [JsonConstructor]
        public Users(string email, string password, string salt, Settings settings, UserHistory history)
        {
            Email = email;
            Password = password;
            Salt = salt;
            Settings = settings;
            History = history;
        }

        //Construct for session
        public Users(string email, Settings settings, UserHistory history)
        {
            Email = email;
            Settings = settings;
            History = history;

        }
        public Users() { }

        /// <summary>
        /// Reads all users from the GetUsers() method
        /// Create new user object with email and Hash and Salt from DPassword class
        /// Add new user object to the allUsers List
        /// Write the list to JSON
        /// </summary>
        /// <param name="email"></param>
        /// <param name="dPassword"></param>
        public static void SetUser(string email, DPassword dPassword, Settings settings, UserHistory history)
        {
            AllUsers allUsers = JSON_RW.GetUsers();
            Users user = new Users(email, dPassword.Hash, dPassword.Salt, settings, history);
            allUsers.Users.Add(user);
            JSON_RW.WriteFile(allUsers);
        }

        /// <summary>
        /// Creates salt by using a random value generator and stores it in an array
        /// Then it creates an hashed password by taking the set password from the user together with the created salt
        /// Uses the SHA-256 algorithm
        /// and does a number of iterations to apply to the process and set a length of the derived key
        /// Returns the hash and the converted base64 string of the salt
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DPassword CreatePassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);

            string hashed = Convert.ToBase64String(Rfc2898DeriveBytes.Pbkdf2(
                password: password,
                salt: salt,
                hashAlgorithm: HashAlgorithmName.SHA256,
                iterations: 100000,
                outputLength: 64
                ));

            // Chose to return a new DPassword object instead of an string array
            // Using a string array as its return type would result in less readable code
            return new DPassword(hashed, Convert.ToBase64String(salt));
        }

        /// <summary>
        /// Take the salt and store it in a byte array
        /// Create a new hash for the login password
        /// Return the converted base64 string of the newly created hash
        /// This method will check if the already stored password is the same as the newly created hash
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string hashLoginPassword(string password, string salt)
        {
            byte[] saltAsBytes = Convert.FromBase64String(salt);

            byte[] hashToCompare = Rfc2898DeriveBytes.Pbkdf2(
                password,
                saltAsBytes,
                hashAlgorithm: HashAlgorithmName.SHA256,
                iterations: 100000,
                outputLength: 64
                );
            return Convert.ToBase64String(hashToCompare);
        }


        public static void SetTheme(string theme)
        {
            AllUsers allUsers = JSON_RW.GetUsers();
            Users user = JSON_RW.GetSession();
            Users currentUser = allUsers.Users.Find(x => x.Email == user.Email);
            currentUser.Settings.Theme = theme;
            JSON_RW.UpdateUserSettings(allUsers);
        }
        public static void SetFontSize(string fontSize)
        {
            AllUsers allUsers = JSON_RW.GetUsers();
            Users user = JSON_RW.GetSession();
            Users currentUser = allUsers.Users.Find(x => x.Email == user.Email);
            currentUser.Settings.FontSize = fontSize;
            JSON_RW.UpdateUserSettings(allUsers);
        }

        public static void setHistory(History gameHistory)
        {
            AllUsers allUsers = JSON_RW.GetUsers();
            Users user = JSON_RW.GetSession();
            Users currentUser = allUsers.Users.Find(x => x.Email == user.Email);
            //History has to be a list to add the gameHistory to
            // WIP
            //UserHistory AllHistory = currentUser.History;
            //currentUser.History
            // TODO: Convert history to list
        }
        public static AllUsers GetUsers()
        {
            return JSON_RW.GetUsers();
        }
    }
}
