using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.Xml.Linq;
using System.Numerics;
using System.Drawing;

#region Class FixedSize<T>
public class FixedSizeList<T>
{
    private T[] items;
    private int currentCount;

    public FixedSizeList(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity must be greater than 0");
        }

        items = new T[capacity];
        currentCount = 0;
    }

    public int Capacity => items.Length;
    public int Count => currentCount;
    public bool IsFull => currentCount >= items.Length;

    public void Add(T item)
    {
        if (!IsFull)
        {
            items[currentCount] = item;
            currentCount++;
        }


    }

    public T Get(int index)
    {
        return items[index];
    }

    public override string ToString()
    {
        return $"Count: {Count}, Capacity: {Capacity}, Items: [{string.Join(", ", items[..currentCount])}]";
    }
} 
#endregion
class Program
{

    static void Main()
    {

        #region Q1
        #region Q
        ////    You are given an ArrayList containing a sequence of elements. 
        ////    try to reverse the order of elements in the ArrayList 
        ////    in-place(in the same arrayList) without using the built-in Reverse
        ////    Implement a function that takes the ArrayList as input and
        ////    modifies it to have the reversed order of elements. 
        #endregion

        ////void Reverse(ArrayList arr)
        ////{

        ////    for (int i = 0; i < arr.Count / 2; i++)
        ////    {
        ////        int temp = (int)arr[i];
        ////        arr[i] = arr[arr.Count - i - 1];
        ////        arr[arr.Count - i - 1] = temp;
        ////    }
        ////    foreach (int i in arr) Console.Write($"{i} ");

        ////}
        ////ArrayList arr = new ArrayList { 6, 5, 4, 3, 2, 1 };
        ////Reverse(arr); 
        #endregion
        #region Q2
        #region Q
        // You are given a list of integers. Your task is to find and return a new 
        // list containing only the even numbers from the given list 
        #endregion

        //void PrintEvenNumbers(List<int> list)
        //{
        //    List<int> EvenList = new List<int>();
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] % 2 == 0)
        //            EvenList.Add(list[i]);

        //    }
        //    foreach (int i in EvenList) { Console.Write($"{i} "); }
        //}
        //List<int> list = new List<int> {1,2,3,4,5,6,7,8};
        //PrintEvenNumbers(list); 
        #endregion
        #region Q3
        //FixedSizeList<int> numbers = new FixedSizeList<int>(3);


        //numbers.Add(10);
        //numbers.Add(20);
        //numbers.Add(30);
        //Console.WriteLine(numbers);  
        //numbers.Add(40); 
        #endregion
        #region Q4
        //static int FindFirstUniqueChar(string s)
        //{
        //    Dictionary<char, int> charCount = new Dictionary<char, int>();

        //    foreach (char c in s)
        //    {
        //        if (charCount.ContainsKey(c))
        //        {
        //            charCount[c]++;
        //        }
        //        else
        //        {
        //            charCount[c] = 1;
        //        }
        //    }

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (charCount[s[i]] == 1)
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}


        //Console.WriteLine("Enter a string:");
        //string input = Console.ReadLine();

        //int result = FindFirstUniqueChar(input);

        //if (result != -1)
        //{
        //  Console.WriteLine($"First unique character '{input[result]}' found at index: {result}");
        //}
        //else
        //{
        //  Console.WriteLine("No unique character found");
        //} 
        #endregion
        #region Q5
        #region Q
        //Given an array  consists of  numbers with size N and number of queries,
        //in each query you will be given an integer X, and you should print how many
        //numbers in array that is greater than  X  
        #endregion

        //string[] firstLine = Console.ReadLine().Split();
        //int N = int.Parse(firstLine[0]);
        //int Q = int.Parse(firstLine[1]);

        //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //for (int i = 0; i < Q; i++)
        //{
        //    int X = int.Parse(Console.ReadLine());
        //    int count = numbers.Count(num => num > X);
        //    Console.WriteLine(count);
        //} 
        #endregion
        #region Q6

        #region Q
        // 6.Given a number N and an array of N numbers.Determine if it's palindrome or not. 
        #endregion

        //int size= Convert.ToInt32(Console.ReadLine());
        //int[] arr = new int[size];
        //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //bool flag= true;
        //for (int i = 0; i < size/2; i++)
        //{
        //    if (numbers[i] != numbers[size - i - 1])
        //        flag=false;                   
        //}
        //if (flag) Console.WriteLine("YES");
        //else Console.WriteLine("NO");

        #endregion
        #region Q7
        //#region Q
        //// Given an array, implement a function to remove duplicate elements from an array.

        //#endregion

        ////int[] RemoveDuplicate(int[] arr)
        ////{
        ////    if (arr == null || arr.Length == 0)
        ////        return arr;

        ////    List<int> result = new List<int>();
        ////    foreach (int num in arr)
        ////    {
        ////        if (!result.Contains(num))
        ////        {
        ////            result.Add(num);
        ////        }
        ////    }
        ////    return result.ToArray();
        ////}


        ////int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        ////       int[] result3 = RemoveDuplicate(array);
        ////Console.WriteLine("------------------------------------");
        ////Console.WriteLine(string.Join(" ", result3)); 
        #endregion
        #region Q8
        #region Q
        //Given an array list, implement a function to remove all odd numbers from it.

        #endregion


        //static List<int> RemoveOddNumbers(List<int> numbers)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int num in numbers)
        //    {
        //        if (num % 2 == 0)
        //        {
        //            result.Add(num);
        //        }
        //    }
        //    return result;
        //}

        //List<int> numbers = Console.ReadLine().Split().Select(int.Parse) .ToList();
        //List<int> result2 = RemoveOddNumbers(numbers);
        //Console.WriteLine(string.Join(" ", result2));

        #endregion


    }
}

