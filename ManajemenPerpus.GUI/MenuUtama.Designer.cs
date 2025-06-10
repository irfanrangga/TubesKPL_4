namespace ManajemenPerpus.GUI
{
    partial class MenuUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 155);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "MenuUtama";
            Text = "Form1";
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            customButton1 = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            panel1 = new Panel();
            panel3 = new Panel();
            customButton3 = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            LogoutButton = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            customButton2 = new ManajemenPerpus.GUI.CustomControl.CustomButton();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
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
            customButton1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(0, 0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(300, 124);
            customButton1.TabIndex = 2;
            customButton1.Text = "Koleksi Buku";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1771, 124);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(customButton3);
            panel3.Controls.Add(LogoutButton);
            panel3.Controls.Add(customButton2);
            panel3.Controls.Add(customButton1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(716, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1055, 124);
            panel3.TabIndex = 1;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.RoyalBlue;
            customButton3.BackgroundColor = Color.RoyalBlue;
            customButton3.BorderColor = Color.PaleVioletRed;
            customButton3.BorderRadius = 0;
            customButton3.BorderSize = 0;
            customButton3.Dock = DockStyle.Left;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(600, 0);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(300, 124);
            customButton3.TabIndex = 4;
            customButton3.Text = "Ulasan";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.RoyalBlue;
            LogoutButton.BackgroundColor = Color.RoyalBlue;
            LogoutButton.BorderColor = Color.PaleVioletRed;
            LogoutButton.BorderRadius = 0;
            LogoutButton.BorderSize = 0;
            LogoutButton.Dock = DockStyle.Right;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Image = (Image)resources.GetObject("LogoutButton.Image");
            LogoutButton.Location = new Point(900, 0);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(155, 124);
            LogoutButton.TabIndex = 3;
            LogoutButton.TextColor = Color.White;
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
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
            customButton2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(300, 0);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(300, 124);
            customButton2.TabIndex = 3;
            customButton2.Text = "Peminjaman";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 124);
            panel2.TabIndex = 0;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 124);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(24);
            panel4.Size = new Size(1771, 967);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(24, 152);
            label3.Name = "label3";
            label3.Size = new Size(893, 71);
            label3.TabIndex = 1;
            label3.Text = "Di Aplikasi Manajemen Perpustakaan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(24, 24);
            label2.Name = "label2";
            label2.Size = new Size(771, 128);
            label2.TabIndex = 0;
            label2.Text = "Selamat Datang";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1771, 1091);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Manajemen Perpustakaan";
            Load += MenuUtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
>>>>>>> main
            ResumeLayout(false);
        }

        #endregion
<<<<<<< HEAD

        private Button button1;
=======
        private CustomControl.CustomButton customButton1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private CustomControl.CustomButton customButton2;
        private Panel panel4;
        private CustomControl.CustomButton LogoutButton;
        private CustomControl.CustomButton customButton3;
        private Label label2;
        private Label label3;
>>>>>>> main
    }
}
