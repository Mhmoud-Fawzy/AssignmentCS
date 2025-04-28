#region Q13
//Write a program to allow the user to enter a string
//and print the REVERSE of it.


//Console.WriteLine("Enter String To Revers: ");
//string s= Console.ReadLine();
//String res="";
//for (int i = s.Length - 1; i >= 0; i--)
//{
//    res += s[i];
//}
//Console.WriteLine($"String After Reversing : {res}"); 
#endregion

#region Q14
//Write a program to allow the user to enter int
// and print the REVERSED of it.


//Console.WriteLine("Enter int to revers: ");
//int num = Convert.ToInt32(Console.ReadLine());

//int res = 0;

//while (num != 0)
//{
//    int LastDigit = num % 10;     
//    res *= 10 ;
//    res += LastDigit;
//    num /= 10;  
//}
//Console.WriteLine($"Reversed Number: {res}");  
#endregion

#region Q15

//Write a program in C# Sharp to find 
//prime numbers within a range of numbers.


//Console.Write("Enter the starting number: ");
//int start = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter the ending number: ");
//int end = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Prime numbers between {start} and {end}:");

//for (int i = start; i <= end; i++)
//{
//    if (i <= 1)
//        continue; 

//    bool flag = true;

//    for (int j = 2; j <= Math.Sqrt(i); j++)
//    {
//        if (i % j == 0)
//        {
//            flag = false;  
//            break;
//        }
//    }

//    if (flag)
//    {
//        Console.Write($"{i} ");
//    }
//}


#endregion

#region Q16
//Write a program in C# Sharp to convert a decimal number
//into binary without using an array

//Console.Write("Enter number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int x = num;
//string res = "";

//    while (num > 0)
//    {
//        int rem = num % 2;
//        res = rem + res;
//        num /= 2;
//        Console.WriteLine(num);
//}

//Console.WriteLine($"The Binary of {x} is: {res}");

#endregion

#region Q17
//Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line

//Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
//double x1 = Convert.ToDouble(Console.ReadLine());
//double y1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
//double x2 = Convert.ToDouble(Console.ReadLine());
//double y2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
//double x3 = Convert.ToDouble(Console.ReadLine());
//double y3 = Convert.ToDouble(Console.ReadLine());

//  if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
//    Console.WriteLine("The points lie on a single straight line.");
//  else
//    Console.WriteLine("The points do not lie on a single straight line."); 
#endregion

#region Q18
// Within a company, the efficiency of workers is evaluated 

//Console.Write("Enter the time taken to complete the task (in hours): ");
//double timeTaken = Convert.ToDouble(Console.ReadLine());

//if (timeTaken >= 2 && timeTaken <= 3)
//{
//    Console.WriteLine("The worker is highly efficient.");
//}
//else if (timeTaken > 3 && timeTaken <= 4)
//{
//    Console.WriteLine("The worker is instructed to increase their speed.");
//}
//else if (timeTaken > 4 && timeTaken <= 5)
//{
//    Console.WriteLine("The worker is provided with training to enhance their speed.");
//}
//else if (timeTaken > 5)
//{
//    Console.WriteLine("The worker is required to leave the company.");
//}
//else
//{
//    Console.WriteLine("Invalid input. Time taken cannot be less than 2 hours.");
//}

#endregion