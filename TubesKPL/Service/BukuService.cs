using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using TubesKPL.Model;

namespace TubesKPL.Service
{
    internal class BukuService
    {
        List<Buku> listBuku = new List<Buku>();

        public void AddBuku(string judul, string penulis, string penerbit,
                          Buku.KATEGORIBUKU kategori, string sinopsis)
        {
            string id = GenerateBukuId();
            Buku newBuku = new Buku(id, judul, penulis, penerbit, kategori, sinopsis);
            listBuku.Add(newBuku);
        }

        private string GenerateBukuId()
        {
            var existingNumbers = new HashSet<int>();

            foreach (var buku in listBuku)
            {
                if (buku.GetIdBuku().StartsWith("B") &&
                    buku.GetIdBuku().Length == 4)
                {
                    if (int.TryParse(buku.GetIdBuku().Substring(1), out int num))
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
            return listBuku;
        }

        public Buku GetBukuById(string id)
        {
            return listBuku.FirstOrDefault(b => b.GetIdBuku() == id);
        }

        public bool DeleteBuku(string id)
        {
            var buku = GetBukuById(id);
            if (buku != null)
            {
                listBuku.Remove(buku);
                return true;
            }
            return false;
        }
    }
}
