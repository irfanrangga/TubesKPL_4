namespace ManajemenAdminGUI.Forms
{
    partial class MenuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnDaftar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnDaftar = new Button();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(520, 107);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(155, 68);
            btnTambah.Text = "Tambah Buku";
            btnTambah.Click += new EventHandler(btnTambah_Click);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(520, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 68);
            btnEdit.Text = "Edit Buku";
            btnEdit.Click += new EventHandler(btnEdit_Click);
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(520, 270);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(155, 68);
            btnHapus.Text = "Hapus Buku";
            btnHapus.Click += new EventHandler(btnHapus_Click);
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(520, 350);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(155, 68);
            btnDaftar.Text = "Daftar Buku";
            btnDaftar.Click += new EventHandler(btnDaftar_Click);
            // 
            // MenuAdmin
            // 
            ClientSize = new Size(1280, 720);
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnDaftar);
            Text = "Menu Admin";
            ResumeLayout(false);
        }
    }
}
