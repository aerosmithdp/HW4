using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter days: ");
            int a = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Now;
            Console.WriteLine(date.AddDays(a));
        }
    }
}