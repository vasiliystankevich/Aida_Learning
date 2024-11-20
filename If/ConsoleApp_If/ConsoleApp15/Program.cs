//  Даны три числа. Найти сумму двух наибольших из них.

using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите три числа: ");
            var  arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            int c = Convert.ToInt32(arr[2]);
            if (a<=b & a<=c )
            {
                Console.WriteLine(b + c);
            }
            else if (b<=a & b<= c)
            {
                Console.WriteLine(a + c);
            }
            else if (c<=a & c<=b)
            {
                Console.WriteLine(a + b);
            }
            Console.ReadKey();

        }
    }
}