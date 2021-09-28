using System;

namespace Task3
{
    class Program
    {
        static void PrintSequence(int[] arr, int index, int value)
        {
            for (int i = index; i < index+value; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            int counter = 1, maxSequence = 0;

            //Fill array random values
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 10);
                Console.Write(arr[i] + " ");
            }

            //Find length the longest sequence of numbers ordered by ascending in arr.
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    counter++;

                    if (counter > maxSequence)
                        maxSequence = counter;
                }
                else
                    counter = 1;
            }
            Console.WriteLine($"\n\nLength the longest sequence of numbers: {maxSequence}\n");
            
            counter = 1;
            //Find and print the longest sequences of numbers ordered by ascending in arr.
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    counter++;
                    
                    if (counter == maxSequence)
                    {
                        PrintSequence(arr, i + 2 - maxSequence, maxSequence);
                        counter = 1;
                    }
                }

                else
                    counter = 1;
            }
        }
    }
}
