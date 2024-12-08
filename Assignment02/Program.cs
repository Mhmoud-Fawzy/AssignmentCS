namespace Assignment
{
    class point
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main()
        {
            #region Q1
            ////Write a program that allows the user to enter a number then print it.
            //Console.Write("Enter Number to Print ");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Number is: {Number}");
            #endregion
            #region Q2
            ///*Write C# program that Convert a string to an integer, but the
            //string contains non-numeric characters. And mention what will happen */
            //Console.Write("Enter String to Print ");
            //string s = (Console.ReadLine());
            //Console.WriteLine(int.Parse(s)); //it will throw an Format Exception

            ////instead We can do this
            //if (int.TryParse(s, out int result)) 
            //{
            //    Console.Write($"String Is:{result}");
            //}
            //else
            //{
            //    Console.WriteLine($"You can't convert non numeric value");
            //}
            #endregion
            #region Q3
            ///*Write C# program that Perform a simple arithmetic operation with floating-point numbers
            //And mention what will happen*/
            //float f1 = 1.5f;
            //float f2 = .5f;
            //Console.WriteLine($"diffrence between {f1} and {f2} is {f1 - f2}");
            ////it will print the difference
            #endregion
            #region Q4
            ///*
            // Write C# program that Extract a substring from a given string.
            // */
            //Console.Write("Enter Your string ");
            //String s = Console.ReadLine();
            //Console.Write("Enter Your substring length you want ");
            //int l = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your substring is {s.Substring(0, l)}");
            #endregion
            #region Q5
            /////*
            //// Write C# program that Assigning one value type variable to another
            //// and modifying the value of one variable and mention what will happen
            //// */
            //int Val1 = 0;
            //int Val2 = 1;
            //Val1 = Val2;
            //Val2 = 7;
            //Console.WriteLine($"value 1 is {Val1}");
            //Console.WriteLine($"value 2 is {Val2}");
            ////A change in one doesn't affect the other
            #endregion
            #region Q6
            ///*
            // Write C# program that Assigning one reference type variable to another and
            // modifying the object through one variable and mention what will happen
            // */
            //point p1 = new point();
            //p1.x = 7;
            //p1.y = 9;
            //point p2 = p1;
            //Console.WriteLine($"X in P1 {p1.x} ---- Y in P1 {p1.y}");
            //Console.WriteLine($"X in P2 {p2.x} ---- Y in p2 {p2.y}");
            // //A change in one affects the other
            #endregion
            #region Q7
            ///*
            // Write C# program that take two string variables and print them as one variable 
            // */
            //Console.Write("Enter Your string first string ");
            //String s1 = Console.ReadLine();
            //Console.Write("Enter Your string Second string ");
            //String s2 = Console.ReadLine();
            //String s3 = s1 + s2;
            //Console.WriteLine($"your new String is:{s3}");
            #endregion
            #region Q8
            //A value 1 will be assigned to d.
            #endregion
            #region Q9
            //6 1
            #endregion
            #region Q10
            // 7 7
            #endregion

        }
    }
}
