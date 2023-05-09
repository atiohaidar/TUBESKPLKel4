using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TUBESKPLKel4
{
    internal class PeminjamanModel
    {
        string format = "yyyy-MM-dd HH:mm:ss";


        public PeminjamanModel()
        {
        }
        public List<Peminjaman> getAllRiwayat()
        {

            List<Peminjaman> all_peminjaman = new List<Peminjaman>();
            KoneksiMySql.connect();
            String query = "select * from peminjaman";
            
            var cmd = new MySqlCommand(query, KoneksiMySql.myConnection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int kode_peminjaman = reader.GetInt32(0);
                String nama_peminjam = reader.GetString(1);
                DateTime waktu_melakukan_peminjaman = reader.GetDateTime(2);
                DateTime deadline_peminjaman = reader.GetDateTime(3);
                String status = reader.GetString(4);
                int kode_buku = reader.GetInt32(5);

                all_peminjaman.Add(new Peminjaman(kode_peminjaman, nama_peminjam, waktu_melakukan_peminjaman, deadline_peminjaman, status, kode_buku));



            }
            KoneksiMySql.close();
            return all_peminjaman;
        }
        public void updateDeadlinePengembalian(int kode_peminjaman, DateTime deadline_peminjaman)
        {

            if (KoneksiMySql.connect())
            {
                string query = string.Format("update peminjaman " +
                    "set deadline_peminjaman='{0}' " +
                    "where kode_peminjaman='{1}';",

                    (object)deadline_peminjaman.ToString(format),
                    (object)kode_peminjaman


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

        public void updateStatusPeminjaman(int kode_peminjaman, String status)
        {
            if (KoneksiMySql.connect())
            {
                string query = string.Format("update peminjaman " +
                    "set status = '{0}' " +
                    "where kode_peminjaman='{1}';",


                    (object)status,
                    (object)kode_peminjaman


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
        public void insertPeminjaman(Peminjaman peminjaman)

        {

            if (KoneksiMySql.connect())
            {
                

                string query = string.Format("insert into peminjaman " +
                    "(nama_peminjam, waktu_melakukan_peminjaman, deadline_peminjaman, status, kode_buku) values('{0}', '{1}', '{2}', '{3}', '{4}')",

                    (object)peminjaman.nama_peminjam,
                    (object)peminjaman.waktu_melakukan_peminjaman.ToString(format),
                    (object)peminjaman.deadline_peminjaman.ToString(format),
                    (object)peminjaman.status,
                    (object)peminjaman.kode_buku




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
                Console.WriteLine(":hai");

            }

        }

    }
}
