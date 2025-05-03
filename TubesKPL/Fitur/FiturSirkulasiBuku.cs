using System;
using System.Collections.Generic;
using TubesKPL.Model;
using TubesKPL.Service;

namespace TubesKPL.Fitur
{
    internal class FiturSirkulasiBuku
    {
        private PinjamanService pinjamanService;
        private BukuService bukuService;
        private PenggunaService penggunaService;

        // Table-driven configuration
        private Dictionary<string, int> dendaPerHari = new Dictionary<string, int>
        {
            { "default", 1000 }, // denda 1000 per hari keterlambatan
            { "" }
        };

        public FiturSirkulasiBuku(PinjamanService ps, BukuService bs, PenggunaService us)
        {
            pinjamanService = ps;
            bukuService = bs;
            penggunaService = us;
        }

        public void ProsesPeminjaman(string idBuku, string idAnggota, int lamaHari)
        {
            DateTime batasKembali = DateTime.Now.AddDays(lamaHari);
            pinjamanService.TambahPinjaman(idBuku, idAnggota, batasKembali);
        }

        public void ProsesPengembalian(string idPinjaman)
        {
            var pinjaman = pinjamanService.GetPinjamanById(idPinjaman);
            if (pinjaman == null)
            {
                Console.WriteLine("Pinjaman tidak ditemukan.");
                return;
            }

            DateTime sekarang = DateTime.Now;
            DateTime batasKembali = pinjaman.GetBatasPengembalian();

            if (sekarang > batasKembali)
            {
                TimeSpan keterlambatan = sekarang - batasKembali;
                int jumlahHari = keterlambatan.Days;
                int denda = HitungDenda(jumlahHari);
                Console.WriteLine($"Buku terlambat dikembalikan selama {jumlahHari} hari.");
                Console.WriteLine($"Denda: Rp{denda}");
            }
            else
            {
                Console.WriteLine("Buku dikembalikan tepat waktu.");
            }

            pinjamanService.HapusPinjaman(idPinjaman);
        }

        public void PerpanjangPinjaman(string idPinjaman, int tambahanHari)
        {
            var pinjaman = pinjamanService.GetPinjamanById(idPinjaman);
            if (pinjaman == null)
            {
                Console.WriteLine("Pinjaman tidak ditemukan.");
                return;
            }

            DateTime baruBatas = pinjaman.GetBatasPengembalian().AddDays(tambahanHari);
            // Simulasi: Buat objek baru dengan batas baru (atau update jika bisa)
            pinjamanService.HapusPinjaman(idPinjaman); // hapus lama
            pinjamanService.TambahPinjaman(pinjaman.GetIdBuku(), pinjaman.GetIdAnggota(), baruBatas); // tambah baru
            Console.WriteLine($"Pinjaman diperpanjang hingga {baruBatas.ToShortDateString()}");
        }

        private int HitungDenda(int jumlahHari)
        {
            return jumlahHari * dendaPerHari["default"];
        }
    }
}
