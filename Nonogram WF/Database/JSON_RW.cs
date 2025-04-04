using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Nonogram_WF.Models;
using System.Runtime.Caching;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Security;

namespace Nonogram_WF.Database
{
    public class JSON_RW
    {
        private static ObjectCache _sessionCache = MemoryCache.Default;



        // The relative filepath so data can be stored in the data.json file in the database folder.


        //--THIS IS NEEDED FOR TESTING, YOU CANT ADD USERCONTROLS WITHOUT PROPER PATHSETTING--

        //inspiration from https://stackoverflow.com/questions/30991331/how-to-navigate-one-folder-up-from-current-file-path
        static string prefix = Convert.ToString(Directory.GetParent(Convert.ToString(Directory.GetParent(Convert.ToString(Directory.GetParent(Convert.ToString(Directory.GetParent(Environment.CurrentDirectory))))))));
        private static readonly string _filePath = prefix + "/Nonogram WF/Database/data.json";
        private static readonly string _sessionPath = prefix + "/Nonogram WF/Database/session.json";

        //private static readonly string _filePath    = "../../../../Nonogram WF/Database/data.json";
        //private static readonly string _sessionPath = "../../../../Nonogram WF/Database/session.json";

        /// <summary>
        /// Static method so it is possible to write to data.json everywhere
        /// Serializes the object that is stored and the options
        /// Writes the serialized content to the data.json 
        /// </summary>
        /// <param name="obj"></param>
        public static void WriteFile(object obj)
        {
            string JsonString = JsonSerializer.Serialize(obj, _options);
            
            File.WriteAllText(_filePath, JsonString);
        }

        /// <summary>
        /// // Options for the data.json file
        /// Indentation for better readability
        /// </summary>
        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
        };

        /// <summary>
        /// Uses streamreader to read through the whole JSON file
        /// Deserializes the JSON string to the AllUsers object
        /// Returns the AllUsers object
        /// </summary>
        /// <returns type="AllUsers"></returns>
        public static AllUsers GetUsers()
        {
            using StreamReader streamReader = new StreamReader(_filePath);

            string json = streamReader.ReadToEnd();

            // if string is empty or null or whitespace
            // make json valid JSON object
            // if initialization of JSON was empty, it would result in error
            if (string.IsNullOrWhiteSpace(json)) json = "{}";
            AllUsers? users = JsonSerializer.Deserialize<AllUsers>(json, _options);
            return users!;
        }
        public static void SetSession(string email, Settings settings, UserHistory history)
        { //add setting

            Users? user = _sessionCache["session"] as Users;
            Users UserSession = new Users(email, settings, history);
            if (user != null) {
                _sessionCache.Remove("session");
                CacheItemPolicy policy = new CacheItemPolicy();
                List<string> filePaths = new() { _sessionPath };
                policy.ChangeMonitors.Add(new HostFileChangeMonitor(filePaths));
                _sessionCache.Set("session", UserSession, policy);
            }

            string JsonString = JsonSerializer.Serialize(UserSession, _options);
            File.WriteAllText(_sessionPath, JsonString);
        }
        public static Users GetSession()
        {
            Users? user = _sessionCache["session"] as Users;
                CacheItemPolicy policy = new CacheItemPolicy();
                List<string> filePaths = new() { _sessionPath }; 
                string json = "";
            if (user == null || user.Email == "")
            {
                policy.ChangeMonitors.Add(new HostFileChangeMonitor(filePaths));
            try
            {
                json = File.ReadAllText(_sessionPath);
                if (string.IsNullOrWhiteSpace(json)) json = "{}";
                Users session = JsonSerializer.Deserialize<Users>(json, _options);
                _sessionCache.Set("session", session, policy);
                return session!;   
            }
                catch

            {
                //added failsafe if reader dies that the application will close
                MessageBox.Show("Something went wrong, please restart");
                Application.Exit();
            }

                }
                else { 
                
                return user; }

            return new Users();

        }
        public static void RemoveSession()
        {
            Settings settings = new("", "");

            Users user = new Users("", settings, new UserHistory());
            string JsonString = JsonSerializer.Serialize(user, _options);

            File.WriteAllText(_sessionPath, JsonString);
            return;
        }
        public static void UpdateUserSettings(AllUsers allUsers)
        {
            string JsonString = JsonSerializer.Serialize(allUsers, _options);
            File.WriteAllText(_filePath, JsonString);
        }
        public static void UpdateSessionSettings(Users allUsers)
        {
            string JsonString = JsonSerializer.Serialize(allUsers, _options);
            File.WriteAllText(_sessionPath, JsonString);


        }
    }
}
