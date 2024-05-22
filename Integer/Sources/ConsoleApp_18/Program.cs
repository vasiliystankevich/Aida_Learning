// Дано целое число, большее 999. Используя одну операцию деления нацело и
// одну операцию взятия остатка от деления, найти цифру, соответствующую разряду тысяч в записи этого числа

using System;

namespace ConsoleApp_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a % 10000) / 1000;
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}