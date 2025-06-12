using System;
using System.Windows.Forms;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;

namespace ManajemenAdminGUI.Forms
{
    public partial class FormTambahBuku : Form
    {
        private readonly BukuService _bukuService;

        public FormTambahBuku()
        {
            InitializeComponent();
            _bukuService = new BukuService();

            // Isi ComboBox Kategori
            cmbKategori.DataSource = Enum.GetValues(typeof(BukuDeprecated.KATEGORIBUKU));
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string judul = txtJudul.Text.Trim();
                string penulis = txtPenulis.Text.Trim();
                string penerbit = txtPenerbit.Text.Trim();
                string sinopsis = txtSinopsis.Text.Trim();
                var kategori = (BukuDeprecated.KATEGORIBUKU)cmbKategori.SelectedItem;

                if (string.IsNullOrEmpty(judul) || string.IsNullOrEmpty(penulis) || string.IsNullOrEmpty(penerbit))
                {
                    MessageBox.Show("Judul, Penulis, dan Penerbit tidak boleh kosong.");
                    return;
                }

                _bukuService.AddBuku(judul, penulis, penerbit, kategori, sinopsis);
                MessageBox.Show("Buku berhasil ditambahkan!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
