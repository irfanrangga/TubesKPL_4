using System;
using System.Collections.Generic;
using System.Linq;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;


namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturSirkulasiBuku
    {
        private readonly BukuService _bukuService;
        private readonly PenggunaService _penggunaService;
        private readonly PinjamanService _pinjamanService;
        private readonly DendaService _dendaService;

        public ProgramState MenuSirkulasiBuku()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SIRKULASI BUKU ===");
                Console.WriteLine("1. Proses Peminjaman");
                Console.WriteLine("2. Pengembalian Buku");
                Console.WriteLine("3. Perpanjangan Pinjaman");
                Console.WriteLine("4. Perhitungan Denda");
                Console.WriteLine("5. Lihat Daftar Pinjaman Aktif");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.Write("Pilih opsi: ");

                if (int.TryParse(Console.ReadLine(), out int pilihan))
                {
                    switch (pilihan)
                    {
                        case 1:
                            ProsesPeminjaman();
                            break;
                        case 2:
                            ProsesPengembalian();
                            break;
                        case 3:
                            ProsesPerpanjangan();
                            break;
                        case 4:
                            HitungDenda();
                            break;
                        case 5:
                            TampilkanDaftarPinjaman();
                            break;
                        case 0:
                            return ProgramState.StateMenuUtama;
                        default:
                            Console.WriteLine("Pilihan tidak valid!");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input harus berupa angka!");
                    Console.ReadKey();
                }
            }
        }

        private void ProsesPeminjaman()
        {
            Console.Clear();
            Console.WriteLine("=== PROSES PEMINJAMAN ===");

            // Tampilkan daftar buku yang tersedia
            var bukuTersedia = _bukuService.GetAllBuku()
                .Where(b => b.Status == Buku.STATUSBUKU.TERSEDIA)
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

            // Pilih buku
            Console.Write("\nPilih nomor buku: ");
            if (!int.TryParse(Console.ReadLine(), out int pilihanBuku) ||
                pilihanBuku < 1 || pilihanBuku > bukuTersedia.Count)
            {
                Console.WriteLine("Pilihan tidak valid!");
                Console.ReadKey();
                return;
            }

            var bukuDipinjam = bukuTersedia[pilihanBuku - 1];

            // Input ID anggota
            Console.Write("Masukkan ID Anggota: ");
            string idAnggota = Console.ReadLine().Trim();
            var anggota = _penggunaService.GetPenggunaById(idAnggota);

            if (anggota == null || anggota.Role != Pengguna.ROLEPENGGUNA.anggota)
            {
                Console.WriteLine("Anggota tidak ditemukan atau ID tidak valid!");
                Console.ReadKey();
                return;
            }

            // Proses peminjaman
            DateTime batasPengembalian = DateTime.Now.AddDays(7); // Batas 7 hari
            _pinjamanService.TambahPinjaman(bukuDipinjam.IdBuku, idAnggota, batasPengembalian);

            Console.WriteLine("\nPeminjaman berhasil!");
            Console.WriteLine($"ID Buku: {bukuDipinjam.IdBuku}");
            Console.WriteLine($"Judul: {bukuDipinjam.Judul}");
            Console.WriteLine($"Batas Pengembalian: {batasPengembalian:dd/MM/yyyy}");
            Console.ReadKey();
        }

        private void ProsesPengembalian()
        {
            Console.Clear();
            Console.WriteLine("=== PENGEMBALIAN BUKU ===");

            // Input ID pinjaman
            Console.Write("Masukkan ID Pinjaman: ");
            string idPinjaman = Console.ReadLine().Trim();
            var pinjaman = _pinjamanService.GetPinjamanById(idPinjaman);

            if (pinjaman == null)
            {
                Console.WriteLine("Pinjaman tidak ditemukan!");
                Console.ReadKey();
                return;
            }

            var buku = _bukuService.GetBukuById(pinjaman.IdBuku);
            var anggota = _penggunaService.GetPenggunaById(pinjaman.IdAnggota);

            // Hitung denda jika terlambat
            if (DateTime.Now > pinjaman.BatasPengembalian)
            {
                TimeSpan keterlambatan = DateTime.Now - pinjaman.BatasPengembalian;
                int hariTerlambat = (int)Math.Ceiling(keterlambatan.TotalDays);
                int jumlahDenda = hariTerlambat * 5000; // Rp5000 per hari

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

            // Hapus pinjaman
            _pinjamanService.HapusPinjaman(idPinjaman);

            Console.WriteLine("\nPengembalian berhasil diproses!");
            Console.ReadKey();
        }

        private void ProsesPerpanjangan()
        {
            Console.Clear();
            Console.WriteLine("=== PERPANJANGAN PINJAMAN ===");

            // Input ID pinjaman
            Console.Write("Masukkan ID Pinjaman: ");
            string idPinjaman = Console.ReadLine().Trim();
            var pinjaman = _pinjamanService.GetPinjamanById(idPinjaman);

            if (pinjaman == null)
            {
                Console.WriteLine("Pinjaman tidak ditemukan!");
                Console.ReadKey();
                return;
            }

            // Perpanjang 7 hari dari batas sebelumnya
            DateTime batasBaru = pinjaman.BatasPengembalian.AddDays(7);

            // Update pinjaman (karena kita tidak punya method update, kita hapus dan buat baru)
            _pinjamanService.HapusPinjaman(idPinjaman);
            _pinjamanService.TambahPinjaman(pinjaman.IdBuku, pinjaman.IdAnggota, batasBaru);

            Console.WriteLine("\nPerpanjangan berhasil!");
            Console.WriteLine($"Batas pengembalian baru: {batasBaru:dd/MM/yyyy}");
            Console.ReadKey();
        }

        private void HitungDenda()
        {
            Console.Clear();
            Console.WriteLine("=== PERHITUNGAN DENDA ===");

            // Tampilkan denda yang belum lunas
            var dendaBelumLunas = _dendaService.GetAllDenda()
                .Where(d => d.StatusDenda == Denda.STATUSDENDA.BELUMLUNAS)
                .ToList();

            if (!dendaBelumLunas.Any())
            {
                Console.WriteLine("Tidak ada denda yang belum dibayar.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nDaftar Denda Belum Lunas:");
            for (int i = 0; i < dendaBelumLunas.Count; i++)
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

            // Pilihan untuk membayar denda
            Console.Write("Pilih nomor denda yang akan dibayar (0 untuk batal): ");
            if (!int.TryParse(Console.ReadLine(), out int pilihan) ||
                pilihan < 0 || pilihan > dendaBelumLunas.Count)
            {
                Console.WriteLine("Pilihan tidak valid!");
                Console.ReadKey();
                return;
            }

            if (pilihan == 0) return;

            var dendaDipilih = dendaBelumLunas[pilihan - 1];
            _dendaService.BayarDenda(dendaDipilih.IdDenda);

            Console.WriteLine($"\nDenda {dendaDipilih.IdDenda} telah dibayar.");
            Console.ReadKey();
        }

        private void TampilkanDaftarPinjaman()
        {
            Console.Clear();
            Console.WriteLine("=== DAFTAR PINJAMAN AKTIF ===");

            var semuaPinjaman = _pinjamanService.GetAllPinjaman();

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