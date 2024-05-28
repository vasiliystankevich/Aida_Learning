// Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A ≥ 0 или B < −2».

using System;

namespace ConsoleApp_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            int b = Convert.ToInt32(Console.ReadLine());
            bool c = a >= 0 || b < -2;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}