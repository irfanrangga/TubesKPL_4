using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.CLI.Service
{
    public class UlasanService
    {
        private static int currentID = 0;
        public List<Buku> bukuList;
        public Buku buku;
        public Pengguna pengguna;
        public BukuService bukuService;
        public List<Ulasan> ulasanList;

        // Function untuk buat Ulasan
        public Ulasan buatUlasan()
        {
            Console.WriteLine("=== Buat Ulasan ===");
            Console.Write("Masukkan ID Buku: ");
            string idBuku = Console.ReadLine();
            if (string.IsNullOrEmpty(idBuku))
            {
                Console.WriteLine("ID Buku tidak boleh kosong.");
                return null;
            }

            bukuList = bukuService.GetAllBuku();
            foreach (var buku in bukuList)
            {
                if (buku.IdBuku == idBuku)
                {
                    Console.Write("Masukkan Ulasan: ");
                    string ulasan = Console.ReadLine();
                    if (string.IsNullOrEmpty(ulasan))
                    {
                        Console.WriteLine("Ulasan tidak boleh kosong.");
                        return null;
                    }
                    Console.WriteLine("Ulasan berhasil ditambahkan pada buku:.");
                    return new Ulasan(generateIdUlasan(), pengguna.IdPengguna, ulasan);
                }
            }
            return null;
        }

        // Function untuk menambahkan Ulasan ke dalam list
        public void addUlasan(Ulasan ulasan)
        {
            if (ulasan != null)
            {
                ulasanList.Add(ulasan);
                Console.WriteLine("Ulasan berhasil ditambahkan.");
            }
            else
            {
                Console.WriteLine("Gagal menambahkan ulasan.");
            }
        }

        // Function untuk generate ID Ulasan dengan format "U" + "3 digit angka" -> "U001"
        public static string generateIdUlasan()
        {
            currentID++;
            return "U" + currentID.ToString("D3");
        }

        // Function untuk mendapatkan semua ulasan dari list
        public List<Ulasan> getAllUlasan()
        {
            return ulasanList;
        }

        // Function untuk menyimpan data ulasan ke dalam file JSON
        public void simpanUlasanKeFile()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string basePath = AppContext.BaseDirectory;
            string filePath = Path.Combine(basePath, "..", "..", "..", "SharedData", "DataJson", "DataUlasan.json");
            filePath = Path.GetFullPath(filePath);

            string jsonString = JsonSerializer.Serialize(getAllUlasan(), options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}