using System.Net.NetworkInformation;

namespace Classes;

public class Libraty
{
    private Book[] _books = null;

    /// <summary>
    /// Returns books count
    /// </summary>
    public int BooksCount
    {
        get
        {
            if (_books != null)
            {
                return _books.Length;
            }
            else
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// Fills library by default programmers' books
    /// </summary>
    public void FillLibrary()
    {
        _books = new Book[]
        {
            new Book("CLR via C#")
            {
                Author = "Jeffrey Richter"
            },
            new Book("Code Complete")
            {
                Author = "Steve McConnell"
            },
            new Book(" Windows Runtime Via C#")
            {
                Author = "Jeffrey Richter"
            },
        };
    }

    /// <summary>
    /// Find only one book by start title text
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Book FindBookByTitle(string name)
    {
        for (int i = 0; i < _books.Length; i++)
        {
            if (_books[i].Title.Contains(name))
            {
                return _books[i];
            }
        }
        return _books[0];
    }

    /// <summary>
    /// Find set of books by start author name text
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Book[] FindBooksByAuthor(string name)
    {
        Book[] findBooksArray;
        List<Book> termsList = new List<Book>();
        for (int i = _books.Length - 1; i >= 0; i--)
        {
            if (_books[i].Author.Contains(name))
            {
                termsList.Add(_books[i]);
            }
        }
        findBooksArray = termsList.ToArray();
        return findBooksArray;
    }

    private Book[] Books
    {
        get
        {
            if (_books == null)
            {
                return new Book[0];
            }

            return _books;
        }
    }
}