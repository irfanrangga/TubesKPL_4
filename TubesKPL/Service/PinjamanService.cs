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
        private BukuService _bukuService = new BukuService();
        private PenggunaService _penggunaService = new PenggunaService();
        private DendaService _dendaService = new DendaService();
        private readonly string _jsonFilePath;

        public PinjamanService()
        {
            string sharedDataPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,"SharedData", "DataJson");
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
            var buku = _bukuService.GetBukuById(idBuku);
            var anggota = _penggunaService.GetPenggunaById(idAnggota);

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

            buku.Status = BukuDeprecated.STATUSBUKU.DIPINJAM;
            _bukuService.UpdateBuku(buku); // Make sure to call UpdateBuku to save the status change
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
                var buku = _bukuService.GetBukuById(pinjaman.IdBuku);
                if (buku != null)
                {
                    buku.Status = BukuDeprecated.STATUSBUKU.TERSEDIA;
                    _bukuService.UpdateBuku(buku); // Make sure to call UpdateBuku to save the status change
                }

                listPinjaman.Remove(pinjaman);
                SaveData();
                return true;
            }
            return false;
        }

        public void ProsesPeminjaman()
        {
            Console.Clear();
            Console.WriteLine("=== PROSES PEMINJAMAN ===");

            var bukuTersedia = _bukuService.GetAllBuku()
                .Where(b => b.Status == BukuDeprecated.STATUSBUKU.TERSEDIA)
                .ToList();

            if (!bukuTersedia.Any())
            {
                Console.WriteLine("Tidak ada buku yang tersedia untuk dipinjam.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nDaftar Buku Tersedia:");
            for (int i = 0; i < bukuTersedia.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bukuTersedia[i].Judul} (ID: {bukuTersedia[i].IdBuku})");
            }

            Console.Write("\nPilih nomor buku: ");
            if (!int.TryParse(Console.ReadLine(), out int pilihanBuku) ||
                pilihanBuku < 1 || pilihanBuku > bukuTersedia.Count)
            {
                Console.WriteLine("Pilihan tidak valid!");
                Console.ReadKey();
                return;
            }

            var bukuDipinjam = bukuTersedia[pilihanBuku - 1];

            Console.Write("Masukkan ID Anggota: ");
            string idAnggota = Console.ReadLine().Trim();
            var anggota = _penggunaService.GetPenggunaById(idAnggota);

            if (anggota == null || anggota.Role != Pengguna.ROLEPENGGUNA.anggota)
            {
                Console.WriteLine("Anggota tidak ditemukan atau ID tidak valid!");
                Console.ReadKey();
                return;
            }

            DateTime batasPengembalian = DateTime.Now.AddDays(7);
            TambahPinjaman(bukuDipinjam.IdBuku, idAnggota, batasPengembalian);

            Console.WriteLine("\nPeminjaman berhasil!");
            Console.WriteLine($"ID Buku: {bukuDipinjam.IdBuku}");
            Console.WriteLine($"Judul: {bukuDipinjam.Judul}");
            Console.WriteLine($"Batas Pengembalian: {batasPengembalian:dd/MM/yyyy}");
            Console.ReadKey();
        }


        public void ProsesPengembalian()
        {
            Console.Clear();
            Console.WriteLine("=== PENGEMBALIAN BUKU ===");

            Console.Write("Masukkan ID Pinjaman: ");
            string idPinjaman = Console.ReadLine().Trim();
            var pinjaman = GetPinjamanById(idPinjaman);

            if (pinjaman == null)
            {
                Console.WriteLine("Pinjaman tidak ditemukan!");
                Console.ReadKey();
                return;
            }

            var buku = _bukuService.GetBukuById(pinjaman.IdBuku);
            var anggota = _penggunaService.GetPenggunaById(pinjaman.IdAnggota);

            if (DateTime.Now > pinjaman.BatasPengembalian)
            {
                TimeSpan keterlambatan = DateTime.Now - pinjaman.BatasPengembalian;
                int hariTerlambat = (int)Math.Ceiling(keterlambatan.TotalDays);
                int jumlahDenda = hariTerlambat * 5000;

                string idDenda = "D" + DateTime.Now.ToString("yyyyMMddHHmmss");
                var denda = new Denda(
                    pinjaman.IdAnggota,
                    pinjaman.IdBuku,
                    pinjaman.IdPinjaman,
                    Denda.STATUSDENDA.BELUMLUNAS)
                {
                    IdDenda = idDenda,
                    JumlahHariTerlambat = hariTerlambat,
                    JumlahDenda = jumlahDenda
                };

                _dendaService.AddDenda(denda);

                Console.WriteLine($"\nBuku dikembalikan terlambat {hariTerlambat} hari.");
                Console.WriteLine($"Denda yang harus dibayar: Rp{jumlahDenda}");
            }
            else
            {
                Console.WriteLine("\nBuku dikembalikan tepat waktu.");
            }

            if (!HapusPinjaman(idPinjaman))
            {
                Console.WriteLine("Pengembalian gagal");
            }

            Console.WriteLine("\nPengembalian berhasil diproses!");
            Console.ReadKey();
        }

        public void ProsesPerpanjangan()
        {
            Console.Clear();
            Console.WriteLine("=== PERPANJANGAN PINJAMAN ===");


            Console.Write("Masukkan ID Pinjaman: ");
            string idPinjaman = Console.ReadLine().Trim();
            var pinjaman = GetPinjamanById(idPinjaman);

            if (pinjaman == null)
            {
                Console.WriteLine("Pinjaman tidak ditemukan!");
                Console.ReadKey();
                return;
            }


            DateTime batasBaru = pinjaman.BatasPengembalian.AddDays(7);


            HapusPinjaman(idPinjaman);
            TambahPinjaman(pinjaman.IdBuku, pinjaman.IdAnggota, batasBaru);

            Console.WriteLine("\nPerpanjangan berhasil!");
            Console.WriteLine($"Batas pengembalian baru: {batasBaru:dd/MM/yyyy}");
            Console.ReadKey();
        }

        public void TampilkanDaftarPinjaman()
        {
            Console.Clear();
            Console.WriteLine("=== DAFTAR PINJAMAN AKTIF ===");

            var semuaPinjaman = GetAllPinjaman();

            if (!semuaPinjaman.Any())
            {
                Console.WriteLine("Tidak ada pinjaman aktif.");
                Console.ReadKey();
                return;
            }

            foreach (var pinjaman in semuaPinjaman)
            {
                var buku = _bukuService.GetBukuById(pinjaman.IdBuku);
                var anggota = _penggunaService.GetPenggunaById(pinjaman.IdAnggota);

                Console.WriteLine($"ID Pinjaman: {pinjaman.IdPinjaman}");
                Console.WriteLine($"Buku: {buku?.Judul ?? "Unknown"} (ID: {pinjaman.IdBuku})");
                Console.WriteLine($"Anggota: {anggota?.Fullname ?? "Unknown"} (ID: {pinjaman.IdAnggota})");
                Console.WriteLine($"Batas Pengembalian: {pinjaman.BatasPengembalian:dd/MM/yyyy}");
                Console.WriteLine($"Status: {(DateTime.Now > pinjaman.BatasPengembalian ? "Terlambat" : "Aktif")}");
                Console.WriteLine();
            }

            Console.WriteLine("Tekan sembarang tombol untuk kembali...");
            Console.ReadKey();
        }

    }
}