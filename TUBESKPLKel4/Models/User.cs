using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBESKPLKel4.Models
{
    internal class User
    {
        public string name, username;
        private string password;

        public User(string username, string name, string password) { 
            this.name = name;
            this.username = username;
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }

    }
}
