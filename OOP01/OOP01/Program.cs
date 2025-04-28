#region Q1
//Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
//Then, write a C# program that prints out all the days of the week using this enum.

//public enum WeekDays
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//        foreach (object day in Enum.GetNames(typeof(WeekDays)))
//        {
//            Console.WriteLine(day);
//        }
//    }
//}


#endregion
#region Q2
//Define a struct "Person" with properties "Name" and "Age". Create an array
//of three "Person" objects and populate it with data. Then, write a C# program to
//display the details of all the persons in the array


//public struct Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person[] person = new Person[3];
//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine($"Enter Name of Person num {i + 1}");
//            person[i].Name = Console.ReadLine();

//            Console.WriteLine($"Enter Age of Person num {i + 1}");
//            person[i].Age = Convert.ToInt32(Console.ReadLine());
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine($"Name Of Person Num {i + 1} is {person[i].Name} , His Age is {person[i].Age}");
//        }
//    }
//}
#endregion
#region Q3
// 3.Create an enum called "Season" with the four seasons
// (Spring, Summer, Autumn, Winter) as its members. Write a
// C# program that takes a season name as input from the user
// and displays the corresponding month range for that season.
// Note range for seasons ( spring march to may , summer june
// to august , autumn September to November , winter December to February)

//enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the name of a season");
//        string input = Console.ReadLine();

//        if (Enum.TryParse(input, out Season season))
//        {
//            switch (season)
//            {
//                case Season.Spring:
//                    Console.WriteLine("Spring from March to May.");
//                    break;
//                case Season.Summer:
//                    Console.WriteLine("Summer from June to August.");
//                    break;
//                case Season.Autumn:
//                    Console.WriteLine("Autumn from September to November.");
//                    break;
//                case Season.Winter:
//                    Console.WriteLine("Winter from December to February.");
//                    break;
//                default:
//                    Console.WriteLine("Invalid season entered.");
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input");
//        }
//    }
//}
#endregion
#region Q4

// Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
// Create Variable from previous Enum to Add and Remove Permission from variable, check
// if specific Permission is existed inside variable



//[Flags]
//enum Permissions
//{
//    None = 0,
//    Read = 1,
//    Write = 2,
//    Delete = 4,
//    Execute = 8
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Permissions userPermissions = Permissions.None;

//        while (true)
//        {
//            Console.WriteLine($"Current permissions: {userPermissions} ");
//            Console.WriteLine("Choose an option:");
//            Console.WriteLine("1. Add a permission");
//            Console.WriteLine("2. Remove a permission");
//            Console.WriteLine("3. Exit");

//            string choice = Console.ReadLine();

//            if (choice == "3") break;

//            Console.WriteLine("Enter the permission to modify (Read, Write, Delete, Execute):");
//            string input = Console.ReadLine();

//            if (!Enum.TryParse(input, out Permissions permission))
//            {
//                Console.WriteLine("Invalid permission. Try again.");
//                continue;
//            }

//            switch (choice)
//            {
//                case "1":
//                    if ((userPermissions & permission) == permission)
//                        Console.WriteLine($"{permission} permission is already granted.");
//                    else
//                    {
//                        userPermissions |= permission;
//                        Console.WriteLine($"{permission} permission has been added.");
//                    }
//                    break;

//                case "2":
//                    if ((userPermissions & permission) == permission)
//                    {
//                        userPermissions &= ~permission;
//                        Console.WriteLine($"{permission} permission has been removed.");
//                    }
//                    else
//                        Console.WriteLine($"{permission} permission is not currently granted.");
//                    break;

//                default:
//                    Console.WriteLine("Invalid option. Try again.");
//                    break;
//            }
//        }
//        Console.WriteLine($"Final permissions: {userPermissions}");
//    }
//}

#endregion
#region Q5
//Create an enum called "Colors" with the basic colors (Red, Green, Blue)
//as its members. Write a C# program that takes a color name as input from the user and displays
//a message indicating whether the input color is a primary color or not

//public enum Colors
//{
//    Red,
//    Green,
//    Blue
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Colors[] colors = { Colors.Red, Colors.Green, Colors.Blue };
//        Console.WriteLine("Enter A Color");
//        string color= Console.ReadLine();

//        if (Enum.TryParse(typeof(Colors), color, out var result))
//            Console.WriteLine($"{color} is a primary color.");

//        else
//            Console.WriteLine($"{color} is not a primary color.");

//    }
//} 
#endregion
#region Q6

//Create a struct called "Point" to represent a 2D point with properties
//"X" and "Y". Write a C# program that takes two points as input from
//the user and calculates the distance between them.

//public struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Point point1 = new Point();
//        Point point2 = new Point();

//        Console.WriteLine($"Enter X Value For Point1:");
//        point1.X = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine($"Enter Y Value For Point1:");
//        point1.Y = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine($"Enter X Value For Point2:");
//        point2.X = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine($"Enter Y Value For Point2:");
//        point2.Y = Convert.ToInt32(Console.ReadLine());

//        double xdis = (point1.X - point2.X);
//        double ydis = (point1.Y - point2.Y);
//        double sum = Math.Pow(xdis,2) + Math.Pow(ydis,2);

//        double res = Math.Sqrt(sum);

//        Console.WriteLine($"Distanc = {res}");

//    }
//} 
#endregion
#region Q7

//Create a struct called "Person" with properties "Name" and "Age".
//Write a C# program that takes details of 3 persons as input from
//the user and displays the name and age of the oldest person.

//public struct Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person[] person = new Person[3];
//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine($"Enter Name of Person num {i + 1}");
//            person[i].Name = Console.ReadLine();

//            Console.WriteLine($"Enter Age of Person num {i + 1}");
//            person[i].Age = Convert.ToInt32(Console.ReadLine());
//        }

//        if (person[0].Age > person[1].Age && person[0].Age > person[2].Age) 

//            Console.WriteLine($"Oldest Person is {person[0].Name} And His Age is {person[0].Age}");

//        else if (person[1].Age > person[0].Age && person[1].Age > person[2].Age)

//                Console.WriteLine($"Oldest Person is {person[1].Name} And His Age is {person[1].Age}");

//            else
//                Console.WriteLine($"Oldest Person is {person[2].Name} And His Age is {person[2].Age}");

//        }
//}




#endregion
#region Part02


//using System;
//using System.Globalization;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//using System.Security.Claims;
//using System.Security.Cryptography;

//namespace CompanyManagement
//{
//   // 4- Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum
//    public enum SecurityLevel
//    {
//        Guest,
//        Developer,
//        Secretary,
//        DBA
//    }

//    // 2-Develop a Class to represent the Hiring Date Data:
//   // consisting of fields to hold the da y, month and Years

//    public class HireDate
//    {
//        public int Day { get; private set; }
//        public int Month { get; private set; }
//        public int Year { get; private set; }

//        public HireDate(int _day, int _month, int _year)
//        {
//            if (_day < 1 || _day > 31)
//                Console.WriteLine("Invalid day"); 
//            if (_month < 1 || _month > 12)
//            Console.WriteLine("Invalid month");
//            if (_year < 1900 || _year > DateTime.Now.Year)
//                Console.WriteLine("Invalid year");
//            Day = _day;
//            Month = _month;
//            Year = _year;
//        }

//        public override string ToString()
//        {
//            return $"{Day}/{Month}/{Year}";
//        }
//    }
//    //1- Design and implement a Class for the employees in a company:
//    //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
//    public class Employee
//    {
//        public int ID { get; private set; }
//        public string Name { get; private set; }
//        public SecurityLevel SecurityLevel { get; private set; }
//        public decimal Salary { get; private set; }
//        public HireDate HireDate { get; private set; }


//        //3- We need to restrict the Gender field to be only M or F[Male or Female]
//        private char gender;
//        public char Gender
//        {
//            get { return gender; }
//            set
//            {
//                if (value != 'M' && value != 'F')
//                {
//                    Console.WriteLine("Gender must be 'M' or 'F'");
//                }
//                gender = value;
//            }
//        }

//        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, char gender)
//        {
//            if (string.IsNullOrWhiteSpace(name))
//                Console.WriteLine("Name cannot be empty");
//            if (salary < 0)
//                Console.WriteLine("Salary cannot be negative"); 
//            ID = id;
//            Name = name;
//            SecurityLevel = securityLevel;
//            Salary = salary;
//            HireDate = hireDate;
//            Gender = gender;
//        }
//        //5- We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [use String.Format Function]
//        public override string ToString()
//        {
//            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary}, Hire Date: {HireDate}, Gender: {Gender}";
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            Employee[] employees = new Employee[3];

//            employees[0] = new Employee(1, "Mahmoud Fawzi", SecurityLevel.DBA, 8000_0, new HireDate(15, 6, 2015), 'M');
//            employees[1] = new Employee(2, "Hager", SecurityLevel.Guest, 4000_0, new HireDate(22, 3, 2020), 'F');
//            employees[2] = new Employee(3, "Sama", SecurityLevel.Developer, 1200_00, new HireDate(5, 9, 2018), 'F');

//            foreach (object employee in employees)
//            {
//                Console.WriteLine(employee);
//            }
//        }
//    }
//}




#endregion