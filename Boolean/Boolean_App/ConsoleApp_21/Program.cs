// Дано трехзначное число. Проверить истинность высказывания:
// «Цифры данного числа образуют возрастающую последовательность»

using System;

namespace ConsoleApp_21
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
            if (aa < ab & ab < ac)
                Console.WriteLine("Цифры данного числа образуют возрастающую последовательность");
            else
            {
                Console.WriteLine("Цифры данного числа не образуют возрастающую последовательность");
            }

            Console.ReadKey();

        }
    }
}