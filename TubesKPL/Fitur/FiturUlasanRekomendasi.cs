using System;
using System.Threading.Tasks;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturUlasanRekomendasi
    {
        public UlasanService ulasanService = new UlasanService();

        int pilihan;
        public ProgramState MenuUlasanRekomendasi()
        {
            Console.Clear();
            Console.WriteLine("=== ULASAN & REKOMENDASI ===");
            Console.WriteLine("1. Buat Ulasan");
            Console.WriteLine("2. Lihat Ulasan");
            Console.WriteLine("3. Lihat Ulasan Berdasarkan Buku");
            Console.WriteLine("0. Kembali ke Menu Utama");
            Console.Write("Pilih opsi: ");
            pilihan = int.Parse(Console.ReadLine());
            {
                switch (pilihan)
                {
                    case 1:
                        ulasanService.AddUlasan();
                        break;
                    case 2:
                        ulasanService.ShowAllUlasan().GetAwaiter().GetResult();
                        break;
                    case 3:
                        ulasanService.ShowAllUlasanByBookId().GetAwaiter().GetResult();
                        break;
                    default:
                        Console.ReadKey();
                        break;
                }
            }
            return ProgramState.StateMenuUtama;
        }
    }
}