using System;
using System.Collections.Generic;
using System.Linq;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;


namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturSirkulasiBuku
    {
        private readonly BukuService _bukuService = new BukuService();
        private readonly PenggunaService _penggunaService = new PenggunaService();
        private readonly PinjamanService _pinjamanService = new PinjamanService();
        private readonly DendaService _dendaService = new DendaService();

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
    }
}