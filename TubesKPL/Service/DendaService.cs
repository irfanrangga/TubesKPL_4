//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.Json;
//using ManajemenPerpus.Core.Models;

//namespace ManajemenPerpus.CLI.Service
//{
//    public class DendaService
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.CLI.Service
{
    public class DendaService
    {
        private readonly string _jsonFilePath;
        private List<Denda> _dendaList;

        public DendaService()
        {
            // Get the directory where the application is running from
            string baseDirectory = AppContext.BaseDirectory;

            // Navigate up to the project root directory (assuming it's 3 levels up from bin/Debug/net8.0)
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));

            // Combine with the SharedData path
            string sharedDataPath = Path.Combine(projectRoot, "SharedData", "DataJson");

            // Ensure the directory exists
            Directory.CreateDirectory(sharedDataPath);

            _jsonFilePath = Path.Combine(sharedDataPath, "DataDenda.json");
            _dendaList = new List<Denda>();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(_jsonFilePath))
                {
                    string jsonData = File.ReadAllText(_jsonFilePath);
                    _dendaList = JsonSerializer.Deserialize<List<Denda>>(jsonData) ?? new List<Denda>();
                }
                else
                {
                    // Create file if it doesn't exist
                    File.WriteAllText(_jsonFilePath, "[]");
                    _dendaList = new List<Denda>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
                _dendaList = new List<Denda>();
            }
        }

        private void SaveData()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonData = JsonSerializer.Serialize(_dendaList, options);
                File.WriteAllText(_jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        public List<Denda> GetAllDenda()
        {
            return _dendaList;
        }

        public Denda GetDendaById(string id)
        {
            return _dendaList.FirstOrDefault(d => d.IdDenda == id);
        }

        public List<Denda> GetDendaByPengguna(string idPengguna)
        {
            return _dendaList.Where(d => d.IdPengguna == idPengguna).ToList();
        }

        public void AddDenda(Denda newDenda)
        {
            _dendaList.Add(newDenda);
            SaveData();
        }

        public void UpdateDenda(Denda updatedDenda)
        {
            var existingDenda = _dendaList.FirstOrDefault(d => d.IdDenda == updatedDenda.IdDenda);
            if (existingDenda != null)
            {
                existingDenda.IdPengguna = updatedDenda.IdPengguna;
                existingDenda.IdBuku = updatedDenda.IdBuku;
                existingDenda.IdPeminjaman = updatedDenda.IdPeminjaman;
                existingDenda.StatusDenda = updatedDenda.StatusDenda;
                existingDenda.JumlahDenda = updatedDenda.JumlahDenda;
                existingDenda.JumlahHariTerlambat = updatedDenda.JumlahHariTerlambat;
                SaveData();
            }
        }

        public void DeleteDenda(string id)
        {
            var dendaToRemove = _dendaList.FirstOrDefault(d => d.IdDenda == id);
            if (dendaToRemove != null)
            {
                _dendaList.Remove(dendaToRemove);
                SaveData();
            }
        }

        public void BayarDenda(string id)
        {
            var denda = _dendaList.FirstOrDefault(d => d.IdDenda == id);
            if (denda != null)
            {
                denda.StatusDenda = Denda.STATUSDENDA.LUNAS;
                SaveData();
            }
        }
    }
}