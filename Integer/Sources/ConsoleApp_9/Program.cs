//Дано трехзначное число. Используя одну операцию деления нацело, вывести первую цифру данного числа (сотни).

using System;

namespace ConsoleApp_9
{
    class Program
    {
        static void Main(string[] argh)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a / 100;
            Console.WriteLine("Сотни: " + b);
            Console.ReadKey();
        }
    }
}
