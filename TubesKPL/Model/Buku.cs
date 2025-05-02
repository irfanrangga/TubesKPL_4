using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL.Model
{
    internal class Buku
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
            NONFIKSI,
            SELFDEVELOPMENT
        }

        //Data Buku
        public string idBuku;
        public string judul;
        public string penulis;
        public string penerbit;
        public KATEGORIBUKU kategori;
        public string sinopsis;
        public STATUSBUKU status;

        public Buku(string idBuku, string judul, string penulis, string penerbit, KATEGORIBUKU kategori, string sinopsis)
        {
            this.idBuku = idBuku;
            this.judul = judul;
            this.penulis = penulis;
            this.penerbit = penerbit;
            this.kategori = kategori;
            this.sinopsis = sinopsis;
            this.status = STATUSBUKU.TERSEDIA; //status default
        }

        public string GetIdBuku() { return idBuku; }
        public string GetJudul() { return judul; }
        public string GetPenulis() { return penulis; }
        public string GetPenerbit() { return penerbit; }
        public KATEGORIBUKU GetKategori() { return kategori; }
        public string GetSinopsis() { return sinopsis; }
        public STATUSBUKU GetStatus() { return status; }

        public void UpdateBukuData(string newJudul, string newPenulis, string newPenerbit, KATEGORIBUKU newKategori)
        {
            this.judul = newJudul;
            this.penulis = newPenulis;
            this.penerbit = newPenerbit;
            this.kategori = newKategori;
        }

        public bool IsTersedia()
        {
            return status == STATUSBUKU.TERSEDIA;
        }
    }
}
