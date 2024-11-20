// . Даны три числа. Найти наименьшее из них

using System;

namespace ConsoleApp12
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
            if (a < b & a < c   )
            {
                Console.WriteLine($" Наименьшее - {a}");
            }
            else if (b < c & b < a)
            {
                Console.WriteLine($" Наименьшее - {b}");
            }
            else if (c < b & c < a)
            {
                Console.WriteLine($" Наименьшее - {c}");
            }
            
           

            Console.ReadKey();

        }
    }
}