using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class AuthenticationIfElse
    {
        static void Main(string[] args)
        {
            string userLogin = "USER";
            string userPassword = "user";
            string adminLogin = "ADMIN";
            string adminPassword = "admin";

            string loginImput = LoginCheck(userLogin, adminLogin);

            if (loginImput == "")
            {

            }
            else if (loginImput == adminLogin || loginImput == userLogin)
            {
                PasswordCheck(userPassword, adminPassword, userLogin, adminLogin, loginImput);
            }
            else
            {

            }
            
            Console.ReadLine();
        }

        static string LoginCheck(string userLogin, string adminLogin)
        {
            Console.WriteLine("Enter your login: ");
            string loginImput = Console.ReadLine();

            if (loginImput == userLogin)
            {
                return loginImput;
            }
            else if (loginImput == adminLogin)
            {
                return loginImput;
            }
            else if (loginImput == "")
            {
                Console.WriteLine("Hello Anonimus");
            }
            else
            {
                Console.WriteLine("user does not exist");
            }
            return loginImput;
        }
        
        static void PasswordCheck(string userPassword, string adminPassword, string userLogin, string adminLogin, string loginImput)
        {
            Console.WriteLine("Enter your password: ");
            string passwordImput = Console.ReadLine();

            if (loginImput == userLogin && passwordImput == userPassword)
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
