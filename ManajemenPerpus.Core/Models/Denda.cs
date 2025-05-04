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

        private string idDenda;
        private string idPengguna;
        private string idBuku;
        private string idPeminjaman;
        private STATUSDENDA statusDenda;
        private int jumlahDenda;
        private int jumlahHariTerlambat;

        public Denda(string idPengguna, string idBuku, string idPeminjaman, STATUSDENDA statusDenda)
        {
            this.idPengguna = idPengguna;
            this.idBuku = idBuku;
            this.idPeminjaman = idPeminjaman;
            this.statusDenda = statusDenda;

        }

        private string GenerateIdDenda()
        {
            int count = 0;
            return $"DN{count:D3}";
        }

        public string GetIdDenda() { return idDenda; }
        public string GetIdPengguna() { return idPengguna; }
        public string GetIdBuku() { return idBuku; }
        public string GetIdPeminjaman() { return idPeminjaman; }
        public STATUSDENDA GetStatusDenda() { return statusDenda; }
    }
}
