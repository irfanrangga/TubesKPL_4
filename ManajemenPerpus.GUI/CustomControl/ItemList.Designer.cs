namespace ManajemenPerpus.GUI.CustomControl
{
    partial class ItemList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            PenerbitLabel = new Label();
            PenulisLabel = new Label();
            TanggalLabel = new Label();
            KategoriLabel = new Label();
            SinopsisText = new Label();
            BookTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PenerbitLabel);
            panel1.Controls.Add(PenulisLabel);
            panel1.Controls.Add(TanggalLabel);
            panel1.Controls.Add(KategoriLabel);
            panel1.Controls.Add(SinopsisText);
            panel1.Controls.Add(BookTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 162);
            panel1.TabIndex = 1;
            panel1.Click += panel_click;
            panel1.MouseEnter += ItemList_MouseEnter;
            panel1.MouseLeave += ItemList_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 61);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 3;
            label1.Text = "Informasi Buku";
            // 
            // PenerbitLabel
            // 
            PenerbitLabel.AutoSize = true;
            PenerbitLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PenerbitLabel.ForeColor = Color.Black;
            PenerbitLabel.Location = new Point(2, 121);
            PenerbitLabel.Margin = new Padding(2, 0, 2, 0);
            PenerbitLabel.Name = "PenerbitLabel";
            PenerbitLabel.Size = new Size(156, 19);
            PenerbitLabel.TabIndex = 2;
            PenerbitLabel.Text = "Penerbit: Nama Penerbit";
            PenerbitLabel.Click += PenerbitLabel_Click;
            PenerbitLabel.MouseEnter += ItemList_MouseEnter;
            PenerbitLabel.MouseLeave += ItemList_MouseLeave;
            // 
            // PenulisLabel
            // 
            PenulisLabel.AutoSize = true;
            PenulisLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PenulisLabel.ForeColor = Color.Black;
            PenulisLabel.Location = new Point(2, 90);
            PenulisLabel.Margin = new Padding(2, 0, 2, 0);
            PenulisLabel.Name = "PenulisLabel";
            PenulisLabel.Size = new Size(140, 19);
            PenulisLabel.TabIndex = 1;
            PenulisLabel.Text = "Penulis: Nama Penulis";
            PenulisLabel.MouseEnter += ItemList_MouseEnter;
            PenulisLabel.MouseLeave += ItemList_MouseLeave;
            // 
            // TanggalLabel
            // 
            TanggalLabel.AutoSize = true;
            TanggalLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TanggalLabel.ForeColor = Color.Black;
            TanggalLabel.Location = new Point(223, 121);
            TanggalLabel.Margin = new Padding(2, 0, 2, 0);
            TanggalLabel.Name = "TanggalLabel";
            TanggalLabel.Size = new Size(195, 19);
            TanggalLabel.TabIndex = 2;
            TanggalLabel.Text = "Tanggal Masuk: DD/MM/YYYY";
            TanggalLabel.MouseEnter += ItemList_MouseEnter;
            TanggalLabel.MouseLeave += ItemList_MouseLeave;
            // 
            // KategoriLabel
            // 
            KategoriLabel.AutoSize = true;
            KategoriLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KategoriLabel.ForeColor = Color.Black;
            KategoriLabel.Location = new Point(223, 90);
            KategoriLabel.Margin = new Padding(2, 0, 2, 0);
            KategoriLabel.Name = "KategoriLabel";
            KategoriLabel.Size = new Size(162, 19);
            KategoriLabel.TabIndex = 2;
            KategoriLabel.Text = "Kategori: Fiksi / Non Fiksi";
            KategoriLabel.MouseEnter += ItemList_MouseEnter;
            KategoriLabel.MouseLeave += ItemList_MouseLeave;
            // 
            // SinopsisText
            // 
            SinopsisText.AutoSize = true;
            SinopsisText.Dock = DockStyle.Top;
            SinopsisText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SinopsisText.ForeColor = Color.DarkGray;
            SinopsisText.Location = new Point(0, 30);
            SinopsisText.Margin = new Padding(2, 0, 2, 0);
            SinopsisText.Name = "SinopsisText";
            SinopsisText.Padding = new Padding(6);
            SinopsisText.Size = new Size(78, 27);
            SinopsisText.TabIndex = 1;
            SinopsisText.Text = "Isi Sinopsis";
            SinopsisText.MouseEnter += ItemList_MouseEnter;
            SinopsisText.MouseLeave += ItemList_MouseLeave;
            // 
            // BookTitle
            // 
            BookTitle.Dock = DockStyle.Top;
            BookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookTitle.Location = new Point(0, 0);
            BookTitle.Margin = new Padding(2, 0, 2, 0);
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(1920, 30);
            BookTitle.TabIndex = 0;
            BookTitle.Text = "Title";
            BookTitle.TextAlign = ContentAlignment.MiddleLeft;
            BookTitle.MouseEnter += ItemList_MouseEnter;
            BookTitle.MouseLeave += ItemList_MouseLeave;
            // 
            // ItemList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ItemList";
            Size = new Size(1920, 162);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label BookTitle;
        private Label SinopsisText;
        private Label PenulisLabel;
        private Label PenerbitLabel;
        private Label TanggalLabel;
        private Label KategoriLabel;
        private Label label1;
    }
}
