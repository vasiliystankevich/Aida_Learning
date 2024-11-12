//  Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево

using System;

namespace ConsoleApp_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int f;
            Console.WriteLine("Введите терехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = a % 100;
            int d = Math.DivRem(c, 10, out f);
            Console.WriteLine($"Зеркало {f}{d}{b}");
            Console.ReadKey();
            
            
        }
    }
}