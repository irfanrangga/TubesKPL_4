using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class Ulasan
    {
        public Pengguna dataPengguna { get; set; }
        public int ulasanId { get; set; }
        public string penggunaId { get; set; }
        public Buku dataBuku { get; set; }
        public string isiUlasan { get; set; }

        public Ulasan(int ulasanId, string penggunaId, Buku dataBuku, string isiUlasan)
        {
            this.ulasanId = ulasanId;
            this.penggunaId = penggunaId;
            this.dataBuku = dataBuku;
            this.isiUlasan = isiUlasan;
        }
    }
}
