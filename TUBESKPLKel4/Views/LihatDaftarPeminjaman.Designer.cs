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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewPeminjaman = new System.Windows.Forms.DataGridView();
            this.btnPerpanjang = new System.Windows.Forms.Button();
            this.btnDikembalikan = new System.Windows.Forms.Button();
            this.KodePeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPeminjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuPeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadlinePengembalian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 74);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.dataGridViewPeminjaman.Location = new System.Drawing.Point(9, 98);
            this.dataGridViewPeminjaman.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPeminjaman.MultiSelect = false;
            this.dataGridViewPeminjaman.Name = "dataGridViewPeminjaman";
            this.dataGridViewPeminjaman.ReadOnly = true;
            this.dataGridViewPeminjaman.RowHeadersWidth = 51;
            this.dataGridViewPeminjaman.RowTemplate.Height = 24;
            this.dataGridViewPeminjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeminjaman.Size = new System.Drawing.Size(780, 223);
            this.dataGridViewPeminjaman.TabIndex = 12;
            this.dataGridViewPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeminjaman_CellClick);
            this.dataGridViewPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeminjaman_CellContentClick);
            // 
            // btnPerpanjang
            // 
            this.btnPerpanjang.Location = new System.Drawing.Point(155, 334);
            this.btnPerpanjang.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerpanjang.Name = "btnPerpanjang";
            this.btnPerpanjang.Size = new System.Drawing.Size(157, 76);
            this.btnPerpanjang.TabIndex = 13;
            this.btnPerpanjang.Text = "Perpanjang";
            this.btnPerpanjang.UseVisualStyleBackColor = true;
            this.btnPerpanjang.Click += new System.EventHandler(this.btnPerpanjang_Click);
            // 
            // btnDikembalikan
            // 
            this.btnDikembalikan.Location = new System.Drawing.Point(487, 334);
            this.btnDikembalikan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDikembalikan.Name = "btnDikembalikan";
            this.btnDikembalikan.Size = new System.Drawing.Size(157, 76);
            this.btnDikembalikan.TabIndex = 16;
            this.btnDikembalikan.Text = "Dikembalikan";
            this.btnDikembalikan.UseVisualStyleBackColor = true;
            this.btnDikembalikan.Click += new System.EventHandler(this.btnDikembalikan_Click);
            // 
            // KodePeminjaman
            // 
            this.KodePeminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KodePeminjaman.HeaderText = "Kode Peminajan";
            this.KodePeminjaman.MinimumWidth = 6;
            this.KodePeminjaman.Name = "KodePeminjaman";
            // 
            // NamaPeminjam
            // 
            this.NamaPeminjam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaPeminjam.HeaderText = "Nama Peminjam";
            this.NamaPeminjam.MinimumWidth = 6;
            this.NamaPeminjam.Name = "NamaPeminjam";
            // 
            // WaktuPeminjaman
            // 
            this.WaktuPeminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WaktuPeminjaman.HeaderText = "Waktu Peminjaman";
            this.WaktuPeminjaman.MinimumWidth = 6;
            this.WaktuPeminjaman.Name = "WaktuPeminjaman";
            // 
            // DeadlinePengembalian
            // 
            this.DeadlinePengembalian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeadlinePengembalian.HeaderText = "Deadline Pengembalian";
            this.DeadlinePengembalian.MinimumWidth = 6;
            this.DeadlinePengembalian.Name = "DeadlinePengembalian";
            // 
            // KodeBuku
            // 
            this.KodeBuku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KodeBuku.HeaderText = "Kode Buku";
            this.KodeBuku.MinimumWidth = 6;
            this.KodeBuku.Name = "KodeBuku";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // LihatDaftarPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 420);
            this.Controls.Add(this.btnDikembalikan);
            this.Controls.Add(this.btnPerpanjang);
            this.Controls.Add(this.dataGridViewPeminjaman);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LihatDaftarPeminjaman";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeminjaman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPeminjaman;
        private System.Windows.Forms.Button btnPerpanjang;
        private System.Windows.Forms.Button btnDikembalikan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPeminjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuPeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadlinePengembalian;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

