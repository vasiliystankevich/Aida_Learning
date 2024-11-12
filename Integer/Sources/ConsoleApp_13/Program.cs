// Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее справа. Вывести полученное число.

using System;

namespace ConsoleApp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите техзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = a % 10;
            int d = (a / 10) % 10;
            int f = d * 100 + c * 10 + b;
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}