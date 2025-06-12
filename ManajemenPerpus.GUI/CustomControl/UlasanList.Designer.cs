namespace ManajemenPerpus.GUI.CustomControl
{
    partial class UlasanList
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
            IdUlasanLabel = new Label();
            label2 = new Label();
            IsiUlasanLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // IdUlasanLabel
            // 
            IdUlasanLabel.AutoSize = true;
            IdUlasanLabel.Location = new Point(3, 21);
            IdUlasanLabel.Name = "IdUlasanLabel";
            IdUlasanLabel.Size = new Size(99, 15);
            IdUlasanLabel.TabIndex = 2;
            IdUlasanLabel.Text = "Id Ulasan: ULS001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Ulasan";
            // 
            // IsiUlasanLabel
            // 
            IsiUlasanLabel.AutoSize = true;
            IsiUlasanLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsiUlasanLabel.Location = new Point(3, 36);
            IsiUlasanLabel.MaximumSize = new Size(700, 0);
            IsiUlasanLabel.Name = "IsiUlasanLabel";
            IsiUlasanLabel.Size = new Size(71, 20);
            IsiUlasanLabel.TabIndex = 3;
            IsiUlasanLabel.Text = "Isi Ulasan";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(IdUlasanLabel);
            flowLayoutPanel1.Controls.Add(IsiUlasanLabel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(758, 160);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            // 
            // UlasanList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "UlasanList";
            Size = new Size(758, 160);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IdUlasanLabel;
        private Label label2;
        private Label IsiUlasanLabel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
