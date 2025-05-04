using System;
using System.Collections.Generic;
using System.Linq;
using ManajemenPerpus.Core.Models;

namespace TubesKPL.Service
{
    internal class PinjamanService
    {
        private List<Pinjaman> listPinjaman = new List<Pinjaman>();
        private BukuService bukuService;
        private PenggunaService penggunaService;

        public PinjamanService(BukuService bukuService, PenggunaService penggunaService)
        {
            this.bukuService = bukuService;
            this.penggunaService = penggunaService;
        }

        public void TambahPinjaman(string idBuku, string idAnggota, DateTime batasPengembalian)
        {
            var buku = bukuService.GetBukuById(idBuku);
            var anggota = penggunaService.GetPenggunaById(idAnggota);

            if (buku == null)
            {
                Console.WriteLine("Buku tidak ditemukan.");
                return;
            }

            if (anggota == null || anggota.GetRole() != Pengguna.ROLEPENGGUNA.anggota)
            {
                Console.WriteLine("Anggota tidak valid.");
                return;
            }

            if (!buku.IsTersedia())
            {
                Console.WriteLine("Buku tidak tersedia untuk dipinjam.");
                return;
            }

            string idPinjaman = GeneratePinjamanId();
            Pinjaman pinjaman = new Pinjaman(idPinjaman, idBuku, idAnggota, batasPengembalian);
            listPinjaman.Add(pinjaman);

            buku.status = Buku.STATUSBUKU.DIPINJAM;
            Console.WriteLine("Pinjaman berhasil ditambahkan.");
        }

        private string GeneratePinjamanId()
        {
            int count = listPinjaman.Count + 1;
            return $"PJ{count:D3}";
        }

        public List<Pinjaman> GetAllPinjaman()
        {
            return listPinjaman;
        }

        public Pinjaman GetPinjamanById(string id)
        {
            return listPinjaman.FirstOrDefault(p => p.GetIdPinjaman() == id);
        }

        public bool HapusPinjaman(string id)
        {
            var pinjaman = GetPinjamanById(id);
            if (pinjaman != null)
            {
                var buku = bukuService.GetBukuById(pinjaman.GetIdBuku());
                if (buku != null)
                {
                    buku.status = Buku.STATUSBUKU.TERSEDIA;
                }

                listPinjaman.Remove(pinjaman);
                return true;
            }
            return false;
        }
    }
}
