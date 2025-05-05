using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class Ulasan
    {
        public string ulasanId { get; set; }
        public string bukuId { get; set; }
        public string isiUlasan { get; set; }

        public Ulasan(string ulasanId, string bukuId, string isiUlasan)
        {
            this.ulasanId = ulasanId;
            this.bukuId = bukuId;
            this.isiUlasan = isiUlasan;
        }
    }
}
