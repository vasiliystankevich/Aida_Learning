// Дано трехзначное число. Вывести число, полученное при перестановке цифр сотен и десятков исходного числа
// (например, 123 перейдет в 213)

using System;

namespace ConsoleApp_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int d;
            Console.WriteLine("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = Math.DivRem(a, 10, out d);
            int f = c % 10;
            //Console.WriteLine($"{b} {f} {d}");
            int g = f * 100 + b * 10 + d;
            Console.WriteLine(g);
            Console.ReadKey();

        }
    }
}