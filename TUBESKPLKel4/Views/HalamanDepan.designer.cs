namespace TUBESKPLKel4
{
    partial class HalamanDepan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanDepan));
            this.main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Riwayat = new System.Windows.Forms.Panel();
            this.Pinjam = new System.Windows.Forms.Panel();
            this.Tambah = new System.Windows.Forms.Panel();
            this.Lihat = new System.Windows.Forms.Panel();
            this.namaLabel = new System.Windows.Forms.Label();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Controls.Add(this.namaLabel);
            this.main.Controls.Add(this.pictureBox1);
            this.main.Controls.Add(this.Riwayat);
            this.main.Controls.Add(this.Pinjam);
            this.main.Controls.Add(this.Tambah);
            this.main.Controls.Add(this.Lihat);
            this.main.Location = new System.Drawing.Point(1, 1);
            this.main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(711, 358);
            this.main.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Riwayat
            // 
            this.Riwayat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Riwayat.BackgroundImage")));
            this.Riwayat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Riwayat.Location = new System.Drawing.Point(511, 204);
            this.Riwayat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Riwayat.Name = "Riwayat";
            this.Riwayat.Size = new System.Drawing.Size(153, 132);
            this.Riwayat.TabIndex = 4;
            this.Riwayat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Riwayat_MouseClick);
            // 
            // Pinjam
            // 
            this.Pinjam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pinjam.BackgroundImage")));
            this.Pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pinjam.Location = new System.Drawing.Point(353, 204);
            this.Pinjam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pinjam.Name = "Pinjam";
            this.Pinjam.Size = new System.Drawing.Size(153, 132);
            this.Pinjam.TabIndex = 3;
            this.Pinjam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pinjam_MouseClick);
            // 
            // Tambah
            // 
            this.Tambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tambah.BackgroundImage")));
            this.Tambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tambah.Location = new System.Drawing.Point(196, 204);
            this.Tambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(153, 132);
            this.Tambah.TabIndex = 2;
            this.Tambah.Paint += new System.Windows.Forms.PaintEventHandler(this.Tambah_Paint);
            this.Tambah.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tambah_MouseClick);
            // 
            // Lihat
            // 
            this.Lihat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lihat.BackgroundImage")));
            this.Lihat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lihat.Location = new System.Drawing.Point(37, 204);
            this.Lihat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lihat.Name = "Lihat";
            this.Lihat.Size = new System.Drawing.Size(153, 132);
            this.Lihat.TabIndex = 1;
            this.Lihat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lihat_MouseClick);
            // 
            // namaLabel
            // 
            this.namaLabel.AutoSize = true;
            this.namaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.namaLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaLabel.Location = new System.Drawing.Point(173, 84);
            this.namaLabel.Name = "namaLabel";
            this.namaLabel.Size = new System.Drawing.Size(93, 33);
            this.namaLabel.TabIndex = 5;
            this.namaLabel.Text = "Nama";
            this.namaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HalamanDepan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HalamanDepan";
            this.Text = "Form1";
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Riwayat;
        private System.Windows.Forms.Panel Pinjam;
        private System.Windows.Forms.Panel Tambah;
        private System.Windows.Forms.Panel Lihat;
        private System.Windows.Forms.Label namaLabel;
    }
}

