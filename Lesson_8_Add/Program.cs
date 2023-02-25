using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Lesson_8_Add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            string operand1 = Console.ReadLine();
            Console.Write("Enter number 2: ");
            string operand2 = Console.ReadLine();

            Console.WriteLine("\nChoose an action:\n1 - integer addition\n2 - double addition\n3 - string addition");
            int action = int.Parse(Console.ReadLine());
            
            Console.Clear();

            Parser(operand1, operand2, action);

            Console.ReadLine();
        }

        static void Parser(string operand1, string operand2, int action)
        {
            int intResult = 0;
            double doubleResult = 0;

            if (action == 1 && int.TryParse(operand1, out intResult) && int.TryParse(operand2, out intResult))
            {
                Add(int.Parse(operand1), int.Parse(operand2));
            }
            else if (action == 2 && double.TryParse(operand1, out doubleResult) && double.TryParse(operand2, out doubleResult))
            {
                Add(double.Parse(operand1), double.Parse(operand2));
            }
            else if (action == 3)
            {
                Add(operand1, operand2);
            }
            else
            {
                Console.WriteLine("Invalid request");
            }
        }

        static void Add(int operand1, int operand2)
        {
            Console.WriteLine(operand1 + operand2);
        }

        static void Add(double operand1, double operand2)
        {
            Console.WriteLine(operand1 + operand2);
        }

        static void Add(string operand1, string operand2)
        {
            Console.WriteLine(operand1 + operand2);
        }
    }
}
