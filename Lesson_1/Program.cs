using System;
using System.Text;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte personAge = 24;
            decimal minimumBankAccountLimit = -1000000000000;
            decimal maxsimumBankAccountLimit = 1000000000000;
            char letter = 'F';
            string message = "Hello World";
            bool answer = true;
            float humanTemperature = 36.6f;
            long humanPopulation = 8014895000;
            sbyte temperatureInUkraine = -2;

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Вік людини: {personAge}\n" +
                              $"Банківський рахунок з лімітом від: {minimumBankAccountLimit} до {maxsimumBankAccountLimit}\n" +
                              $"Літера: {letter}\n" +
                              $"SMS повідомлення: {message}\n" +
                              $"Дати оцінку твердженню: \"Сусід сказав, що людина може жити 1000 років\":.{answer}\n" +
                              $"Температура людини: {humanTemperature}\n" +
                              $"Кількість населення планети: {humanPopulation}\n" +
                              $"Температура навколишньго середовища в Україні: {temperatureInUkraine}");
        }
    }
}
