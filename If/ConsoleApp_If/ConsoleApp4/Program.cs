// Даны три целых числа. Найти количество положительных чисел в исходном наборе.

using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите последоватенльно три целых числа: ");
            string[] arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            int c = Convert.ToInt32(arr[2]);
            int d = 0;
            if (a > 0) ++d;
            if (b > 0)
            {
                ++d;
            }

            if (c > 0)
            {
                ++d;
            }
            
            Console.WriteLine($"Кoличество положительных чисел : {d}");

            Console.ReadKey();

        }
    }
}