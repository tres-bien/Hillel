using System;
using System.Text;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte personAge = 24;
            double bankAccount = -1000000000000; //наскільки знаю в фін.установах гроші зберігаються в decimal
            char letter = 'F';
            string message = "Hello World";
            bool answer = true;
            float humanTemperature = 36.6f;
            ulong humanPopulation = 8014895000;
            float temperatureInUkraine = -2f; //термометром давно не користуюсь, але знаю що в гуглі температуру пишуть без дробей. Вважаю що це потрібно вказувати в тз

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Вік людини: {personAge}\n" +
                              $"Банківський рахунок: {bankAccount}\n" +
                              $"Літера: {letter}\n" +
                              $"SMS повідомлення: {message}\n" +
                              $"Дати оцінку твердженню: \"Сусід сказав, що людина може жити 1000 років\":.{answer}\n" +
                              $"Температура людини: {humanTemperature}\n" +
                              $"Кількість населення планети: {humanPopulation}\n" +
                              $"Температура навколишньго середовища в Україні: {temperatureInUkraine}");
            
            Console.ReadLine();
        }
    }
}
