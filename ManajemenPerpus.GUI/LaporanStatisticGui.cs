using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.GUI
{
    public partial class LaporanStatisticGui : Form
    {
        private readonly BukuService _bukuService;
        private readonly PinjamanService _pinjamanService;
        private readonly PenggunaService _penggunaService;

        public LaporanStatisticGui()
        {
            InitializeComponent();
            _bukuService = new BukuService();
            _pinjamanService = new PinjamanService();
            _penggunaService = new PenggunaService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the statistics form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int bulan) || bulan < 1 || bulan > 12)
            {
                MessageBox.Show("Masukkan bulan yang valid (1-12)");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int tahun))
            {
                MessageBox.Show("Masukkan tahun yang valid");
                return;
            }

            
            int lastDay = DateTime.DaysInMonth(tahun, bulan);
            DateTime startDate = new DateTime(tahun, bulan, 1);
            DateTime endDate = new DateTime(tahun, bulan, lastDay);

            
            var bukuMasuk = _bukuService.GetAllBuku()
                .Where(b => b.TanggalMasuk >= startDate && b.TanggalMasuk <= endDate)
                .ToList();

            
            var pinjamanBulanIni = _pinjamanService.GetAllPinjaman()
                .Where(p =>
                {
                    DateTime tanggalPinjam = p.BatasPengembalian.AddDays(-7);
                    return tanggalPinjam >= startDate && tanggalPinjam <= endDate;
                })
                .ToList();

            
            int jumlahBukuMasuk = bukuMasuk.Count;
            int jumlahBukuDipinjam = pinjamanBulanIni.Count;

            var jumlahPenggunaMeminjam = pinjamanBulanIni
                .Select(p => p.IdAnggota)
                .Distinct()
                .Count();

            
            var penggunaTeraktif = pinjamanBulanIni
                .GroupBy(p => p.IdAnggota)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            string namaPenggunaTeraktif = "Tidak ada data";
            int jumlahPinjamanTeraktif = 0;

            if (penggunaTeraktif != null)
            {
                var pengguna = _penggunaService.GetPenggunaById(penggunaTeraktif.Key);
                namaPenggunaTeraktif = pengguna?.Fullname ?? "Unknown";
                jumlahPinjamanTeraktif = penggunaTeraktif.Count();
            }

            
            var bukuTerpopuler = pinjamanBulanIni
                .GroupBy(p => p.IdBuku)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            string judulBukuTerpopuler = "Tidak ada data";
            int jumlahPinjamanBuku = 0;

            if (bukuTerpopuler != null)
            {
                var buku = _bukuService.GetBukuById(bukuTerpopuler.Key);
                judulBukuTerpopuler = buku?.Judul ?? "Unknown";
                jumlahPinjamanBuku = bukuTerpopuler.Count();
            }

            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"LAPORAN STATISTIK BULANAN");
            sb.AppendLine($"Periode: {startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}");
            sb.AppendLine("");
            sb.AppendLine($"1. Jumlah buku masuk: {jumlahBukuMasuk}");
            sb.AppendLine($"2. Jumlah buku dipinjam: {jumlahBukuDipinjam}");
            sb.AppendLine($"3. Jumlah pengguna yang meminjam: {jumlahPenggunaMeminjam}");
            sb.AppendLine($"4. Pengguna paling aktif: {namaPenggunaTeraktif} ({jumlahPinjamanTeraktif}x)");
            sb.AppendLine($"5. Buku paling populer: {judulBukuTerpopuler} ({jumlahPinjamanBuku}x)");
            sb.AppendLine("");
            sb.AppendLine($"Total hari dalam periode: {lastDay} hari");

            MessageBox.Show(sb.ToString(),
                "Statistik Perpustakaan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
      
    }
}