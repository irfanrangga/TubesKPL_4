using System.Windows.Forms;
using System.Drawing;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.GUI
{
    public partial class NotifikasiGui : Form
    {
        private readonly NotifikasiService _notifikasiService;
        private readonly string _idPengguna;

        public NotifikasiGui(string idPengguna)
        {
            InitializeComponent();
            _notifikasiService = new NotifikasiService();
            _idPengguna = idPengguna;
            SetupDataGridView();
            LoadNotifikasiData();
        }

        private void SetupDataGridView()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Add columns with headers
            dataGridView1.Columns.Add("IsiNotifikasi", "Isi Notifikasi");
            dataGridView1.Columns.Add("TanggalNotifikasi", "Tanggal");

            // Style the DataGridView
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set column width ratios (1/3 for date, 2/3 for content)
            dataGridView1.Columns["IsiNotifikasi"].FillWeight = 66.67f; // 2/3 of width
            dataGridView1.Columns["TanggalNotifikasi"].FillWeight = 33.33f; // 1/3 of width

            // Optional: Adjust date column alignment
            dataGridView1.Columns["TanggalNotifikasi"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadNotifikasiData()
        {
            dataGridView1.Rows.Clear();
            var notifikasiList = _notifikasiService.GetNotifikasiByPengguna(_idPengguna);

            foreach (var notif in notifikasiList)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = notif.IsiNotifikasi;
                row.Cells[1].Value = notif.TanggalNotifikasi.ToString("yyyy-MM-dd HH:mm");
                row.Tag = notif.IdNotifikasi; // Simpan ID di Tag
                dataGridView1.Rows.Add(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var notifId = selectedRow.Tag?.ToString();

                if (MessageBox.Show("Hapus notifikasi terpilih?", "Konfirmasi",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(notifId) && _notifikasiService.DeleteNotifikasi(notifId))
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                        MessageBox.Show("Notifikasi berhasil dihapus", "Informasi");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus notifikasi", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih notifikasi terlebih dahulu", "Peringatan");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedNotif = dataGridView1.SelectedRows[0].Cells["IsiNotifikasi"].Value?.ToString();
                MessageBox.Show($"Membaca notifikasi:\n\n{selectedNotif}", "Detail Notifikasi");
            }
            else
            {
                MessageBox.Show("Pilih notifikasi terlebih dahulu", "Peringatan");
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        var selectedNotif = dataGridView1.SelectedRows[0].Cells["IsiNotifikasi"].Value?.ToString();
        //        var selectedDate = dataGridView1.SelectedRows[0].Cells["TanggalNotifikasi"].Value?.ToString();

        //        if (MessageBox.Show("Hapus notifikasi terpilih?", "Konfirmasi",
        //            MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            // Find the notification by content and date (since we don't have ID displayed)
        //            var notifToDelete = _notifikasiService.GetNotifikasiByPengguna(_idPengguna)
        //                .FirstOrDefault(n =>
        //                    n.IsiNotifikasi == selectedNotif &&
        //                    n.TanggalNotifikasi.ToString("yyyy-MM-dd HH:mm") == selectedDate);

        //            if (notifToDelete != null && _notifikasiService.DeleteNotifikasi(notifToDelete.IdNotifikasi))
        //            {
        //                LoadNotifikasiData();
        //                MessageBox.Show("Notifikasi berhasil dihapus", "Informasi");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Gagal menghapus notifikasi", "Error");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Pilih notifikasi terlebih dahulu", "Peringatan");
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cell click logic if needed
        }
    }
}