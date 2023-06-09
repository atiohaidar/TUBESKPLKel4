﻿using System;
using System.Windows.Forms;
using TUBESKPLKel4.Service;
using TUBESKPLKel4.Model;

namespace TUBESKPLKel4
{
    public partial class LihatDaftarPeminjaman : Form
    {
        PeminjamanService peminjamanService;
        public LihatDaftarPeminjaman()
        {
            this.peminjamanService = new PeminjamanService();
            InitializeComponent();
            refreshDataGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnPerpanjang_Click(object sender, EventArgs e)
        {
            int kode_peminjaman = 0;
            DateTime deadline = new DateTime();
            for (int i = 0; i < dataGridViewPeminjaman.Rows.Count; i += 1)
            {
                if (dataGridViewPeminjaman.Rows[i].Selected)
                {
                    kode_peminjaman = int.Parse(dataGridViewPeminjaman.Rows[i].Cells[0].Value.ToString()); // buat ngambil id
                    deadline = DateTime.Parse(dataGridViewPeminjaman.Rows[i].Cells[3].Value.ToString());


                }
            }
            try
            {

                peminjamanService.perpanjangPeminjaman(kode_peminjaman, deadline);
                MessageBox.Show("berhasil diperpanjang", "konfirmasi");
                refreshDataGridView();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btnDikembalikan_Click(object sender, EventArgs e)
        {
            int kode_peminjaman = 0;
            int kode_buku = 0;
            for (int i = 0; i < dataGridViewPeminjaman.Rows.Count; i += 1)
            {
                if (dataGridViewPeminjaman.Rows[i].Selected)
                {
                    kode_peminjaman = int.Parse(dataGridViewPeminjaman.Rows[i].Cells[0].Value.ToString()); // buat ngambil id
                    kode_buku = int.Parse(dataGridViewPeminjaman.Rows[i].Cells[4].Value.ToString());



                }
            }

            peminjamanService.pengembalian(kode_peminjaman, kode_buku);
            MessageBox.Show("berhasil dikembalikan", "konfirmasi");
            refreshDataGridView();
        }

        private void dataGridViewPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void refreshDataGridView()
        {
            dataGridViewPeminjaman.Rows.Clear();
            foreach (Peminjaman peminjaman in peminjamanService.showAllRiwayat())
            {
                string[] newRow = { "", "", "", "", "", "" };
                newRow[0] = peminjaman.kode_peminjaman.ToString();
                newRow[1] = peminjaman.nama_peminjam;
                newRow[2] = peminjaman.waktu_melakukan_peminjaman.ToString();
                newRow[3] = peminjaman.deadline_peminjaman.ToString();
                newRow[4] = peminjaman.kode_buku.ToString();
                newRow[5] = peminjaman.status.ToString();
                dataGridViewPeminjaman.Rows.Add(newRow);



            }
        }
    }
}
