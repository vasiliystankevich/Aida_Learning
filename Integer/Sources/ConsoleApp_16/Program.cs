// Дано трехзначное число. Вывести число, полученное при перестановке цифр десятков и единиц исходного
// числа (например, 123 перейдет 132).

using System;

namespace ConsoleApp_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = (a / 10) % 10;
            int d = a % 10;
            int f = b * 100 + d * 10 + c;
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}