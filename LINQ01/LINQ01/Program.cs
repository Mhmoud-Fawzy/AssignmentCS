using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
using static LINQ01.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LINQ01
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators


            #region Q1. Find all products that are out of stock. 
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;
            #endregion

            #region Q2. Find all products that are in stock and cost more than 3.00 per unit.

            var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);

            Result = from P in ProductList
                     where P.UnitsInStock > 0 && P.UnitPrice > 3
                     select P;



            #endregion

            #region Q3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((Name, Value) => Name.Length < Value);

            //var values = from Name in Arr
            //             select new
            //             {
            //                 Name = Name,
            //                 Index = Array.IndexOf(Arr, Name),
            //             };

            //Result = from NameIndex in values
            //         where NameIndex.Name.Length < NameIndex.Index
            //         select NameIndex.Name;


            #endregion

            #endregion

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


            #region Filteration

            #region Find all products that are out of stock
            //Find all products that are out of stock
            //var res = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}

            //Console.WriteLine("--------------------------------");
            //res = from p in ProductList
            //      where p.UnitsInStock == 0
            //      select p;

            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //} 
            #endregion
            #region Find all products that are in stock and cost more than 3.00 per unit
            //Find all products that are in stock and cost more than 3.00 per unit
            //var res = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}

            //res =from p in ProductList
            //    where p.UnitPrice > 3 && p.UnitsInStock == 0
            //    select p;

            //foreach (var unit in res)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion
            #region Q3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////Returns digits whose name is shorter than their value.

            //var res = Arr.Where((Arr, i) => Arr.Length < i);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion














            #endregion


            #region Q1
            //Return a sequence of just the names of a list of products
            //var names = ProductList.Select(p => p.ProductName);
            //names=from p in ProductList
            //      select p.ProductName; 
            #endregion

            #region Q2
            //Produce a sequence of the uppercase and lowercase versions
            //of each word in the original array(Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res = words.Select(words => new
            //{
            //    Uppercase = words.ToUpper(),
            //    Lowercase = words.ToLower()
            //});

            //res = from word in words
            //      select new
            //      {
            //          Uppercase = word.ToUpper(),
            //          Lowercase = word.ToLower()
            //      }; 
            #endregion
            #region Q3

            //Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.

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
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Select((X, I) => new
            //{
            //    X,
            //    I,
            //    MatchTheirPosition = (X == I) ? true : false
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //    #endregion

            //} 
            #endregion

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var res = numbersA.SelectMany(A => numbersB, (A, B) => new
            {
                A,
                B
            }).Where(P => P.A < P.B);
            foreach (var i in res) Console.WriteLine(i);


        }


    }
}