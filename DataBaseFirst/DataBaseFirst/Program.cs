using DataBaseFirst.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

class Program
{
    static void Main()
    {
        using NorthwindContext northwindContext = new NorthwindContext();
        var count = 3;
        var res = northwindContext.Categories.FromSqlRaw("select top({0})* from Categories",count);
        res = northwindContext.Categories.FromSqlInterpolated($"select top({count}) * from Categories");

        var cat_id = 1;
        northwindContext.Database.ExecuteSqlInterpolated($"update Categories set CategoryName='TestCat' where CategoryID =({cat_id})");

        NorthwindContextProcedures northwindContextProcedures = new NorthwindContextProcedures(northwindContext);
        var res02 = northwindContextProcedures.SalesByCategoryAsync("TestCat","2018").Result;
        foreach (var item in res02) Console.WriteLine(item);
    }
}
