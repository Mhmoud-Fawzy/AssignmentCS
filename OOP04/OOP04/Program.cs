using OOP04.Inherintace;
using System;
using System.Numerics;

class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }
    static int Sum(int x, int y, int z)
    {
        return x + y + z;
    }
    static double Sum(double x, double y, double z)
    {
        return x + y + z;
    }

    static void Main()
    {

        #region Inheritance
        Console.WriteLine("============Parent============");
        Parent parent = new Parent(1, 2);
        Console.WriteLine(parent);
        Console.WriteLine(parent.Product());
        Console.WriteLine("============Child============");
        Child child = new Child(100, 200, 500);
        Console.WriteLine(child);
        Console.WriteLine(child.Product());

        // Access Modifiers 

        parent.A = 1; // Public
        parent.B = 1; // Internal
        //parent.C = 1; // Protected
        parent.D = 1; // Internal Protected
                      //parent.E = 1; // Private Protected 
        #endregion
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine(Sum(1, 2));
        Console.WriteLine(Sum(1, 3, 5));
        Console.WriteLine(Sum(1.1, 4.2, 6.5));

        Console.WriteLine("-----------------------------------------------------");

        Complex c1 = new Complex(3, 4);
        Complex c2 = new Complex(1, 2);

        Complex sum = c1 + c2;
        Complex diff = c1 - c2;
        Complex product = c1 * c2;

        Complex unaryPlus = +c1;
        Complex unaryMinus = -c1;

        Console.WriteLine($"c1: {c1}");
        Console.WriteLine($"c2: {c2}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {diff}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Unary Plus of c1: {unaryPlus}");
        Console.WriteLine($"Unary Minus of c1: {unaryMinus}");
    }
}
