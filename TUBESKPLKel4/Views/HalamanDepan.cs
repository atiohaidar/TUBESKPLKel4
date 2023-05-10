using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUBESKPLKel4.Models;
using TUBESKPLKel4.Services;
using TUBESKPLKel4.Views;

namespace TUBESKPLKel4
{
    public partial class HalamanDepan : Form
    {

        private LoginService loginService;
        public HalamanDepan()
        {
            this.loginService = new LoginService(new Repositories.UserRepository());
            InitializeComponent();
            namaLabel.Text = ActiveUser.user.name;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
