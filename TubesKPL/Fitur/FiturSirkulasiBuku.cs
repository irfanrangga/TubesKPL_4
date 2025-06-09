using System;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturSirkulasiBuku
    {
        private readonly BukuService _bukuService = new();
        private readonly PenggunaService _penggunaService = new();
        private readonly PinjamanService _pinjamanService = new();
        private readonly DendaService _dendaService = new();

        /// Menampilkan menu sirkulasi buku dan menangani navigasi serta error handling global.
        public ProgramState MenuSirkulasiBuku()
        {
            while (true)
            {
                Console.Clear();
                TampilkanMenu();
                Console.Write("Pilih opsi: ");

                try
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int selectedOption))
                    {
                        Console.WriteLine("Input harus berupa angka! Tekan tombol apa saja untuk melanjutkan...");
                        Console.ReadKey();
                        continue;
                    }

                    switch (selectedOption)
                    {
                        case 1:
                            _pinjamanService.ProsesPeminjaman();
                            break;
                        case 2:
                            _pinjamanService.ProsesPengembalian();
                            break;
                        case 3:
                            _pinjamanService.ProsesPerpanjangan();
                            break;
                        case 4:
                            _dendaService.HitungDenda();
                            break;
                        case 5:
                            _pinjamanService.TampilkanDaftarPinjaman();
                            break;
                        case 0:
                            return ProgramState.StateMenuUtama;
                        default:
                            Console.WriteLine("Pilihan tidak valid! Tekan tombol apa saja untuk melanjutkan...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nTerjadi kesalahan: {ex.Message}");
                    Console.WriteLine("Tekan tombol apa saja untuk melanjutkan...");
                    Console.ReadKey();
                }
            }
        }

        private void TampilkanMenu()
        {
            Console.WriteLine("=== SIRKULASI BUKU ===");
            Console.WriteLine("1. Proses Peminjaman");
            Console.WriteLine("2. Pengembalian Buku");
            Console.WriteLine("3. Perpanjangan Pinjaman");
            Console.WriteLine("4. Perhitungan Denda");
            Console.WriteLine("5. Lihat Daftar Pinjaman Aktif");
            Console.WriteLine("0. Kembali ke Menu Utama");
        }
    }
}
