namespace ManajemenPerpus.GUI
{
    partial class UlasanGui
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UlasanGui));
            NavbarPanel = new Panel();
            panel3 = new Panel();
            UlasanBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            LogoutBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            PeminjamanBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            KoleksiBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            LogoPanel = new Panel();
            label1 = new Label();
            SearchPanel = new Panel();
            Searchbar = new TextBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            NavbarPanel.SuspendLayout();
            panel3.SuspendLayout();
            LogoPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavbarPanel
            // 
            NavbarPanel.BackColor = Color.RoyalBlue;
            NavbarPanel.Controls.Add(panel3);
            NavbarPanel.Controls.Add(LogoPanel);
            NavbarPanel.Dock = DockStyle.Top;
            NavbarPanel.Location = new Point(0, 0);
            NavbarPanel.Name = "NavbarPanel";
            NavbarPanel.Size = new Size(1771, 124);
            NavbarPanel.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(UlasanBtn);
            panel3.Controls.Add(LogoutBtn);
            panel3.Controls.Add(PeminjamanBtn);
            panel3.Controls.Add(KoleksiBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(716, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1055, 124);
            panel3.TabIndex = 1;
            // 
            // UlasanBtn
            // 
            UlasanBtn.BackColor = Color.RoyalBlue;
            UlasanBtn.BackgroundColor = Color.RoyalBlue;
            UlasanBtn.BorderColor = Color.PaleVioletRed;
            UlasanBtn.BorderRadius = 0;
            UlasanBtn.BorderSize = 0;
            UlasanBtn.Dock = DockStyle.Left;
            UlasanBtn.FlatAppearance.BorderSize = 0;
            UlasanBtn.FlatStyle = FlatStyle.Flat;
            UlasanBtn.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UlasanBtn.ForeColor = Color.White;
            UlasanBtn.Location = new Point(600, 0);
            UlasanBtn.Name = "UlasanBtn";
            UlasanBtn.Size = new Size(300, 124);
            UlasanBtn.TabIndex = 4;
            UlasanBtn.Text = "Ulasan";
            UlasanBtn.TextColor = Color.White;
            UlasanBtn.UseVisualStyleBackColor = false;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.RoyalBlue;
            LogoutBtn.BackgroundColor = Color.RoyalBlue;
            LogoutBtn.BorderColor = Color.PaleVioletRed;
            LogoutBtn.BorderRadius = 0;
            LogoutBtn.BorderSize = 0;
            LogoutBtn.Dock = DockStyle.Right;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(900, 0);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(155, 124);
            LogoutBtn.TabIndex = 3;
            LogoutBtn.TextColor = Color.White;
            LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // PeminjamanBtn
            // 
            PeminjamanBtn.BackColor = Color.RoyalBlue;
            PeminjamanBtn.BackgroundColor = Color.RoyalBlue;
            PeminjamanBtn.BorderColor = Color.PaleVioletRed;
            PeminjamanBtn.BorderRadius = 0;
            PeminjamanBtn.BorderSize = 0;
            PeminjamanBtn.Dock = DockStyle.Left;
            PeminjamanBtn.FlatAppearance.BorderSize = 0;
            PeminjamanBtn.FlatStyle = FlatStyle.Flat;
            PeminjamanBtn.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PeminjamanBtn.ForeColor = Color.White;
            PeminjamanBtn.Location = new Point(300, 0);
            PeminjamanBtn.Name = "PeminjamanBtn";
            PeminjamanBtn.Size = new Size(300, 124);
            PeminjamanBtn.TabIndex = 3;
            PeminjamanBtn.Text = "Peminjaman";
            PeminjamanBtn.TextColor = Color.White;
            PeminjamanBtn.UseVisualStyleBackColor = false;
            // 
            // KoleksiBtn
            // 
            KoleksiBtn.BackColor = Color.RoyalBlue;
            KoleksiBtn.BackgroundColor = Color.RoyalBlue;
            KoleksiBtn.BorderColor = Color.PaleVioletRed;
            KoleksiBtn.BorderRadius = 0;
            KoleksiBtn.BorderSize = 0;
            KoleksiBtn.Dock = DockStyle.Left;
            KoleksiBtn.FlatAppearance.BorderSize = 0;
            KoleksiBtn.FlatStyle = FlatStyle.Flat;
            KoleksiBtn.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KoleksiBtn.ForeColor = Color.White;
            KoleksiBtn.Location = new Point(0, 0);
            KoleksiBtn.Name = "KoleksiBtn";
            KoleksiBtn.Size = new Size(300, 124);
            KoleksiBtn.TabIndex = 2;
            KoleksiBtn.Text = "Koleksi Buku";
            KoleksiBtn.TextColor = Color.White;
            KoleksiBtn.UseVisualStyleBackColor = false;
            // 
            // LogoPanel
            // 
            LogoPanel.Controls.Add(label1);
            LogoPanel.Dock = DockStyle.Left;
            LogoPanel.ForeColor = SystemColors.Control;
            LogoPanel.Location = new Point(0, 0);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(524, 124);
            LogoPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(471, 50);
            label1.TabIndex = 0;
            label1.Text = "Manajemen Perpustakaan";
            // 
            // SearchPanel
            // 
            SearchPanel.AutoSize = true;
            SearchPanel.BackColor = Color.AliceBlue;
            SearchPanel.Controls.Add(Searchbar);
            SearchPanel.Controls.Add(label2);
            SearchPanel.Dock = DockStyle.Top;
            SearchPanel.Location = new Point(0, 124);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Padding = new Padding(24);
            SearchPanel.Size = new Size(1771, 149);
            SearchPanel.TabIndex = 5;
            // 
            // Searchbar
            // 
            Searchbar.BackColor = Color.White;
            Searchbar.BorderStyle = BorderStyle.FixedSingle;
            Searchbar.Dock = DockStyle.Top;
            Searchbar.ForeColor = SystemColors.ControlText;
            Searchbar.Location = new Point(24, 83);
            Searchbar.Multiline = true;
            Searchbar.Name = "Searchbar";
            Searchbar.PlaceholderText = "Masukan Judul Buku";
            Searchbar.Size = new Size(1723, 42);
            Searchbar.TabIndex = 1;
            Searchbar.TextChanged += Searchbar_TextChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 24);
            label2.Name = "label2";
            label2.Size = new Size(1723, 59);
            label2.TabIndex = 0;
            label2.Text = "Cari Buku";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 273);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1771, 818);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // UlasanGui
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1771, 1091);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchPanel);
            Controls.Add(NavbarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UlasanGui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lihat Ulasan";
            Load += UlasanGui_Load;
            NavbarPanel.ResumeLayout(false);
            NavbarPanel.PerformLayout();
            panel3.ResumeLayout(false);
            LogoPanel.ResumeLayout(false);
            LogoPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavbarPanel;
        private Panel panel3;
        private CustomControl.CustomButton UlasanBtn;
        private CustomControl.CustomButton LogoutBtn;
        private CustomControl.CustomButton PeminjamanBtn;
        private CustomControl.CustomButton KoleksiBtn;
        private Panel LogoPanel;
        private Label label1;
        private Panel SearchPanel;
        private TextBox Searchbar;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}