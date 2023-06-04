using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBESKPLKel4
{
    public partial class LihatDaftarBuku : Form
    {
        BukuService bukuService;
        public LihatDaftarBuku()
        {
            bukuService = new BukuService();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int kode = 0;
            for (int i = 0; i < dataGridViewBuku.Rows.Count; i += 1)
            {
                if (dataGridViewBuku.Rows[i].Selected)
                {
                    kode = int.Parse(dataGridViewBuku.Rows[i].Cells[0].Value.ToString()); // buat ngambil id



                }
            }
            bukuService.deleteBuku(kode);
            MessageBox.Show("Berhasil terhapus", "konfirmasi");
            refreshDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int kode = 0;
            for (int i = 0; i < dataGridViewBuku.Rows.Count; i += 1)
            {
                if (dataGridViewBuku.Rows[i].Selected)
                {
                    kode = int.Parse(dataGridViewBuku.Rows[i].Cells[0].Value.ToString()); // buat ngambil id
                 
                   

                }
            }
            bukuService.editBuku(kode, txtJudulBuku.Text, txtPengarang.Text, int.Parse(numKuantitas.Value.ToString()));
            MessageBox.Show("Berhasil Teredit", "konfirmasi");
            refreshDataGridView();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LihatDaftarBuku_Load(object sender, EventArgs e)
        {
            refreshDataGridView();

        }
        private void refreshDataGridView()
        {
            dataGridViewBuku.Rows.Clear();
            foreach (Buku buku in bukuService.showAllBuku())
            {
                string[] newRow = { "", "", "", "" };
                newRow[0] = buku.kode.ToString();
                newRow[1] = buku.nama;
                newRow[2] = buku.pengarang;
                newRow[3] = buku.kuantitas.ToString();
                dataGridViewBuku.Rows.Add(newRow);



            }
        }

        private void dataGridViewBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
            for (int i = 0; i < dataGridViewBuku.Rows.Count; i += 1)
            {
                if (dataGridViewBuku.Rows[i].Selected)
                {
                    txtJudulBuku.Text = dataGridViewBuku.Rows[i].Cells[1].Value.ToString(); // buat ngambil id
                    txtPengarang.Text = dataGridViewBuku.Rows[i].Cells[2].Value.ToString(); // buat ngambil id
                    numKuantitas.Value = int.Parse(dataGridViewBuku.Rows[i].Cells[3].Value.ToString()); // buat ngambil id

                }
            }
        }

        private void testPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
