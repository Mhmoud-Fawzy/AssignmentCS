using System;
using System.Collections.Generic;

/*
1. Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:
*/
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public DateTime PublicationDate { get; set; }

    // Constructor
    public Book(string title, string author, string isbn, DateTime publicationDate)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationDate = publicationDate;
    }

    // Method to get ISBN
    public string GetISBN()
    {
        return ISBN;
    }

    // Method to get publication date
    public DateTime GetPublicationDate()
    {
        return PublicationDate;
    }
}

public class BookFunctions
{
    // Method to process books
    //public void ProcessBooks(List<Book> books, Func<Book, string> function)
    //{
    //    foreach (var book in books)
    //    {
    //        Console.WriteLine(function(book));
    //    }
    //}
     public void ProcessBooks(List<Book> books, BookFunctionDelegate function)
    {
        foreach (var book in books)
        {
            Console.WriteLine(function(book));
        }
    }
}

/*
a) Create User Defined Delegate with the same signature of methods existed in BookFunctions class.
*/
public delegate string BookFunctionDelegate(Book book);

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

        // a) User-Defined Delegate
        BookFunctionDelegate isbnDelegate = new BookFunctionDelegate(book => book.GetISBN());
        bookFunctions.ProcessBooks(books, isbnDelegate);

        // b) Built-in Delegate (Func)
        bookFunctions.ProcessBooks(books, book => book.GetISBN());

        // c) Anonymous Method
        bookFunctions.ProcessBooks(books, delegate(Book book) { return book.GetISBN(); });

        // d) Lambda Expression
        bookFunctions.ProcessBooks(books, book => book.GetPublicationDate().ToString());
    }
}