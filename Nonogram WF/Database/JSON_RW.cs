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
        private string _filePath = "../../../Database/data.json";

        public static void WriteFile(object obj, string fileName)
        {
            string JsonString = JsonSerializer.Serialize(obj, _options);
            File.WriteAllText(fileName, JsonString);
        }

        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
        };

        public static Users GetUsers(string fileName)
        {
            using StreamReader streamReader = new StreamReader(fileName);
            string json = streamReader.ReadToEnd();
            Users? users = JsonSerializer.Deserialize<Users>(json, _options);
            return users!;
        }
    }
}
