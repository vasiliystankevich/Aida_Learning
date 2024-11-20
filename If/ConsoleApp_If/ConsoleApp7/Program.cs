// Даны два числа. Вывести порядковый номер меньшего из них

using System;

namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите два числа: ");
            string[] arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            int c;
            if (a > b)
            {
                c = 2;
                Console.WriteLine($"Порядковый номер меньшего числа : {c}");
            }
            else
            {
                c = 1;
                Console.WriteLine($"Порядковый номер меньшего числа : {c}");
            }

            ;

            Console.ReadKey();

        }
    }
}