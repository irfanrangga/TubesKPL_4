using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManajemenPerpus.Core.Models
{
    public class Pinjaman
    {
        public string IdPinjaman { get; set; }
        public string IdBuku { get; set; }
        public string IdAnggota { get; set; }
        public DateTime BatasPengembalian { get; set; }

        public Pinjaman(string idPinjaman, string idBuku, string idAnggota, DateTime batasPengembalian)
        {
            this.IdPinjaman = idPinjaman;
            this.IdBuku = idBuku;
            this.IdAnggota = idAnggota;
            this.BatasPengembalian = batasPengembalian;
        }
    }
}
