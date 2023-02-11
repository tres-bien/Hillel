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

            int q = 0;
            int b = 0;
            int c = 0;
            int f = 0;

            Console.WriteLine("Logical OR");

            for (int i = mask; i < 192; i = mask << 1)
            {
                mask = i;
                q = w | i;
                b = o | i;
                c = r | i;
                f = d | i;

                string a = Convert.ToString(i, 2).PadLeft(8, '0');
                Console.Write($"mask: {a} {(char)q} |{w}| {(char)b} |{o}| {(char)c} |{r}| {(char)f} |{d}| ");

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Logical AND");
            
            mask = 0b0000011;
            q = 0;
            b = 0;
            c = 0;
            f = 0;

            for (int i = mask; i < 192; i = mask << 1)
            {
                mask = i;
                q = w & i;
                b = o & i;
                c = r & i;
                f = d & i;

                string a = Convert.ToString(i, 2).PadLeft(8, '0');
                Console.Write($"mask: {a} {(char)q} |{w}| {(char)b} |{o}| {(char)c} |{r}| {(char)f} |{d}| ");

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Logical exclusive OR");

            mask = 0b0000011;
            q = 0;
            b = 0;
            c = 0;
            f = 0;

            for (int i = mask; i < 192; i = mask << 1)
            {
                mask = i;
                q = w ^ i;
                b = o ^ i;
                c = r ^ i;
                f = d ^ i;

                string a = Convert.ToString(i, 2).PadLeft(8, '0');
                Console.Write($"mask: {a} {(char)q} |{w}| {(char)b} |{o}| {(char)c} |{r}| {(char)f} |{d}| ");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
