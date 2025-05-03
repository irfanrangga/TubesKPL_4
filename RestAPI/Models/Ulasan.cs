using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL.Model
{
    internal class Ulasan
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

        public Ulasan buatUlasan(Buku dataBuku)
        {
            try
            {
                Console.WriteLine("Masukkan ID Ulasan: ");
                int ulasanId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukkan ID Pengguna: ");
                string penggunaId = Console.ReadLine();
                Console.WriteLine("Masukkan Isi Ulasan: ");
                string isiUlasan = Console.ReadLine();
                return new Ulasan(ulasanId, penggunaId, dataBuku, isiUlasan);
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan: " + e.Message);
            }
            return null;
        }
    }
}
