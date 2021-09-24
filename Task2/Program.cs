using System;

namespace Task2
{
    class Program
    {
        static string IsSameElement(int[] arr)
        {
            foreach (var item in arr)
            {
                if (Array.LastIndexOf(arr, item) == Array.IndexOf(arr, item))
                    return "String doesn`t contain the same elements";
                else
                    return "String contains the same elements";
            }
            return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsSameElement(new int[] { 1, 2, 3, 4, 5, 6, 7, 1, 8, 9, 10 }));
        }
    }
}
