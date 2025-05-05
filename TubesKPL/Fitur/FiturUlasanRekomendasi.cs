using System;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Fitur
{
    public class FiturUlasanRekomendasi
    {
        public UlasanService ulasanService;

        int pilihan;
        public ProgramState MenuUlasanRekomendasi()
        {
            Console.Clear();
            Console.WriteLine("=== ULASAN & REKOMENDASI ===");
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
            return ProgramState.StateMenuUtama;
        }
    }
}