using System;

namespace SistemPerpustakaan.Feature
{
    public class FiturManajemenPengguna
    {
        public void TampilkanManajemenPengguna()
        {
            Console.Clear();
            Console.WriteLine("=== MANAJEMEN PENGGUNA & KEANGGOTAAN ===");
            Console.WriteLine("1. Tambah Anggota Baru");
            Console.WriteLine("2. Edit Data Anggota");
            Console.WriteLine("3. Hapus Anggota");
            Console.WriteLine("4. Lihat Daftar Anggota");
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