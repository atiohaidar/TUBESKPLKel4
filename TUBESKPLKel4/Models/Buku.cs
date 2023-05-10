using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBESKPLKel4.Model
{
    internal class Buku
    {
        public int kode;
        public String nama;
        public String pengarang;
        public int kuantitas;
        public Buku(int kode, string nama, string pengarang, int kuantitas)
        {
            this.kode = kode;
            this.nama = nama;
            this.pengarang = pengarang;
            this.kuantitas = kuantitas;
        }
    }
}
