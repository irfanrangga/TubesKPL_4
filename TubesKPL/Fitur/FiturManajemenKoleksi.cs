using System;
using ManajemenPerpus.Core.Models;

namespace SistemPerpustakaan.Feature
{
    public class FiturManajemenKoleksi
    {
        public void TampilkanManajemenKoleksi()
        {
            Console.Clear();
            Console.WriteLine("=== MANAJEMEN KOLEKSI BUKU ===");
            Console.WriteLine("1. Tambah Buku Baru");
            Console.WriteLine("2. Edit Data Buku");
            Console.WriteLine("3. Hapus Buku");
            Console.WriteLine("4. Cari Buku");
            Console.WriteLine("5. Lihat Daftar Buku");
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


        //...
    }
}
