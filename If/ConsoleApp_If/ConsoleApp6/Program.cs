//  Даны два числа. Вывести большее из них.

using System;

namespace ConsoleApp6
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
            if (a > b) Console.WriteLine($"Большее число : {a}");
            else Console.WriteLine($"Большее число : {b}");;
            
            Console.ReadKey();

        }
    }
}  