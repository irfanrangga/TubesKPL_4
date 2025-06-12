namespace ManajemenPerpus.GUI
{
    partial class UlasanPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UlasanPage));
            ulasanControllerBindingSource1 = new BindingSource(components);
            ulasanServiceBindingSource = new BindingSource(components);
            panel1 = new Panel();
            ulasanTextBox = new TextBox();
            btnPanel = new Panel();
            cancelBtnPanel = new Panel();
            customButton1 = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            submitBtnPanel = new Panel();
            btnSubmit = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            label1 = new Label();
            NavbarPanel = new Panel();
            customButton2 = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            panel3 = new Panel();
            PeminjamanBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            KoleksiBtn = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            layoutUlasan = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ulasanControllerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ulasanServiceBindingSource).BeginInit();
            panel1.SuspendLayout();
            btnPanel.SuspendLayout();
            cancelBtnPanel.SuspendLayout();
            submitBtnPanel.SuspendLayout();
            NavbarPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ulasanControllerBindingSource1
            // 
            ulasanControllerBindingSource1.DataSource = typeof(API.Controllers.UlasanController);
            // 
            // panel1
            // 
            panel1.Controls.Add(ulasanTextBox);
            panel1.Controls.Add(btnPanel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 58);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(1008, 158);
            panel1.TabIndex = 2;
            // 
            // ulasanTextBox
            // 
            ulasanTextBox.BackColor = SystemColors.Window;
            ulasanTextBox.Dock = DockStyle.Top;
            ulasanTextBox.Location = new Point(12, 33);
            ulasanTextBox.Multiline = true;
            ulasanTextBox.Name = "ulasanTextBox";
            ulasanTextBox.PlaceholderText = "Bagaimana pendapatmu tentang buku ini?";
            ulasanTextBox.Size = new Size(984, 49);
            ulasanTextBox.TabIndex = 3;
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(cancelBtnPanel);
            btnPanel.Controls.Add(submitBtnPanel);
            btnPanel.Location = new Point(12, 88);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(984, 55);
            btnPanel.TabIndex = 2;
            // 
            // cancelBtnPanel
            // 
            cancelBtnPanel.AutoSize = true;
            cancelBtnPanel.Controls.Add(customButton1);
            cancelBtnPanel.Dock = DockStyle.Right;
            cancelBtnPanel.Location = new Point(660, 0);
            cancelBtnPanel.Name = "cancelBtnPanel";
            cancelBtnPanel.Padding = new Padding(6);
            cancelBtnPanel.Size = new Size(162, 55);
            cancelBtnPanel.TabIndex = 1;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.White;
            customButton1.BackgroundColor = Color.White;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 10;
            customButton1.BorderSize = 0;
            customButton1.Dock = DockStyle.Right;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.Red;
            customButton1.Location = new Point(6, 6);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 43);
            customButton1.TabIndex = 0;
            customButton1.Text = "Hapus";
            customButton1.TextColor = Color.Red;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click_1;
            // 
            // submitBtnPanel
            // 
            submitBtnPanel.AutoSize = true;
            submitBtnPanel.Controls.Add(btnSubmit);
            submitBtnPanel.Dock = DockStyle.Right;
            submitBtnPanel.Location = new Point(822, 0);
            submitBtnPanel.Name = "submitBtnPanel";
            submitBtnPanel.Padding = new Padding(6);
            submitBtnPanel.Size = new Size(162, 55);
            submitBtnPanel.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RoyalBlue;
            btnSubmit.BackgroundColor = Color.RoyalBlue;
            btnSubmit.BorderColor = Color.PaleVioletRed;
            btnSubmit.BorderRadius = 10;
            btnSubmit.BorderSize = 0;
            btnSubmit.Dock = DockStyle.Right;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(6, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 43);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Kirim";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Ulasan";
            // 
            // NavbarPanel
            // 
            NavbarPanel.BackColor = Color.RoyalBlue;
            NavbarPanel.Controls.Add(customButton2);
            NavbarPanel.Controls.Add(panel3);
            NavbarPanel.Dock = DockStyle.Top;
            NavbarPanel.Location = new Point(0, 0);
            NavbarPanel.Margin = new Padding(2, 1, 2, 1);
            NavbarPanel.Name = "NavbarPanel";
            NavbarPanel.Size = new Size(1008, 58);
            NavbarPanel.TabIndex = 1;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.RoyalBlue;
            customButton2.BackgroundColor = Color.RoyalBlue;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 0;
            customButton2.BorderSize = 0;
            customButton2.Dock = DockStyle.Left;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Image = (Image)resources.GetObject("customButton2.Image");
            customButton2.Location = new Point(0, 0);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(85, 58);
            customButton2.TabIndex = 2;
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
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
            // layoutUlasan
            // 
            layoutUlasan.Dock = DockStyle.Fill;
            layoutUlasan.Location = new Point(0, 216);
            layoutUlasan.Name = "layoutUlasan";
            layoutUlasan.Size = new Size(1008, 513);
            layoutUlasan.TabIndex = 3;
            // 
            // UlasanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 729);
            Controls.Add(layoutUlasan);
            Controls.Add(panel1);
            Controls.Add(NavbarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "UlasanPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UlasanPage";
            ((System.ComponentModel.ISupportInitialize)ulasanControllerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ulasanServiceBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            btnPanel.ResumeLayout(false);
            btnPanel.PerformLayout();
            cancelBtnPanel.ResumeLayout(false);
            submitBtnPanel.ResumeLayout(false);
            NavbarPanel.ResumeLayout(false);
            NavbarPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomControl.CustomButton btnSubmit;
        private CustomControl.CustomButton PeminjamanBtn;
        private CustomControl.CustomButton KoleksiBtn;
        private CustomControl.CustomButton KirimBtn;
        private CustomControl.CustomButton BatalBtn;
        private BindingSource ulasanControllerBindingSource1;
        private BindingSource ulasanServiceBindingSource;
        private CustomControl.UlasanList ulasanList1;
        private CustomControl.UlasanList ulasanList2;
        private Panel panel1;
        private Panel btnPanel;
        private Panel cancelBtnPanel;
        private Panel submitBtnPanel;
        private Label label1;
        private CustomControl.CustomButton customButton1;
        private Panel NavbarPanel;
        private CustomControl.CustomButton customButton2;
        private Panel panel3;
        private FlowLayoutPanel layoutUlasan;
        private TextBox ulasanTextBox;
    }
}