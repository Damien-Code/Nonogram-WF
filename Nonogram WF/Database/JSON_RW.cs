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

namespace Nonogram_WF.Database
{
    public class JSON_RW
    {
        private static ObjectCache _sessionCache = MemoryCache.Default;
        // The relative filepath so data can be stored in the data.json file in the database folder.
        private static readonly string _filePath = "../../../Database/data.json";
        private static readonly string _sessionPath = "../../../Database/session.json";

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
            Users UserSession = new Users(email, settings, history);
            string JsonString = JsonSerializer.Serialize(UserSession, _options);
            File.WriteAllText(_sessionPath, JsonString);
        }
        public static Users GetSession()
        {
            //TODO: Add try catch
            try
            {
                Users? user = _sessionCache["session"] as Users;
                if (user == null)
                {
                    CacheItemPolicy policy = new CacheItemPolicy();
                    List<string> filePaths = new() { _sessionPath };
                    policy.ChangeMonitors.Add(new HostFileChangeMonitor(filePaths));
                    //using (FileStream file = new FileStream(_sessionPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                    //{
                    using (StreamReader streamReader = new StreamReader(_sessionPath))
                    {
                        string json = streamReader.ReadToEnd();
                        if (string.IsNullOrWhiteSpace(json)) json = "{}";

                        Users session = JsonSerializer.Deserialize<Users>(json, _options);
                        _sessionCache.Set("session", session,policy);
                        return session!;
                    }
                }
                else { return user; }
            }
            catch
            {
                //added failsafe if reader dies that the application will close
                MessageBox.Show("Something went wrong, please restart");
                Application.Exit();
            }

            return new Users();
            
        }
        public static void RemoveSession()
        {
            Settings settings = new Settings("", "");
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
            try
            {
                string JsonString = JsonSerializer.Serialize(allUsers, _options);
                File.WriteAllText(_sessionPath, JsonString);
            }
            catch
            {
                //added failsafe if reader dies that the application will close
                MessageBox.Show("Something went wrong, please restart");
                Application.Exit();
            }
        }
    }
}
