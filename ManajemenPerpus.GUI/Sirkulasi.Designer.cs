
namespace ManajemenPerpus.GUI
{
    partial class Sirkulasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Inisialisasi control dan layout form
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            buttonBack = new Button();
            labelTitle = new Label();
            groupBoxPeminjaman = new GroupBox();
            labelIdAnggota = new Label();
            textBoxIdAnggota = new TextBox();
            labelPilihBuku = new Label();
            comboBoxBuku = new ComboBox();
            labelBatasPengembalian = new Label();
            labelTanggalKembali = new Label();
            buttonPinjam = new Button();
            buttonResetPeminjaman = new Button();
            groupBoxPengembalian = new GroupBox();
            labelDisplayDenda = new Label();
            labelDenda = new Label();
            buttonCek = new Button();
            labelIdPeminjaman = new Label();
            textBoxIdPeminjamanReturn = new TextBox();
            labelBukuReturn = new Label();
            labelDisplayBukuReturn = new Label();
            labelIdAnggotaReturn = new Label();
            labelDisplayIdAnggotaReturn = new Label();
            labelBatasPengembalianReturn = new Label();
            labelDisplayBatasPengembalian = new Label();
            labelStatus = new Label();
            labelDisplayStatus = new Label();
            buttonKembalikan = new Button();
            buttonResetPengembalian = new Button();
            panelHeader.SuspendLayout();
            groupBoxPeminjaman.SuspendLayout();
            groupBoxPengembalian.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.RoyalBlue;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(buttonBack);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Location = new Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(760, 50);
            panelHeader.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(10, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 25);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Kembali";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(320, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(114, 21);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Fitur Sirkulasi";
            // 
            // groupBoxPeminjaman
            // 
            groupBoxPeminjaman.Controls.Add(labelIdAnggota);
            groupBoxPeminjaman.Controls.Add(textBoxIdAnggota);
            groupBoxPeminjaman.Controls.Add(labelPilihBuku);
            groupBoxPeminjaman.Controls.Add(comboBoxBuku);
            groupBoxPeminjaman.Controls.Add(labelBatasPengembalian);
            groupBoxPeminjaman.Controls.Add(labelTanggalKembali);
            groupBoxPeminjaman.Controls.Add(buttonPinjam);
            groupBoxPeminjaman.Controls.Add(buttonResetPeminjaman);
            groupBoxPeminjaman.Location = new Point(12, 75);
            groupBoxPeminjaman.Name = "groupBoxPeminjaman";
            groupBoxPeminjaman.Size = new Size(370, 350);
            groupBoxPeminjaman.TabIndex = 1;
            groupBoxPeminjaman.TabStop = false;
            groupBoxPeminjaman.Text = "Formulir Peminjaman";
            // 
            // labelIdAnggota
            // 
            labelIdAnggota.AutoSize = true;
            labelIdAnggota.Location = new Point(20, 40);
            labelIdAnggota.Name = "labelIdAnggota";
            labelIdAnggota.Size = new Size(73, 15);
            labelIdAnggota.TabIndex = 0;
            labelIdAnggota.Text = "ID Anggota :";
            // 
            // textBoxIdAnggota
            // 
            textBoxIdAnggota.Location = new Point(130, 37);
            textBoxIdAnggota.Name = "textBoxIdAnggota";
            textBoxIdAnggota.Size = new Size(200, 23);
            textBoxIdAnggota.TabIndex = 1;
            // 
            // labelPilihBuku
            // 
            labelPilihBuku.AutoSize = true;
            labelPilihBuku.Location = new Point(20, 85);
            labelPilihBuku.Name = "labelPilihBuku";
            labelPilihBuku.Size = new Size(66, 15);
            labelPilihBuku.TabIndex = 2;
            labelPilihBuku.Text = "Pilih Buku :";
            // 
            // comboBoxBuku
            // 
            comboBoxBuku.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBuku.FormattingEnabled = true;
            comboBoxBuku.Location = new Point(130, 82);
            comboBoxBuku.Name = "comboBoxBuku";
            comboBoxBuku.Size = new Size(200, 23);
            comboBoxBuku.TabIndex = 3;
            // 
            // labelBatasPengembalian
            // 
            labelBatasPengembalian.AutoSize = true;
            labelBatasPengembalian.Location = new Point(20, 130);
            labelBatasPengembalian.Name = "labelBatasPengembalian";
            labelBatasPengembalian.Size = new Size(120, 15);
            labelBatasPengembalian.TabIndex = 4;
            labelBatasPengembalian.Text = "Batas Pengembalian :";
            // 
            // labelTanggalKembali
            // 
            labelTanggalKembali.AutoSize = true;
            labelTanggalKembali.Location = new Point(159, 130);
            labelTanggalKembali.Name = "labelTanggalKembali";
            labelTanggalKembali.Size = new Size(164, 15);
            labelTanggalKembali.TabIndex = 5;
            labelTanggalKembali.Text = "menampilkan tanggal 7 hari...";
            // 
            // buttonPinjam
            // 
            buttonPinjam.Location = new Point(50, 250);
            buttonPinjam.Name = "buttonPinjam";
            buttonPinjam.Size = new Size(75, 30);
            buttonPinjam.TabIndex = 6;
            buttonPinjam.Text = "Pinjam";
            buttonPinjam.UseVisualStyleBackColor = true;
            buttonPinjam.Click += buttonPinjam_Click;
            // 
            // buttonResetPeminjaman
            // 
            buttonResetPeminjaman.Location = new Point(220, 250);
            buttonResetPeminjaman.Name = "buttonResetPeminjaman";
            buttonResetPeminjaman.Size = new Size(75, 30);
            buttonResetPeminjaman.TabIndex = 7;
            buttonResetPeminjaman.Text = "Reset";
            buttonResetPeminjaman.UseVisualStyleBackColor = true;
            buttonResetPeminjaman.Click += buttonResetPeminjaman_Click;
            // 
            // groupBoxPengembalian
            // 
            groupBoxPengembalian.Controls.Add(labelDisplayDenda);
            groupBoxPengembalian.Controls.Add(labelDenda);
            groupBoxPengembalian.Controls.Add(buttonCek);
            groupBoxPengembalian.Controls.Add(labelIdPeminjaman);
            groupBoxPengembalian.Controls.Add(textBoxIdPeminjamanReturn);
            groupBoxPengembalian.Controls.Add(labelBukuReturn);
            groupBoxPengembalian.Controls.Add(labelDisplayBukuReturn);
            groupBoxPengembalian.Controls.Add(labelIdAnggotaReturn);
            groupBoxPengembalian.Controls.Add(labelDisplayIdAnggotaReturn);
            groupBoxPengembalian.Controls.Add(labelBatasPengembalianReturn);
            groupBoxPengembalian.Controls.Add(labelDisplayBatasPengembalian);
            groupBoxPengembalian.Controls.Add(labelStatus);
            groupBoxPengembalian.Controls.Add(labelDisplayStatus);
            groupBoxPengembalian.Controls.Add(buttonKembalikan);
            groupBoxPengembalian.Controls.Add(buttonResetPengembalian);
            groupBoxPengembalian.Location = new Point(402, 75);
            groupBoxPengembalian.Name = "groupBoxPengembalian";
            groupBoxPengembalian.Size = new Size(370, 350);
            groupBoxPengembalian.TabIndex = 2;
            groupBoxPengembalian.TabStop = false;
            groupBoxPengembalian.Text = "Formulir Pengembalian";
            // 
            // labelDisplayDenda
            // 
            labelDisplayDenda.AutoSize = true;
            labelDisplayDenda.Location = new Point(140, 250);
            labelDisplayDenda.Name = "labelDisplayDenda";
            labelDisplayDenda.Size = new Size(40, 15);
            labelDisplayDenda.TabIndex = 14;
            labelDisplayDenda.Text = "denda";
            // 
            // labelDenda
            // 
            labelDenda.AutoSize = true;
            labelDenda.Location = new Point(20, 250);
            labelDenda.Name = "labelDenda";
            labelDenda.Size = new Size(47, 15);
            labelDenda.TabIndex = 13;
            labelDenda.Text = "Denda: ";
            // 
            // buttonCek
            // 
            buttonCek.Location = new Point(280, 37);
            buttonCek.Name = "buttonCek";
            buttonCek.Size = new Size(75, 20);
            buttonCek.TabIndex = 12;
            buttonCek.Text = "Cek";
            buttonCek.UseVisualStyleBackColor = true;
            buttonCek.Click += buttonCek_Click;
            // 
            // labelIdPeminjaman
            // 
            labelIdPeminjaman.AutoSize = true;
            labelIdPeminjaman.Location = new Point(20, 40);
            labelIdPeminjaman.Name = "labelIdPeminjaman";
            labelIdPeminjaman.Size = new Size(94, 15);
            labelIdPeminjaman.TabIndex = 0;
            labelIdPeminjaman.Text = "ID Peminjaman :";
            // 
            // textBoxIdPeminjamanReturn
            // 
            textBoxIdPeminjamanReturn.Location = new Point(140, 37);
            textBoxIdPeminjamanReturn.Name = "textBoxIdPeminjamanReturn";
            textBoxIdPeminjamanReturn.Size = new Size(120, 23);
            textBoxIdPeminjamanReturn.TabIndex = 1;
            // 
            // labelBukuReturn
            // 
            labelBukuReturn.AutoSize = true;
            labelBukuReturn.Location = new Point(20, 80);
            labelBukuReturn.Name = "labelBukuReturn";
            labelBukuReturn.Size = new Size(40, 15);
            labelBukuReturn.TabIndex = 2;
            labelBukuReturn.Text = "Buku :";
            // 
            // labelDisplayBukuReturn
            // 
            labelDisplayBukuReturn.AutoSize = true;
            labelDisplayBukuReturn.Location = new Point(140, 80);
            labelDisplayBukuReturn.Name = "labelDisplayBukuReturn";
            labelDisplayBukuReturn.Size = new Size(110, 15);
            labelDisplayBukuReturn.TabIndex = 3;
            labelDisplayBukuReturn.Text = "menampilkan judul";
            // 
            // labelIdAnggotaReturn
            // 
            labelIdAnggotaReturn.AutoSize = true;
            labelIdAnggotaReturn.Location = new Point(20, 120);
            labelIdAnggotaReturn.Name = "labelIdAnggotaReturn";
            labelIdAnggotaReturn.Size = new Size(59, 15);
            labelIdAnggotaReturn.TabIndex = 4;
            labelIdAnggotaReturn.Text = "Anggota :";
            // 
            // labelDisplayIdAnggotaReturn
            // 
            labelDisplayIdAnggotaReturn.AutoSize = true;
            labelDisplayIdAnggotaReturn.Location = new Point(140, 120);
            labelDisplayIdAnggotaReturn.Name = "labelDisplayIdAnggotaReturn";
            labelDisplayIdAnggotaReturn.Size = new Size(93, 15);
            labelDisplayIdAnggotaReturn.TabIndex = 5;
            labelDisplayIdAnggotaReturn.Text = "menampilkan id";
            // 
            // labelBatasPengembalianReturn
            // 
            labelBatasPengembalianReturn.AutoSize = true;
            labelBatasPengembalianReturn.Location = new Point(20, 160);
            labelBatasPengembalianReturn.Name = "labelBatasPengembalianReturn";
            labelBatasPengembalianReturn.Size = new Size(120, 15);
            labelBatasPengembalianReturn.TabIndex = 6;
            labelBatasPengembalianReturn.Text = "Batas Pengembalian :";
            // 
            // labelDisplayBatasPengembalian
            // 
            labelDisplayBatasPengembalian.AutoSize = true;
            labelDisplayBatasPengembalian.Location = new Point(155, 160);
            labelDisplayBatasPengembalian.Name = "labelDisplayBatasPengembalian";
            labelDisplayBatasPengembalian.Size = new Size(123, 15);
            labelDisplayBatasPengembalian.TabIndex = 7;
            labelDisplayBatasPengembalian.Text = "menampilkan tanggal";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(20, 200);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(45, 15);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status :";
            // 
            // labelDisplayStatus
            // 
            labelDisplayStatus.AutoSize = true;
            labelDisplayStatus.Location = new Point(140, 200);
            labelDisplayStatus.Name = "labelDisplayStatus";
            labelDisplayStatus.Size = new Size(85, 15);
            labelDisplayStatus.TabIndex = 9;
            labelDisplayStatus.Text = "telat atau tidak";
            // 
            // buttonKembalikan
            // 
            buttonKembalikan.Location = new Point(50, 296);
            buttonKembalikan.Name = "buttonKembalikan";
            buttonKembalikan.Size = new Size(102, 30);
            buttonKembalikan.TabIndex = 10;
            buttonKembalikan.Text = "Kembalikan";
            buttonKembalikan.UseVisualStyleBackColor = true;
            buttonKembalikan.Click += buttonKembalikan_Click;
            // 
            // buttonResetPengembalian
            // 
            buttonResetPengembalian.Location = new Point(220, 296);
            buttonResetPengembalian.Name = "buttonResetPengembalian";
            buttonResetPengembalian.Size = new Size(75, 30);
            buttonResetPengembalian.TabIndex = 11;
            buttonResetPengembalian.Text = "Reset";
            buttonResetPengembalian.UseVisualStyleBackColor = true;
            buttonResetPengembalian.Click += buttonResetPengembalian_Click;
            // 
            // Sirkulasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(panelHeader);
            Controls.Add(groupBoxPeminjaman);
            Controls.Add(groupBoxPengembalian);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Sirkulasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sirkulasi";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBoxPeminjaman.ResumeLayout(false);
            groupBoxPeminjaman.PerformLayout();
            groupBoxPengembalian.ResumeLayout(false);
            groupBoxPengembalian.PerformLayout();
            ResumeLayout(false);
        }





        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.GroupBox groupBoxPeminjaman;
        private System.Windows.Forms.Label labelIdAnggota;
        private System.Windows.Forms.TextBox textBoxIdAnggota;
        private System.Windows.Forms.Label labelPilihBuku;
        private System.Windows.Forms.ComboBox comboBoxBuku;
        private System.Windows.Forms.Label labelBatasPengembalian;
        private System.Windows.Forms.Label labelTanggalKembali;
        private System.Windows.Forms.Button buttonPinjam;
        private System.Windows.Forms.Button buttonResetPeminjaman;

        private System.Windows.Forms.GroupBox groupBoxPengembalian;
        private System.Windows.Forms.Label labelIdPeminjaman;
        private System.Windows.Forms.TextBox textBoxIdPeminjamanReturn; // Ganti Label menjadi TextBox
        private System.Windows.Forms.Label labelBukuReturn;
        private System.Windows.Forms.Label labelDisplayBukuReturn;
        private System.Windows.Forms.Label labelIdAnggotaReturn;
        private System.Windows.Forms.Label labelDisplayIdAnggotaReturn;
        private System.Windows.Forms.Label labelBatasPengembalianReturn;
        private System.Windows.Forms.Label labelDisplayBatasPengembalian;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDisplayStatus;
        private System.Windows.Forms.Button buttonKembalikan;
        private System.Windows.Forms.Button buttonResetPengembalian;
        private Button buttonCek;
        private Label labelDenda;
        private Label labelDisplayDenda;
    }
}
