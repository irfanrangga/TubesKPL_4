using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManajemenPerpus.Core.Models;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using static ManajemenPerpus.CLI.Program;

namespace ManajemenPerpus.CLI
{
    public class Menu
    {

        public static ProgramState MenuUtama()
        {
            // Placeholder for the main menu logic
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Manajemen Pengguna");
            Console.WriteLine("2. Manajemen Koleksi");
            Console.WriteLine("3. Sirkulasi Buku");
            Console.WriteLine("4. Ulasan dan Rekomendasi");
            Console.WriteLine("5. Laporan Statistik");
            Console.WriteLine("6. Notifikasi Otomatis");
            Console.WriteLine("7. Keluar");
            Console.Write("Pilih opsi: ");

            var input = Console.ReadLine();
            return input switch
            {
                "1" => ProgramState.StateManajemenPengguna,
                "2" => ProgramState.StateManajemenBuku,
                "3" => ProgramState.StateSirkulasiBuku,
                "4" => ProgramState.StateUlasanRekomendasi,
                "5" => ProgramState.StateLaporanStatistik,
                "6" => ProgramState.StateNotifikasiOtomatis,
                "7" => ProgramState.StateKeluar,
                _ => ProgramState.StateMenuUtama
            };
        }


    }
}
