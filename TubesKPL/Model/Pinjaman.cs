using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL.Model
{
    internal class Pinjaman
    {
        private string idPinjaman;
        private string idBuku;
        private string idAnggota;
        private DateTime batasPengembalian;

        public Pinjaman(string idPinjaman, string idBuku, string idAnggota, DateTime batasPengembalian)
        {
            this.idPinjaman = idPinjaman;
            this.idBuku = idBuku;
            this.idAnggota = idAnggota;
            this.batasPengembalian = batasPengembalian;
        }
    }
}
