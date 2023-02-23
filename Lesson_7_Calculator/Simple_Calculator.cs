using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Simple_Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Write number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Write number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Write type of operation: ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Your answer: ");

            Calculator(number1, number2, operation);

            Console.ReadLine();
        }

        static void Calculator(int operand1, int operand2, char operation)
        {
            switch(operation)
            {
                case '+':
                    Console.WriteLine(operand1 + operand2);
                    break;
                case '-':
                    Console.WriteLine(operand1 - operand2);
                    break;
                case '*':
                    Console.WriteLine(operand1 * operand2);
                    break;
                case'/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Dividing by 0 is not allowed");
                        break;
                    }
                    Console.WriteLine(operand1 / operand2);
                    break;
                case '^':
                    int square = 1;
                    for (int i = 1; i < operand2; i++)
                    {
                        square *= operand1;
                    }
                    Console.WriteLine(square);
                    break;
            }
        }
    }
}
