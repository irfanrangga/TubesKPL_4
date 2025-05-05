using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using ManajemenPerpus.Core.Models;
using System.Text.Json;

namespace ManajemenPerpus.CLI.Service
{
    public class BukuService
    {
        private readonly string _jsonFilePath;
        private List<Buku> _listBuku;

        public BukuService()
        {
            string sharedDataPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,
                                               "SharedData", "DataJson");
            _jsonFilePath = Path.Combine(sharedDataPath, "buku.json");
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(_jsonFilePath))
            {
                string json = File.ReadAllText(_jsonFilePath);
                _listBuku = JsonSerializer.Deserialize<List<Buku>>(json) ?? new List<Buku>();
            }
            else
            {
                _listBuku = new List<Buku>();
                SaveData();
            }
        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize;
            File.WriteAllText(_jsonFilePath, json);
        }

        public void AddBuku(string judul, string penulis, string penerbit,
                          Buku.KATEGORIBUKU kategori, string sinopsis)
        {
            string id = GenerateBukuId();
            Buku newBuku = new Buku(id, judul, penulis, penerbit, kategori, sinopsis);
            _listBuku.Add(newBuku);
            SaveData();
        }

        private string GenerateBukuId()
        {
            var existingNumbers = new HashSet<int>();

            foreach (var buku in _listBuku)
            {
                if (buku.IdBuku.StartsWith("B") && buku.IdBuku.Length == 4)
                {
                    if (int.TryParse(buku.IdBuku.Substring(1), out int num))
                    {
                        existingNumbers.Add(num);
                    }
                }
            }

            int newNumber = 1;
            while (existingNumbers.Contains(newNumber))
            {
                newNumber++;
            }

            return $"B{newNumber:D3}";
        }

        public List<Buku> GetAllBuku()
        {
            return _listBuku.OrderBy(b => b.IdBuku).ToList();
        }

        public Buku GetBukuById(string id)
        {
            return _listBuku.FirstOrDefault(b => b.IdBuku.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public bool DeleteBuku(string id)
        {
            var buku = GetBukuById(id);
            if (buku != null)
            {
                _listBuku.Remove(buku);
                SaveData();
                return true;
            }
            return false;
        }

        public bool UpdateBuku(Buku updatedBuku)
        {
            var existingBuku = GetBukuById(updatedBuku.IdBuku);
            if (existingBuku != null)
            {
                existingBuku.Judul = updatedBuku.Judul;
                existingBuku.Penulis = updatedBuku.Penulis;
                existingBuku.Penerbit = updatedBuku.Penerbit;
                existingBuku.Kategori = updatedBuku.Kategori;
                existingBuku.Sinopsis = updatedBuku.Sinopsis;
                SaveData();
                return true;
            }
            return false;
        }
    }
}