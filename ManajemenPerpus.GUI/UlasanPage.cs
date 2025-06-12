using ManajemenPerpus.CLI.Service;
using ManajemenPerpus.Core.Helper;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.GUI.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManajemenPerpus.GUI
{
    public partial class UlasanPage : Form
    {
        private string _idBuku;
        private UlasanService _ulasanService = new UlasanService();
        private List<Ulasan> _listUlasan;
        string filePath = @"D:\Dev\Konstruksi PL\TubesKPL\SharedData\DataJson\DataUlasan.json";

        public UlasanPage(string idBuku)
        {
            InitializeComponent();
            this._idBuku = idBuku;
            layoutUlasan.Dock = DockStyle.Fill;
            layoutUlasan.FlowDirection = FlowDirection.TopDown;
            layoutUlasan.WrapContents = false;
            layoutUlasan.AutoScroll = true;
            this.Load += UlasanGui_Load;
        }

        private async Task loadUlasan()
        {
            try
            {
                var ulasan = await _ulasanService.GetUlasanFromApi();
                if (ulasan.Count == 0)
                {
                    MessageBox.Show("Tidak ada ulasan yang tersedia.");
                    return;
                }
                foreach (var u in ulasan)
                {
                    if (u.bukuId == _idBuku)
                    {
                        UlasanList ulasanL = new UlasanList
                        {
                            IdUlasan = u.ulasanId,
                            IsiUlasan = u.isiUlasan,
                            Padding = new Padding(10)
                        };
                        layoutUlasan.Controls.Add(ulasanL);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ulasan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            KoleksiBuku koleksiBuku = new KoleksiBuku();
            koleksiBuku.Show();
            this.Hide();
        }

        private async void UlasanGui_Load(object sender, EventArgs e)
        {
            await loadUlasan();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string isi = ulasanTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(isi))
            {
                MessageBox.Show("Isi ulasan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _listUlasan = JsonHelper.ReadJson<Ulasan>(filePath) ?? new List<Ulasan>();
            // Membuat objek Ulasan baru
            Ulasan ulasanBaru = new Ulasan(_ulasanService.GenerateUlasanId(), _idBuku, isi);

            // Tambahkan ke list
            _listUlasan.Add(ulasanBaru);

            // Menampilkan di GUI
            UlasanList list = new UlasanList();
            list.SetUlasan(isi);
            layoutUlasan.Controls.Add(list);

            MessageBox.Show("Ulasan berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Menyimpan ke file JSON
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            JsonHelper.WriteJson(filePath, _listUlasan);

            ulasanTextBox.Clear();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            KoleksiBuku koleksiBuku = new KoleksiBuku();
            koleksiBuku.Show();
            this.Hide();
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            ulasanTextBox.Clear();
        }

        private void PeminjamanBtn_Click(object sender, EventArgs e)
        {
            Sirkulasi sirkulasi = new Sirkulasi();
            sirkulasi.Show();
            this.Hide();
        }
    }
}
