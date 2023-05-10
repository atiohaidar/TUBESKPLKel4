using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUBESKPLKel4.Config;
using TUBESKPLKel4.Models;

namespace TUBESKPLKel4.Repositories
{
    internal class UserRepository
    {

        private MySqlConnection conn;

        public UserRepository()
        {
            this.conn = KoneksiMySql.getConnection();
        }


        public User getUserByUsername(string username)
        {
            this.conn.Open();
            try
            {
                User user = null;
                String query = String.Format("select * from user where username = '{0}'",(object)username);
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                }

                return user;
            } catch (Exception ex)
            {
                throw ex;
            } finally
            {
                this.conn.Close();
            }
        }

    }
}
