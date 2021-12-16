using System;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("print.txt");
            string s;
            while (sr.EndOfStream != true)
            {
                s = sr.ReadLine();
                Console.WriteLine(s);
            }

            //№2

            //string path = @"C:\Users\User\source\repos\Task5\Task5\bin\Debug\net5.0\print.txt";
            //string[] readText = File.ReadAllLines(path);
            //foreach (string s in readText)
            //{
            //    Console.WriteLine(s);

            //}
        }
    }
}