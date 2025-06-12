using System.Windows.Forms;

namespace ManajemenAdminGUI.Forms
{
    partial class FormHapusBuku
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblIdBuku;
        private TextBox txtIdBuku;
        private Button btnHapus;
        private Button btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblIdBuku = new Label();
            txtIdBuku = new TextBox();
            btnHapus = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblIdBuku
            // 
            lblIdBuku.AutoSize = true;
            lblIdBuku.Location = new Point(30, 30);
            lblIdBuku.Name = "lblIdBuku";
            lblIdBuku.Size = new Size(63, 20);
            lblIdBuku.TabIndex = 0;
            lblIdBuku.Text = "ID Buku:";
            // 
            // txtIdBuku
            // 
            txtIdBuku.Location = new Point(100, 27);
            txtIdBuku.Name = "txtIdBuku";
            txtIdBuku.Size = new Size(200, 27);
            txtIdBuku.TabIndex = 1;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(100, 70);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(90, 30);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.Click += btnHapus_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(210, 70);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 30);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batal";
            btnBatal.Click += btnBatal_Click;
            // 
            // FormHapusBuku
            // 
            ClientSize = new Size(429, 199);
            Controls.Add(lblIdBuku);
            Controls.Add(txtIdBuku);
            Controls.Add(btnHapus);
            Controls.Add(btnBatal);
            Name = "FormHapusBuku";
            Text = "Hapus Buku";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
