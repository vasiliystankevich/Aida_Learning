// Дано трехзначное число. Проверить истинность высказывания: «Все цифры данного числа различны»

using System;

namespace ConsoleApp_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int aa = (a % 1000) / 100;
            int ab = (a % 100) / 10;
            int ac = a % 10;
            if (aa != ab & aa != ac & ab != ac)
                Console.WriteLine("Все цифры данного числа различны");
            else
            {
                Console.WriteLine("Некоторые цифры данного числа одинаковы");
            }
            Console.ReadKey();
            
        }
    }
}