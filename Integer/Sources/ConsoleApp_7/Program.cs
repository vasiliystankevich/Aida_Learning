//  Дано двузначное число. Найти сумму и произведение его цифр

using System;

namespace ConsoleApp_7
{
    class Program
    {
        static void Main(string[] argh)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите двузначное число: ");
            int a = int.Parse(Console.ReadLine());
            int b = 10;
            int result;
            int c = Math.DivRem(a, b, out result);
            int sum = c + result;
            int product = c * result;
            Console.WriteLine($"Сумма цифр: {sum} . Произведение цифр: {product}");
            Console.ReadKey();
        }
    }
}