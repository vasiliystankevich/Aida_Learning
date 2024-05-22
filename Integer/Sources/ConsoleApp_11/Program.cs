//  Дано трехзначное число. Найти сумму и произведение его цифр.

using System;

namespace ConsoleApp_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.WriteLine("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = a % 100;
            int d = Math.DivRem(c, 10, out f);
            Console.WriteLine($"сотни{b} десятки{d} еденицы{f}");
            Console.ReadKey();
            int sum = b + d + f;
            int pres = b * d * f;
            Console.WriteLine($"Сумма:{sum}, произведение: {pres}");
            Console.ReadKey();

        }
    }
}