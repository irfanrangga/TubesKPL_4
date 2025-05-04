using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class Buku
    {
        public enum STATUSBUKU
        {
            TERSEDIA,
            DIPINJAM,
            RUSAK
        }

        public enum KATEGORIBUKU
        {
            FIKSI,
            NONFIKSI
        }

        // Data Buku  
        public string IdBuku { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Penerbit { get; set; }
        public KATEGORIBUKU Kategori { get; set; }
        public string Sinopsis { get; set; }
        public STATUSBUKU Status { get; set; }

        public Buku(string idBuku, string judul, string penulis, string penerbit, KATEGORIBUKU kategori, string sinopsis)
        {
            IdBuku = idBuku;
            Judul = judul;
            Penulis = penulis;
            Penerbit = penerbit;
            Kategori = kategori;
            Sinopsis = sinopsis;
            Status = STATUSBUKU.TERSEDIA; // status default  
        }
    }
}
