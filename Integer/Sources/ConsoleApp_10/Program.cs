// Дано трехзначное число. Вывести вначале его последнюю цифру,
// (единицы), а затем — его среднюю цифру (десятки)

using System;

namespace ConsoleApp_8
{
    class Program
    {
        static void Main(string[] argh)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a % 100;
            int result;
            int c = Math.DivRem(b, 10, out result);
            Console.WriteLine($"Единицы: {result} Десятки: {c}");
            Console.ReadKey();
        }
    }
}

