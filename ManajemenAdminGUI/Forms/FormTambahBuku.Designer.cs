namespace ManajemenAdminGUI.Forms
{
    partial class FormTambahBuku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPenulis;
        private System.Windows.Forms.Label lblPenerbit;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblSinopsis;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtJudul = new TextBox();
            txtPenulis = new TextBox();
            txtPenerbit = new TextBox();
            cmbKategori = new ComboBox();
            txtSinopsis = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            lblJudul = new Label();
            lblPenulis = new Label();
            lblPenerbit = new Label();
            lblKategori = new Label();
            lblSinopsis = new Label();
            SuspendLayout();
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(150, 30);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(600, 27);
            txtJudul.TabIndex = 1;
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(150, 70);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(600, 27);
            txtPenulis.TabIndex = 3;
            // 
            // txtPenerbit
            // 
            txtPenerbit.Location = new Point(150, 110);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new Size(600, 27);
            txtPenerbit.TabIndex = 5;
            // 
            // cmbKategori
            // 
            cmbKategori.Location = new Point(150, 150);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(300, 28);
            cmbKategori.TabIndex = 7;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(150, 190);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(600, 100);
            txtSinopsis.TabIndex = 9;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(150, 320);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan";
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(250, 320);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 11;
            btnBatal.Text = "Batal";
            btnBatal.Click += btnBatal_Click;
            // 
            // lblJudul
            // 
            lblJudul.Location = new Point(30, 30);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(100, 23);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Judul:";
            // 
            // lblPenulis
            // 
            lblPenulis.Location = new Point(30, 70);
            lblPenulis.Name = "lblPenulis";
            lblPenulis.Size = new Size(100, 23);
            lblPenulis.TabIndex = 2;
            lblPenulis.Text = "Penulis:";
            // 
            // lblPenerbit
            // 
            lblPenerbit.Location = new Point(30, 110);
            lblPenerbit.Name = "lblPenerbit";
            lblPenerbit.Size = new Size(100, 23);
            lblPenerbit.TabIndex = 4;
            lblPenerbit.Text = "Penerbit:";
            // 
            // lblKategori
            // 
            lblKategori.Location = new Point(30, 150);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(100, 23);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "Kategori:";
            // 
            // lblSinopsis
            // 
            lblSinopsis.Location = new Point(30, 190);
            lblSinopsis.Name = "lblSinopsis";
            lblSinopsis.Size = new Size(100, 23);
            lblSinopsis.TabIndex = 8;
            lblSinopsis.Text = "Sinopsis:";
            // 
            // FormTambahBuku
            // 
            ClientSize = new Size(866, 449);
            Controls.Add(lblJudul);
            Controls.Add(txtJudul);
            Controls.Add(lblPenulis);
            Controls.Add(txtPenulis);
            Controls.Add(lblPenerbit);
            Controls.Add(txtPenerbit);
            Controls.Add(lblKategori);
            Controls.Add(cmbKategori);
            Controls.Add(lblSinopsis);
            Controls.Add(txtSinopsis);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Name = "FormTambahBuku";
            Text = "Tambah Buku";
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated 

        #endregion
    }
}