// Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка
// от деления, найти цифру, соответствующую разряду сотен в записи этого числа

using System;

namespace ConsoleApp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите четырехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = b % 10;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}