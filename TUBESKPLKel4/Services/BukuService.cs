using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUBESKPLKel4.Repository;
using TUBESKPLKel4.Model;

namespace TUBESKPLKel4.Service
{
    // udah terverivikasi aman, (klo inputannya bener)
    public class BukuService
    {
        public static BukuRepository bukuRepo;
        public BukuService(BukuRepository bRepo) { 
            bukuRepo = bRepo;
        }
        public List<Buku> showAllBuku()
        {
            return bukuRepo.getAllBuku();
        }

        public Buku getBukuByKode(int kode)
        {
            return bukuRepo.getBukuByKode(kode);
        }
        public void editBuku(int kode, String nama, String pengarang, int kuantitas)
        {
            if (nama == "")
            {
                throw new Exception("Nama Buku Tidak Boleh Kosong");
            }
            else if (pengarang == "")
            {
                throw new Exception("Pengarang Tidak Boleh Kosong");
            }

            Buku buku_diedit = new Buku(kode, nama, pengarang, kuantitas);
            bukuRepo.updateBukuByKode(buku_diedit);
        }
        public void addBuku(String nama, String pengarang, int kuantitas)
        {
            if (nama == "")
            {
                throw new Exception("Nama Buku Tidak Boleh Kosong");
            } else if (pengarang == "")
            {
                throw new Exception("Pengarang Tidak Boleh Kosong");
            }

            Buku buku = new Buku(0, nama, pengarang, kuantitas);
            bukuRepo.insertBuku(buku);
        }
        public void deleteBuku(int kode)
        {
            bukuRepo.deleteBukuByKode(kode);
        }
        
    }
}
