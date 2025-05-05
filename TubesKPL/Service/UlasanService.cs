//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using ManajemenPerpus.Core.Models;

//namespace ManajemenPerpus.CLI.Service
//{
//    public class UlasanService
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
    public class UlasanService
    {
        private List<Ulasan> ulasanList;
        private readonly BukuService bukuService;
        private readonly string _jsonFilePath;

        public UlasanService(BukuService bukuService)
        {
            this.bukuService = bukuService;

            // Initialize JSON file path
            string baseDirectory = AppContext.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));
            string sharedDataPath = Path.Combine(projectRoot, "SharedData", "DataJson");
            Directory.CreateDirectory(sharedDataPath);

            _jsonFilePath = Path.Combine(sharedDataPath, "DataUlasan.json");
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(_jsonFilePath))
            {
                string jsonData = File.ReadAllText(_jsonFilePath);
                if (!string.IsNullOrEmpty(jsonData))
                {
                    ulasanList = JsonSerializer.Deserialize<List<Ulasan>>(jsonData) ?? new List<Ulasan>();
                }
                else
                {
                    ulasanList = new List<Ulasan>();
                }
            }
            else
            {
                ulasanList = new List<Ulasan>();
            }
        }

        private void SaveData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(ulasanList, options);
            File.WriteAllText(_jsonFilePath, jsonData);
        }

        public Ulasan BuatUlasan(string bukuId, string penggunaId, string isiUlasan)
        {
            if (string.IsNullOrEmpty(bukuId))
            {
                Console.WriteLine("ID Buku tidak boleh kosong.");
                return null;
            }

            if (string.IsNullOrEmpty(isiUlasan))
            {
                Console.WriteLine("Ulasan tidak boleh kosong.");
                return null;
            }

            var buku = bukuService.GetBukuById(bukuId);
            if (buku == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return null;
            }

            string ulasanId = GenerateIdUlasan();
            var newUlasan = new Ulasan(ulasanId, penggunaId, isiUlasan);
            ulasanList.Add(newUlasan);
            SaveData();

            Console.WriteLine($"Ulasan berhasil ditambahkan pada buku: {buku.Judul}");
            return newUlasan;
        }

        public void AddUlasan(Ulasan ulasan)
        {
            if (ulasan != null)
            {
                ulasanList.Add(ulasan);
                SaveData();
                Console.WriteLine("Ulasan berhasil ditambahkan.");
            }
            else
            {
                Console.WriteLine("Gagal menambahkan ulasan.");
            }
        }

        private string GenerateIdUlasan()
        {
            int maxId = 0;
            foreach (var ulasan in ulasanList)
            {
                if (int.TryParse(ulasan.ulasanId.Substring(1), out int currentId))
                {
                    maxId = Math.Max(maxId, currentId);
                }
            }
            return $"U{(maxId