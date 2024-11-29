// Даны три числа. Вывести вначале наименьшее, а затем наибольшее из данных чисел. 

using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите три числа: ");
            string[] arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            int c = Convert.ToInt32(arr[2]);
            int MaxAb = Math.Max(a, b);
            int MaxBc = Math.Max(b, c);
            int Max = Math.Max(MaxAb, MaxBc);
            Console.WriteLine($"Наибольше из трех чисел {Max}");
            int MinAb = Math.Min(a, b);
            int MinBc = Math.Min(b, c);
            int Min = Math.Min(MinAb, MinBc);
            Console.WriteLine($"Наименьшее из трех чисел {Min}");
            Console.ReadKey();

        }
    }
}