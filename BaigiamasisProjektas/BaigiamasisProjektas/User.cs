using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisProjektas
{
    public class User
    {
        public static User DeafaultUser = new User("JulitaD", "julita");
        public string Username;
        public string Password;
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
