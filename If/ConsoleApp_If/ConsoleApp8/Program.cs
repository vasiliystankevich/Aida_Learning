// Даны два числа. Вывести вначале большее, а затем меньшее из них.

using System;

namespace ConsoleApp8
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
            if (a > b)
            {
                Console.WriteLine($"От большего к меньшему: {a},{b}");
            }
            else
            {
                Console.WriteLine($"От большего к меньшему: {b},{a}");
            }

            ;

            Console.ReadKey();

        }
    }
}