using ManajemenPerpus.CLI.Service;
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
    public partial class KoleksiBuku : Form
    {
        private BukuServiceNew _bukuService = new BukuServiceNew();
        public KoleksiBuku()
        {
            InitializeComponent();
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private async void KoleksiBuku_Load(object sender, EventArgs e)
        {
            await PopulateItems();
        }

        private async Task PopulateItems()
        {
            try
            {
                var bukuList = await _bukuService.GetBukuFromApi();
                foreach (var buku in bukuList)
                {
                    ItemList item = new ItemList
                    {
                        Title = buku.Judul,
                        Sinopsis = buku.Sinopsis,
                        Penulis = buku.Penulis,
                        Penerbit = buku.Penerbit,
                        Kategori = buku.Kategori,
                        TanggalMasuk = buku.TanggalMasuk.ToString("dd/MM/yyyy") ?? "-",
                        Padding = new Padding(10),
                        Tag = buku.IdBuku // Menyimpan ID Buku pada Tag untuk referensi
                    };
                    
                    item.Click += ItemClicked; // Menambahkan event handler untuk klik pada item
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ItemClicked(object sender, EventArgs e)
        {
            if(sender is ItemList item && item.Tag is string idBuku)
            {
                UlasanPage ulasanPage = new UlasanPage(idBuku);
                ulasanPage.Show();
                this.Hide(); // Sembunyikan form KoleksiBuku saat membuka UlasanPage
            }
        }

        private async void Searchbar_TextChanged(object sender, EventArgs e)
        {
            string searchText = Searchbox.Text.ToLower().Trim();
            flowLayoutPanel1.Controls.Clear();

            try
            {
                var bukuList = await _bukuService.GetBukuFromApi();
                var filteredList = bukuList
                    .Where(buku =>
                        buku.Judul.ToLower().Contains(searchText) ||
                        buku.Penulis.ToLower().Contains(searchText) ||
                        buku.Penerbit.ToLower().Contains(searchText) ||
                        buku.Kategori.ToLower().Contains(searchText) ||
                        (buku.Sinopsis != null && buku.Sinopsis.ToLower().Contains(searchText))
                    )
                    .ToList();

                foreach (var buku in filteredList)
                {
                    ItemList item = new ItemList
                    {
                        Title = buku.Judul,
                        Sinopsis = buku.Sinopsis,
                        Penulis = buku.Penulis,
                        Penerbit = buku.Penerbit,
                        Kategori = buku.Kategori,
                        TanggalMasuk = buku.TanggalMasuk.ToString("dd/MM/yyyy") ?? "-",
                        Padding = new Padding(10)
                    };

                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogoBtn_Clicked(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
            this.Hide();
        }

        private void PeminjamanBtn_Click(object sender, EventArgs e)
        {
            Sirkulasi peminjaman = new Sirkulasi();
            peminjaman.Show();
            this.Hide();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            MenuUtama menu = new MenuUtama();
            menu.Show();
            this.Hide();
        }
    }
}
