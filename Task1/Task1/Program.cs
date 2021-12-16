using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int[] num = new int[5] { -1, 56, 87, -24, 45 };
            foreach(int nums in num)
            {
                if(nums > 0)
                {
                    a++;
                }
            }
            Console.WriteLine($"Количество положительных чисел: {a}");
        }
    }
}