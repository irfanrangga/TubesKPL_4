using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ManajemenPerpus.CLI.Service;
using ManajemenPerpus.Core.Models;

namespace ManajemenAdminGUI.Forms
{
    public partial class FormDaftarBuku : Form
    {
        private readonly BukuService _bukuService;

        public FormDaftarBuku()
        {
            InitializeComponent();
            _bukuService = new BukuService();
            TampilkanDaftarBuku();
        }

        private void TampilkanDaftarBuku()
        {
            List<Buku> daftarBuku = _bukuService.GetAllBuku();
            dataGridViewBuku.Rows.Clear();

            foreach (var buku in daftarBuku)
            {
                dataGridViewBuku.Rows.Add(
                    buku.IdBuku,
                    buku.Judul,
                    buku.Penulis,
                    buku.Penerbit,
                    buku.Kategori,
                    buku.Sinopsis
                );
            }
        }
    }
}
