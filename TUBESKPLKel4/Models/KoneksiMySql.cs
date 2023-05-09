using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TUBESKPLKel4
{
    internal class KoneksiMySql
    {
        public static String conString = "server=127.0.0.1;database=perpusapp;uid=root;pwd=;";
        public static MySqlConnection myConnection;
        
        public static bool connect()
        {
            myConnection = new MySqlConnection(conString);
            try
            {
                myConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }

            

        }
        public static void close()
        {
            myConnection.Close();
            Console.Write("berhsil aterputus");

        }
    }
}
