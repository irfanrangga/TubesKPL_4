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
        public string penggunaId { get; set; }
        public string isiUlasan { get; set; }

        public Ulasan(string ulasanId, string penggunaId, string isiUlasan)
        {
            this.ulasanId = ulasanId;
            this.penggunaId = penggunaId;
            this.isiUlasan = isiUlasan;
        }
    }
}
