using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBESKPLKel4
{
    internal class PeminjamanService
    {
        public PeminjamanModel peminjamanModel;
        public BukuModel bukuModel;

        public PeminjamanService()
        {
            bukuModel = new BukuModel();
            peminjamanModel = new PeminjamanModel();
        }
        public List<Peminjaman> showAllRiwayat()
        {
            return peminjamanModel.getAllRiwayat();

        }
public void createPeminjaman(String nama, int kode_buku)
        {
            DateTime sekarang = DateTime.Now;
            Buku yangdipinjem = bukuModel.getBukuByKode(kode_buku);
            bukuModel.updateKuantitasBuku(kode_buku, yangdipinjem.kuantitas - 1);
            Peminjaman new_peminjaman = new Peminjaman(0, nama, sekarang, sekarang.AddDays(10), "meminjam", kode_buku);
            peminjamanModel.insertPeminjaman(new_peminjaman);

        }
public void perpanjangPeminjaman(int kode_peminjaman,DateTime deadline_peminjaman)
        {
            peminjamanModel.updateDeadlinePengembalian(kode_peminjaman, deadline_peminjaman.AddDays(90));

        }
public void pengembalian(int kode_peminjaman, int kode_buku)
        {
            Buku yangdipinjem =bukuModel.getBukuByKode(kode_buku);
            bukuModel.updateKuantitasBuku(kode_buku, yangdipinjem.kuantitas + 1);
            peminjamanModel.updateStatusPeminjaman(kode_peminjaman, "selesai");
        }
    public List<String> checkBukuyngAkanDipinjam(int kode_buku)
    {
        Buku yang_akan_dipinjam;
        List<String> result = new List<String>();
        if (kode_buku == null)
        {
            yang_akan_dipinjam = new Buku(0, "-", "-", 0);
        }
        yang_akan_dipinjam = bukuModel.getBukuByKode(kode_buku);

        result.Add(yang_akan_dipinjam.nama);
        result.Add(yang_akan_dipinjam.pengarang);
        result.Add(yang_akan_dipinjam.kuantitas > 0 ? "tersedia": "tidak tersedia");



        return result;
    }
        
    }
}
