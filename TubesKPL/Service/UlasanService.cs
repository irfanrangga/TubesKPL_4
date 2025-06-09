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
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7143/api/Ulasan";
        private readonly string filePath;

        private List<FactoryBuku> _listBuku;
        public BukuServiceNew bukuService = new BukuServiceNew();
        
        public UlasanService()
        {
            var root = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName;
            filePath = Path.Combine(root, "SharedData", "DataJson", "DataUlasan.json");
            _httpClient = new HttpClient();
        }

        public async Task<List<Ulasan>> GetUlasanFromApi()
        {
            try
            {
                var response = await _httpClient.GetAsync(_apiUrl);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var ulasanList = JsonSerializer.Deserialize<List<Ulasan>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return ulasanList ?? new List<Ulasan>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error fetching ulasan: {ex.Message}");
                return new List<Ulasan>();
            }
        }

        public async Task ShowAllUlasan()
        {
            var listUlasan = await GetUlasanFromApi();

            if (listUlasan.Count == 0)
            {
                Console.WriteLine("Tidak ada ulasan yang tersedia.");
            }
            else
            {
                Console.WriteLine("Daftar Ulasan:");
                foreach (var u in listUlasan)
                {
                    Console.WriteLine($"ID Ulasan: {u.ulasanId}, ID Buku: {u.bukuId}, Isi Ulasan: {u.isiUlasan}");
                }
            }
            Console.WriteLine("Tekan sembarang tombol untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }

        public async Task ShowAllUlasanByBookId()
        {
            var listUlasan = await GetUlasanFromApi();
            Console.WriteLine("Masukkan ID Buku untuk melihat ulasan: ");
            string bukuId = Console.ReadLine();
            var ulasanByBookId = listUlasan.Where(u => u.bukuId == bukuId).ToList();
            if (ulasanByBookId.Count == 0)
            {
                Console.WriteLine($"Tidak ada ulasan untuk buku dengan ID {bukuId}.");
            }
            else
            {
                Console.WriteLine($"Daftar Ulasan untuk Buku ID {bukuId}:");
                foreach (var u in ulasanByBookId)
                {
                    Console.WriteLine($"ID Ulasan: {u.ulasanId}, Isi Ulasan: {u.isiUlasan}");
                }
            }
            Console.WriteLine("Tekan sembarang tombol untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }

         public void AddUlasan()
        {
            var _listUlasan = JsonHelper.ReadJson<Ulasan>(filePath) ?? new List<Ulasan>();
            try
            {
                Console.WriteLine("Masukan ID Buku: ");
                string bukuId = Console.ReadLine();
                _listBuku = bukuService.GetBukuFromApi().GetAwaiter().GetResult();
                foreach (var buku in _listBuku)
                {
                    if (buku.IdBuku == bukuId)
                    {
                        Console.WriteLine("Masukan Ulasan: ");
                        string isiUlasan = Console.ReadLine();
                        Ulasan ulasan = new Ulasan(GenerateUlasanId(), bukuId, isiUlasan);
                        _listUlasan.Add(ulasan);
                        Console.WriteLine("Ulasan berhasil ditambahkan.");
                        break;
                    }
                }
                JsonHelper.WriteJson(filePath, _listUlasan);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding ulasan: {ex.Message}");
            }
        }

        public string GenerateUlasanId()
        {
            var listUlasan = JsonHelper.ReadJson<Ulasan>(filePath);

            string id = "ULS" + (listUlasan.Count + 1).ToString("D3");
            return id;
        }
    }
}