using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TUBESKPLKel4.Config;
using TUBESKPLKel4.Model;

namespace TUBESKPLKel4.Repository
{
    internal class PeminjamanRepository
    {
        string format = "yyyy-MM-dd HH:mm:ss";
        private MySqlConnection conn;

        public PeminjamanRepository()
        {
            conn =  KoneksiMySql.getConnection();
        }
        public List<Peminjaman> getAllRiwayat()
        {
            conn.Open();

            try
            {
                List<Peminjaman> all_peminjaman = new List<Peminjaman>();
                String query = "select * from peminjaman";

                var cmd = new MySqlCommand(query, conn);
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
                return all_peminjaman;
            } catch (Exception ex) { throw ex; } finally { conn.Close(); }
            
        }

        public Peminjaman getPeminjamanByKode(int kode)
        {
            this.conn.Open();
            try
            {
                Peminjaman peminjaman = null;
                String query = string.Format("select * from peminjaman where kode_peminjaman = '{0}'", (object)kode);
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int kode_peminjaman = reader.GetInt32(0);
                    String nama_peminjam = reader.GetString(1);
                    DateTime waktu_melakukan_peminjaman = reader.GetDateTime(2);
                    DateTime deadline_peminjaman = reader.GetDateTime(3);
                    String status = reader.GetString(4);
                    int kode_buku = reader.GetInt32(5);
                    peminjaman = new Peminjaman(kode_peminjaman, nama_peminjam, waktu_melakukan_peminjaman, deadline_peminjaman, status, kode_buku);
                  
                }
                return peminjaman;
            } catch (Exception ex) { throw ex; } finally { conn.Close(); }
        }
        public void updateDeadlinePengembalian(int kode_peminjaman, DateTime deadline_peminjaman)
        {
            conn.Open();
            try
            {
                string query = string.Format("update peminjaman " +
                    "set deadline_peminjaman='{0}' " +
                    "where kode_peminjaman='{1}';",

                    (object)deadline_peminjaman.ToString(format),
                    (object)kode_peminjaman


                );

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteNonQuery();
            } catch (Exception ex) { throw ex; } finally { conn.Close(); }

        }

        public void updateStatusPeminjaman(int kode_peminjaman, String status)
        {
            conn.Open();
            try
            {
                string query = string.Format("update peminjaman " +
                    "set status = '{0}' " +
                    "where kode_peminjaman='{1}';",


                    (object)status,
                    (object)kode_peminjaman


                );

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteNonQuery();
            } catch(Exception ex) { throw ex; }
            finally { conn.Close(); }

        }
        public void insertPeminjaman(Peminjaman peminjaman)

        {

            conn.Open();
            try
            {
                string query = string.Format("insert into peminjaman " +
                    "(nama_peminjam, waktu_melakukan_peminjaman, deadline_peminjaman, status, kode_buku) values('{0}', '{1}', '{2}', '{3}', '{4}')",

                    (object)peminjaman.nama_peminjam,
                    (object)peminjaman.waktu_melakukan_peminjaman.ToString(format),
                    (object)peminjaman.deadline_peminjaman.ToString(format),
                    (object)peminjaman.status,
                    (object)peminjaman.kode_buku

                    );

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteNonQuery();
            } catch (Exception ex) { throw ex; } finally { conn.Close(); }

        }

    }
}
