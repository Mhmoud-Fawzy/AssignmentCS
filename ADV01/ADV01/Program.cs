using System.Collections;

namespace ADV01
{
    internal class Program
    {
        public static void BubbleSort(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < Arr.Length - i - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        swap = true;
                        Swap(ref Arr[j], ref Arr[j + 1]);
                    }
                }
                if (!swap)
                {
                    break;
                }
            }

        }
        public static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        
        static void Main(string[] args)
        {
             
            //List<int> arr = new List<int>();
            //Console.WriteLine($"Count: {arr.Count}, Capacity: {arr.Capacity}");
            //arr.Add(1);
            //arr.Add(2);
            //arr.AddRange(arr);
            //Console.WriteLine($"Count: {arr.Count}, Capacity: {arr.Capacity}");
            //foreach (int i in arr) Console.Write($"{i } ");
            //Console.WriteLine(" ");
            //arr.Add(3);
            //Console.WriteLine($"Count: {arr.Count}, Capacity: {arr.Capacity}");
            //arr.TrimExcess();
            //Console.WriteLine($"Count: {arr.Count}, Capacity: {arr.Capacity}");

            List<int> arr = new List<int>([2,5,8,3,9,2,9,2,4,33]);
            Console.WriteLine($"Count: {arr.Count}, Capacity: {arr.Capacity}");
            foreach (int i in arr) Console.Write($"{i } ");
            Console.WriteLine(" ");
            arr[3] = 5;
            arr.Insert(0, 100);
            foreach (int i in arr) Console.Write($"{i} ");
            Console.WriteLine(" ");
            arr.AddRange([200,300,400]);
            arr.InsertRange(1, [77, 88]);
            foreach (int i in arr) Console.Write($"{i} ");
            Console.WriteLine(" ");




        }

    }
}
