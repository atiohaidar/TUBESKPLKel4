using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBESKPLKel4
{
    public partial class HalamanDepan : Form
    {
        public HalamanDepan()
        {
            InitializeComponent();
        }

        private void Lihat_MouseClick(object sender, MouseEventArgs e)
        {
            new LihatDaftarBuku().Show();

        }

        private void Tambah_MouseClick(object sender, MouseEventArgs e)
        {
            new HalamanTambahBuku().Show();
        }

        private void Pinjam_MouseClick(object sender, MouseEventArgs e)
        {

            PeminjamanService peminjamanService = new PeminjamanService();

            List<String> a = peminjamanService.checkBukuyngAkanDipinjam(4);
            MessageBox.Show(a[1]);
        }

        private void Riwayat_MouseClick(object sender, MouseEventArgs e)
        {
            new LihatDaftarPeminjaman().Show();
        }

        private void Tambah_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
