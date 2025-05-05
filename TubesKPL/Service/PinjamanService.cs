using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.CLI.Service
{
    public class PinjamanService
    {
        private List<Pinjaman> listPinjaman = new List<Pinjaman>();
        private BukuService bukuService;
        private PenggunaService penggunaService;
        private readonly string _jsonFilePath;

        public PinjamanService(BukuService bukuService, PenggunaService penggunaService)
        {
            this.bukuService = bukuService;
            this.penggunaService = penggunaService;

            // Get the directory where the application is running from
            string baseDirectory = AppContext.BaseDirectory;

            // Navigate up to the project root directory (assuming it's 3 levels up from bin/Debug/net8.0)
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));

            // Combine with the SharedData path
            string sharedDataPath = Path.Combine(projectRoot, "SharedData", "DataJson");

            // Ensure the directory exists
            Directory.CreateDirectory(sharedDataPath);

            _jsonFilePath = Path.Combine(sharedDataPath, "DataPinjaman.json");
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(_jsonFilePath))
            {
                string jsonData = File.ReadAllText(_jsonFilePath);
                if (!string.IsNullOrEmpty(jsonData))
                {
                    listPinjaman = JsonSerializer.Deserialize<List<Pinjaman>>(jsonData) ?? new List<Pinjaman>();
                }
            }
        }

        private void SaveData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(listPinjaman, options);
            File.WriteAllText(_jsonFilePath, jsonData);
        }

        public void TambahPinjaman(string idBuku, string idAnggota, DateTime batasPengembalian)
        {
            var buku = bukuService.GetBukuById(idBuku);
            var anggota = penggunaService.GetPenggunaById(idAnggota);

            if (buku == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return;
            }

            if (anggota == null || anggota.Role != Pengguna.ROLEPENGGUNA.anggota)
            {
                Console.WriteLine("Anggota tidak valid.");
                return;
            }

            string idPinjaman = GeneratePinjamanId();
            Pinjaman pinjaman = new Pinjaman(idPinjaman, idBuku, idAnggota, batasPengembalian);
            listPinjaman.Add(pinjaman);
            SaveData();

            buku.Status = Buku.STATUSBUKU.DIPINJAM;
            bukuService.UpdateBuku(buku); // Make sure to call UpdateBuku to save the status change
            Console.WriteLine("Pinjaman berhasil ditambahkan.");
        }

        private string GeneratePinjamanId()
        {
            int count = listPinjaman.Count + 1;
            return $"PJ{count:D3}";
        }

        public List<Pinjaman> GetAllPinjaman()
        {
            return listPinjaman;
        }

        public Pinjaman GetPinjamanById(string id)
        {
            return listPinjaman.FirstOrDefault(p => p.IdPinjaman == id);
        }

        public bool HapusPinjaman(string id)
        {
            var pinjaman = GetPinjamanById(id);
            if (pinjaman != null)
            {
                var buku = bukuService.GetBukuById(pinjaman.IdBuku);
                if (buku != null)
                {
                    buku.Status = Buku.STATUSBUKU.TERSEDIA;
                    bukuService.UpdateBuku(buku); // Make sure to call UpdateBuku to save the status change
                }

                listPinjaman.Remove(pinjaman);
                SaveData();
                return true;
            }
            return false;
        }
    }
}