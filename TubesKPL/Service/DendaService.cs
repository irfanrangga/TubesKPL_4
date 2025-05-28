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
        private BukuService _bukuService = new BukuService();
        private PenggunaService _penggunaService = new PenggunaService();

        public DendaService()
        {
            string sharedDataPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "SharedData", "DataJson");
            _jsonFilePath = Path.Combine(sharedDataPath, "DataDenda.json");
            _dendaList = new List<Denda>();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string jsonData = File.ReadAllText(_jsonFilePath);
                if (!string.IsNullOrEmpty(jsonData))
                {
                    _dendaList = JsonSerializer.Deserialize<List<Denda>>(jsonData) ?? new List<Denda>();
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

        public void HitungDenda()
        {
            Console.Clear();
            Console.WriteLine("=== PERHITUNGAN DENDA ===");


            var dendaBelumLunas = GetAllDenda()
                .Where(d => d.StatusDenda == Denda.STATUSDENDA.BELUMLUNAS)
                .ToArray();

            if (!dendaBelumLunas.Any())
            {
                Console.WriteLine("Tidak ada denda yang belum dibayar.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nDaftar Denda Belum Lunas:");
            for (int i = 0; i < dendaBelumLunas.Length; i++)
            {
                var denda = dendaBelumLunas[i];
                var buku = _bukuService.GetBukuById(denda.IdBuku);
                var anggota = _penggunaService.GetPenggunaById(denda.IdPengguna);

                Console.WriteLine($"{i + 1}. ID Denda: {denda.IdDenda}");
                Console.WriteLine($"   Buku: {buku?.Judul ?? "Unknown"}");
                Console.WriteLine($"   Anggota: {anggota?.Fullname ?? "Unknown"}");
                Console.WriteLine($"   Hari Keterlambatan: {denda.JumlahHariTerlambat}");
                Console.WriteLine($"   Jumlah Denda: Rp{denda.JumlahDenda}");
                Console.WriteLine();
            }

            Console.Write("Pilih nomor denda yang akan dibayar (0 untuk batal): ");
            if (!int.TryParse(Console.ReadLine(), out int pilihan) ||
                pilihan < 0 || pilihan > dendaBelumLunas.Length)
            {
                Console.WriteLine("Pilihan tidak valid!");
                Console.ReadKey();
                return;
            }

            if (pilihan == 0) return;

            var dendaDipilih = dendaBelumLunas[pilihan - 1];
            BayarDenda(dendaDipilih.IdDenda);

            Console.WriteLine($"\nDenda {dendaDipilih.IdDenda} telah dibayar.");
            Console.ReadKey();
        }

    }
}