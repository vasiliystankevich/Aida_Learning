//  Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».

using System;

namespace ConsoleApp_15
{
    class Proram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите последовательно три целых числа - А, В и С: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            if ((a > 0 & b > 0 & c < 0) || (a > 0 & b < 0 & c > 0) || (a < 0 & b > 0 & c > 0))
            {
                Console.WriteLine("Два из трех чисел являются положительными");
            }
            else
            {
                Console.WriteLine("Высказывание 'ровно два из трех чисел положительно' - ложно");
            }

            Console.ReadKey();

        }
    }
}

