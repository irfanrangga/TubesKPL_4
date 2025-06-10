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
        public static void WriteJson<T>(string filePath, List<T> data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static List<T> ReadJson<T>(string filePath)
        {

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
            try
            {
                string jsonString = File.ReadAllText(filePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                return JsonSerializer.Deserialize<List<T>>(jsonString, options) ?? new List<T>();
            }
            catch(JsonException ex)
            {
                throw new InvalidOperationException($"Error deserializing JSON from file: {filePath}", ex);
            }
        }
    }
}
