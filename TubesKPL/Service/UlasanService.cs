using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManajemenPerpus.Core.Models;

namespace TubesKPL.Service
{
    internal class UlasanService
    {
        public Ulasan buatUlasan()
        {
            Console.WriteLine("Masukan ID Buku yang ingin diulas: ");
            string idBuku = Console.ReadLine();
            if(idBuku == null)
            {
                Console.WriteLine("ID Buku tidak boleh kosong");
                return null;
            } else if(idBuku == )
        }
    }
}
