using System;

namespace ArrayHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 10, 12, 15, 10, 5 };
            int min = arr[0];
            int counter = 0;
            
            foreach (var item in arr)
            {
                if (item < min)
                    min = item;
            }
            
            foreach (var item in arr)
            {
                if (item == min + 5)
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
