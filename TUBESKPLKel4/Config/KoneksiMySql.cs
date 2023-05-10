using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TUBESKPLKel4.Config
{
    internal class KoneksiMySql
    {
        private static String conString = "server=127.0.0.1;database=perpusapp;uid=root;pwd=;";
        private static MySqlConnection myConnection;
        
        public static MySqlConnection getConnection()
        {
            if (myConnection == null)
            {
                myConnection = new MySqlConnection(conString);
            }

            return myConnection;
        }
    }
}
