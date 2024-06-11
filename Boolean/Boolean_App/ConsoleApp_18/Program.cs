//  Проверить истинность высказывания: «Среди трех данных целых
// чисел есть хотя бы одна пара совпадающих»

using System;

namespace ConsoleApp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите последовательно три целых числа: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            if ((a == c) || (b == c) || (a == b) )
                Console.WriteLine("Среди трех данных целых есть хотя бы одна пара совпадающих");
            else
            {
                Console.WriteLine("Среди трех данных целых нет совпадающих");
            }

            Console.ReadKey();
        }
    }
}
        