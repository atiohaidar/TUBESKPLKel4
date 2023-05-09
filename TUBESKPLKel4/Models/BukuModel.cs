using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TUBESKPLKel4
{
    internal class BukuModel
    {

        public BukuModel()
        {
        }
        public List<Buku> getAllBuku()
        {
            List<Buku> all_buku = new List<Buku>();
            KoneksiMySql.connect();
            String query = "select * from buku";
            var cmd = new MySqlCommand(query, KoneksiMySql.myConnection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int kode = reader.GetInt32(0);
                String nama = reader.GetString(1);
                String pengarang = reader.GetString(2);
                int kuantitas = reader.GetInt32(3);
                all_buku.Add(new Buku(kode, nama, pengarang, kuantitas));



            }
            KoneksiMySql.close();
            return all_buku;
        }
        public void updateKuantitasBuku(int kode_buku, int kuantitas)
        {

            if (KoneksiMySql.connect())
            {
                string query = string.Format("update buku " +
                    "set  kuantitas='{0}' " +
                    "where kode='{1}'",

                    (object)kuantitas,
                    (object)kode_buku


                    );
                try
                {

                    var cmd = new MySqlCommand(query, KoneksiMySql.myConnection);
                    var reader = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                KoneksiMySql.close();
            }

        }
        public Buku getBukuByKode(int kode)
        {
            Buku buku;
            KoneksiMySql.connect();
            String query = String.Format("select * from buku where kode = '{0}'", (object)kode);
            var cmd = new MySqlCommand(query, KoneksiMySql.myConnection);
            var reader = cmd.ExecuteReader();
            reader.Read();

            String nama = reader.GetString(1);
            String pengarang = reader.GetString(2);
            int kuantitas = reader.GetInt32(3);
            buku = new Buku(kode, nama, pengarang, kuantitas);




            KoneksiMySql.close();
            return buku;

        }

        public void updateBukuByKode(Buku buku)
        {
            if (KoneksiMySql.connect())
            {
                string query = string.Format("update buku " +
                    "set nama = '{0}', pengarang = '{1}',  kuantitas='{2}' " +
                    "where kode={3} ",

                    (object)buku.nama,
                    (object)buku.pengarang,
                    (object)buku.kuantitas,
                    (int)buku.kode


                    );
                try
                {

                    var cmd = new MySqlCommand(query, KoneksiMySql.myConnection);
                    var reader = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                KoneksiMySql.close();
            }

        }
        public void insertBuku(Buku buku)

        {
            if (KoneksiMySql.connect())
            {
                string query = string.Format("insert into buku " +
                    "(nama, pengarang, kuantitas) values('{0}', '{1}', '{2}')",

                    (object)buku.nama,
                    (object)buku.pengarang,
                    (object)buku.kuantitas


                    );
                try
                {

                    var cmd = new MySqlCommand(query, KoneksiMySql.myConnection);
                    var reader = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                KoneksiMySql.close();
            }

        }
        public void deleteBukuByKode(int kode)
        {
            if (KoneksiMySql.connect())
            {
                string query = string.Format("delete from buku where kode = '{0}'",
                    

                    (object)kode


                    );
                try
                {

                    var cmd = new MySqlCommand(query, KoneksiMySql.myConnection);
                    var reader = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                KoneksiMySql.close();
            }
        }
    }
}
