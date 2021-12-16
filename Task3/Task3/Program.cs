using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            array[0] = 0;
            array[1] = 1;

            for(int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            foreach (int num in array)
            Console.Write($"{num} ");
        }
    }
}