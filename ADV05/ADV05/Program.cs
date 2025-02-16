using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public DateTime PublicationDate { get; set; }

    public Book(string title, string author, string isbn, DateTime publicationDate)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationDate = publicationDate;
    }

    public string GetISBN()
    {
        return ISBN;
    }

    public DateTime GetPublicationDate()
    {
        return PublicationDate;
    }

    // Override ToString to provide book information
    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publication Date: {PublicationDate.ToShortDateString()}";
    }
}

public class BookFunctions
{
    // ProcessBooks method now accepts a built-in delegate (Func<Book, string>)
    public void ProcessBooks(List<Book> books, Func<Book, string> function)
    {
        foreach (var book in books)
        {
            Console.WriteLine(function(book));
        }
    }
}

class Program
{
    static void Main()
    {
        BookFunctions bookFunctions = new BookFunctions();
        List<Book> books = new List<Book>
        {
            new Book("Title1", "Author1", "ISBN1", new DateTime(2020, 1, 1)),
            new Book("Title2", "Author2", "ISBN2", new DateTime(2021, 1, 1))
        };

        // Using built-in delegate (Func<Book, string>)
        Func<Book, string> isbnDelegate = book => book.GetISBN();
        bookFunctions.ProcessBooks(books, isbnDelegate);

        // Alternatively, you can directly pass a lambda expression
        bookFunctions.ProcessBooks(books, book => book.GetPublicationDate().ToString());

        // You can also pass the ToString method directly
        bookFunctions.ProcessBooks(books, book => book.ToString());
    }
}