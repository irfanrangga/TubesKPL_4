using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManajemenPerpus.GUI.CustomControl
{
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximumSize = new Size(0, 0);
            this.Resize += ItemList_Resize;
        }

        #region Properties
        private string _title;
        private string _sinopsis;
        private string _penerbit;
        private string _penulis;
        private string _kategori;
        private string _tanggalMasuk;

        private void ItemList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
        }

        private void ItemList_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ItemList_Resize(object sender, EventArgs e)
        {
            SinopsisText.MaximumSize = new Size(this.Width - 40, 0);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void PenerbitLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel_click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ItemList clickedItem = sender as ItemList;
            if(clickedItem != null && clickedItem.Tag is string idBuku)
            {
                UlasanPage ulasanPage = new UlasanPage(idBuku);
                ulasanPage.Show();
                this.Hide(); // Sembunyikan form KoleksiBuku saat membuka UlasanPage
            }
        }

        [Category("Custom Properties")]
        public string Title
        {
            get { return _title; }
            set { _title = value; BookTitle.Text = value; BookTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; }
        }

        [Category("Custom Properties")]
        public string Sinopsis
        {
            get { return _sinopsis; }
            set
            {
                _sinopsis = value;
                SinopsisText.AutoSize = true;
                SinopsisText.MaximumSize = new Size(this.Width - 40, 0); // supaya wrap teks
                SinopsisText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                SinopsisText.Text = value;
            }
        }

        [Category("Custom Properties")]
        public string Penerbit
        {
            get { return _penerbit; }
            set { _penerbit = value; PenerbitLabel.Text = "Penerbit: " + value; PenerbitLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; }
        }

        [Category("Custom Properties")]
        public string Penulis
        {
            get { return _penulis; }
            set { _penulis = value; PenulisLabel.Text = "Penulis: " + value; PenulisLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; }
        }

        [Category("Custom Properties")]
        public string Kategori
        {
            get { return _kategori; }
            set { _kategori = value; KategoriLabel.Text = "Kategori: " + value; KategoriLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; }
        }

        [Category("Custom Properties")]
        public string TanggalMasuk
        {
            get { return _tanggalMasuk; }
            set { _tanggalMasuk = value; TanggalLabel.Text = "Tanggal Masuk: " + value; TanggalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; }
        }

        #endregion
    }
}
