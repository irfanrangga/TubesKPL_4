//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using ManajemenPerpus.Core.Models;

//namespace ManajemenPerpus.CLI.Service
//{
//    public class NotifikasiService
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.CLI.Service
{
    public class NotifikasiService
    {
        private readonly string _jsonFilePath;
        private List<Notifikasi> _notifikasiList;

        public NotifikasiService()
        {
            // Get the directory where the application is running from
            string baseDirectory = AppContext.BaseDirectory;

            // Navigate up to the project root directory (assuming it's 3 levels up from bin/Debug/net8.0)
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));

            // Combine with the SharedData path
            string sharedDataPath = Path.Combine(projectRoot, "SharedData", "DataJson");

            // Ensure the directory exists
            Directory.CreateDirectory(sharedDataPath);

            _jsonFilePath = Path.Combine(sharedDataPath, "DataNotifikasi.json");
            _notifikasiList = new List<Notifikasi>();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(_jsonFilePath))
                {
                    string jsonData = File.ReadAllText(_jsonFilePath);
                    _notifikasiList = JsonSerializer.Deserialize<List<Notifikasi>>(jsonData) ?? new List<Notifikasi>();
                }
                else
                {
                    // Create file if it doesn't exist
                    File.WriteAllText(_jsonFilePath, "[]");
                    _notifikasiList = new List<Notifikasi>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading notification data: {ex.Message}");
                _notifikasiList = new List<Notifikasi>();
            }
        }

        private void SaveData()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonData = JsonSerializer.Serialize(_notifikasiList, options);
                File.WriteAllText(_jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving notification data: {ex.Message}");
            }
        }

        public List<Notifikasi> GetAllNotifikasi()
        {
            return _notifikasiList;
        }

        public List<Notifikasi> GetNotifikasiByPengguna(string idPengguna)
        {
            return _notifikasiList.Where(n => n.IdPengguna == idPengguna).ToList();
        }

        public Notifikasi GetNotifikasiById(string id)
        {
            return _notifikasiList.FirstOrDefault(n => n.IdNotifikasi == id);
        }

        public void AddNotifikasi(Notifikasi newNotifikasi)
        {
            if (string.IsNullOrEmpty(newNotifikasi.IdNotifikasi))
            {
                newNotifikasi.IdNotifikasi = Guid.NewGuid().ToString();
            }
            newNotifikasi.TanggalNotifikasi = DateTime.Now;
            _notifikasiList.Add(newNotifikasi);
            SaveData();
        }

        public void UpdateNotifikasi(Notifikasi updatedNotifikasi)
        {
            var existingNotifikasi = _notifikasiList.FirstOrDefault(n => n.IdNotifikasi == updatedNotifikasi.IdNotifikasi);
            if (existingNotifikasi != null)
            {
                existingNotifikasi.IdPengguna = updatedNotifikasi.IdPengguna;
                existingNotifikasi.IsiNotifikasi = updatedNotifikasi.IsiNotifikasi;
                existingNotifikasi.TanggalNotifikasi = updatedNotifikasi.TanggalNotifikasi;
                SaveData();
            }
        }

        public void DeleteNotifikasi(string id)
        {
            var notifikasiToRemove = _notifikasiList.FirstOrDefault(n => n.IdNotifikasi == id);
            if (notifikasiToRemove != null)
            {
                _notifikasiList.Remove(notifikasiToRemove);
                SaveData();
            }
        }

        public void SendNotifikasi(string idPengguna, string message)
        {
            var newNotifikasi = new Notifikasi(
                idNotifikasi: Guid.NewGuid().ToString(),
                idPengguna: idPengguna,
                isiNotifikasi: message,
                tanggalNotifikasi: DateTime.Now
            );
            AddNotifikasi(newNotifikasi);
        }
    }
}