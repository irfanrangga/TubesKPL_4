using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Fitur
{
    internal class FiturManajemenBuku
    {
        private readonly BukuServiceNew _bukuService;

        public FiturManajemenBuku()
        {
            _bukuService = new BukuServiceNew();
        }

        public ProgramState MenuManajemenBuku()
        {
            Console.Clear();
            Console.WriteLine("=== Manajemen BUKU ===");
            Console.WriteLine("1. Tambah Buku");
            Console.WriteLine("2. Lihat Semua Buku");
            Console.WriteLine("0. Kembali ke Menu Utama");
            Console.Write("Pilih opsi: ");

            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    _bukuService.AddBuku();
                    break;
                case 2:
                    _bukuService.ShowAllBuku().GetAwaiter().GetResult();
                    break;
                default:
                    Console.ReadKey();
                    break;
            }

            return ProgramState.StateMenuUtama;
        }
    }
}
