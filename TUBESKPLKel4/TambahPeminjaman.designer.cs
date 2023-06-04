namespace TUBESKPLKel4.Views
{
    partial class TambahPeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahPeminjaman));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPengarang = new System.Windows.Forms.Label();
            this.lblNamaBuku = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.txtKodeBuku = new System.Windows.Forms.TextBox();
            this.txtNamaPeminjam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.testPanel1 = new Test.TestPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.testPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.btnPinjam);
            this.panel1.Controls.Add(this.txtKodeBuku);
            this.panel1.Controls.Add(this.txtNamaPeminjam);
            this.panel1.Location = new System.Drawing.Point(11, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 541);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblPengarang);
            this.groupBox1.Controls.Add(this.lblNamaBuku);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(557, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 445);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(230, 310);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(29, 47);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "-";
            // 
            // lblPengarang
            // 
            this.lblPengarang.AutoSize = true;
            this.lblPengarang.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPengarang.Location = new System.Drawing.Point(230, 210);
            this.lblPengarang.Name = "lblPengarang";
            this.lblPengarang.Size = new System.Drawing.Size(29, 47);
            this.lblPengarang.TabIndex = 5;
            this.lblPengarang.Text = "-";
            this.lblPengarang.Click += new System.EventHandler(this.lblPengarang_Click);
            // 
            // lblNamaBuku
            // 
            this.lblNamaBuku.AutoSize = true;
            this.lblNamaBuku.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBuku.Location = new System.Drawing.Point(230, 110);
            this.lblNamaBuku.Name = "lblNamaBuku";
            this.lblNamaBuku.Size = new System.Drawing.Size(29, 47);
            this.lblNamaBuku.TabIndex = 4;
            this.lblNamaBuku.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 47);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 47);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pengarang :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 47);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama Buku : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(100, 10, 100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 62);
            this.label4.TabIndex = 0;
            this.label4.Text = "Keterangan Buku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kode Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama Peminjam";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.Control;
            this.btnBatal.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(305, 393);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(50, 2, 50, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(200, 100);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBatal_MouseClick);
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.SystemColors.Control;
            this.btnPinjam.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinjam.Location = new System.Drawing.Point(53, 393);
            this.btnPinjam.Margin = new System.Windows.Forms.Padding(2);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(200, 100);
            this.btnPinjam.TabIndex = 8;
            this.btnPinjam.Text = "PINJAM";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPinjam_MouseClick);
            // 
            // txtKodeBuku
            // 
            this.txtKodeBuku.BackColor = System.Drawing.SystemColors.Window;
            this.txtKodeBuku.Location = new System.Drawing.Point(25, 290);
            this.txtKodeBuku.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeBuku.Name = "txtKodeBuku";
            this.txtKodeBuku.Size = new System.Drawing.Size(500, 20);
            this.txtKodeBuku.TabIndex = 6;
            this.txtKodeBuku.TextChanged += new System.EventHandler(this.txtKodeBuku_TextChanged);
            // 
            // txtNamaPeminjam
            // 
            this.txtNamaPeminjam.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamaPeminjam.Location = new System.Drawing.Point(25, 150);
            this.txtNamaPeminjam.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaPeminjam.Name = "txtNamaPeminjam";
            this.txtNamaPeminjam.Size = new System.Drawing.Size(500, 20);
            this.txtNamaPeminjam.TabIndex = 1;
            this.txtNamaPeminjam.TextChanged += new System.EventHandler(this.txtNamaPeminjam_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "HOME > Pinjam Buku";
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
            this.testPanel1.Controls.Add(this.label8);
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
            // TambahPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.testPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "TambahPeminjaman";
            this.Text = "TambahPeminjaman";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.testPanel1.ResumeLayout(false);
            this.testPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.TextBox txtKodeBuku;
        private System.Windows.Forms.TextBox txtNamaPeminjam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPengarang;
        private System.Windows.Forms.Label lblNamaBuku;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Test.TestPanel testPanel1;
    }
}