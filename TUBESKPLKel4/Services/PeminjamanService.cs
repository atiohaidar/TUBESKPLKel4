using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUBESKPLKel4.Repository;
using TUBESKPLKel4.Model;

namespace TUBESKPLKel4.Service
{
    public class PeminjamanService
    {
        public PeminjamanRepository peminjamanRepository;
        public BukuRepository bukuRepository;

        public PeminjamanService()
        {
            bukuRepository = new BukuRepository();
            peminjamanRepository = new PeminjamanRepository();
        }
        public List<Peminjaman> showAllRiwayat()
        {
            try
            {
                return peminjamanRepository.getAllRiwayat();
            } catch (Exception ex) { throw ex; }
        }
        public void createPeminjaman(String nama, int kode_buku)
        {
            try
            {
                DateTime sekarang = DateTime.Now;
                Buku yangdipinjem = bukuRepository.getBukuByKode(kode_buku);
                if (yangdipinjem == null || yangdipinjem.kuantitas == 0)
                {
                    throw new Exception("Buku Tidak Tersedia");
                }

                bukuRepository.updateKuantitasBuku(kode_buku, yangdipinjem.kuantitas - 1);
                Peminjaman new_peminjaman = new Peminjaman(0, nama, sekarang, sekarang.AddDays(10), "meminjam", kode_buku);
                peminjamanRepository.insertPeminjaman(new_peminjaman);
            } catch (Exception ex) { throw ex; }

        }
        public void perpanjangPeminjaman(int kode_peminjaman, DateTime deadline_peminjaman)
        {
            try
            {
                Peminjaman peminjaman = peminjamanRepository.getPeminjamanByKode(kode_peminjaman);
                if (peminjaman.status != "selesai")
                {
                    peminjamanRepository.updateDeadlinePengembalian(kode_peminjaman, deadline_peminjaman.AddDays(90));
                } else
                {
                    throw new Exception("Peminjaman sudah selesai");
                }
            } catch (Exception ex) { throw ex; }

        }
        public void pengembalian(int kode_peminjaman, int kode_buku)
        {
            try
            {
                Buku yangdipinjem = bukuRepository.getBukuByKode(kode_buku);
                bukuRepository.updateKuantitasBuku(kode_buku, yangdipinjem.kuantitas + 1);
                peminjamanRepository.updateStatusPeminjaman(kode_peminjaman, "selesai");
            } catch (Exception ex) { throw ex; }
        }
        public List<String> checkBukuyngAkanDipinjam(int kode_buku)
        {
            try {

                Buku yang_akan_dipinjam;
                List<String> result = new List<String>();

                yang_akan_dipinjam = bukuRepository.getBukuByKode(kode_buku);

                if (yang_akan_dipinjam != null)
                {
                    result.Add(yang_akan_dipinjam.nama);
                    result.Add(yang_akan_dipinjam.pengarang);
                    result.Add(yang_akan_dipinjam.kuantitas > 0 ? "tersedia" : "tidak tersedia");
                } else
                {
                    result.Add("-");
                    result.Add("-");
                    result.Add("tidak tersedia");
                }


                return result;
            } catch (Exception ex) { throw ex; }
        }
    }
}
