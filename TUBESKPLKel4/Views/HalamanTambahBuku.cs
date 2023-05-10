using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUBESKPLKel4.Service;
using TUBESKPLKel4.Model;

namespace TUBESKPLKel4
{
    public partial class HalamanTambahBuku : Form
    {
        BukuService bukuService;
        public HalamanTambahBuku()
        {
            this.bukuService= new BukuService(new Repository.BukuRepository());
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
               
                bukuService.addBuku(txtJudul.Text, txtPengarang.Text, (int)numKuantitas.Value);
                MessageBox.Show("tersimpan ya ges", "informasi");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }


        }
    }
}
