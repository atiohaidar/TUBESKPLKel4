using System;
using System.Windows.Forms;

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
            peminjamanService.perpanjangPeminjaman(kode_peminjaman, deadline);
            MessageBox.Show("berhasil diperpanjang", "konfirmasi");
        }

        private void btnDikembalikan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("berhasil dikembalikan", "konfirmasi");
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
