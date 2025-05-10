using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ManajemenPerpus.Core.Models;

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
                    listUlasan = JsonSerializer.Deserialize<List<Ulasan>>(json) ?? new List<Ulasan>();
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
                SaveData();
            }
        }

        public void SaveData()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(GetAllUlasan(), options);
            File.WriteAllText(filePath, json);
        }

        public void AddUlasan(string ulasanId, string bukuId, string isiUlasan)
        {
            Ulasan ulasan = new Ulasan(generateUlasanId(), bukuId, isiUlasan);
            listUlasan.Add(ulasan);
            SaveData();
        }

        public string generateUlasanId()
        {
            string id = "ULS" + (listUlasan.Count + 1).ToString("D3");
            return id;
        }

        public List<Ulasan> GetAllUlasan()
        {
            return listUlasan;
        }

        public Ulasan GetUlasanById(string id)
        {
            return listUlasan.FirstOrDefault(u => u.ulasanId == id);
        }

        public void tambahUlasan()
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
                    AddUlasan(generateUlasanId(), bukuId, isiUlasan);
                    Console.WriteLine("Ulasan berhasil ditambahkan.");
                    break;
                }
                else
                {
                    Console.WriteLine("ID Buku tidak ditemukan.");
                }
            }
            Console.WriteLine("Tekan sembarang tombol untuk melanjutkan...");
            Console.ReadKey();
        }

        public void tampilkanSemuaUlasan()
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
