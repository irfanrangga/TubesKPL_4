using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class Notifikasi
    {
        public string IdNotifikasi { get; set; }
        public string IdPengguna { get; set; }
        public string IsiNotifikasi { get; set; }
        public DateTime TanggalNotifikasi { get; set; }

        public Notifikasi(string idNotifikasi, string idPengguna, string isiNotifikasi, DateTime tanggalNotifikasi)
        {
            this.IdNotifikasi = idNotifikasi;
            this.IdPengguna = idPengguna;
            this.IsiNotifikasi = isiNotifikasi;
            this.TanggalNotifikasi = tanggalNotifikasi;
        }
    }
}
