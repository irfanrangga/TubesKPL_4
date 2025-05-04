using System;

namespace SistemPerpustakaan.Feature
{
    public class FiturUlasanRekomendasi
    {
        public void TampilkanUlasanRekomendasi()
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
                    case 0:
                        return;
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
