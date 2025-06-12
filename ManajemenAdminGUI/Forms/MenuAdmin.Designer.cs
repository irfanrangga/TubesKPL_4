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
            btnLogout = new Button();
            btnLaporan = new Button();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(503, 116);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(189, 68);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah Buku";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(503, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(189, 68);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Buku";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(503, 264);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(189, 68);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus Buku";
            btnHapus.Click += btnHapus_Click;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(503, 338);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(189, 68);
            btnDaftar.TabIndex = 3;
            btnDaftar.Text = "Daftar Buku";
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(520, 547);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(155, 68);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(503, 412);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(189, 84);
            btnLaporan.TabIndex = 3;
            btnLaporan.Text = "Laporan Statistik";
            btnLaporan.Click += btnLaporan_Click;
            // 
            // MenuAdmin
            // 
            ClientSize = new Size(1280, 720);
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnLogout);
            Controls.Add(btnLaporan);
            Controls.Add(btnDaftar);
            Name = "MenuAdmin";
            Text = "Menu Admin";
            ResumeLayout(false);
        }
        private Button btnLogout;
        private Button btnLaporan;
    }
}
