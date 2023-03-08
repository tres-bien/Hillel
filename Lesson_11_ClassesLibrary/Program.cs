using System;
using System.Text;

namespace Classes
{
    class Program
    {
        //Do not change code in this file!!!
        //Не змінюй нічого в цьому файлі!!!
        static void Main()
        {
            var library = new Libraty();

            ShowSearchResult(library.BooksCount);

            library.FillLibrary();

            var codeCompleteBook = library.FindBookByTitle("Code");

            codeCompleteBook.Show();

            var jefrysBooks = library.FindBooksByAuthor("Jef");

            ShowSearchResult(jefrysBooks.Length);

            for (int i = 0; i < jefrysBooks.Length; i++)
            {
                jefrysBooks[i].Show();
            }

            // Delay.
            Console.ReadKey();
        }

        /// <summary>
        /// Shows result of search
        /// </summary>
        /// <param name="countResult"></param>
        private static void ShowSearchResult(int countResult)
        {
            Console.WriteLine($"Found {countResult} books");
        }
    }
}