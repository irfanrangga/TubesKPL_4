using System;
using System.Windows.Forms;
using ManajemenPerpus.CLI.Service; 

namespace ManajemenAdminGUI.Forms
{
    public partial class FormHapusBuku : Form
    {
        private BukuService bukuService;

        public FormHapusBuku()
        {
            InitializeComponent();
            bukuService = new BukuService();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string id = txtIdBuku.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID Buku tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool sukses = bukuService.DeleteBuku(id);

            if (sukses)
            {
                MessageBox.Show($"Buku dengan ID {id} berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdBuku.Clear();
            }
            else
            {
                MessageBox.Show($"Buku dengan ID {id} tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
