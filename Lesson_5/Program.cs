using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width of the diamond: ");
            int width = int.Parse(Console.ReadLine());
            Console.Clear();

            char symbol = '*';
            int halfWidth = width / 2;
            int tempWidth = 0;

            tempWidth = width % 2 == 0 ? 2 : 1;

            for (int i = 0; i < width / 2; i++)
            {
                Console.WriteLine();
                Console.SetCursorPosition(halfWidth, i);
                halfWidth--;

                for (int j = 0; j < tempWidth; j++)
                {
                    Console.Write(symbol);
                }
                tempWidth += 2;
            }

            for (int i = 0; i < width / 2 + 1; i++)
            {
                Console.WriteLine();
                Console.SetCursorPosition(halfWidth, i + width / 2);
                halfWidth++;

                for (int j = tempWidth; j > 0; j--)
                {
                    Console.Write(symbol);
                }
                tempWidth -= 2;
            }
            Console.ReadLine();
        }
    }
}
