#region Q1
//Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

//Passing by Value:
//the method gets a copy of the reference to the object.
//Modifications to the object inside the method affect the original object 
//When assigning a new object inside the method does not affect the original reference outside the method

//Passing by Reference
//When assigning a new object inside the method the original reference outside the method will affect


//using System.Buffers;
//using System.Reflection.Metadata.Ecma335;

//static int SunNumsPassingByValue(int[] arr)
//{

//    arr = new int[] {100,200,300};
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//        sum += arr[i];
//    arr[0] = 123;
//    return sum;
//}

//int[] arr = { 1, 2, 3, 4, 5 };
//Console.WriteLine($"Arr[0] Befor Calling The Funcrion: {arr[0]}");
//int sum = SunNumsPassingByValue(arr);
//Console.WriteLine($"Sum Of Array ELements is: {sum}");
//Console.WriteLine($"Arr[0] After Calling The Funcrion: {arr[0]}"); // doesn't change 


//static int SunNumsPassingByRef(ref int[] arr)
//{
//    int sum = 0;
//    arr =new int[] {100,200,300};
//    for (int i = 0; i < arr.Length; i++)
//        sum += arr[i];
//    arr[0] = 123;
//    return sum;
//}

//int[] arr = { 1, 2, 3};
//Console.WriteLine($"Arr[0] Befor Calling The Funcrion: {arr[0]}");
//int sum = SunNumsPassingByRef(ref arr);
//Console.WriteLine($"Sum Of Array ELements is: {sum}");
//Console.WriteLine($"Arr[0] After Calling The Funcrion: {arr[0]}");



#endregion
#region Q2
//2-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

//static void SumAndSub(int n1, int n2, out int sum , out int sub)
//{

//    sum = n1+n2;
//    if  (n1>n2)
//        sub = n1-n2;
//    else
//        sub = n2 - n1;
//}
//Console.Write("Enter Fist Number: ");
//int n1=Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter Second Number: ");
//int n2 = Convert.ToInt32(Console.ReadLine());

//int sum, sub;
//SumAndSub(n1, n2,out sum, out sub);

//Console.WriteLine($"Sum =: {sum}");
//Console.WriteLine($"Sub =: {sub}");

#endregion
#region Q3
//Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

//static int[] MinMaxArray(ref int[] arr)
//{
//    int [] MinMax= new int[2];
//    MinMax[0]=arr[0]; MinMax[1]=arr[0];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < MinMax[0])
//            MinMax[0]= arr[i]; 
//        if (arr[i] > MinMax[1])
//            MinMax[1]= arr[i];
//    }
//    return MinMax;
//}

//Console.WriteLine("Enrer Size of Array: ");
//int size=Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];

//for (int i = 0;i < size;i++)
//{
//    Console.WriteLine($"Enter Element No {i+1}: ");
//    arr[i]= Convert.ToInt32(Console.ReadLine());
//}

//int [] MinMax = MinMaxArray(ref arr);
//Console.WriteLine($"Max No is: {MinMax[1]}");
//Console.WriteLine($"Min No is: {MinMax[0]}"); 
#endregion
