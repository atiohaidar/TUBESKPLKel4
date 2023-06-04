namespace TUBESKPLKel4
{
    partial class LihatDaftarPeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatDaftarPeminjaman));
            this.dataGridViewPeminjaman = new System.Windows.Forms.DataGridView();
            this.KodePeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPeminjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuPeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadlinePengembalian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPerpanjang = new System.Windows.Forms.Button();
            this.btnDikembalikan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.testPanel1 = new Test.TestPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.testPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPeminjaman
            // 
            this.dataGridViewPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeminjaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodePeminjaman,
            this.NamaPeminjam,
            this.WaktuPeminjaman,
            this.DeadlinePengembalian,
            this.KodeBuku,
            this.Status});
            this.dataGridViewPeminjaman.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewPeminjaman.MultiSelect = false;
            this.dataGridViewPeminjaman.Name = "dataGridViewPeminjaman";
            this.dataGridViewPeminjaman.ReadOnly = true;
            this.dataGridViewPeminjaman.RowHeadersWidth = 51;
            this.dataGridViewPeminjaman.RowTemplate.Height = 24;
            this.dataGridViewPeminjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeminjaman.Size = new System.Drawing.Size(1060, 401);
            this.dataGridViewPeminjaman.TabIndex = 12;
            this.dataGridViewPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeminjaman_CellClick);
            this.dataGridViewPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeminjaman_CellContentClick);
            // 
            // KodePeminjaman
            // 
            this.KodePeminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KodePeminjaman.HeaderText = "Kode Peminajan";
            this.KodePeminjaman.MinimumWidth = 6;
            this.KodePeminjaman.Name = "KodePeminjaman";
            this.KodePeminjaman.ReadOnly = true;
            // 
            // NamaPeminjam
            // 
            this.NamaPeminjam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaPeminjam.HeaderText = "Nama Peminjam";
            this.NamaPeminjam.MinimumWidth = 6;
            this.NamaPeminjam.Name = "NamaPeminjam";
            this.NamaPeminjam.ReadOnly = true;
            // 
            // WaktuPeminjaman
            // 
            this.WaktuPeminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WaktuPeminjaman.HeaderText = "Waktu Peminjaman";
            this.WaktuPeminjaman.MinimumWidth = 6;
            this.WaktuPeminjaman.Name = "WaktuPeminjaman";
            this.WaktuPeminjaman.ReadOnly = true;
            // 
            // DeadlinePengembalian
            // 
            this.DeadlinePengembalian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeadlinePengembalian.HeaderText = "Deadline Pengembalian";
            this.DeadlinePengembalian.MinimumWidth = 6;
            this.DeadlinePengembalian.Name = "DeadlinePengembalian";
            this.DeadlinePengembalian.ReadOnly = true;
            // 
            // KodeBuku
            // 
            this.KodeBuku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KodeBuku.HeaderText = "Kode Buku";
            this.KodeBuku.MinimumWidth = 6;
            this.KodeBuku.Name = "KodeBuku";
            this.KodeBuku.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnPerpanjang
            // 
            this.btnPerpanjang.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerpanjang.Location = new System.Drawing.Point(210, 540);
            this.btnPerpanjang.Margin = new System.Windows.Forms.Padding(200, 2, 2, 2);
            this.btnPerpanjang.Name = "btnPerpanjang";
            this.btnPerpanjang.Size = new System.Drawing.Size(300, 100);
            this.btnPerpanjang.TabIndex = 13;
            this.btnPerpanjang.Text = "PERPANJANG";
            this.btnPerpanjang.UseVisualStyleBackColor = true;
            this.btnPerpanjang.Click += new System.EventHandler(this.btnPerpanjang_Click);
            // 
            // btnDikembalikan
            // 
            this.btnDikembalikan.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDikembalikan.Location = new System.Drawing.Point(575, 540);
            this.btnDikembalikan.Margin = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.btnDikembalikan.Name = "btnDikembalikan";
            this.btnDikembalikan.Size = new System.Drawing.Size(300, 100);
            this.btnDikembalikan.TabIndex = 16;
            this.btnDikembalikan.Text = "SELESAI";
            this.btnDikembalikan.UseVisualStyleBackColor = true;
            this.btnDikembalikan.Click += new System.EventHandler(this.btnDikembalikan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "HOME > Riwayat Peminjaman";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(960, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // testPanel1
            // 
            this.testPanel1.BackColor = System.Drawing.Color.White;
            this.testPanel1.BoerderRadius = 50;
            this.testPanel1.Controls.Add(this.label4);
            this.testPanel1.Controls.Add(this.pictureBox2);
            this.testPanel1.ForeColor = System.Drawing.Color.Black;
            this.testPanel1.GradientAngle = 90F;
            this.testPanel1.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.testPanel1.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.testPanel1.Location = new System.Drawing.Point(0, -25);
            this.testPanel1.Name = "testPanel1";
            this.testPanel1.Size = new System.Drawing.Size(1086, 129);
            this.testPanel1.TabIndex = 17;
            // 
            // LihatDaftarPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.testPanel1);
            this.Controls.Add(this.btnDikembalikan);
            this.Controls.Add(this.btnPerpanjang);
            this.Controls.Add(this.dataGridViewPeminjaman);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LihatDaftarPeminjaman";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.testPanel1.ResumeLayout(false);
            this.testPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPeminjaman;
        private System.Windows.Forms.Button btnPerpanjang;
        private System.Windows.Forms.Button btnDikembalikan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPeminjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuPeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadlinePengembalian;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Test.TestPanel testPanel1;
    }
}

