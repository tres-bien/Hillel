using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_switch_case
{
    internal class AuthenticationSwitch
    {
        static void Main(string[] args)
        {
            string userLogin = "USER";
            string userPassword = "user";
            string adminLogin = "ADMIN";
            string adminPassword = "admin";

            string loginImput = LoginCheck(userLogin, adminLogin);

            switch (loginImput)
            {
                case "": break;
                case "USER":
                case "ADMIN":
                    PasswordCheck(userPassword, adminPassword, userLogin, adminLogin, loginImput);
                    break;
                default: break;
            }

            Console.ReadLine();
        }

        static string LoginCheck(string userLogin, string adminLogin)
        {
            Console.WriteLine("Enter your login: ");
            string loginImput = Console.ReadLine();

            switch (loginImput)
            {
                case "USER" when loginImput == userLogin:
                    break;
                case "ADMIN" when loginImput == adminLogin:
                    break;
                case "":
                    Console.WriteLine("Hello Anonimus");
                    break;
                default:
                    Console.WriteLine("user does not exist");
                    break;
            }
            return loginImput;
        }

        static void PasswordCheck(string userPassword, string adminPassword, string login, string adminLogin, string loginImput)
        {
            Console.WriteLine("Enter your password: ");
            string passwordImput = Console.ReadLine();

            switch (passwordImput)
            {
                case "user" when loginImput == adminPassword:
                    Console.WriteLine("Hello User");
                    break;
                case "admin" when loginImput == adminLogin:
                    Console.WriteLine("Hello Admin");
                    break;
                default:
                    Console.WriteLine("Incorrect password");
                    break;
            }
        }
    }
}
