using ManajemenPerpus.CLI.Service;
using ManajemenPerpus.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ManajemenPerpus.GUI
{
    public partial class Sirkulasi : Form
    {
        private readonly PinjamanService pinjamanService;

        public Sirkulasi()
        {
            InitializeComponent();
            pinjamanService = new PinjamanService();
            LoadComboBoxBuku();
            SetDefaultTanggalKembali();

            textBoxIdPeminjamanReturn.Text = string.Empty;
            buttonResetPeminjaman_Click(null, null);
            buttonResetPengembalian_Click(null, null);
        }

        // untuk muat daftar buku tersedia ke combobox
        private void LoadComboBoxBuku()
        {
            var bukuTersedia = pinjamanService.bukuService.GetAllBuku()
                .Where(b => b.Status == BukuDeprecated.STATUSBUKU.TERSEDIA)
                .ToList();

            comboBoxBuku.Items.Clear();
            if (!bukuTersedia.Any())
            {
                MessageBox.Show("Tidak ada buku yang tersedia untuk dipinjam.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bukuTersedia.ForEach(b => comboBoxBuku.Items.Add(b.Judul));
            comboBoxBuku.SelectedIndex = 0;
        }

        // untuk mengatur tanggal kembali default (7 hari dari hari ini)
        private void SetDefaultTanggalKembali()
        {
            DateTime tanggalBatas = DateTime.Today.AddDays(7);
            labelTanggalKembali.Text = tanggalBatas.ToString("dd/MM/yyyy");
        }

        // untuk tutup form saat tombol kembali diklik
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // untuk proses klik pinjam validasi input tampilkan info simpan pinjaman
        private void buttonPinjam_Click(object sender, EventArgs e)
        {
            string idAnggota = textBoxIdAnggota.Text.Trim();
            string judulBuku = comboBoxBuku.SelectedItem.ToString();

            if (string.IsNullOrEmpty(idAnggota))
            {
                MessageBox.Show("ID Anggota harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var anggota = pinjamanService.penggunaService.GetPenggunaById(idAnggota);
            if (anggota == null || anggota.Role != Pengguna.ROLEPENGGUNA.anggota)
            {
                MessageBox.Show("Anggota tidak ditemukan atau ID tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bukuDipinjam = pinjamanService.bukuService.GetAllBuku()
                .FirstOrDefault(b => b.Judul == judulBuku);
            DateTime batasPengembalian = DateTime.Now.AddDays(7);

            string idPeminjamanBaru = pinjamanService.GeneratePinjamanId();

            MessageBox.Show("Peminjaman berhasil:\nID Peminjaman: " + idPeminjamanBaru + "\nBatas Kembali: " + labelTanggalKembali.Text,
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pinjamanService.TambahPinjaman(bukuDipinjam.IdBuku, idAnggota, batasPengembalian);
            pinjamanService.LoadData();

            LoadComboBoxBuku();
        }

        // untuk mereset form peminjaman
        private void buttonResetPeminjaman_Click(object sender, EventArgs e)
        {
            textBoxIdAnggota.Clear();
            if (comboBoxBuku.Items.Count > 0) comboBoxBuku.SelectedIndex = 0;
            SetDefaultTanggalKembali();
        }

        // untuk proses klik kembalikan
        private void buttonKembalikan_Click(object sender, EventArgs e)
        {
            string idPeminjamanInput = textBoxIdPeminjamanReturn.Text.Trim();
            if (string.IsNullOrEmpty(idPeminjamanInput))
            {
                MessageBox.Show("Silakan masukkan ID Peminjaman terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pinjaman = pinjamanService.GetPinjamanById(idPeminjamanInput);
            DateTime tanggalSekarang = DateTime.Today;
            DateTime tanggalBatas = DateTime.Parse(labelDisplayBatasPengembalian.Text);

            if (tanggalSekarang > tanggalBatas)
            {
                TimeSpan terlambat = tanggalSekarang - tanggalBatas;
                int jumlahDenda = terlambat.Days * 5000;
                string idDenda = $"D{DateTime.Now:yyyyMMddHHmmss}";
                var denda = new Denda(pinjaman.IdAnggota, pinjaman.IdBuku, pinjaman.IdPinjaman, Denda.STATUSDENDA.BELUMLUNAS)
                {
                    IdDenda = idDenda,
                    JumlahHariTerlambat = terlambat.Days,
                    JumlahDenda = jumlahDenda
                };
                pinjamanService.dendaService.AddDenda(denda);
                MessageBox.Show($"Proses pengembalian selesai.\nStatus: {labelDisplayStatus.Text}\nDenda: {denda.JumlahDenda}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelDisplayStatus.Text = "Tepat waktu";
                MessageBox.Show($"Proses pengembalian selesai.\nStatus: {labelDisplayStatus.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (pinjamanService.HapusPinjaman(idPeminjamanInput))
            {
                LoadComboBoxBuku();
                buttonResetPengembalian_Click(null, null);
            }
            else
            {
                MessageBox.Show("Pengembalian gagal. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // untuk mereset form pengembalian
        private void buttonResetPengembalian_Click(object sender, EventArgs e)
        {
            textBoxIdPeminjamanReturn.Clear();
            labelDisplayBukuReturn.Text = string.Empty;
            labelDisplayIdAnggotaReturn.Text = string.Empty;
            labelDisplayBatasPengembalian.Text = string.Empty;
            labelDisplayStatus.Text = string.Empty;
            labelDisplayDenda.Text = "-";
        }

        // untuk cek status pinjaman
        private void buttonCek_Click(object sender, EventArgs e)
        {
            var pinjaman = pinjamanService.GetPinjamanById(textBoxIdPeminjamanReturn.Text.Trim());
            if (pinjaman == null)
            {
                MessageBox.Show("Pinjaman tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Now > pinjaman.BatasPengembalian)
            {
                TimeSpan keterlambatan = DateTime.Now - pinjaman.BatasPengembalian;
                labelDisplayStatus.Text = "Terlambat";
                labelDisplayDenda.Text = (keterlambatan.Days * 5000).ToString();
            }
            else
            {
                labelDisplayStatus.Text = "Tepat waktu";
            }

            labelDisplayBukuReturn.Text = pinjamanService.bukuService.GetBukuById(pinjaman.IdBuku).Judul;
            labelDisplayIdAnggotaReturn.Text = pinjamanService.penggunaService.GetPenggunaById(pinjaman.IdAnggota).Username;
            labelDisplayBatasPengembalian.Text = pinjaman.BatasPengembalian.ToString("dd/MM/yyyy");
        }
    }
}
