using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.Core.Helper;

namespace ManajemenPerpus.CLI.Service
{

    public class UlasanService
    {
        private readonly string filePath;
        private List<Ulasan> listUlasan;
        private List<Buku> listBuku;
        private BukuService bukuService = new BukuService();
        
        public UlasanService()
        {
            var root = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName;
            filePath = Path.Combine(root, "SharedData", "DataJson", "DataUlasan.json");
            LoadData();
        }

        public void LoadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                try
                {
                    listUlasan = JsonHelper.ReadJson<List<Ulasan>>(filePath);
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Error deserializing JSON: {ex.Message}");
                    listUlasan = new List<Ulasan>();
                }
            }
            else
            {
                listUlasan = new List<Ulasan>();
                JsonHelper.WriteJson(filePath, listUlasan);
            }
        }

        public void AddUlasan()
        {
            try
            {
                Console.WriteLine("Masukan ID Buku: ");
                string bukuId = Console.ReadLine();
                listBuku = bukuService.GetAllBuku();
                foreach (var buku in listBuku)
                {
                    if (buku.IdBuku == bukuId)
                    {
                        Console.WriteLine("Masukan Ulasan: ");
                        string isiUlasan = Console.ReadLine();
                        Ulasan ulasan = new Ulasan(GenerateUlasanId(), bukuId, isiUlasan);
                        listUlasan.Add(ulasan);
                        Console.WriteLine("Ulasan berhasil ditambahkan.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ID Buku tidak ditemukan.");
                    }
                }
                JsonHelper.WriteJson(filePath, listUlasan);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding ulasan: {ex.Message}");
            }
        }

        public string GenerateUlasanId()
        {
            string id = "ULS" + (listUlasan.Count + 1).ToString("D3");
            return id;
        }

        public void ShowAllUlasan()
        {
            Console.WriteLine("Daftar Ulasan:");
            foreach (var ulasan in listUlasan)
            {
                Console.WriteLine($"ID Ulasan: {ulasan.ulasanId}, ID Buku: {ulasan.bukuId}, Isi Ulasan: {ulasan.isiUlasan}");
            }
            Console.WriteLine("Tekan sembarang tombol untuk melanjutkan...");
            Console.ReadKey();
        }
    }
}