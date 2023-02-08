using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "USER";
            string password = "user";
            string adminLogin = "ADMIN";
            string adminPassword = "admin";
            string loginImput = "";

            loginImput = LoginCheck(login, adminLogin, loginImput);
            PasswordCheck(password, adminPassword, login, adminLogin, loginImput);
        }

        static string LoginCheck(string login, string adminLogin, string loginImput)
        {
            Console.WriteLine("Enter your login: ");
            loginImput = Console.ReadLine();

            if (loginImput == login)
            {
                return loginImput;
            }
            else if (loginImput == adminLogin)
            {
                return loginImput;
            }
            else if (loginImput != login || loginImput != adminLogin)
            {
                Console.WriteLine("user does not exist");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Hello Anonimus");
            }
            return loginImput;
        }
        
        static void PasswordCheck(string password, string adminPassword, string login, string adminLogin, string loginImput)
        {
            Console.WriteLine("Enter your password: ");
            string passwordImput = Console.ReadLine();

            if (loginImput == login && passwordImput == password)
            {
                Console.WriteLine("Hello User");
            }
            else if (loginImput == adminLogin && passwordImput == adminPassword)
            {
                Console.WriteLine("Hello Admin");
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }
        }
    }
}
