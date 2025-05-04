using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class Denda
    {
        public enum STATUSDENDA
        {
            LUNAS,
            BELUMLUNAS
        }

        public string IdDenda { get; set; }
        public string IdPengguna { get; set; }
        public string IdBuku { get; set; }
        public string IdPeminjaman { get; set; }
        public STATUSDENDA StatusDenda { get; set; }
        public int JumlahDenda { get; set; }
        public int JumlahHariTerlambat { get; set; }

        public Denda(string idPengguna, string idBuku, string idPeminjaman, STATUSDENDA statusDenda)
        {
            this.IdPengguna = idPengguna;
            this.IdBuku = idBuku;
            this.IdPeminjaman = idPeminjaman;
            this.StatusDenda = statusDenda;
        }
    }
}
