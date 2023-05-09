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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.txtKodeBuku = new System.Windows.Forms.TextBox();
            this.txtNamaPeminjam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNamaBuku = new System.Windows.Forms.Label();
            this.lblPengarang = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(120, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 315);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kode Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama Peminjam";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DarkGray;
            this.btnBatal.Location = new System.Drawing.Point(128, 210);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(91, 19);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBatal_MouseClick);
            // 
            // btnPinjam
            // 
            this.btnPinjam.BackColor = System.Drawing.Color.DarkGray;
            this.btnPinjam.Location = new System.Drawing.Point(23, 210);
            this.btnPinjam.Margin = new System.Windows.Forms.Padding(2);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(91, 19);
            this.btnPinjam.TabIndex = 8;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.UseVisualStyleBackColor = false;
            this.btnPinjam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPinjam_MouseClick);
            // 
            // txtKodeBuku
            // 
            this.txtKodeBuku.BackColor = System.Drawing.Color.DarkGray;
            this.txtKodeBuku.Location = new System.Drawing.Point(22, 162);
            this.txtKodeBuku.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeBuku.Name = "txtKodeBuku";
            this.txtKodeBuku.Size = new System.Drawing.Size(157, 20);
            this.txtKodeBuku.TabIndex = 6;
            this.txtKodeBuku.TextChanged += new System.EventHandler(this.txtKodeBuku_TextChanged);
            // 
            // txtNamaPeminjam
            // 
            this.txtNamaPeminjam.BackColor = System.Drawing.Color.DarkGray;
            this.txtNamaPeminjam.Location = new System.Drawing.Point(22, 115);
            this.txtNamaPeminjam.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaPeminjam.Name = "txtNamaPeminjam";
            this.txtNamaPeminjam.Size = new System.Drawing.Size(157, 20);
            this.txtNamaPeminjam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pinjam Buku";
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
            this.groupBox1.Location = new System.Drawing.Point(286, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 187);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Keterangan Buku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama Buku: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pengarang:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status:";
            // 
            // lblNamaBuku
            // 
            this.lblNamaBuku.AutoSize = true;
            this.lblNamaBuku.Location = new System.Drawing.Point(81, 46);
            this.lblNamaBuku.Name = "lblNamaBuku";
            this.lblNamaBuku.Size = new System.Drawing.Size(10, 13);
            this.lblNamaBuku.TabIndex = 4;
            this.lblNamaBuku.Text = "-";
            // 
            // lblPengarang
            // 
            this.lblPengarang.AutoSize = true;
            this.lblPengarang.Location = new System.Drawing.Point(81, 69);
            this.lblPengarang.Name = "lblPengarang";
            this.lblPengarang.Size = new System.Drawing.Size(10, 13);
            this.lblPengarang.TabIndex = 5;
            this.lblPengarang.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(81, 94);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "-";
            // 
            // TambahPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TambahPeminjaman";
            this.Text = "TambahPeminjaman";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPengarang;
        private System.Windows.Forms.Label lblNamaBuku;
        private System.Windows.Forms.Label lblStatus;
    }
}