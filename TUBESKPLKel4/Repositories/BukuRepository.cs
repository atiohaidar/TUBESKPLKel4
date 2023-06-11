using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TUBESKPLKel4.Config;
using TUBESKPLKel4.Model;

namespace TUBESKPLKel4.Repository
{
    public class BukuRepository
    {

        private MySqlConnection conn;

        public BukuRepository()
        {
            this.conn = KoneksiMySql.getConnection();
        }

        public List<Buku> getAllBuku()
        {
            conn.Open();
            try
            {
                List<Buku> all_buku = new List<Buku>();
                String query = "select * from buku";
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int kode = reader.GetInt32(0);
                    String nama = reader.GetString(1);
                    String pengarang = reader.GetString(2);
                    int kuantitas = reader.GetInt32(3);
                    all_buku.Add(new Buku(kode, nama, pengarang, kuantitas));
                }
                return all_buku;
            } catch (Exception ex)
            {
                throw ex;
            } finally { conn.Close(); }
            
        }
        public void updateKuantitasBuku(int kode_buku, int kuantitas)
        {
            conn.Open();
            try
            {
                string query = string.Format("update buku " +
                    "set  kuantitas='{0}' " +
                    "where kode='{1}'",

                    (object)kuantitas,
                    (object)kode_buku


                );
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteNonQuery();
            } catch (Exception ex) { 
                throw ex; 
            } finally { conn.Close(); }

        }
        public Buku getBukuByKode(int kode)
        {
            conn.Open();
            try
            {
                Buku buku = null;

                String query = String.Format("select * from buku where kode = '{0}'", (object)kode);
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    String nama = reader.GetString(1);
                    String pengarang = reader.GetString(2);
                    int kuantitas = reader.GetInt32(3);
                    buku = new Buku(kode, nama, pengarang, kuantitas);
                }


                return buku;
            } catch (Exception ex) { throw ex; } finally { conn.Close(); }
            

        }

        public void updateBukuByKode(Buku buku)
        {
            conn.Open();
            try
            {
                string query = string.Format("update buku " +
                    "set nama = '{0}', pengarang = '{1}',  kuantitas='{2}' " +
                    "where kode={3} ",

                    (object)buku.nama,
                    (object)buku.pengarang,
                    (object)buku.kuantitas,
                    (int)buku.kode


                );

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteNonQuery();
            } catch (Exception ex) { throw ex; } finally { conn.Close(); }

        }
        public void insertBuku(Buku buku)

        {
            conn.Open();
            try
            {
                string query = string.Format("insert into buku " +
                    "(nama, pengarang, kuantitas) values('{0}', '{1}', '{2}')",

                    (object)buku.nama,
                    (object)buku.pengarang,
                    (object)buku.kuantitas


                );

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteNonQuery();
            } catch(Exception ex) { throw ex; }
            finally { conn.Close(); }

        }
        public void deleteBukuByKode(int kode)
        {
            conn.Open();
            try
            {
                string query = string.Format("delete from buku where kode = '{0}'",


                    (object)kode


                );

                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteNonQuery();
            } catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }
    }
}
