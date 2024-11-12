// Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».

using System;

namespace ConsoleApp_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите три целых числа  - А, В и С: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            if (a > 0 & b < 0 & c < 0 )
            {
                Console.Write("Ровно одно из трех чисел положительное");
            }
            else if (a < 0 & b > 0 & c < 0)
            {
                
                Console.WriteLine("Ровно одно из трех чисел положительное");
            }
            else if ( a < 0 & b < 0 & c > 0)
            {
                Console.WriteLine("Ровно одно из трех чисел положительное");
            }
            else
            {
                Console.WriteLine("Не соответствует условию");
            }

            Console.ReadKey();
            



            }
    }
}