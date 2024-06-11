// Дано целое положительное число. Проверить истинность высказывания: «Данное число является
// нечетным трехзначным»

using System;

namespace ConsoleApp_17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите целое положительное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a > 99) & (a < 1000) & (a % 2 != 0))
            Console.WriteLine("Число является нечетным трехзначным");
            else
            {
                Console.WriteLine("Число не является нечетным трехзначным");
            }


            Console.ReadKey();
        }
    }
}
