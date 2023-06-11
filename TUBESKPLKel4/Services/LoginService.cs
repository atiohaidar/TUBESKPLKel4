using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUBESKPLKel4.Repositories;
using TUBESKPLKel4.Models;

namespace TUBESKPLKel4.Services
{
    public class LoginService
    {
        private UserRepository userRepo;
        private Boolean isLoggedIn;

        public LoginService(UserRepository userRepo)
        {
            this.isLoggedIn = false;
            this.userRepo = userRepo;
        }

        public Boolean IsValidUser(string username, string password)
        {
            User user = userRepo.getUserByUsername(username);
            if (user == null || (user != null && password != user.getPassword()))
            {
                throw new Exception("Username atau password salah");
            }

            ActiveUser.user = user;
            this.isLoggedIn=true;
            return true;
        }
    }
}
