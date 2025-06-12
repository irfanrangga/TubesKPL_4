namespace ManajemenAdminGUI.Forms
{
    partial class FormDaftarBuku
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
            this.dataGridViewBuku = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).BeginInit();
            this.SuspendLayout();

            // dataGridViewBuku
            this.dataGridViewBuku.AllowUserToAddRows = false;
            this.dataGridViewBuku.AllowUserToDeleteRows = false;
            this.dataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuku.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewBuku.Name = "dataGridViewBuku";
            this.dataGridViewBuku.ReadOnly = true;
            this.dataGridViewBuku.RowTemplate.Height = 25;
            this.dataGridViewBuku.Size = new System.Drawing.Size(740, 400);
            this.dataGridViewBuku.TabIndex = 0;
            this.dataGridViewBuku.Columns.Add("IdBuku", "ID Buku");
            this.dataGridViewBuku.Columns.Add("Judul", "Judul");
            this.dataGridViewBuku.Columns.Add("Penulis", "Penulis");
            this.dataGridViewBuku.Columns.Add("Penerbit", "Penerbit");
            this.dataGridViewBuku.Columns.Add("Kategori", "Kategori");
            this.dataGridViewBuku.Columns.Add("Sinopsis", "Sinopsis");

            // FormDaftarBuku
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.dataGridViewBuku);
            this.Name = "FormDaftarBuku";
            this.Text = "Daftar Buku";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBuku;
    }
}
