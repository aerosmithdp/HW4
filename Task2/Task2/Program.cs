using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Reverse(arr);

            foreach (int x in arr)
            Console.Write($"{x} ");
        }
    }
}
