using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Nonogram_WF.Models;
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
    }
}
