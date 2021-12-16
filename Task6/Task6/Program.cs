using System;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите имя 1-го человека: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите имя 2-го человека: ");
            string name2 = Console.ReadLine();

            if (name1 == name2)
            {
                Console.WriteLine("Имена людей одинаковы, попробуйте еще.");
                Main();
            }

            int age1;
            int age2;
            do
            {
                Console.Write("Введите возраст 1-го человека: ");
                age1 = int.Parse(Console.ReadLine());
                if (age1 <= 0)
                {
                    Console.WriteLine("Возраст не может быть меньше или равен 0.");
                    Console.WriteLine("Введены некорректные данные, попробуйте еще раз.");
                }
                else if (age1 > 120)
                {
                    Console.WriteLine("Если верить Википедии, люди столько не живут.");
                    Console.WriteLine("Введены некорректные данные, попробуйте еще раз.");
                }
            }
            while (age1 <= 0 || age1 > 120);

            do
            {
                Console.Write("Введите возраст 2-го человека: ");
                age2 = int.Parse(Console.ReadLine());
                if (age2 <= 0)
                {
                    Console.WriteLine("Возраст не может быть меньше или равен 0.");
                    Console.WriteLine("Введены некорректные данные, попробуйте еще раз.");
                }
                else if (age2 > 120)
                {
                    Console.WriteLine("Если верить Википедии, люди столько не живут.");
                    Console.WriteLine("Введены некорректные данные, попробуйте еще раз.");
                }
            }
            while (age2 <= 0 || age2 > 120);


            if (age1 == age2)
            {
                Console.WriteLine("Возраст людей одинаковый, попробуйте еще.");
                Main();
            }

            Console.WriteLine($"Имя 1-го человека - {name1}");
            Console.WriteLine($"Возраст 1-го человека - {age1}");
            Console.WriteLine($"Имя 2-го человека - {name2}");
            Console.WriteLine($"Возраст 2-го человека - {age2}");

            Console.WriteLine($"Кто старше? {name1} или {name2}? ");
            string answer = Console.ReadLine();
            int result1 = age1 - age2;
            int result2 = age2 - age1;

            if (answer == name1 && age1 > age2)
            {
                Console.WriteLine($"Верно, {name1} старше {name2} на {result1} лет");
            }
            else if (answer == name2 && age2 > age1)
            {
                Console.WriteLine($"Верно, {name2} старше {name1} на {result2} лет");
            }
            else if (answer == name1 && age1 < age2)
            {
                Console.WriteLine($"Неверно, {name2} старше на {result2} лет");
            }
            else if (answer == name2 && age2 < age1)
            {
                Console.WriteLine($"Неверно, {name1} старше на {result1} лет");
            }
        }
    }
}
