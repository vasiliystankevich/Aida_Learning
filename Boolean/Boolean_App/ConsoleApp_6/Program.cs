// Даны три целых числа: A, B, C. Проверить истинность высказывания: «Справедливо двойное неравенство
// A < B < C»

using System;

namespace ConsoleApp_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            bool d = (a < b) & (b < c);
            Console.WriteLine(b);
            Console.ReadKey();
            

        }
    }
}