using ADV04;
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        #region Hashtable
        //Hashtable Note = new Hashtable(StringComparer.OrdinalIgnoreCase);

        //Note.Add("Alaa", 95);
        //Note.Add("Fahd", 88);
        //Note.Add("Sama", 92);
        //Note.Add("Hager", 97);
        //Note.Add("Noor", 123);
        //Console.WriteLine("---------------------------------");

        //try
        //{
        //    Note.Add("noor", 123);
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine("Cannot add duplicate key : " + ex.Message);
        //}
        //Console.WriteLine("---------------------------------");


        //foreach (DictionaryEntry entry in Note)
        //{
        //    Console.WriteLine($"{entry.Key}: {entry.Value}");
        //}

        //Console.WriteLine("---------------------------------");


        //foreach (object value in Note.Values)
        //{
        //    Console.WriteLine(value);
        //}
        //Console.WriteLine("---------------------------------");

        //foreach (object key in Note.Keys)
        //{
        //    Console.WriteLine(key);
        //} 
        #endregion
        #region Dictionary
        //    var initialData = new List<KeyValuePair<string, int>>
        //{
        //    new KeyValuePair<string, int>("Alaa", 95),
        //    new KeyValuePair<string, int>("Fahd", 88),
        //    new KeyValuePair<string, int>("Sama", 92),
        //    new KeyValuePair<string, int>("Hager", 97),
        //    new KeyValuePair<string, int>("Noor", 123)
        //};

        //    Dictionary<string, int> Note = new Dictionary<string, int>(initialData, StringComparer.OrdinalIgnoreCase);
        //    Console.WriteLine("---------------------------------");
        //    try
        //    {
        //        Note.Add("noor", 123);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine("Cannot add duplicate key : " + ex.Message);
        //    }
        //    Console.WriteLine("---------------------------------");
        //    foreach (var Person in Note)
        //    {
        //        Console.WriteLine($"{Person.Key}: {Person.Value}");
        //    }
        //    Console.WriteLine("---------------------------------");
        //    foreach (int value in Note.Values)
        //    {
        //        Console.WriteLine(value);
        //    }
        //    Console.WriteLine("---------------------------------");
        //    foreach (string key in Note.Keys)
        //    {
        //        Console.WriteLine(key);
        //    }
        //    Console.WriteLine("---------------------------------");

        //    if (Note.TryGetValue("Ahmed", out int num))
        //    {
        //        Console.WriteLine($"Found Ahmed's key: {num}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ahmed's key not found");
        //    }

        #endregion
        #region HashSet
        //var initialNumbers = new List<int> { 2, 4, 6, 8, 10 };

        //HashSet<int> EvenNumbers = new HashSet<int>(initialNumbers);

        //Console.WriteLine("---------------------------------");
        //try
        //{
        //    bool added = EvenNumbers.Add(4);
        //    Console.WriteLine($"Added 4? {added}"); 
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error adding number: " + ex.Message);
        //}

        //Console.WriteLine("---------------------------------");
        //foreach (var number in EvenNumbers)
        //{
        //    Console.WriteLine(number);
        //}

        //Console.WriteLine("---------------------------------");
        //if (EvenNumbers.Contains(6))
        //{
        //    Console.WriteLine("Number 6 exists in set");
        //}

        //Console.WriteLine("---------------------------------");
        //if (EvenNumbers.TryGetValue(8, out int foundNumber))
        //{
        //    Console.WriteLine($"Found number: {foundNumber}");
        //}
        //else
        //{
        //    Console.WriteLine("Number not found");
        //}


        //HashSet<Movie> movies = new HashSet<Movie>();

        //Movie movie1 = new Movie { Id = 1, Name = "MovieX" };
        //Movie movie2 = new Movie { Id = 2, Name = "MovieY" };
        //Movie movie3 = new Movie { Id = 1, Name = "MovieZ" }; 

        //bool addedMovie1 = movies.Add(movie1);
        //bool addedMovie2 = movies.Add(movie2);
        //bool addedMovie3 = movies.Add(movie3); 

        //Console.WriteLine($"Movie1 added: {addedMovie1}");
        //Console.WriteLine($"Movie2 added: {addedMovie2}"); 
        //Console.WriteLine($"Movie3 added: {addedMovie3}");

        //Console.WriteLine("===========================================");
        //Console.WriteLine("Movies in the HashSet:");
        //foreach (var movie in movies)
        //{
        //    Console.WriteLine($"ID: {movie.Id}, Name: {movie.Name}");
        //}

        #endregion
    }
}