using LINQ02;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using static LINQ02.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{
    static void Main()
    {

        #region Element Operators

        #region Q1
        ////Get first Product out of Stock
        ////var res = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

        #endregion
        #region Q2
        ////Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
        ////var res = ProductList.FirstOrDefault(p => p.UnitPrice > 1000); 
        #endregion
        #region Q3
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //Retrieve the second number greater than 5
        //var res=Arr.Where(p=>p>5).ElementAtOrDefault(2);

        #endregion

        #endregion
        #region Aggregate Operators

        #region Q1
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //1. Uses Count to get the number of odd numbers in the array
        //var res = Arr.Count(Arr => Arr % 2 == 1);


        #endregion
        #region Q2
        //2.Return a list of customers and how many orders each has.
        //var res = CustomerList.Select(c => new
        //       {
        //           CustomerName = c.CustomerName,
        //           OrderCount = c.Orders.Count() 
        //       }); 
        #endregion
        #region Q3
        //3. Return a list of categories and how many products each has

        //var res = ProductList.GroupBy(p => p.Category).Select(c => new
        //      {
        //          Category = c.Key, 
        //          ProductCount = c.Count() 
        //      });

        #endregion
        #region Q4
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //.Get the total of the numbers in an array.
        //var res = Arr.Sum(); 
        #endregion

        string[] words = File.ReadAllLines("dictionary_english.txt");
        #region Q5
        ////Get the total number of characters of all words in dictionary_English.txt
        ////(Read dictionary_English.txt into Array of String First).

        ////var res = words.Sum(word => word.Length);
        ////Console.WriteLine(res); 
        #endregion
        #region Q6
        ////Get the length of the shortest word in dictionary_english.txt
        ////(Read dictionary_english.txt into Array of String First).
        ////var res = words.Min(w => w.Length); 
        #endregion
        #region Q7
        ////Get the length of the longest word in dictionary_english.txt
        ////(Read dictionary_english.txt into Array of String First).
        ////var res = words.Max(x => x.Length); 
        #endregion
        #region Q8
        //. Get the average length of the words in dictionary_english.txt
        //(Read dictionary_english.txt into Array of String First).
        //var res = words.Average(x => x.Length);  
        #endregion
        #region Q9
        //.Get the total units in stock for each product category.
        //var res = ProductList.GroupBy(c=>c.Category).Select(g => new
        //{
        //    Category = g.Key,
        //    TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
        //}); 
        #endregion
        #region Q10
        //10.Get the cheapest price among each category's products
        //var res = ProductList.GroupBy(c => c.Category).Select(p => new
        //{
        //    Category = p.Key,
        //    CheapestPrice = p.Min(p => p.UnitPrice)//.Select(p=>p.UnitPrice)
        //}); 
        #endregion
        #region Q12
        // 11. Get the products with the cheapest price in each category using let
        //var res = ProductList.GroupBy(p => p.Category).Select(g => new
        //    {
        //        Category = g.Key,
        //        CheapestPrice = g.Min(p => p.UnitPrice),
        //        Products = g.Where(p => p.UnitPrice == g.Min(x => x.UnitPrice))
        //    }); 
        #endregion
        #region Q13
        // 12. Get the most expensive price among each category's products
        //var res = ProductList.GroupBy(p => p.Category).Select(g => new
        //    {
        //        Category = g.Key,
        //        MostExpensivePrice = g.Max(p => p.UnitPrice)
        //    }); 
        #endregion
        #region Q14
        // 13. Get the products with the most expensive price in each category
        //var res = ListGenerators.ProductList.GroupBy(p => p.Category).Select(g => new
        //    {
        //        Category = g.Key,
        //        MaxPrice = g.Max(p => p.UnitPrice),
        //        Product = g.FirstOrDefault(p => p.UnitPrice == g.Max(x => x.UnitPrice))
        //    }); 
        #endregion
        #region Q15
        // 14. Get the average price of each category's products
        //var res = ProductList.GroupBy(p => p.Category)
        //    .Select(g => new
        //    {
        //        Category = g.Key,
        //        AveragePrice = g.Average(p => p.UnitPrice)
        //    }); 
        #endregion







        #endregion
        #region Ordering Operators
        #region Q1
        //Sort a list of products by name
        //var res = ProductList.OrderBy(p => p.ProductName);

        //res =from p in ProductList 
        //     orderby p.ProductName
        //     select p; 
        #endregion
        #region Q2
        // 2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
        //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //var res = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
        //foreach (var item in res)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion
        #region Q3
        //Sort a list of products by units in stock from highest to lowest.

        // var res = ProductList.OrderByDescending(p => p.UnitsInStock);

        #endregion
        #region Q4
        //Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
        //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        //var res = Arr.OrderBy(word => word.Length).ThenBy(word => word);

        #endregion
        #region Q5
        //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //Sort first by-word length and then by a case-insensitive sort of the words in an array.
        //var res = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

        #endregion
        #region Q6
        //Sort a list of products, first by category, and then by unit price, from highest to lowest.
        //var res = ProductList.OrderBy(c => c.Category).ThenByDescending(c => c.UnitPrice);

        #endregion
        #region Q7
        //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        // var res = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);


        #endregion
        #region Q8
        //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        //Create a list of all digits in the array whose second letter is 'i'
        //that is reversed from the order in the original array.

        //var res = Arr.Where(word => word[1] == 'i') .Reverse();
        //foreach (var item in res)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #endregion
        #region Transformation Operators

        #region Q1. Return a sequence of just the names of a list of products.

        //var Result = ProductList.Select(P => P.ProductName).ToList();

        //Result = (from Product in ProductList
        //          select Product.ProductName)
        //          .ToList();

        #endregion

        #region Q2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

        //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        //var Result = words.Select((N) => new
        //{
        //    Upper = N.ToUpper(),
        //    Lower = N.ToLower(),
        //});

        //Result = from N in words
        //         select new
        //         {
        //             Upper = N.ToUpper(),
        //             Lower = N.ToLower(),
        //         };
        #endregion

        #region Q3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
        //var Result = ProductList.Select(P => new
        //{
        //    Price = P.UnitPrice,
        //    P.ProductName,
        //    P.UnitsInStock
        //});

        //Result = from P in ProductList
        //         select new
        //         {
        //             Price = P.UnitPrice,
        //             P.ProductName,
        //             P.UnitsInStock
        //         };
        #endregion

        #region Q4. Determine if the value of ints in an array match their position in the array.

        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var Result = Arr.Select((X, I) => new
        //{
        //    Value = X,
        //    Position = I,
        //    MatchTheirPosition = (X == I) ? true : false,
        //});

        //var values = from Name in Arr
        //             select new
        //             {
        //                 Name = Name,
        //                 Index = Array.IndexOf(Arr, Name),
        //             };
        //Result = from ValuePosition in values
        //         select new
        //         {
        //             Value = ValuePosition.Name,
        //             Position = ValuePosition.Index,
        //             MatchTheirPosition = (ValuePosition.Name == ValuePosition.Index) ? true : false,
        //         };
        #endregion


        #region Q5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

        //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        //int[] numbersB = { 1, 3, 5, 7, 8 };
        //var Result = numbersA.SelectMany(A => numbersB, (A, B) => new
        //{
        //    A,
        //    B
        //}).Where(P => P.A < P.B);
        //Result = from A in numbersA
        //         from B in numbersB
        //         where A < B
        //         select new
        //         {
        //             A,
        //             B
        //         };

        #endregion

        #region Q6. Select all orders where the order total is less than 500.00

        //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500m);

        //Result = from C in CustomerList
        //         from O in C.Orders
        //         where O.Total < 500m
        //         select O;

        #endregion

        #region Q7. Select all orders where the order was made in 1998 or later.

        //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year >= 1998);

        //Result = from C in CustomerList
        //         from O in C.Orders
        //         where O.OrderDate.Year >= 1998
        //         select O;

        #endregion

        #endregion
        #region Set Operators
        #region Q1
        ////Find the unique Category names from Product List
        ////var res = ProductList.Select(p => p.Category).Distinct();


        #endregion
        #region Q2
        //Produce a Sequence containing the unique first letter from both product and customer names.

        //var res = ProductList.Select(p => p.ProductName[0]) 
        //    .Union(CustomerList.Select(c => c.CustomerName[0])) .Distinct().OrderBy(c => c); 

        #endregion
        #region Q3
        //Create one sequence that contains the common first letter from both product and customer names

        //var res = ProductList.Select(p => p.ProductName[0])
        //   .Intersect(CustomerList.Select(c => c.CustomerName[0])).OrderBy(c => c);

        #endregion
        #region Q4
        ////Create one sequence that contains the first letters of product names that are not also first letters of customer names.
        ////var res = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));

        #endregion
        #region Q5
        //Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
        //var res = ProductList .Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
        //.Concat(ListGenerators.CustomerList
        //.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));

        #endregion







        #endregion
        #region Quantifiers

        #region Q1
        //1.Determine if any of the words in dictionary_english.txt
        //(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

        //var res = words.Any(word => word.Contains("ei"));


        #endregion
        #region Q2
        //2.Return a grouped a list of products only for categories that have at least one
        //product that is out of stock.
        //var res = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)) 
        //   .Select(g => new { Category = g.Key, Products = g.ToList() });

        #endregion
        #region Q3
        //3.Return a grouped a list of products only for categories that have all of their products in stock.

        //var res = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0)) 
        //    .Select(g => new { Category = g.Key, Products = g.ToList() });



        #endregion







        #endregion
        #region Grouping Operators
        #region Q1
        //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //var res = numbers.GroupBy(n => n % 5)
        //    .Select(g => new { Remainder = g.Key, Numbers = g.ToList() });


        #endregion
        #region Q2
        //Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input

        //var groupedWords = words.Where(word => !string.IsNullOrWhiteSpace(word)).GroupBy(word => word[0])
        //.Select(g => new { FirstLetter = g.Key, Words = g.ToList() }); 
        #endregion
        #region Q3

        //Use Group By with a custom comparer that matches words that are consists of the same Characters Together
        //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
        //var res = Arr.GroupBy(word => new string(word.OrderBy(c => c).ToArray())).Select(g => new { Key = g.Key, Words = g.ToList() }); 

        #endregion

        #endregion
        //foreach (var i in res) Console.WriteLine(i);

    }
}