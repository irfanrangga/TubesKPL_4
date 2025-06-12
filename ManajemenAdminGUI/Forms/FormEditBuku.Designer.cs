namespace ManajemenAdminGUI.Forms
{
    partial class FormEditBuku
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtIdCari = new TextBox();
            btnCari = new Button();
            groupEdit = new GroupBox();
            txtJudul = new TextBox();
            txtPenulis = new TextBox();
            txtPenerbit = new TextBox();
            cmbKategori = new ComboBox();
            txtSinopsis = new TextBox();
            btnSimpan = new Button();
            groupEdit.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdCari
            // 
            txtIdCari.Location = new Point(30, 20);
            txtIdCari.Name = "txtIdCari";
            txtIdCari.Size = new Size(200, 27);
            txtIdCari.TabIndex = 0;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(250, 20);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(100, 23);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.Click += btnCari_Click;
            // 
            // groupEdit
            // 
            groupEdit.Controls.Add(txtJudul);
            groupEdit.Controls.Add(txtPenulis);
            groupEdit.Controls.Add(txtPenerbit);
            groupEdit.Controls.Add(cmbKategori);
            groupEdit.Controls.Add(txtSinopsis);
            groupEdit.Controls.Add(btnSimpan);
            groupEdit.Enabled = false;
            groupEdit.Location = new Point(30, 60);
            groupEdit.Name = "groupEdit";
            groupEdit.Size = new Size(600, 250);
            groupEdit.TabIndex = 2;
            groupEdit.TabStop = false;
            groupEdit.Text = "Edit Buku";
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(20, 30);
            txtJudul.Name = "txtJudul";
            txtJudul.PlaceholderText = "Judul";
            txtJudul.Size = new Size(250, 27);
            txtJudul.TabIndex = 0;
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(20, 65);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.PlaceholderText = "Penulis";
            txtPenulis.Size = new Size(250, 27);
            txtPenulis.TabIndex = 1;
            // 
            // txtPenerbit
            // 
            txtPenerbit.Location = new Point(20, 100);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.PlaceholderText = "Penerbit";
            txtPenerbit.Size = new Size(250, 27);
            txtPenerbit.TabIndex = 2;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Items.AddRange(new object[] { "FIKSI", "NON_FIKSI", "SAINS", "SEJARAH" });
            cmbKategori.Location = new Point(20, 135);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(250, 28);
            cmbKategori.TabIndex = 3;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(300, 30);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.PlaceholderText = "Sinopsis";
            txtSinopsis.Size = new Size(280, 130);
            txtSinopsis.TabIndex = 4;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(480, 180);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 30);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.Click += btnSimpan_Click;
            // 
            // FormEditBuku
            // 
            ClientSize = new Size(738, 380);
            Controls.Add(txtIdCari);
            Controls.Add(btnCari);
            Controls.Add(groupEdit);
            Name = "FormEditBuku";
            Text = "Edit Buku";
            groupEdit.ResumeLayout(false);
            groupEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.GroupBox groupEdit;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Button btnSimpan;
    }
}
