namespace ManajemenPerpus.GUI
{
    partial class LaporanStatisticGui
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 137);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 3;
            label1.Text = "Bulan";
            //label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 245);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 4;
            label2.Text = "Tahun";
            // 
            // button1
            // 
            button1.Location = new Point(53, 35);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 31);
            textBox1.TabIndex = 6;
           // textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 31);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(53, 326);
            button2.Name = "button2";
            button2.Size = new Size(215, 34);
            button2.TabIndex = 8;
            button2.Text = "Tampilkan Statistik";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(186, 112);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 9;
            label3.Text = "Masukan Bulan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(186, 220);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 10;
            label4.Text = "Masukan Tahun\r\n";
            // 
            // LaporanStatisticGui
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LaporanStatisticGui";
            Text = "LaporanStatisticGui";
            //Load += LaporanStatisticGui_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}