using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 4, 2, 4, 4, 5, 6, 10, 8, 9 };
            int res = 0, counter = 0;

            for (int i = 1; i < arr.Length; i+=2)
            {
                if (arr[i]%2==0)
                {
                    res += arr[i];
                    counter++;
                }
            }
            Console.WriteLine($"Average value: {res/counter}");
        }
    }
}
