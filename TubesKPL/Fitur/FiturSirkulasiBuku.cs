using System;
using System.Collections.Generic;
using TubesKPL.Model;
using TubesKPL.Service;

namespace TubesKPL.Fitur
{
    public class FiturSirkulasiBuku
    {
        public void TampilkanSirkulasiBuku()
        {
            Console.Clear();
            Console.WriteLine("=== SIRKULASI BUKU ===");
            Console.WriteLine("1. Proses Peminjaman");
            Console.WriteLine("2. Pengembalian Buku");
            Console.WriteLine("3. Perpanjangan Pinjaman");
            Console.WriteLine("4. Perhitungan Denda Otomatis");
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