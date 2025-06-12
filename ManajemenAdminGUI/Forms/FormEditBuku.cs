using System;
using System.Windows.Forms;
using ManajemenPerpus.Core.Models;
using ManajemenPerpus.CLI.Service;

namespace ManajemenAdminGUI.Forms
{
    public partial class FormEditBuku : Form
    {
        private readonly BukuService _bukuService;
        private BukuDeprecated bukuDitemukan;

        public FormEditBuku()
        {
            InitializeComponent();
            _bukuService = new BukuService();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string id = txtIdCari.Text.Trim().ToUpper();
            bukuDitemukan = _bukuService.GetBukuById(id);

            if (bukuDitemukan != null)
            {
                txtJudul.Text = bukuDitemukan.Judul;
                txtPenulis.Text = bukuDitemukan.Penulis;
                txtPenerbit.Text = bukuDitemukan.Penerbit;
                cmbKategori.SelectedItem = bukuDitemukan.Kategori.ToString();
                txtSinopsis.Text = bukuDitemukan.Sinopsis;

                groupEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Buku tidak ditemukan.");
                groupEdit.Enabled = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (bukuDitemukan == null)
            {
                MessageBox.Show("Cari buku terlebih dahulu.");
                return;
            }

            try
            {
                BukuDeprecated.KATEGORIBUKU kategori = (BukuDeprecated.KATEGORIBUKU)Enum.Parse(typeof(BukuDeprecated.KATEGORIBUKU), cmbKategori.SelectedItem.ToString());

                BukuDeprecated bukuBaru = new BukuDeprecated(
                    bukuDitemukan.IdBuku,
                    txtJudul.Text,
                    txtPenulis.Text,
                    txtPenerbit.Text,
                    kategori,
                    txtSinopsis.Text
                );

                bool berhasil = _bukuService.UpdateBuku(bukuBaru);
                if (berhasil)
                {
                    MessageBox.Show("Buku berhasil diperbarui.");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui buku.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtIdCari.Clear();
            txtJudul.Clear();
            txtPenulis.Clear();
            txtPenerbit.Clear();
            cmbKategori.SelectedIndex = -1;
            txtSinopsis.Clear();
            groupEdit.Enabled = false;
        }
    }
}
