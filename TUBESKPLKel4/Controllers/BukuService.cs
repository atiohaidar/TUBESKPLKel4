using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TUBESKPLKel4
{
    // udah terverivikasi aman, (klo inputannya bener)
    internal class BukuService
    {
        public static BukuModel bukuModel;
        public BukuService() { 
            bukuModel = new BukuModel();
        
        }
        public List<Buku> showAllBuku()
        {
            return bukuModel.getAllBuku();
        }
        public void editBuku(int kode, String nama, String pengarang, int kuantitas)
        {
            Buku buku_diedit = new Buku(kode, nama, pengarang, kuantitas);
            Console.WriteLine("halo");
            bukuModel.updateBukuByKode(buku_diedit);
        }
        public void addBuku(String nama, String pengarang, int kuantitas)
        {
            Buku buku = new Buku(0, nama, pengarang, kuantitas);
            bukuModel.insertBuku(buku);
        }
        public void deleteBuku(int kode)
        {
            bukuModel.deleteBukuByKode(kode);

        }
        
    }
}
