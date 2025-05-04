using System;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturUlasanRekomendasi
    {
        public UlasanService ulasanService;
        
        public void MenuUlasanRekomendasi()
        {
            Console.Clear();
            Console.WriteLine("=== ULASAN & REKOMENDASI ===");
            Console.WriteLine("1. Beri Ulasan Buku");
            Console.WriteLine("2. Lihat Ulasan Buku");
            Console.WriteLine("3. Rekomendasi Buku");
            Console.WriteLine("0. Kembali ke Menu Utama");
            Console.Write("Pilih opsi: ");

            int pilihan;
            if (int.TryParse(Console.ReadLine(), out pilihan))
            {
                switch (pilihan)
                {
                    case 1:
                        ulasanService.buatUlasan();
                        ulasanService.addUlasan(ulasanService.buatUlasan());
                        ulasanService.simpanUlasanKeFile();
                        break;
                    case 2:
                        Console.WriteLine(ulasanService.getAllUlasan());
                        break;
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
        }
    }
}
