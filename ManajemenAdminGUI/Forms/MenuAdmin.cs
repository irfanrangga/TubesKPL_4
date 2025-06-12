using System;
using System.Windows.Forms;

namespace ManajemenAdminGUI.Forms
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent(); 
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            new FormTambahBuku().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FormEditBuku().ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            new FormHapusBuku().ShowDialog();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            new FormDaftarBuku().ShowDialog();
        }
    }
}
