// Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе

using System;

namespace ConsoleApp5
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
            int f = 0;
            if (a > 0) ++d;
            else ++f;
            if (b > 0) ++d;
            else ++f;
            if (c > 0) ++d;
            else ++f;

            Console.WriteLine($"Кoличество положительных чисел : {d}, количество отрицательных чисел : {f}");

            Console.ReadKey();

        }
    }
}    
