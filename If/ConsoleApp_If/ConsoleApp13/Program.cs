// Даны три числа. Найти среднее из них (то есть число, расположенное
// между наименьшим и наибольшим).

using System;

namespace ConsoleApp13
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
            if (a > c & a < b)
            {
                Console.WriteLine($" Среднее - {a}");
            }
            else if ( a > b & a < c)
            {
                Console.WriteLine($" Среднее - {a}");
            }
            else if (c > b & c < a)
            {
                Console.WriteLine($" Среднее - {c}");
            }
            else if (c > a & c < b)
            {
                Console.WriteLine($" Среднее - {c}");
            }
            else if (b > a & b < c)
            {
                Console.WriteLine($" Среднее - {b}");
            }
            else
            {
                Console.WriteLine($" Среднее - {b}");
            }
           

            Console.ReadKey();

        }
    }
}