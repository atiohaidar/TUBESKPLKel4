using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBESKPLKel4.Model
{
    internal class Peminjaman
    {
        public int kode_peminjaman;
        public String nama_peminjam;
        public DateTime waktu_melakukan_peminjaman;
        public DateTime deadline_peminjaman;
        public String status;
        public int kode_buku;
        public Peminjaman(int kode_peminjaman, string nama_peminjam, DateTime waktu_melakukan_peminjaman, DateTime deadline_peminjaman, string status, int kode_buku)
        {
            this.kode_peminjaman = kode_peminjaman;
            this.nama_peminjam = nama_peminjam;
            this.waktu_melakukan_peminjaman = waktu_melakukan_peminjaman;
            this.deadline_peminjaman = deadline_peminjaman;
            this.status = status;
            this.kode_buku = kode_buku;
        }
    }
}
