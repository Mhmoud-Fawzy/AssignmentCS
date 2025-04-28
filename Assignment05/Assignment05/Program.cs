#region Q19

// Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

//Console.WriteLine("Enter Number");
//int num = Convert.ToInt32(Console.ReadLine());

//int [,] arr=new int [num,num];
//for (int i = 0; i < num; i++) {
//    for (int j = 0; j < num; j++)
//    {
//        Console.Write((i == j) ? "1 " : "0 ");
//    }
//    Console.WriteLine("");
//} 
#endregion
#region Q20
//Write a program in C# Sharp to find the sum of all elements of the array.

//using System.Runtime.InteropServices;
//using System.Transactions;

//Console.Write("Enter Size Of Array: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr= new int[size];

//for (int i = 0; i < size; i++) {
//    Console.Write($"Enter Element Number {i+1}: ");
//    arr[i]=Convert.ToInt32(Console.ReadLine());
//}
//int sum=0;
//for (int i = 0; i < size; i++)
//{
//    sum+=arr[i];
//}
//Console.WriteLine($"Summation Of Array Is: {sum}");




#endregion
#region Q21
//Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

//Console.Write("Enter the size of the arrays: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr1 = new int[size];
//int[] arr2 = new int[size];

//Console.WriteLine("Enter elements for the first array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    arr1[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Enter elements for the second array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    arr2[i] = Convert.ToInt32(Console.ReadLine());
//}

//int[] mergedArray = new int[size * 2];
//arr1.CopyTo(mergedArray, 0);
//arr2.CopyTo(mergedArray, size);

//Array.Sort(mergedArray);

//Console.WriteLine("Merged and sorted array:");
//foreach (int num in mergedArray)
//{
//    Console.Write(num + " ");
//} 
#endregion
#region Q22
//Write a program in C# Sharp to count the frequency of each element of an array

//Console.Write("Enter the size of the array: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[size];
//Console.WriteLine("Enter the elements of the array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//bool[] visited = new bool[size];

//Console.WriteLine("\nFrequency of each element:");
//for (int i = 0; i < size; i++)
//{
//    if (visited[i])
//        continue; 

//    int count = 1; 
//    for (int j = i + 1; j < size; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            count++;
//            visited[j] = true; 
//        }
//    }

//    Console.WriteLine($"Element {arr[i]} occurs {count} time(s).");
//}

#endregion
#region Q23
//Write a program in C# Sharp to find maximum and minimum element in an array

//Console.Write("Enter the size of the array: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[size];
//Console.WriteLine("Enter the elements of the array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//int max = arr[0],min = arr[0];

//for (int i = 1; i < size; i++)
//{
//    if (arr[i] > max) 
//        max = arr[i];
//    if (arr[i] < min)   
//        min = arr[i];
//}

//Console.WriteLine($"MAX VALUE IS:{max}");
//Console.WriteLine($"MIN VALUE IS:{min}"); 
#endregion
#region Q24

//Write a program in C# Sharp to find the second largest element in an array.

//using System.ComponentModel.Design;
//using System.Runtime.ExceptionServices;

//Console.Write("Enter the size of the array: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[size];
//Console.WriteLine("Enter the elements of the array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//int FirstMax = arr[0], SecondMax = arr[0];

//for (int i = 1; i < size; i++) 
//{    
//    if (arr[i] > FirstMax)
//    {
//        SecondMax = FirstMax; 
//        FirstMax = arr[i]; 
//    }
//    else if (arr[i] > SecondMax && arr[i] < FirstMax)
//    {
//        SecondMax = arr[i]; 
//    }
//}

//Console.WriteLine($"Second Max Value is {SecondMax}");


#endregion
#region Q25

//Consider an Array of Integer values with size N, having values as in this Example

//Console.Write("Enter the size of the array: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[size];
//Console.WriteLine("Enter the elements of the array:");

//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//int res = 0;

//for (int i = 0; i < size; i++)
//{
//    for (int j = i + 1; j < size; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            int distance = j - i - 1; 
//            res = Math.Max(res, distance);
//        }
//    }
//}

//Console.WriteLine($"The longest distance between two equal cells is {res}.");

#endregion
#region Q26
//Given a list of space separated words, reverse the order of the words

//Console.Write("Enter the words: ");
//string input = Console.ReadLine();

//string[] words = input.Split(' '); 
//Array.Reverse(words);
//for (int i = 0; i < words.Length; i++)
//{
//    Console.Write($"{words[i]} ");
//}

#endregion
#region Q27
//Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

//Console.Write("Enter number or rows in your array: ");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter number or columns in your array: ");
//int columns = Convert.ToInt32(Console.ReadLine());

//int[,] arr1 = new int[rows,columns];
//int[,] arr2 = new int[rows, columns];

//Console.WriteLine("Enter the elements of the array:");

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.WriteLine($"Enter Element in the row num {i+1} and column number {j+1}");
//        arr1[i,j] = Convert.ToInt32(Console.ReadLine()); 
//    }
//}

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        arr2[i,j] = arr1[i, j];
//    }
//}
//Console.WriteLine ("====================== Array 2 After copying ======================");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{arr2[i,j]} ");
//    }
//    Console.WriteLine("");
//} 
#endregion
#region Q28
// Write a Program to Print One Dimensional Array in Reverse Order

//Console.Write("Enter the size of the array: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[size];

//Console.WriteLine("Enter the elements of the array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("\nArray in reverse order:");
//for (int i = size - 1; i >= 0; i--)
//{
//    Console.Write(arr[i] + " ");
//}

#endregion
#region Q29
//Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
//Passing by Value:
//A copy of the value is passed to the method.
//Changes made inside the method do not affect the original variable.
//Default behavior for value types

//Passing by Reference:
//A reference to the original variable is passed to the method.
//Changes made inside the method affect the original variable.
//Done using the ref or out keyword

//static void DuplicateNumbers(int num)
//{
//    num *= 2;
//    Console.WriteLine(num);
//}
//int a = 2;
//Console.WriteLine("==============Passing By Value Example==============");
//Console.WriteLine("Calling Passing By Value Fun");
//DuplicateNumbers(a);
//Console.WriteLine($"Value of a in passing by val: {a}");

//Console.WriteLine("=====================================================");
//Console.WriteLine("=====================================================");
//static void DuplicateNumber(ref int num)
//{
//    num*=2;
//    Console.WriteLine(num);
//}
//Console.WriteLine("Calling Passing By Ref Fun");
//DuplicateNumber(ref a);
//Console.WriteLine($"Value of a in passing by Ref: {a}");

#endregion
#region Q30
//Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
//static int sum(int num)
//{
//    int s = 0;
//    while (num > 0)
//    {
//        s += num % 10;
//        num /= 10;
//    } 
//    return s;
//}

//int x = sum(1234);
//Console.WriteLine(x); 
#endregion
#region Q31
//Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .

//static bool IsPrime(int num)
//{
//    if (num <= 1) return false; 
//    if (num == 2) return true;

//    for (int i = 2; i <= Math.Sqrt(num); i++)
//    {
//        if (num % i == 0)
//        {
//            return false; 
//        }
//    }

//    return true; 
//}
//Console.WriteLine("Enter Num To Check: ");
//int num =Convert.ToInt32(Console.ReadLine());
//bool flag = IsPrime(num);
//Console.WriteLine(IsPrime(num) ? "Prime" : "Not Prime");

#endregion
#region Q32
////Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
//static int Fact(int x)
//{
//	int res = 1;
//	for (int i = x; i > 0; i--)
//	{
//		res *= i;
//	}  
//    return res;
//}
//Console.WriteLine(Fact(5)); 
#endregion
#region Q33
//Create a function named "ChangeChar" to modify a letter in a       certain position (0 based) of a string, replacing it with a different letter 
//using System.Threading.Channels;

//static string ChangeChar(string text,char old,char rep)
//{
//    return text.Replace(text[text.IndexOf(old)], rep);
//}

//Console.WriteLine("Enter String");
//string s=Console.ReadLine();
//Console.WriteLine("Enter Char You Want to replace: ");
//char old =Convert.ToChar(Console.ReadLine());
//Console.WriteLine("Enter Char You Want to Add: ");
//char rep = Convert.ToChar(Console.ReadLine());

//Console.WriteLine(ChangeChar(s, old, rep));  
#endregion
