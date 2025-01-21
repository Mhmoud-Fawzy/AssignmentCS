#region Project1

//using System;
//using System.Linq;


//using System;

//public class Point3D
//{
//    public double X { get; set; }
//    public double Y { get; set; }
//    public double Z { get; set; }

//    public Point3D() : this(0, 0, 0) { }

//    public Point3D(double x, double y, double z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }
//    public override string ToString()
//    {
//        return $"Point Coordinates: ({X}, {Y}, {Z})";
//    }

//    public static bool operator ==(Point3D p1, Point3D p2)
//    {
//        if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
//            return true;
//        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
//            return false;
//        return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
//    }

//    public static bool operator !=(Point3D p1, Point3D p2)
//    {
//        return !(p1 == p2);
//    }
//    public override bool Equals(object obj)
//    {
//        if (obj is Point3D point)
//        {
//            return this == point;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(X, Y, Z);
//    }

//    public static Point3D ReadPointFromUser(string pointName)
//    {
//        double x, y, z;

//        while (true)
//        {
//            Console.WriteLine($"\nEnter coordinates for {pointName}:");

//            Console.Write("Enter X coordinate: ");
//            if (!double.TryParse(Console.ReadLine(), out x))
//            {
//                Console.WriteLine("Invalid input for X coordinate. Please try again.");
//                continue;
//            }

//            Console.Write("Enter Y coordinate: ");
//            if (!double.TryParse(Console.ReadLine(), out y))
//            {
//                Console.WriteLine("Invalid input for Y coordinate. Please try again.");
//                continue;
//            }

//            Console.Write("Enter Z coordinate: ");
//            if (!double.TryParse(Console.ReadLine(), out z))
//            {
//                Console.WriteLine("Invalid input for Z coordinate. Please try again.");
//                continue;
//            }

//            return new Point3D(x, y, z);
//        }
//    }

//    public static void SortPoints(Point3D[] points)
//    {
//        for (int i = 0; i < points.Length - 1; i++)
//        {
//            for (int j = 0; j < points.Length - i - 1; j++)
//            {
//                if (points[j].X > points[j + 1].X)
//                {
//                    SwapPoints(points, j, j + 1);
//                }
//                else if (points[j].X == points[j + 1].X && points[j].Y > points[j + 1].Y)
//                {
//                    SwapPoints(points, j, j + 1);
//                }
//            }
//        }
//    }

//    private static void SwapPoints(Point3D[] points, int i, int j)
//    {
//        Point3D temp = points[i];
//        points[i] = points[j];
//        points[j] = temp;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Point3D p = new Point3D(10, 10, 10);
//        Console.WriteLine(p.ToString());

//        Point3D p1 = Point3D.ReadPointFromUser("P1");
//        Point3D p2 = Point3D.ReadPointFromUser("P2");

//        Console.WriteLine("\nTesting equality:");
//        Console.WriteLine($"P1 == P2: {p1 == p2}");

//        Point3D[] points = new Point3D[]
//        {
//            new Point3D(3, 4, 1),
//            new Point3D(1, 2, 3),
//            new Point3D(2, 2, 1),
//            new Point3D(1, 1, 1)
//        };

//        Console.WriteLine("\nOriginal array of points:");
//        foreach (var point in points)
//        {
//            Console.WriteLine(point);
//        }

//        Point3D.SortPoints(points);  

//        Console.WriteLine("\nSorted array of points (by X then Y):");
//        foreach (var point in points)
//        {
//            Console.WriteLine(point);
//        }
//    }
//} 
#endregion
#region Project2
//using System;
//class Maths
//{
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public static int Subtract(int a, int b)
//    {
//        return a - b;
//    }

//    public static int Multiply(int a, int b)
//    {
//        return a * b;
//    }

//    public static double Divide(int a, int b)
//    {
//        return (double)a / b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int sum = Maths.Add(10, 5);
//        int difference = Maths.Subtract(10, 5);
//        int product = Maths.Multiply(10, 5);
//        double quotient = Maths.Divide(10, 5);

//        Console.WriteLine($"Addition: 10 + 5 = {sum}");
//        Console.WriteLine($"Subtraction: 10 - 5 = {difference}");
//        Console.WriteLine($"Multiplication: 10 * 5 = {product}");
//        Console.WriteLine($"Division: 10 / 5 = {quotient}");
//    }
//} 
#endregion
#region Project3
//class Duration 
//{
//    public int Hours { get; set; }
//    public int Minutes { get; set; }
//    public int Seconds { get; set; }

//    public Duration(int hours, int minutes, int seconds)
//    {
//        NormalizeTime(ref hours, ref minutes, ref seconds);
//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//        Console.WriteLine(this.ToString());
//    }

//    public Duration(int totalSeconds)
//    {
//        int hours = totalSeconds / 3600;
//        int minutes = (totalSeconds % 3600) / 60;
//        int seconds = totalSeconds % 60;

//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//        Console.WriteLine(this.ToString());
//    }

//    public Duration() : this(0, 0, 0) { }

//    public override string ToString()
//    {
//        string result = "";
//        if (Hours > 0)
//        {
//            result += $"Hours: {Hours}";
//        }
//        if (Minutes > 0)
//        {
//            if (result.Length > 0) result += ", ";
//            result += $"Minutes: {Minutes}";
//        }
//        if (Seconds > 0 || result.Length == 0)
//        {
//            if (result.Length > 0) result += ", ";
//            result += $"Seconds: {Seconds}";
//        }
//        return result;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Duration other)
//        {
//            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Hours, Minutes, Seconds);
//    }

//    public static Duration operator +(Duration d1, Duration d2)
//    {
//        return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
//    }


//    private int ToSeconds()
//    {
//        return Hours * 3600 + Minutes * 60 + Seconds;
//    }


//    public static Duration operator +(Duration d1, int seconds)
//    {
//        return new Duration(d1.ToSeconds() + seconds);
//    }

//    public static Duration operator +(int seconds, Duration d1)
//    {
//        return d1 + seconds;
//    }

//    public static Duration operator -(Duration d1, Duration d2)
//    {
//        return new Duration(d1.ToSeconds() - d2.ToSeconds());
//    }

//    public static Duration operator ++(Duration d1)
//    {
//        return new Duration(d1.ToSeconds() + 60);
//    }

//    public static Duration operator --(Duration d1)
//    {
//        return new Duration(d1.ToSeconds() - 60);
//    }

//    public static bool operator >(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() > d2.ToSeconds();
//    }

//    public static bool operator <(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() < d2.ToSeconds();
//    }

//    public static bool operator >=(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() >= d2.ToSeconds();
//    }

//    public static bool operator <=(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() <= d2.ToSeconds();
//    }

//    public static bool operator true(Duration d1)
//    {
//        return d1.ToSeconds() != 0;
//    }

//    public static bool operator false(Duration d1)
//    {
//        return d1.ToSeconds() == 0;
//    }

//    public static explicit operator DateTime(Duration d)
//    {
//        return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
//    }

//    private static void NormalizeTime(ref int hours, ref int minutes, ref int seconds)
//    {
//        minutes += seconds / 60;
//        seconds %= 60;

//        hours += minutes / 60;
//        minutes %= 60;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Duration d1 = new Duration(1, 10, 15);
//        Duration d2 = new Duration(3600);
//        Duration d3 = new Duration(7800);
//        Duration d4 = new Duration(666);

//        Duration d5 = d1 + d3;
//        Console.WriteLine($"D5 = D1 + D3: {d5}");

//        Duration d6 = d1 + 7800;
//        Console.WriteLine($"D6 = D1 + 7800: {d6}");

//        Duration d7 = 666 + d4;
//        Console.WriteLine($"D7 = 666 + D4: {d7}");

//        d1++;
//        Console.WriteLine($"D1 after ++: {d1}");

//        d3--;
//        Console.WriteLine($"D3 after --: {d3}");

//        Duration d8 = d1 - d2;
//        Console.WriteLine($"D8 = D1 - D2: {d8}");

//        if (d1 > d2)
//            Console.WriteLine("D1 > D2");
//        if (d1 <= d2)
//            Console.WriteLine("D1 <= D2");

//        if (d1)
//            Console.WriteLine("D1 is not zero.");

//        DateTime obj = (DateTime)d1;
//        Console.WriteLine($"D1 as DateTime: {obj}");
//    }
//} 
#endregion
