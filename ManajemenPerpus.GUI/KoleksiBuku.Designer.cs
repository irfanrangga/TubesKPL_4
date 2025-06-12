namespace ManajemenPerpus.GUI
{
    partial class KoleksiBuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoleksiBuku));
            NavbarPanel = new Panel();
            customButton1 = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            panel3 = new Panel();
            PeminjamanBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            KoleksiBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            SearchPanel = new Panel();
            Searchbox = new TextBox();
            NavbarPanel.SuspendLayout();
            panel3.SuspendLayout();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavbarPanel
            // 
            NavbarPanel.BackColor = Color.RoyalBlue;
            NavbarPanel.Controls.Add(customButton1);
            NavbarPanel.Controls.Add(panel3);
            NavbarPanel.Dock = DockStyle.Top;
            NavbarPanel.Location = new Point(0, 0);
            NavbarPanel.Margin = new Padding(2, 1, 2, 1);
            NavbarPanel.Name = "NavbarPanel";
            NavbarPanel.Size = new Size(1008, 58);
            NavbarPanel.TabIndex = 4;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.RoyalBlue;
            customButton1.BackgroundColor = Color.RoyalBlue;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.Dock = DockStyle.Left;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Image = (Image)resources.GetObject("customButton1.Image");
            customButton1.Location = new Point(0, 0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(85, 58);
            customButton1.TabIndex = 2;
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(PeminjamanBtn);
            panel3.Controls.Add(KoleksiBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(684, 0);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 58);
            panel3.TabIndex = 1;
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
            PeminjamanBtn.Location = new Point(162, 0);
            PeminjamanBtn.Margin = new Padding(2, 1, 2, 1);
            PeminjamanBtn.Name = "PeminjamanBtn";
            PeminjamanBtn.Size = new Size(162, 58);
            PeminjamanBtn.TabIndex = 3;
            PeminjamanBtn.Text = "Peminjaman";
            PeminjamanBtn.TextColor = Color.White;
            PeminjamanBtn.UseVisualStyleBackColor = false;
            PeminjamanBtn.Click += PeminjamanBtn_Click;
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
            KoleksiBtn.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KoleksiBtn.ForeColor = Color.White;
            KoleksiBtn.Location = new Point(0, 0);
            KoleksiBtn.Margin = new Padding(2, 1, 2, 1);
            KoleksiBtn.Name = "KoleksiBtn";
            KoleksiBtn.Size = new Size(162, 58);
            KoleksiBtn.TabIndex = 2;
            KoleksiBtn.Text = "Koleksi Buku";
            KoleksiBtn.TextColor = Color.White;
            KoleksiBtn.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 131);
            flowLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1008, 598);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(982, 28);
            label2.TabIndex = 0;
            label2.Text = "Cari Buku";
            // 
            // SearchPanel
            // 
            SearchPanel.AutoSize = true;
            SearchPanel.BackColor = Color.AliceBlue;
            SearchPanel.Controls.Add(Searchbox);
            SearchPanel.Controls.Add(label2);
            SearchPanel.Dock = DockStyle.Top;
            SearchPanel.Location = new Point(0, 58);
            SearchPanel.Margin = new Padding(2, 1, 2, 1);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Padding = new Padding(13, 11, 13, 11);
            SearchPanel.Size = new Size(1008, 73);
            SearchPanel.TabIndex = 5;
            // 
            // Searchbox
            // 
            Searchbox.BorderStyle = BorderStyle.FixedSingle;
            Searchbox.Dock = DockStyle.Top;
            Searchbox.Location = new Point(13, 39);
            Searchbox.Name = "Searchbox";
            Searchbox.PlaceholderText = "Masukan Judul Buku";
            Searchbox.Size = new Size(982, 23);
            Searchbox.TabIndex = 1;
            Searchbox.TextChanged += Searchbar_TextChanged;
            // 
            // KoleksiBuku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 729);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchPanel);
            Controls.Add(NavbarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "KoleksiBuku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Koleksi Buku";
            Load += KoleksiBuku_Load;
            NavbarPanel.ResumeLayout(false);
            NavbarPanel.PerformLayout();
            panel3.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavbarPanel;
        private Panel panel3;
        private CustomControl.CustomButton PeminjamanBtn;
        private CustomControl.CustomButton KoleksiBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomControl.CustomButton customButton1;
        private Label label2;
        private Panel SearchPanel;
        private TextBox Searchbox;
    }
}