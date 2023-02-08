using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_AuthenticationTernary
{
    internal class AuthenticationTernary
    {
        static void Main(string[] args)
        {
            string userLogin = "USER";
            string userPassword = "user";
            string adminLogin = "ADMIN";
            string adminPassword = "admin";

            string loginImput = LoginCheck(userLogin, adminLogin);

            loginImput = loginImput == userLogin || loginImput == adminLogin ? PasswordCheck(userPassword, adminPassword, userLogin, adminLogin, loginImput)
                       : loginImput == "anonimus" ? "Hello Anonimus" 
                       : "user does not exist";

            Console.WriteLine(loginImput);
            Console.ReadLine();
        }

        static string LoginCheck(string userLogin, string adminLogin)
        {
            Console.WriteLine("Enter your login: ");
            string loginImput = Console.ReadLine();

            loginImput = loginImput == userLogin ? userLogin 
                       : loginImput == adminLogin ? adminLogin 
                       : loginImput == "" ? "anonimus" 
                       : "user does not exist";

            return loginImput;
        }

        static string PasswordCheck(string userPassword, string adminPassword, string userLogin, string adminLogin, string loginImput)
        {
            Console.WriteLine("Enter your password: ");
            string passwordImput = Console.ReadLine();

            passwordImput = passwordImput == userPassword && loginImput == userLogin ? "Hello User" 
                          : passwordImput == adminPassword && loginImput == adminLogin ? "Hello Admin" 
                          : "Incorrect password";

            return passwordImput;
        }
    }
}
