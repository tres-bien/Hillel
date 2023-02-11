using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Test
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int mask = 0b0000011;
            string word = string.Empty;

            int w = 82;
            int o = 85;
            int r = 67;
            int d = 68;

            Console.WriteLine("Logical OR");

            for (int i = mask; i < 192; i = mask << 1)
            {
                mask = i;
                w = w | i;
                o = o | i;
                r = r | i;
                d = d | i;

                string a = Convert.ToString(i, 2).PadLeft(8, '0');
                Console.Write($"mask: {a} {(char)w}{(char)o}{(char)r}{(char)d}");

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Logical AND");
            
            mask = 0b0000011;

            for (int i = mask; i < 192; i = mask << 1)
            {
                mask = i;
                w = w & i;
                o = o & i;
                r = r & i;
                d = d & i;

                string a = Convert.ToString(i, 2).PadLeft(8, '0');
                Console.Write($"mask: {a} {(char)w}{(char)o}{(char)r}{(char)d}");

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Logical exclusive OR");

            mask = 0b0000011;

            for (int i = mask; i < 192; i = mask << 1)
            {
                mask = i;
                w = w ^ i;
                o = o ^ i;
                r = r ^ i;
                d = d ^ i;

                string a = Convert.ToString(i, 2).PadLeft(8, '0');
                Console.Write($"mask: {a} {(char)w}{(char)o}{(char)r}{(char)d}");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
