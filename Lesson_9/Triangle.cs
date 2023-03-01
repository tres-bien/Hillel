using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Triangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the triangle: ");
            int arrLength = int.Parse(Console.ReadLine());
            Console.Clear();

            char[][] array = new char[arrLength/2 + arrLength%2][];

            FillArray(array, arrLength);
            PrintArray(array);

            Console.ReadLine();
        }

        static void FillArray(char[][] array, int arrLength)
        {
            int tempLength = array.Length - arrLength%2;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new char[i + i + 1 + tempLength];
                tempLength--;
            }

            tempLength= array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = ' ';
                    if (j > tempLength - 1)
                        array[i][j] = '*';
                }
                tempLength--;
            }
        }

        static void PrintArray(char[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
