using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUBESKPLKel4.Views;

namespace TUBESKPLKel4
{
    public partial class HalamanDepan : Form
    {

       );
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

            new TambahPeminjaman().Show();
        }

        private void Riwayat_MouseClick(object sender, MouseEventArgs e)
        {
            new LihatDaftarPeminjaman().Show();
        }

        private void Tambah_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HalamanDepan_Load(object sender, EventArgs e)
        {

        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
