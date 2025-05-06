//using System;

//namespace ManajemenPerpus.CLI.Fitur
//{
//    public class FiturLaporanStatistik
//    {
//        public ProgramState MenuLaporanStatistik()
//        {
//            Console.Clear();
//            Console.WriteLine("=== LAPORAN & STATISTIK ===");
//            Console.WriteLine("1. Laporan Peminjaman");
//            Console.WriteLine("2. Statistik Pengunjung");
//            Console.WriteLine("3. Laporan Buku Populer");
//            Console.WriteLine("0. Kembali ke Menu Utama");
//            Console.Write("Pilih opsi: ");

//            int pilihan;
//            if (int.TryParse(Console.ReadLine(), out pilihan))
//            {
//                switch (pilihan)
//                {
//                    case 0:
//                        return ProgramState.StateMenuUtama;
//                    default:
//                        Console.WriteLine($"Fitur {pilihan} akan diimplementasikan");
//                        Console.ReadKey();
//                        break;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Input tidak valid. Harap masukkan angka.");
//                Console.ReadKey();
//            }
//            return ProgramState.StateMenuUtama;
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using ManajemenPerpus.CLI.Service;
using ManajemenPerpus.Core.Models;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturLaporanStatistik
    {
        private readonly BukuService _bukuService;
        private readonly PinjamanService _pinjamanService;
        private readonly DendaService _dendaService;
        private readonly PenggunaService _penggunaService;

        public FiturLaporanStatistik(BukuService bukuService, PinjamanService pinjamanService,
                                   DendaService dendaService, PenggunaService penggunaService)
        {
            _bukuService = bukuService;
            _pinjamanService = pinjamanService;
            _dendaService = dendaService;
            _penggunaService = penggunaService;
        }

        public ProgramState MenuLaporanStatistik()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== LAPORAN & STATISTIK ===");
                Console.WriteLine("1. Laporan Peminjaman Bulanan");
                Console.WriteLine("2. Statistik Buku Populer");
                Console.WriteLine("3. Laporan Denda");
                Console.WriteLine("4. Aktivitas Anggota");
                Console.WriteLine("0. Kembali ke Menu Utama");
                Console.Write("Pilih opsi: ");

                int pilihan;
                if (int.TryParse(Console.ReadLine(), out pilihan))
                {
                    switch (pilihan)
                    {
                        case 1:
                            LaporanPeminjamanBulanan();
                            break;
                        case 2:
                            StatistikBukuPopuler();
                            break;
                        case 3:
                            LaporanDenda();
                            break;
                        case 4:
                            AktivitasAnggota();
                            break;
                        case 0:
                            return ProgramState.StateMenuUtama;
                        default:
                            Console.WriteLine($"Fitur {pilihan} belum tersedia");
                            Console.WriteLine("Tekan sembarang tombol untuk melanjutkan...");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Harap masukkan angka.");
                    Console.WriteLine("Tekan sembarang tombol untuk melanjutkan...");
                    Console.ReadKey();
                }
            }
        }

        private void LaporanPeminjamanBulanan()
        {
            bool kembali = false;
            while (!kembali)
            {
                Console.Clear();
                Console.WriteLine("=== LAPORAN PEMINJAMAN BULANAN ===");

                int currentYear = DateTime.Now.Year;
                int currentMonth = DateTime.Now.Month;

                Console.Write($"Masukkan tahun (kosongkan untuk {currentYear}): ");
                string yearInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(yearInput) && !int.TryParse(yearInput, out currentYear))
                {
                    Console.WriteLine("Tahun tidak valid. Menggunakan tahun saat ini.");
                    currentYear = DateTime.Now.Year;
                }

                Console.Write($"Masukkan bulan (1-12, kosongkan untuk {currentMonth}): ");
                string monthInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(monthInput) && (!int.TryParse(monthInput, out currentMonth) || currentMonth < 1 || currentMonth > 12))
                {
                    Console.WriteLine("Bulan tidak valid. Menggunakan bulan saat ini.");
                    currentMonth = DateTime.Now.Month;
                }

                var loans = _pinjamanService.GetAllPinjaman()
                    .Where(p => p.TanggalPinjam.Year == currentYear && p.TanggalPinjam.Month == currentMonth)
                    .ToList();

                Console.WriteLine($"\nLaporan Peminjaman Bulan {currentMonth}/{currentYear}");
                Console.WriteLine("=================================");
                Console.WriteLine($"Total Peminjaman: {loans.Count}");
                Console.WriteLine("---------------------------------");

                if (loans.Any())
                {
                    var bukuGroups = loans.GroupBy(p => p.IdBuku)
                        .Select(g => new {
                            BukuId = g.Key,
                            Judul = _bukuService.GetBukuById(g.Key)?.Judul ?? "Unknown",
                            Count = g.Count()
                        })
                        .OrderByDescending(x => x.Count);

                    Console.WriteLine("\nPeminjaman per Buku:");
                    foreach (var group in bukuGroups)
                    {
                        Console.WriteLine($"{group.Judul} ({group.BukuId}): {group.Count}x");
                    }

                    var anggotaGroups = loans.GroupBy(p => p.IdAnggota)
                        .Select(g => new {
                            AnggotaId = g.Key,
                            Nama = _penggunaService.GetPenggunaById(g.Key)?.Fullname ?? "Unknown",
                            Count = g.Count()
                        })
                        .OrderByDescending(x => x.Count);

                    Console.WriteLine("\nPeminjaman per Anggota:");
                    foreach (var group in anggotaGroups)
                    {
                        Console.WriteLine($"{group.Nama} ({group.AnggotaId}): {group.Count}x");
                    }
                }
                else
                {
                    Console.WriteLine("Tidak ada data peminjaman untuk periode ini.");
                }

                Console.WriteLine("\n1. Lihat laporan bulan lain");
                Console.WriteLine("0. Kembali ke Menu Laporan");
                Console.Write("Pilihan: ");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    kembali = true;
                }
            }
        }

        private void StatistikBukuPopuler()
        {
            bool kembali = false;
            while (!kembali)
            {
                Console.Clear();
                Console.WriteLine("=== STATISTIK BUKU POPULER ===");

                var bukuPopuler = _pinjamanService.GetAllPinjaman()
                    .GroupBy(p => p.IdBuku)
                    .Select(g => new {
                        BukuId = g.Key,
                        Judul = _bukuService.GetBukuById(g.Key)?.Judul ?? "Unknown",
                        PeminjamanCount = g.Count(),
                        TerakhirDipinjam = g.Max(p => p.TanggalPinjam)
                    })
                    .OrderByDescending(x => x.PeminjamanCount)
                    .Take(10)
                    .ToList();

                Console.WriteLine("\n10 Buku Paling Populer:");
                Console.WriteLine("=================================");
                Console.WriteLine("No. Judul\t\t\tJumlah Peminjaman\tTerakhir Dipinjam");
                Console.WriteLine("-------------------------------------------------");

                int counter = 1;
                foreach (var buku in bukuPopuler)
                {
                    string judulTruncated = buku.Judul.Length > 20 ? buku.Judul.Substring(0, 17) + "..." : buku.Judul;
                    Console.WriteLine($"{counter++}. {judulTruncated,-20}\t{buku.PeminjamanCount}\t\t\t{buku.TerakhirDipinjam:dd/MM/yyyy}");
                }

                var bukuByCategory = _bukuService.GetAllBuku()
                    .GroupBy(b => b.Kategori)
                    .Select(g => new {
                        Kategori = g.Key.ToString(),
                        JumlahBuku = g.Count(),
                        RataPeminjaman = g.Average(b =>
                            _pinjamanService.GetAllPinjaman().Count(p => p.IdBuku == b.IdBuku))
                    });

                Console.WriteLine("\nStatistik per Kategori:");
                Console.WriteLine("---------------------------------");
                foreach (var category in bukuByCategory)
                {
                    Console.WriteLine($"{category.Kategori}: {category.JumlahBuku} buku, Rata-rata peminjaman: {category.RataPeminjaman:F1}");
                }

                Console.WriteLine("\n0. Kembali ke Menu Laporan");
                Console.Write("Pilihan: ");

                if (Console.ReadLine() == "0")
                {
                    kembali = true;
                }
            }
        }

        private void LaporanDenda()
        {
            bool kembali = false;
            while (!kembali)
            {
                Console.Clear();
                Console.WriteLine("=== LAPORAN DENDA ===");

                var allDenda = _dendaService.GetAllDenda();
                var unpaidDenda = allDenda.Where(d => d.StatusDenda == Denda.STATUSDENDA.BELUMLUNAS).ToList();

                Console.WriteLine($"Total Denda: {allDenda.Count}");
                Console.WriteLine($"Denda Belum Lunas: {unpaidDenda.Count}");
                Console.WriteLine($"Total Pendapatan Denda: {allDenda.Where(d => d.StatusDenda == Denda.STATUSDENDA.LUNAS).Sum(d => d.JumlahDenda):C}");
                Console.WriteLine("---------------------------------");

                if (allDenda.Any())
                {
                    var dendaByMember = allDenda
                        .GroupBy(d => d.IdPengguna)
                        .Select(g => new {
                            AnggotaId = g.Key,
                            Nama = _penggunaService.GetPenggunaById(g.Key)?.Fullname ?? "Unknown",
                            TotalDenda = g.Sum(d => d.JumlahDenda),
                            Unpaid = g.Count(d => d.StatusDenda == Denda.STATUSDENDA.BELUMLUNAS)
                        })
                        .OrderByDescending(x => x.TotalDenda);

                    Console.WriteLine("\nDenda per Anggota:");
                    foreach (var member in dendaByMember)
                    {
                        Console.WriteLine($"{member.Nama} ({member.AnggotaId}): Total {member.TotalDenda:C} ({member.Unpaid} belum lunas)");
                    }

                    var topDenda = allDenda
                        .OrderByDescending(d => d.JumlahDenda)
                        .Take(5);

                    Console.WriteLine("\n5 Denda Tertinggi:");
                    foreach (var denda in topDenda)
                    {
                        var buku = _bukuService.GetBukuById(denda.IdBuku);
                        var anggota = _penggunaService.GetPenggunaById(denda.IdPengguna);
                        Console.WriteLine($"{anggota?.Fullname ?? "Unknown"} - {buku?.Judul ?? "Unknown"}: {denda.JumlahDenda:C} ({denda.JumlahHariTerlambat} hari terlambat)");
                    }
                }
                else
                {
                    Console.WriteLine("Tidak ada data denda.");
                }

                Console.WriteLine("\n0. Kembali ke Menu Laporan");
                Console.Write("Pilihan: ");

                if (Console.ReadLine() == "0")
                {
                    kembali = true;
                }
            }
        }

        private void AktivitasAnggota()
        {
            bool kembali = false;
            while (!kembali)
            {
                Console.Clear();
                Console.WriteLine("=== AKTIVITAS ANGGOTA ===");

                var allMembers = _penggunaService.GetAllPengguna()
                    .Where(p => p.Role == Pengguna.ROLEPENGGUNA.anggota)
                    .ToList();

                var allLoans = _pinjamanService.GetAllPinjaman();
                var allFines = _dendaService.GetAllDenda();

                Console.WriteLine($"Total Anggota: {allMembers.Count}");
                Console.WriteLine("---------------------------------");

                var activeMembers = allMembers
                    .Select(m => new {
                        Anggota = m,
                        LoanCount = allLoans.Count(l => l.IdAnggota == m.IdPengguna),
                        LastActivity = allLoans.Where(l => l.IdAnggota == m.IdPengguna)
                                            .OrderByDescending(l => l.TanggalPinjam)
                                            .FirstOrDefault()?.TanggalPinjam
                    })
                    .OrderByDescending(m => m.LoanCount)
                    .Take(5);

                Console.WriteLine("\n5 Anggota Paling Aktif:");
                foreach (var member in activeMembers)
                {
                    Console.WriteLine($"{member.Anggota.Fullname} ({member.Anggota.IdPengguna}): {member.LoanCount} peminjaman, terakhir aktif: {(member.LastActivity.HasValue ? member.LastActivity.Value.ToString("dd/MM/yyyy") : "tidak ada aktivitas")}");
                }

                var membersWithFines = allMembers
                    .Select(m => new {
                        Anggota = m,
                        TotalFines = allFines.Where(f => f.IdPengguna == m.IdPengguna).Sum(f => f.JumlahDenda),
                        UnpaidFines = allFines.Count(f => f.IdPengguna == m.IdPengguna && f.StatusDenda == Denda.STATUSDENDA.BELUMLUNAS)
                    })
                    .Where(m => m.TotalFines > 0)
                    .OrderByDescending(m => m.TotalFines);

                Console.WriteLine("\nAnggota dengan Denda:");
                if (membersWithFines.Any())
                {
                    foreach (var member in membersWithFines)
                    {
                        Console.WriteLine($"{member.Anggota.Fullname} ({member.Anggota.IdPengguna}): Total denda {member.TotalFines:C} ({member.UnpaidFines} belum lunas)");
                    }
                }
                else
                {
                    Console.WriteLine("Tidak ada anggota dengan denda.");
                }

                var newMembers = allMembers
                    .Where(m => m.IdPengguna.StartsWith("P") &&
                                _pinjamanService.GetAllPinjaman().Any(p => p.IdAnggota == m.IdPengguna &&
                                                                         p.TanggalPinjam.Month == DateTime.Now.Month &&
                                                                         p.TanggalPinjam.Year == DateTime.Now.Year))
                    .ToList();

                Console.WriteLine("\nAnggota Baru Bulan Ini:");
                if (newMembers.Any())
                {
                    foreach (var member in newMembers)
                    {
                        Console.WriteLine($"{member.Fullname} ({member.IdPengguna})");
                    }
                }
                else
                {
                    Console.WriteLine("Tidak ada anggota baru bulan ini.");
                }

                Console.WriteLine("\n0. Kembali ke Menu Laporan");
                Console.Write("Pilihan: ");

                if (Console.ReadLine() == "0")
                {
                    kembali = true;
                }
            }
        }
    }
}