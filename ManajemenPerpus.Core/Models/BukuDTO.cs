using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpus.Core.Models
{
    public class BukuDTO
    {
        public string IdBuku { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Penerbit { get; set; }
        public string Kategori { get; set; }
        public string Sinopsis { get; set; }
        public STATUSBUKU Status { get; set; }
        public DateTime TanggalMasuk { get; set; }
    }
}
