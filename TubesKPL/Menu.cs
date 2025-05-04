using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManajemenPerpus.Core.Models;
using Microsoft.AspNetCore.Mvc.ViewEngines;
namespace TubesKPL
{
    public class Menu
    {

        public static Program.ProgramState MenuUtama()
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
                "1" => Program.ProgramState.StateManajemenPengguna,
                "2" => Program.ProgramState.StateManajemenKoleksi,
                "3" => Program.ProgramState.StateSirkulasiBuku,
                "4" => Program.ProgramState.StateUlasanRekomendasi,
                "5" => Program.ProgramState.StateLaporanStatistik,
                "6" => Program.ProgramState.StateNotifikasiOtomatis,
                "7" => Program.ProgramState.StateKeluar,
                _ => Program.ProgramState.StateMenuUtama
            };
        }

        
    }
}
