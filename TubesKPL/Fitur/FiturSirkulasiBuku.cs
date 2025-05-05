using System;
using System.Collections.Generic;
using TubesKPL.Model;
using TubesKPL.Service;
using static TubesKPL.Program;

namespace TubesKPL.Fitur
{
    public class FiturSirkulasiBuku
    {
        public enum StateSirkulasibuku
        {
            StateMenuSirkulasibuku,
            StateProsesPeminjaman,
            StatePengembalianBuku,
            StatePerpanjanganPinjaman,
            StatePerhitunganDenda,
            StateKeluarSirkulasibuku
        }

        private StateSirkulasibuku currentState = StateSirkulasibuku.StateMenuSirkulasibuku;

        public ProgramState MenuSirkulasiBuku()
        {
            while (true)
            {
                switch (currentState)
                {
                    case StateSirkulasibuku.StateMenuSirkulasibuku:
                        currentState = TampilkanMenuSirkulasiBuku();
                        break;
                    case StateSirkulasibuku.StateProsesPeminjaman:
                        Console.Clear();
                        Console.WriteLine("=== PROSES PEMINJAMAN ===");
                        // Implementasi proses peminjaman di sini
                        Console.WriteLine("Fitur Proses Peminjaman akan diimplementasikan");
                        Console.ReadKey();
                        currentState = StateSirkulasibuku.StateMenuSirkulasibuku;
                        break;
                    case StateSirkulasibuku.StatePengembalianBuku:
                        Console.Clear();
                        Console.WriteLine("=== PENGEMBALIAN BUKU ===");
                        // Implementasi pengembalian buku di sini
                        Console.WriteLine("Fitur Pengembalian Buku akan diimplementasikan");
                        Console.ReadKey();
                        currentState = StateSirkulasibuku.StateMenuSirkulasibuku;
                        break;
                    case StateSirkulasibuku.StatePerpanjanganPinjaman:
                        Console.Clear();
                        Console.WriteLine("=== PERPANJANGAN PINJAMAN ===");
                        // Implementasi perpanjangan pinjaman di sini
                        Console.WriteLine("Fitur Perpanjangan Pinjaman akan diimplementasikan");
                        Console.ReadKey();
                        currentState = StateSirkulasibuku.StateMenuSirkulasibuku;
                        break;
                    case StateSirkulasibuku.StatePerhitunganDenda:
                        Console.Clear();
                        Console.WriteLine("=== PERHITUNGAN DENDA ===");
                        // Implementasi perhitungan denda di sini
                        Console.WriteLine("Fitur Perhitungan Denda akan diimplementasikan");
                        Console.ReadKey();
                        currentState = StateSirkulasibuku.StateMenuSirkulasibuku;
                        break;
                    case StateSirkulasibuku.StateKeluarSirkulasibuku:
                        return ProgramState.StateMenuUtama;
                }
            }
        }

        private StateSirkulasibuku TampilkanMenuSirkulasiBuku()
        {
            Console.Clear();
            Console.WriteLine("=== SIRKULASI BUKU ===");
            Console.WriteLine("1. Proses Peminjaman");
            Console.WriteLine("2. Pengembalian Buku");
            Console.WriteLine("3. Perpanjangan Pinjaman");
            Console.WriteLine("4. Perhitungan Denda Otomatis");
            Console.WriteLine("0. Kembali ke Menu Utama");
            Console.Write("Pilih opsi: ");

            if (int.TryParse(Console.ReadLine(), out int pilihan))
            {
                switch (pilihan)
                {
                    case 0:
                        return StateSirkulasibuku.StateKeluarSirkulasibuku;
                    case 1:
                        return StateSirkulasibuku.StateProsesPeminjaman;
                    case 2:
                        return StateSirkulasibuku.StatePengembalianBuku;
                    case 3:
                        return StateSirkulasibuku.StatePerpanjanganPinjaman;
                    case 4:
                        return StateSirkulasibuku.StatePerhitunganDenda;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Harap masukkan angka 0-4.");
                        Console.ReadKey();
                        return StateSirkulasibuku.StateMenuSirkulasibuku;
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid. Harap masukkan angka.");
                Console.ReadKey();
                return StateSirkulasibuku.StateMenuSirkulasibuku;
            }
        }


    }
}