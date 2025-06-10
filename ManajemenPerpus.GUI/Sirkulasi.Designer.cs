
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
            panelHeader.Location = new Point(14, 16);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(868, 66);
            panelHeader.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(11, 17);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(86, 33);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Kembali";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(366, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(142, 28);
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
            groupBoxPeminjaman.Location = new Point(14, 100);
            groupBoxPeminjaman.Margin = new Padding(3, 4, 3, 4);
            groupBoxPeminjaman.Name = "groupBoxPeminjaman";
            groupBoxPeminjaman.Padding = new Padding(3, 4, 3, 4);
            groupBoxPeminjaman.Size = new Size(423, 467);
            groupBoxPeminjaman.TabIndex = 1;
            groupBoxPeminjaman.TabStop = false;
            groupBoxPeminjaman.Text = "Formulir Peminjaman";
            // 
            // labelIdAnggota
            // 
            labelIdAnggota.AutoSize = true;
            labelIdAnggota.Location = new Point(23, 53);
            labelIdAnggota.Name = "labelIdAnggota";
            labelIdAnggota.Size = new Size(93, 20);
            labelIdAnggota.TabIndex = 0;
            labelIdAnggota.Text = "ID Anggota :";
            // 
            // textBoxIdAnggota
            // 
            textBoxIdAnggota.Location = new Point(149, 49);
            textBoxIdAnggota.Margin = new Padding(3, 4, 3, 4);
            textBoxIdAnggota.Name = "textBoxIdAnggota";
            textBoxIdAnggota.Size = new Size(228, 27);
            textBoxIdAnggota.TabIndex = 1;
            // 
            // labelPilihBuku
            // 
            labelPilihBuku.AutoSize = true;
            labelPilihBuku.Location = new Point(23, 113);
            labelPilihBuku.Name = "labelPilihBuku";
            labelPilihBuku.Size = new Size(80, 20);
            labelPilihBuku.TabIndex = 2;
            labelPilihBuku.Text = "Pilih Buku :";
            // 
            // comboBoxBuku
            // 
            comboBoxBuku.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBuku.FormattingEnabled = true;
            comboBoxBuku.Location = new Point(149, 109);
            comboBoxBuku.Margin = new Padding(3, 4, 3, 4);
            comboBoxBuku.Name = "comboBoxBuku";
            comboBoxBuku.Size = new Size(228, 28);
            comboBoxBuku.TabIndex = 3;
            // 
            // labelBatasPengembalian
            // 
            labelBatasPengembalian.AutoSize = true;
            labelBatasPengembalian.Location = new Point(23, 173);
            labelBatasPengembalian.Name = "labelBatasPengembalian";
            labelBatasPengembalian.Size = new Size(150, 20);
            labelBatasPengembalian.TabIndex = 4;
            labelBatasPengembalian.Text = "Batas Pengembalian :";
            // 
            // labelTanggalKembali
            // 
            labelTanggalKembali.AutoSize = true;
            labelTanggalKembali.Location = new Point(182, 173);
            labelTanggalKembali.Name = "labelTanggalKembali";
            labelTanggalKembali.Size = new Size(204, 20);
            labelTanggalKembali.TabIndex = 5;
            labelTanggalKembali.Text = "menampilkan tanggal 7 hari...";
            // 
            // buttonPinjam
            // 
            buttonPinjam.Location = new Point(57, 333);
            buttonPinjam.Margin = new Padding(3, 4, 3, 4);
            buttonPinjam.Name = "buttonPinjam";
            buttonPinjam.Size = new Size(86, 40);
            buttonPinjam.TabIndex = 6;
            buttonPinjam.Text = "Pinjam";
            buttonPinjam.UseVisualStyleBackColor = true;
            buttonPinjam.Click += buttonPinjam_Click;
            // 
            // buttonResetPeminjaman
            // 
            buttonResetPeminjaman.Location = new Point(251, 333);
            buttonResetPeminjaman.Margin = new Padding(3, 4, 3, 4);
            buttonResetPeminjaman.Name = "buttonResetPeminjaman";
            buttonResetPeminjaman.Size = new Size(86, 40);
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
            groupBoxPengembalian.Location = new Point(459, 100);
            groupBoxPengembalian.Margin = new Padding(3, 4, 3, 4);
            groupBoxPengembalian.Name = "groupBoxPengembalian";
            groupBoxPengembalian.Padding = new Padding(3, 4, 3, 4);
            groupBoxPengembalian.Size = new Size(423, 467);
            groupBoxPengembalian.TabIndex = 2;
            groupBoxPengembalian.TabStop = false;
            groupBoxPengembalian.Text = "Formulir Pengembalian";
            // 
            // labelDisplayDenda
            // 
            labelDisplayDenda.AutoSize = true;
            labelDisplayDenda.Location = new Point(160, 333);
            labelDisplayDenda.Name = "labelDisplayDenda";
            labelDisplayDenda.Size = new Size(51, 20);
            labelDisplayDenda.TabIndex = 14;
            labelDisplayDenda.Text = "denda";
            // 
            // labelDenda
            // 
            labelDenda.AutoSize = true;
            labelDenda.Location = new Point(23, 333);
            labelDenda.Name = "labelDenda";
            labelDenda.Size = new Size(60, 20);
            labelDenda.TabIndex = 13;
            labelDenda.Text = "Denda: ";
            // 
            // buttonCek
            // 
            buttonCek.Location = new Point(320, 49);
            buttonCek.Margin = new Padding(3, 4, 3, 4);
            buttonCek.Name = "buttonCek";
            buttonCek.Size = new Size(86, 27);
            buttonCek.TabIndex = 12;
            buttonCek.Text = "Cek";
            buttonCek.UseVisualStyleBackColor = true;
            buttonCek.Click += buttonCek_Click;
            // 
            // labelIdPeminjaman
            // 
            labelIdPeminjaman.AutoSize = true;
            labelIdPeminjaman.Location = new Point(23, 53);
            labelIdPeminjaman.Name = "labelIdPeminjaman";
            labelIdPeminjaman.Size = new Size(116, 20);
            labelIdPeminjaman.TabIndex = 0;
            labelIdPeminjaman.Text = "ID Peminjaman :";
            // 
            // textBoxIdPeminjamanReturn
            // 
            textBoxIdPeminjamanReturn.Location = new Point(160, 49);
            textBoxIdPeminjamanReturn.Margin = new Padding(3, 4, 3, 4);
            textBoxIdPeminjamanReturn.Name = "textBoxIdPeminjamanReturn";
            textBoxIdPeminjamanReturn.Size = new Size(136, 27);
            textBoxIdPeminjamanReturn.TabIndex = 1;
            // 
            // labelBukuReturn
            // 
            labelBukuReturn.AutoSize = true;
            labelBukuReturn.Location = new Point(23, 107);
            labelBukuReturn.Name = "labelBukuReturn";
            labelBukuReturn.Size = new Size(48, 20);
            labelBukuReturn.TabIndex = 2;
            labelBukuReturn.Text = "Buku :";
            // 
            // labelDisplayBukuReturn
            // 
            labelDisplayBukuReturn.AutoSize = true;
            labelDisplayBukuReturn.Location = new Point(160, 107);
            labelDisplayBukuReturn.Name = "labelDisplayBukuReturn";
            labelDisplayBukuReturn.Size = new Size(136, 20);
            labelDisplayBukuReturn.TabIndex = 3;
            labelDisplayBukuReturn.Text = "menampilkan judul";
            // 
            // labelIdAnggotaReturn
            // 
            labelIdAnggotaReturn.AutoSize = true;
            labelIdAnggotaReturn.Location = new Point(23, 160);
            labelIdAnggotaReturn.Name = "labelIdAnggotaReturn";
            labelIdAnggotaReturn.Size = new Size(74, 20);
            labelIdAnggotaReturn.TabIndex = 4;
            labelIdAnggotaReturn.Text = "Anggota :";
            // 
            // labelDisplayIdAnggotaReturn
            // 
            labelDisplayIdAnggotaReturn.AutoSize = true;
            labelDisplayIdAnggotaReturn.Location = new Point(160, 160);
            labelDisplayIdAnggotaReturn.Name = "labelDisplayIdAnggotaReturn";
            labelDisplayIdAnggotaReturn.Size = new Size(116, 20);
            labelDisplayIdAnggotaReturn.TabIndex = 5;
            labelDisplayIdAnggotaReturn.Text = "menampilkan id";
            // 
            // labelBatasPengembalianReturn
            // 
            labelBatasPengembalianReturn.AutoSize = true;
            labelBatasPengembalianReturn.Location = new Point(23, 213);
            labelBatasPengembalianReturn.Name = "labelBatasPengembalianReturn";
            labelBatasPengembalianReturn.Size = new Size(150, 20);
            labelBatasPengembalianReturn.TabIndex = 6;
            labelBatasPengembalianReturn.Text = "Batas Pengembalian :";
            // 
            // labelDisplayBatasPengembalian
            // 
            labelDisplayBatasPengembalian.AutoSize = true;
            labelDisplayBatasPengembalian.Location = new Point(177, 213);
            labelDisplayBatasPengembalian.Name = "labelDisplayBatasPengembalian";
            labelDisplayBatasPengembalian.Size = new Size(154, 20);
            labelDisplayBatasPengembalian.TabIndex = 7;
            labelDisplayBatasPengembalian.Text = "menampilkan tanggal";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(23, 267);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(56, 20);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status :";
            // 
            // labelDisplayStatus
            // 
            labelDisplayStatus.AutoSize = true;
            labelDisplayStatus.Location = new Point(160, 267);
            labelDisplayStatus.Name = "labelDisplayStatus";
            labelDisplayStatus.Size = new Size(109, 20);
            labelDisplayStatus.TabIndex = 9;
            labelDisplayStatus.Text = "telat atau tidak";
            // 
            // buttonKembalikan
            // 
            buttonKembalikan.Location = new Point(57, 394);
            buttonKembalikan.Margin = new Padding(3, 4, 3, 4);
            buttonKembalikan.Name = "buttonKembalikan";
            buttonKembalikan.Size = new Size(116, 40);
            buttonKembalikan.TabIndex = 10;
            buttonKembalikan.Text = "Kembalikan";
            buttonKembalikan.UseVisualStyleBackColor = true;
            buttonKembalikan.Click += buttonKembalikan_Click;
            // 
            // buttonResetPengembalian
            // 
            buttonResetPengembalian.Location = new Point(251, 394);
            buttonResetPengembalian.Margin = new Padding(3, 4, 3, 4);
            buttonResetPengembalian.Name = "buttonResetPengembalian";
            buttonResetPengembalian.Size = new Size(86, 40);
            buttonResetPengembalian.TabIndex = 11;
            buttonResetPengembalian.Text = "Reset";
            buttonResetPengembalian.UseVisualStyleBackColor = true;
            buttonResetPengembalian.Click += buttonResetPengembalian_Click;
            // 
            // Sirkulasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 588);
            Controls.Add(panelHeader);
            Controls.Add(groupBoxPeminjaman);
            Controls.Add(groupBoxPengembalian);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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
