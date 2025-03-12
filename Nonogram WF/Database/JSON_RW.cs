using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace Nonogram_WF.Database
{
    public class JSON_RW
    {
        // The relative filepath so data can be stored in the data.json file in the database folder.
        private static readonly string _filePath = "../../../Database/data.json";

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
        /// Creates new instance of streamreader so it is possible to read the whole data.json file
        /// Deserialize json to Users object
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns type="Users"></returns>
        //public static Users GetUsers(string fileName)
        //{
        //    using StreamReader streamReader = new StreamReader(fileName);
        //    string json = streamReader.ReadToEnd();
        //    Users? users = JsonSerializer.Deserialize<Users>(json, _options);
        //    return users!;
        //}
    }
}
