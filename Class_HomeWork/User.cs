using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HomeWork
{
    public class User
    {
        public string UserName;
        public string Pasword;
        public bool LoginInfo;

        public User(string UserName, string Pasword)
        {
            this.UserName = UserName;
            this.Pasword = Pasword;
            Console.WriteLine("Sign Up");

        }

        public bool Login()
        {
            if (LoginInfo == false)
            {
                Console.WriteLine("istifadəçi hesaba daxil oldu ");
            }
            else
            {
                Console.WriteLine("istifadəçi öncədən hesaba daxil olub");
            }
            LoginInfo = true;
            return LoginInfo;
             
        }
        public bool Logout()
        {
            if (LoginInfo == true)
            {
                Console.WriteLine("istifadəçi hesabdan çıxış etdi");
            }
            else
            {
                Console.WriteLine("istifadəçi hesaba giriş etməyib");
            }
            LoginInfo = false;
            return LoginInfo;

        }
    }
}
