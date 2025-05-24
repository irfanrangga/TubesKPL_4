using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ManajemenPerpus.Core.Helper
{
    public static class JsonHelper
    {
        public static void WriteJson<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static T ReadJson<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            else
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
        }
    }
}
