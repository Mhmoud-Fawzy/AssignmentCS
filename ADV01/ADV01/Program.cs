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
              #region Q1 The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm And implement the code of this optimised bubble sort algorithm
            //// we can use flag to check if we swaped or not
            //int[] arr = { 9, 8, 7, 8, 4, 5, 6, 2, 10, 3, 1 };
            //BubbleSort(arr);
            //foreach (int num in arr)
            //    Console.WriteLine(num);
 #endregion

            #region Q2
            //Range<int> range = new Range<int>(0, 100);
            //if (range.IsRange(1))
            //    Console.WriteLine("1 in Range");
            //Console.WriteLine($"The Length Of Range is {range.Length()}");
            #endregion

        }
    }
}
