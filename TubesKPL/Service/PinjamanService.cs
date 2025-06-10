﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.CLI.Service
{
    public class PinjamanService
    {
        public readonly List<Pinjaman> pinjamanList = new();
        public readonly BukuService bukuService = new();
        public readonly PenggunaService penggunaService = new();
        public readonly DendaService dendaService = new();
        private readonly string _jsonFilePath;

        public PinjamanService()
        {
            // Inisialisasi path file JSON dan muat data awal
            string sharedDataPath = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.Parent!.FullName,
                "SharedData", "DataJson");

            _jsonFilePath = Path.Combine(sharedDataPath, "DataPinjaman.json");
            LoadData();
        }

        // Baca dan deserialisasi data pinjaman dari file
        public void LoadData()
        {
            if (!File.Exists(_jsonFilePath)) return;

            string jsonData = File.ReadAllText(_jsonFilePath);
            if (!string.IsNullOrWhiteSpace(jsonData))
            {
                pinjamanList.Clear();
                var deserialized = JsonSerializer.Deserialize<List<Pinjaman>>(jsonData);
                if (deserialized != null)
                {
                    pinjamanList.AddRange(deserialized);
                }
            }
        }

        // Serialisasi dan simpan data pinjaman ke file
        private void SaveData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(pinjamanList, options);
            File.WriteAllText(_jsonFilePath, jsonData);
        }

        // Tambah pinjaman baru: cek validitas, buat objek, simpan, update status buku
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

            // Generate ID dan tambahkan ke list
            string idPinjaman = GeneratePinjamanId();
            var pinjaman = new Pinjaman(idPinjaman, idBuku, idAnggota, batasPengembalian);
            pinjamanList.Add(pinjaman);
            SaveData();

<<<<<<< HEAD
            // Ubah status buku menjadi dipinjam
            buku.Status = Buku.STATUSBUKU.DIPINJAM;
            bukuService.UpdateBuku(buku);

=======
            buku.Status = BukuDeprecated.STATUSBUKU.DIPINJAM;
            _bukuService.UpdateBuku(buku); // Make sure to call UpdateBuku to save the status change
>>>>>>> main
            Console.WriteLine("Pinjaman berhasil ditambahkan.");
        }

        // Buat ID pinjaman berurutan
        public string GeneratePinjamanId()
        {
            return $"PJ{pinjamanList.Count + 1:D3}";
        }

        // Ambil semua data pinjaman
        public List<Pinjaman> GetAllPinjaman() => pinjamanList;

        // Cari pinjaman berdasarkan ID
        public Pinjaman? GetPinjamanById(string id)
        {
            return pinjamanList.FirstOrDefault(p => p.IdPinjaman == id);
        }

        // Hapus pinjaman: kembalikan status buku, hapus dari list, simpan file
        public bool HapusPinjaman(string id)
        {
            var pinjaman = GetPinjamanById(id);
<<<<<<< HEAD
            if (pinjaman == null) return false;
=======
            if (pinjaman != null)
            {
                var buku = _bukuService.GetBukuById(pinjaman.IdBuku);
                if (buku != null)
                {
                    buku.Status = BukuDeprecated.STATUSBUKU.TERSEDIA;
                    _bukuService.UpdateBuku(buku); // Make sure to call UpdateBuku to save the status change
                }
>>>>>>> main

            var buku = bukuService.GetBukuById(pinjaman.IdBuku);
            if (buku != null)
            {
                buku.Status = Buku.STATUSBUKU.TERSEDIA;
                bukuService.UpdateBuku(buku);
            }

            pinjamanList.Remove(pinjaman);
            SaveData();
            return true;
        }

        // Proses alur peminjaman via CLI: tampil pilihan buku, input anggota, simpan pinjaman
        public void ProsesPeminjaman()
        {
            Console.Clear();
            Console.WriteLine("=== PROSES PEMINJAMAN ===");

<<<<<<< HEAD
            // Ambil daftar buku tersedia
            var bukuTersedia = bukuService.GetAllBuku()
                .Where(b => b.Status == Buku.STATUSBUKU.TERSEDIA)
=======
            var bukuTersedia = _bukuService.GetAllBuku()
                .Where(b => b.Status == BukuDeprecated.STATUSBUKU.TERSEDIA)
>>>>>>> main
                .ToList();

            if (!bukuTersedia.Any())
            {
                Console.WriteLine("Tidak ada buku yang tersedia untuk dipinjam.");
                Console.ReadKey();
                return;
            }

            // Tampilkan dan ambil pilihan buku
            Console.WriteLine("\nDaftar Buku Tersedia:");
            for (int i = 0; i < bukuTersedia.Count; i++)
            {
                var buku = bukuTersedia[i];
                Console.WriteLine($"{i + 1}. {buku.Judul} (ID: {buku.IdBuku})");
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

            // Input ID anggota dan validasi
            Console.Write("Masukkan ID Anggota: ");
            string idAnggota = Console.ReadLine()?.Trim() ?? "";

            var anggota = penggunaService.GetPenggunaById(idAnggota);
            if (anggota == null || anggota.Role != Pengguna.ROLEPENGGUNA.anggota)
            {
                Console.WriteLine("Anggota tidak ditemukan atau ID tidak valid!");
                Console.ReadKey();
                return;
            }

            // Tentukan batas pengembalian dan panggil tambah pinjaman
            DateTime batasPengembalian = DateTime.Now.AddDays(7);
            TambahPinjaman(bukuDipinjam.IdBuku, idAnggota, batasPengembalian);

            // Tampilkan ringkasan peminjaman
            Console.WriteLine("\nPeminjaman berhasil!");
            Console.WriteLine($"ID Buku: {bukuDipinjam.IdBuku}");
            Console.WriteLine($"Judul: {bukuDipinjam.Judul}");
            Console.WriteLine($"Batas Pengembalian: {batasPengembalian:dd/MM/yyyy}");
            Console.ReadKey();
        }

        // Proses pengembalian via CLI: cek keterlambatan, hitung denda, hapus pinjaman
        public void ProsesPengembalian()
        {
            Console.Clear();
            Console.WriteLine("=== PENGEMBALIAN BUKU ===");

            // Input ID pinjaman
            Console.Write("Masukkan ID Pinjaman: ");
            string idPinjaman = Console.ReadLine()?.Trim() ?? "";

            var pinjaman = GetPinjamanById(idPinjaman);
            if (pinjaman == null)
            {
                Console.WriteLine("Pinjaman tidak ditemukan!");
                Console.ReadKey();
                return;
            }

            var buku = bukuService.GetBukuById(pinjaman.IdBuku);

            // Cek keterlambatan dan proses denda jika perlu
            if (DateTime.Now > pinjaman.BatasPengembalian)
            {
                var keterlambatan = DateTime.Now - pinjaman.BatasPengembalian;
                int hariTerlambat = (int)Math.Ceiling(keterlambatan.TotalDays);
                int jumlahDenda = hariTerlambat * 5000;

                string idDenda = $"D{DateTime.Now:yyyyMMddHHmmss}";
                var denda = new Denda(pinjaman.IdAnggota, pinjaman.IdBuku, pinjaman.IdPinjaman, Denda.STATUSDENDA.BELUMLUNAS)
                {
                    IdDenda = idDenda,
                    JumlahHariTerlambat = hariTerlambat,
                    JumlahDenda = jumlahDenda
                };

                dendaService.AddDenda(denda);
                Console.WriteLine($"\nBuku dikembalikan terlambat {hariTerlambat} hari.");
                Console.WriteLine($"Denda yang harus dibayar: Rp{jumlahDenda}");
            }
            else
            {
                Console.WriteLine("\nBuku dikembalikan tepat waktu.");
            }

            // Hapus pinjaman dan simpan perubahan
            if (!HapusPinjaman(idPinjaman))
            {
                Console.WriteLine("Pengembalian gagal");
                return;
            }

            Console.WriteLine("\nPengembalian berhasil diproses!");
            Console.ReadKey();
        }

        // Proses perpanjangan pinjaman: hapus lama, tambah baru dengan batas baru
        public void ProsesPerpanjangan()
        {
            Console.Clear();
            Console.WriteLine("=== PERPANJANGAN PINJAMAN ===");

            Console.Write("Masukkan ID Pinjaman: ");
            string idPinjaman = Console.ReadLine()?.Trim() ?? "";

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

        // Tampilkan semua pinjaman aktif beserta status
        public void TampilkanDaftarPinjaman()
        {
            Console.Clear();
            Console.WriteLine("=== DAFTAR PINJAMAN AKTIF ===");

            if (!pinjamanList.Any())
            {
                Console.WriteLine("Tidak ada pinjaman aktif.");
                Console.ReadKey();
                return;
            }

            // Loop setiap pinjaman dan tampilkan detail
            foreach (var pinjaman in pinjamanList)
            {
                var buku = bukuService.GetBukuById(pinjaman.IdBuku);
                var anggota = penggunaService.GetPenggunaById(pinjaman.IdAnggota);

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
