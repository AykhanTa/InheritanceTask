using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    internal class Account
    {
        public string Username;
        public string Password;
        public Account()
        {

        }
        public void Login(string username, string password)
        {
           if (username == "Admin" && password == "AdminEA18yr@")
            {
                Console.WriteLine("Giris ugurludur!");
            }
            else
            {
                Console.WriteLine("USername ve ya password duzgun daxil edilmeyib.");
            }
        }
    }
}
