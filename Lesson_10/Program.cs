using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"G:\myFolder\Hillel\Lesson_10\strings.txt");
            Console.OutputEncoding = Encoding.Unicode;

            SentenseCounter(text);

            Console.ReadLine();
        }

        static void SentenseCounter(string text)
        {
            char[] separators = new char[] { '.', '…', '!', '?' };
            string[] sentenses = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            NameExtractor(sentenses);
        }

        static void NameExtractor(string[] sentenses)
        {
            StringBuilder names = new StringBuilder();
            string[] words;
            for (int i = 0; i < sentenses.Length; i++)
            {
                words = sentenses[i].Split(' ', ',', '.', '!', '?', ':', ';', '\t');
                for (int j = 0; j < words.Length; j++)
                {
                    if (!sentenses[i].StartsWith(words[j]) && !sentenses[i].StartsWith(' ' + words[j]) && char.IsUpper(words[j], 0))
                    {
                        names.Append(words[j] + ' ');
                    }
                }
            }
            string[] namesArray = names.ToString().Split(' ');
            names = new StringBuilder(namesArray[0] + ' ');
            for (int i = 0; i < namesArray.Length; i++)
            {
                for (int j = 0; j < namesArray.Length; j++)
                {
                    if (!names.ToString().Contains(namesArray[j]))
                    {
                        names.Append(namesArray[j] + ' ');
                    }
                }
            }
            string[] uniqueNamse = names.ToString().Split(' ');
            Print(sentenses.Length, uniqueNamse);
        }

        static void Print(int sentenseCount, string[] uniqueNames)
        {
            Console.WriteLine($"Кількість речень: {sentenseCount}");
            Console.WriteLine($"Кількість унікальних імен або прізвищ: {uniqueNames.Length}");
            Console.Write("Унікальні імена та прізвища: ");

            for (int i = 0; i < uniqueNames.Length; i++)
            {
                Console.Write(uniqueNames[i] + " ");
            }
        }
    }
}