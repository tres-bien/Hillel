using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_SumTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            var result = SumTo(n);

            if (result < 0)
                Console.WriteLine("Неприпустиме значення аргументу");
            else
                Console.WriteLine(result);

            Console.ReadLine();
        }

        static int SumTo(int n)
        {
            if (n <= 0)
                return n;

            return n-- + SumTo(n);
        }
    }
}
