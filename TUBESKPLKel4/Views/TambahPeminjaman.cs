﻿using System;
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

namespace TUBESKPLKel4.Views
{
    public partial class TambahPeminjaman : Form
    {

        PeminjamanService peminjamanService;
    

            public TambahPeminjaman()
        {
            InitializeComponent();
            this.peminjamanService = new PeminjamanService();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKodeBuku_TextChanged(object sender, EventArgs e)
        {
            List<String> buku = peminjamanService.checkBukuyngAkanDipinjam(int.Parse(txtKodeBuku.Text));
            if (buku != null)
            {

                lblNamaBuku.Text = buku[0];
                lblPengarang.Text = buku[1];
                lblStatus.Text = buku[2];
            }
            else
            {
                lblNamaBuku.Text = "-";
                lblPengarang.Text = "-";
                lblStatus.Text = "-";

            }
        }

        private void btnPinjam_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                peminjamanService.createPeminjaman(txtNamaPeminjam.Text.ToString(), int.Parse(txtKodeBuku.Text.ToString()));
                MessageBox.Show("tersimpan ya ges", "informasi");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            } finally
            {
                this.Close();
            }
        }

        private void btnBatal_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
