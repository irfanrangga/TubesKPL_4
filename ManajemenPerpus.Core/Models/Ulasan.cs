using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class Ulasan
    {
        public int ulasanId { get; set; }
        public string penggunaId { get; set; }
        public string isiUlasan { get; set; }

        public Ulasan(int ulasanId, string penggunaId, string isiUlasan)
        {
            this.ulasanId = ulasanId;
            this.penggunaId = penggunaId;
            this.isiUlasan = isiUlasan;
        }
    }
}
