using System;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturLaporanStatistik
    {
        public ProgramState MenuLaporanStatistik()
        {
            Console.Clear();
            Console.WriteLine("=== LAPORAN & STATISTIK ===");
            Console.WriteLine("1. Laporan Peminjaman");
            Console.WriteLine("2. Statistik Pengunjung");
            Console.WriteLine("3. Laporan Buku Populer");
            Console.WriteLine("0. Kembali ke Menu Utama");
            Console.Write("Pilih opsi: ");

            int pilihan;
            if (int.TryParse(Console.ReadLine(), out pilihan))
            {
                switch (pilihan)
                {
                    case 0:
                        return ProgramState.StateMenuUtama;
                    default:
                        Console.WriteLine($"Fitur {pilihan} akan diimplementasikan");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid. Harap masukkan angka.");
                Console.ReadKey();
            }
            return ProgramState.StateMenuUtama;
        }
    }
}
